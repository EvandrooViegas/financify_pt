using financify_pt;
using financify_pt.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text;

// Business Logic Layer unificada para todas as entidades principais do sistema
// Métodos: ListAll, GetById, Create, Update, Delete

namespace financify_pt
{
    public static class BLL
    {
        // ------------------------------------------------------------------
        // USER
        // ------------------------------------------------------------------
        public static class User
        {

            public static UserModel Login(string email, string password)
            {
                if (string.IsNullOrWhiteSpace(email)) throw new ArgumentException("Cannot be null or whitespace", nameof(email));
                if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Cannot be null or whitespace", nameof(password));

                var userDataTable =
                    new DataAccessLayer().ExecuteReader

                        (
                            "SELECT * FROM [dbo].[User] WHERE [Email] = @Email AND IsLocked = 0",
                            new SqlParameter[]
                            {
                            new("@Email", email)
                            }
                        );

                if (userDataTable.Rows.Count == 0)
                    throw new ApplicationException("Email or password are wrong!");

                var user = new UserModel
                {
                    Id = Convert.ToInt32(userDataTable.Rows[0]["Id"]),
                    Email = userDataTable.Rows[0]["Email"].ToString(),
                    Password = userDataTable.Rows[0]["Password"].ToString(),
                    Salt = userDataTable.Rows[0]["Salt"].ToString(),
                    IsAdmin = Convert.ToBoolean(userDataTable.Rows[0]["IsAdmin"].ToString()),
                    IsLocked = Convert.ToBoolean(userDataTable.Rows[0]["IsLocked"].ToString()),
                    LastLoginDate = DateTimeOffset.Now.ToUniversalTime(),
                    Username = userDataTable.Rows[0]["Username"].ToString(),
                    LockedDate =
                        userDataTable.Rows[0]["LockedDate"] is null
                            ? Convert.ToDateTime(userDataTable.Rows[0]["LockedDate"])
                            : null,
                };

                using var sha256 = SHA512.Create();
                var inputHashedPassword = Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes(password + user.Salt)));
                if (inputHashedPassword != user.Password)
                    throw new ApplicationException("Email or password are wrong!");

                new DataAccessLayer().ExecuteNonQuery
                (
                    "UPDATE [dbo].[User] SET LastLoginDate = @LastLoginDate WHERE Id = @Id",
                    new SqlParameter[]
                    {
                    new("Id", user.Id),
                    new("LastLoginDate", user.LastLoginDate),
                    }
                );
                return user;
            }

            public static void CreateUser(string email, string password, string name,bool isAdmin, bool isLocked)
            {
                if (string.IsNullOrWhiteSpace(email)) throw new ArgumentException("Cannot be null or whitespace", nameof(email));
                if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Cannot be null or whitespace", nameof(password));

                var userDataTable =
                   new DataAccessLayer().ExecuteReader
                        (
                            "SELECT * FROM [dbo].[User] WHERE [Email] = @Email",
                            new SqlParameter[]
                            {
                            new("Email", email)
                            }
                        );

                if (userDataTable.Rows.Count != 0)
                    throw new ApplicationException("The user already exists!");

                var salt = Guid.NewGuid().ToString();
                using var sha256 = SHA512.Create();
                var inputHashedPassword = Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes(password + salt)));

                new DataAccessLayer().ExecuteNonQuery
                (
                    "INSERT INTO [dbo].[User] ([Email], [Password], [Username], [Salt], [IsAdmin], [IsLocked], [Username]) VALUES (@Email, @Password, @Username, @Salt, @IsAdmin, @IsLocked)",
                    new SqlParameter[]
                    {
                    new("Email", email),
                    new("Password", inputHashedPassword),
                    new("Salt", salt),
                    new("IsAdmin", isAdmin),
                    new("IsLocked", isLocked),
                              new("Username", name),
                    }
                );
            }

            public static DataTable ListAll() => new DataAccessLayer().ExecuteReader("SELECT * FROM [dbo].[User]", []);

            public static void UpdateUser(int id, string email, string username)
            {
                if (string.IsNullOrWhiteSpace(email))
                    throw new ArgumentException("Email cannot be empty.");

                if (string.IsNullOrWhiteSpace(username))
                    throw new ArgumentException("Username cannot be empty.");

                var dal = new DataAccessLayer();

                // Verificar se o email já está em uso por outro usuário
                var emailCheck = dal.ExecuteReader(
                    "SELECT Id FROM [dbo].[User] WHERE Email = @Email AND Id != @Id",
                    new[]
                    {
            new SqlParameter("Email", email),
            new SqlParameter("Id", id)
                    });

                if (emailCheck.Rows.Count > 0)
                    throw new ApplicationException("This email is already in use by another user.");

                // Verificar se o username já está em uso por outro usuário
                var usernameCheck = dal.ExecuteReader(
                    "SELECT Id FROM [dbo].[User] WHERE Username = @Username AND Id != @Id",
                    new[]
                    {
            new SqlParameter("Username", username),
            new SqlParameter("Id", id)
                    });

                if (usernameCheck.Rows.Count > 0)
                    throw new ApplicationException("This username is already in use by another user.");

                // Atualizar usuário
                dal.ExecuteNonQuery(
                    "UPDATE [dbo].[User] SET Email = @Email, Username = @Username WHERE Id = @Id",
                    new[]
                    {
            new SqlParameter("Email", email),
            new SqlParameter("Username", username),
            new SqlParameter("Id", id)
                    });
            }

            public static UserModel GetByUsername(string username)
            {
                if (string.IsNullOrWhiteSpace(username))
                    throw new ArgumentException("Cannot be null or whitespace", nameof(username));

                var dt = new DataAccessLayer().ExecuteReader(
                    "SELECT * FROM [dbo].[User] WHERE [Username] = @Username",
                    new[] { new SqlParameter("Username", username) });

                if (dt.Rows.Count == 0)
                    return null;

                var row = dt.Rows[0];

                return new UserModel
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Email = row["Email"].ToString(),
                    Password = row["Password"].ToString(),
                    Salt = row["Salt"].ToString(),
                    IsAdmin = Convert.ToBoolean(row["IsAdmin"]),
                    Username = row["Username"].ToString(),
                    IsLocked = Convert.ToBoolean(row["IsLocked"]),
                    LastLoginDate = row["LastLoginDate"] == DBNull.Value
                        ? (DateTimeOffset?)null
                        : DateTimeOffset.Parse(row["LastLoginDate"].ToString()),
                    LockedDate = row["LockedDate"] == DBNull.Value
                        ? (DateTime?)null
                        : Convert.ToDateTime(row["LockedDate"]),
                };
            }

            public static UserModel GetById(int id)
            {
                var dt = new DataAccessLayer().ExecuteReader(
                    "SELECT * FROM [dbo].[User] WHERE Id = @Id",
                    new[] { new SqlParameter("Id", id) });

                if (dt.Rows.Count == 0)
                    return null;

                var row = dt.Rows[0];

                return new UserModel
                {
                    Username = row["Username"].ToString(),
                    Id = Convert.ToInt32(row["Id"]),
                    Email = row["Email"].ToString(),
                    Password = row["Password"].ToString(),
                    Salt = row["Salt"].ToString(),
                    IsAdmin = Convert.ToBoolean(row["IsAdmin"]),
                    IsLocked = Convert.ToBoolean(row["IsLocked"]),
                    LastLoginDate = row["LastLoginDate"] == DBNull.Value
                        ? (DateTimeOffset?)null
                        : DateTimeOffset.Parse(row["LastLoginDate"].ToString()),
                    LockedDate = row["LockedDate"] == DBNull.Value
                        ? (DateTime?)null
                        : Convert.ToDateTime(row["LockedDate"]),
                };
            }
            public static void Create(string userName, int idTracker, int idUser) =>
                new DataAccessLayer().ExecuteNonQuery("INSERT INTO [dbo].[User] (UserName, IdTracker, IdUser) VALUES (@UserName, @IdTracker, @IdUser)",
                    new[] { new SqlParameter("UserName", userName), new SqlParameter("IdTracker", idTracker), new SqlParameter("IdUser", idUser) });

            public static void Update(int id, string userName, int idTracker, int idUser) =>
                new DataAccessLayer().ExecuteNonQuery("UPDATE [dbo].[User] SET UserName = @UserName, IdTracker = @IdTracker, IdUser = @IdUser WHERE Id = @Id",
                    new[] { new SqlParameter("Id", id), new SqlParameter("UserName", userName), new SqlParameter("IdTracker", idTracker), new SqlParameter("IdUser", idUser) });

            public static void Delete(int id) =>
                new DataAccessLayer().ExecuteNonQuery("DELETE FROM [dbo].[User] WHERE Id = @Id", new[] { new SqlParameter("Id", id) });
        }

        // ------------------------------------------------------------------
        // NOTIFICATION
        // ------------------------------------------------------------------
        public static class Notification
        {
            public static DataTable ListAll() => new DataAccessLayer().ExecuteReader("SELECT * FROM [dbo].[Notification]", []);

            public static DataRow GetById(int id) =>
                new DataAccessLayer().ExecuteReader("SELECT * FROM [dbo].[Notification] WHERE Id = @Id", new[] { new SqlParameter("Id", id) }).Rows[0];

            public static void Create(string messages, int userId) =>
                new DataAccessLayer().ExecuteNonQuery("INSERT INTO [dbo].[Notification] (Message, IdUser) VALUES (@Message, @IdUser)",
                    new[] { new SqlParameter("Message", messages), new SqlParameter("IdUser", userId) });

            public static void Delete(int id) =>
                new DataAccessLayer().ExecuteNonQuery("DELETE FROM [dbo].[Notification] WHERE Id = @Id", new[] { new SqlParameter("Id", id) });
        }

        // ------------------------------------------------------------------
        // TRACKER
        // ------------------------------------------------------------------
        public static class Tracker
        {
            public static DataTable ListAll() => new DataAccessLayer().ExecuteReader("SELECT * FROM [dbo].[Tracker]", []);

            public static TrackerModel GetById(int id)
            {
                var dt = new DataAccessLayer().ExecuteReader(
                    "SELECT * FROM [dbo].[Tracker] WHERE Id = @Id",
                    new[] { new SqlParameter("Id", id) });

                if (dt.Rows.Count == 0)
                    return null; // or throw an exception

                var row = dt.Rows[0];

                return new TrackerModel
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString(),
                    Description = row["Description"].ToString()
                };
            }
            public static TrackerModel Create(string name, string description)
            {
                var dt = new DataAccessLayer().ExecuteReader(
                    "INSERT INTO [dbo].[Tracker] (Name, Description) " +
                    "OUTPUT INSERTED.Id, INSERTED.Name, INSERTED.Description " +
                    "VALUES (@Name, @Description)",
                    new[] {
            new SqlParameter("@Name", name),
            new SqlParameter("@Description", description)
                    });

                if (dt.Rows.Count > 0)
                {
                    var row = dt.Rows[0];
                    return new TrackerModel
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Name = row["Name"].ToString(),
                        Description = row["Description"].ToString()
                    };
                }

                return null; // Or throw an exception if something went wrong
            }
            public static void Update(int id, string name, string description) =>
                new DataAccessLayer().ExecuteNonQuery("UPDATE [dbo].[Tracker] SET Name = @Name, Description = @Description WHERE Id = @Id",
                    new[] { new SqlParameter("Id", id), new SqlParameter("Name", name), new SqlParameter("Description", description) });

            public static void Delete(int id) =>
                new DataAccessLayer().ExecuteNonQuery("DELETE FROM [dbo].[Tracker] WHERE Id = @Id", new[] { new SqlParameter("Id", id) });

            public static TrackerModel[] GetTrackersByUserId(int userId)
            {
                var dt = new DataAccessLayer().ExecuteReader(
                    @"SELECT t.* 
          FROM [dbo].[Tracker] t
          INNER JOIN [dbo].[UserTracker] ut ON t.Id = ut.IdTracker
          WHERE ut.IdUser = @UserId",
                    new[] { new SqlParameter("@UserId", userId) }
                );

                var trackers = new List<TrackerModel>();

                foreach (DataRow row in dt.Rows)
                {
                    trackers.Add(new TrackerModel
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Name = row["Name"].ToString(),
                        Description = row["Description"].ToString()
                    });
                }

                return trackers.ToArray();
            }
        }

        // ------------------------------------------------------------------
        // USERTRACKER
        // ------------------------------------------------------------------
            public static class UserTracker
            {

                public static DataTable ListAll() => new DataAccessLayer().ExecuteReader("SELECT * FROM [dbo].[UserTracker]", []);

                public static DataRow GetById(int id) =>
                    new DataAccessLayer().ExecuteReader("SELECT * FROM [dbo].[UserTracker] WHERE Id = @Id", new[] { new SqlParameter("Id", id) }).Rows[0];

                public static void Create(int idTracker, int idUser, bool isOwner) =>
                    new DataAccessLayer().ExecuteNonQuery("INSERT INTO [dbo].[UserTracker] (IdTracker, IdUser, IsOwner) VALUES (@IdTracker, @IdUser, @IsOwner)",
                        new[] { new SqlParameter("IdTracker", idTracker), new SqlParameter("IdUser", idUser), new SqlParameter("IsOwner", isOwner) });

                public static void Update(int id, int idTracker, int idUser, bool isOwner) =>
                    new DataAccessLayer().ExecuteNonQuery("UPDATE [dbo].[UserTracker] SET IdTracker = @IdTracker, IdUser = @IdUser, IsOwner = @IsOwner WHERE Id = @Id",
                        new[] { new SqlParameter("Id", id), new SqlParameter("IdTracker", idTracker), new SqlParameter("IdUser", idUser), new SqlParameter("IsOwner", isOwner) });

            public static void Delete(int trackerId, int userId) =>
  new DataAccessLayer().ExecuteNonQuery(
      "DELETE FROM [dbo].[UserTracker] WHERE IdTracker = @IdTracker AND IdUser = @IdUser",
      new[] {
            new SqlParameter("@IdTracker", trackerId),
            new SqlParameter("@IdUser", userId)
      });
            public static DataTable GetUsersByTrackerId(int trackerId)
                {
                    return new DataAccessLayer().ExecuteReader(
                        @"SELECT u.* 
                  FROM [dbo].[User] u
                  INNER JOIN [dbo].[UserTracker] ut ON u.Id = ut.IdUser
                  WHERE ut.IdTracker = @TrackerId",
                        new[] { new SqlParameter("@TrackerId", trackerId) });
                }

                // New method: returns true if user is already a participant in the tracker
                public static bool IsUserParticipant(int userId, int trackerId)
                {
                    var dt = new DataAccessLayer().ExecuteReader(
                        @"SELECT COUNT(*) AS Count
                  FROM [dbo].[UserTracker]
                  WHERE IdUser = @UserId AND IdTracker = @TrackerId",
                        new[] {
                    new SqlParameter("@UserId", userId),
                    new SqlParameter("@TrackerId", trackerId)
                        });

                    if (dt.Rows.Count > 0 && int.TryParse(dt.Rows[0]["Count"].ToString(), out int count))
                    {
                        return count > 0;
                    }
                    return false;
                }

                public static bool IsUserOwner(int userId, int trackerId)
                {
                    var dt = new DataAccessLayer().ExecuteReader(
                        @"SELECT COUNT(*) AS Count
              FROM [dbo].[UserTracker]
              WHERE IdUser = @UserId AND IdTracker = @TrackerId AND IsOwner = 1",
                        new[] {
                new SqlParameter("@UserId", userId),
                new SqlParameter("@TrackerId", trackerId)
                        });

                    if (dt.Rows.Count > 0 && int.TryParse(dt.Rows[0]["Count"].ToString(), out int count))
                    {
                        return count > 0;
                    }
                    return false;
                }
            }

        // ------------------------------------------------------------------
        // TRANSACTION
        // ------------------------------------------------------------------
        public static class Transaction
        {
            public static TransactionModel[] GetAllByTrackerId(int trackerId)
            {
                var dt = new DataAccessLayer().ExecuteReader(
                    "SELECT * FROM [dbo].[Transaction] WHERE TrackerId = @TrackerId ORDER BY Date DESC", // latest first
                    new[] { new SqlParameter("TrackerId", trackerId) }
                );

                return dt.AsEnumerable()
                         .Select(row => new TransactionModel
                         {
                             Id = row.Field<int>("Id"),
                             Value = row.Field<decimal>("Value"),
                             Type = row.Field<string>("Type"),
                             CreatedById = row.Field<int>("CreatedById"),
                             Description = row.IsNull("Description") ? null : row.Field<string>("Description"),
                             Date = row.Field<DateTime>("Date"),
                             TrackerId = row.Field<int>("TrackerId")
                         })
                         .ToArray();
            }

            public static DataTable ListAll() =>
                new DataAccessLayer().ExecuteReader("SELECT * FROM [dbo].[Transaction]", []);

            public static DataRow GetById(int id) =>
                new DataAccessLayer().ExecuteReader(
                    "SELECT * FROM [dbo].[Transaction] WHERE Id = @Id",
                    new[] { new SqlParameter("Id", id) }
                ).Rows[0];

            public static void Create(decimal value, string type, int createdById, int trackerId, DateTime date, string description = null) =>
                new DataAccessLayer().ExecuteNonQuery(
                    "INSERT INTO [dbo].[Transaction] (Value, Type, CreatedById, TrackerId, Date, Description) " +
                    "VALUES (@Value, @Type, @CreatedById, @TrackerId, @Date, @Description)",
                    new[]
                    {
                new SqlParameter("Value", value),
                new SqlParameter("Type", type),
                new SqlParameter("CreatedById", createdById),
                new SqlParameter("TrackerId", trackerId),
                new SqlParameter("Date", date),
                new SqlParameter("Description", (object?)description ?? DBNull.Value)
                    });

            public static void Update(int id, decimal value, string type, int createdById, int trackerId, DateTime date, string description = null) =>
                new DataAccessLayer().ExecuteNonQuery(
                    "UPDATE [dbo].[Transaction] SET Value = @Value, Type = @Type, CreatedById = @CreatedById, TrackerId = @TrackerId, Date = @Date, Description = @Description " +
                    "WHERE Id = @Id",
                    new[]
                    {
                new SqlParameter("Id", id),
                new SqlParameter("Value", value),
                new SqlParameter("Type", type),
                new SqlParameter("CreatedById", createdById),
                new SqlParameter("TrackerId", trackerId),
                new SqlParameter("Date", date),
                new SqlParameter("Description", (object?)description ?? DBNull.Value)
                    });

            public static void Delete(int id) =>
                new DataAccessLayer().ExecuteNonQuery(
                    "DELETE FROM [dbo].[Transaction] WHERE Id = @Id",
                    new[] { new SqlParameter("Id", id) });
        }

        // ------------------------------------------------------------------
        // TRANSACTION TYPE
        // ------------------------------------------------------------------
        public static class TransactionType
        {
            public static DataTable ListAll() => new DataAccessLayer().ExecuteReader("SELECT * FROM [dbo].[TransactionType]", []);

            public static DataRow GetById(int id) =>
                new DataAccessLayer().ExecuteReader("SELECT * FROM [dbo].[TransactionType] WHERE Id = @Id", new[] { new SqlParameter("Id", id) }).Rows[0];

            public static void Create(string name) =>
                new DataAccessLayer().ExecuteNonQuery("INSERT INTO [dbo].[TransactionType] (Name) VALUES (@Name)", new[] { new SqlParameter("Name", name) });

            public static void Update(int id, string name) =>
                new DataAccessLayer().ExecuteNonQuery("UPDATE [dbo].[TransactionType] SET Name = @Name WHERE Id = @Id",
                    new[] { new SqlParameter("Id", id), new SqlParameter("Name", name) });

            public static void Delete(int id) =>
                new DataAccessLayer().ExecuteNonQuery("DELETE FROM [dbo].[TransactionType] WHERE Id = @Id", new[] { new SqlParameter("Id", id) });
        }

        // ------------------------------------------------------------------
        // ------------------------------------------------------------------
        // BUDGETS
        // ------------------------------------------------------------------
        public static class Budgets
        {
            public static DataTable ListAll() => new DataAccessLayer().ExecuteReader("SELECT * FROM [dbo].[Budgets]", []);

            public static DataRow GetById(int id) =>
                new DataAccessLayer().ExecuteReader("SELECT * FROM [dbo].[Budgets] WHERE Id = @Id", new[] { new SqlParameter("Id", id) }).Rows[0];

            public static void Create(decimal value, string name, string description) =>
                new DataAccessLayer().ExecuteNonQuery("INSERT INTO [dbo].[Budgets] (Value, Name, Description) VALUES (@Value, @Name, @Description)",
                    new[] { new SqlParameter("Value", value), new SqlParameter("Name", name), new SqlParameter("Description", description) });

            public static void Update(int id, decimal value, string name, string description) =>
                new DataAccessLayer().ExecuteNonQuery("UPDATE [dbo].[Budgets] SET Value = @Value, Name = @Name, Description = @Description WHERE Id = @Id",
                    new[] { new SqlParameter("Id", id), new SqlParameter("Value", value), new SqlParameter("Name", name), new SqlParameter("Description", description) });

            public static void Delete(int id) =>
                new DataAccessLayer().ExecuteNonQuery("DELETE FROM [dbo].[Budgets] WHERE Id = @Id", new[] { new SqlParameter("Id", id) });
        }

        // ------------------------------------------------------------------
        // TRANSACTION TAG
        // ------------------------------------------------------------------
        public static class TransactionTag
        {
            public static DataTable ListAll() => new DataAccessLayer().ExecuteReader("SELECT * FROM [dbo].[TransactionTag]", []);

            public static DataRow GetById(int id) =>
                new DataAccessLayer().ExecuteReader("SELECT * FROM [dbo].[TransactionTag] WHERE Id = @Id", new[] { new SqlParameter("Id", id) }).Rows[0];

            public static void Create(int idTag, int idTransaction) =>
                new DataAccessLayer().ExecuteNonQuery("INSERT INTO [dbo].[TransactionTag] (IdTag, IdTransaction) VALUES (@IdTag, @IdTransaction)",
                    new[] { new SqlParameter("IdTag", idTag), new SqlParameter("IdTransaction", idTransaction) });

            public static void Update(int id, int idTag, int idTransaction) =>
                new DataAccessLayer().ExecuteNonQuery("UPDATE [dbo].[TransactionTag] SET IdTag = @IdTag, IdTransaction = @IdTransaction WHERE Id = @Id",
                    new[] { new SqlParameter("Id", id), new SqlParameter("IdTag", idTag), new SqlParameter("IdTransaction", idTransaction) });

            public static void Delete(int id) =>
                new DataAccessLayer().ExecuteNonQuery("DELETE FROM [dbo].[TransactionTag] WHERE Id = @Id", new[] { new SqlParameter("Id", id) });
        }

        // ------------------------------------------------------------------
        // TAG
        // ------------------------------------------------------------------
        public static class Tag
        {
            public static DataTable ListAll() => new DataAccessLayer().ExecuteReader("SELECT * FROM [dbo].[Tag]", []);

            public static DataRow GetById(int id) =>
                new DataAccessLayer().ExecuteReader("SELECT * FROM [dbo].[Tag] WHERE Id = @Id", new[] { new SqlParameter("Id", id) }).Rows[0];

            public static void Create(string name, string iconUrl) =>
                new DataAccessLayer().ExecuteNonQuery("INSERT INTO [dbo].[Tag] (Name, IconUrl) VALUES (@Name, @IconUrl)",
                    new[] { new SqlParameter("Name", name), new SqlParameter("IconUrl", iconUrl) });

            public static void Update(int id, string name, string iconUrl) =>
                new DataAccessLayer().ExecuteNonQuery("UPDATE [dbo].[Tag] SET Name = @Name, IconUrl = @IconUrl WHERE Id = @Id",
                    new[] { new SqlParameter("Id", id), new SqlParameter("Name", name), new SqlParameter("IconUrl", iconUrl) });

            public static void Delete(int id) =>
                new DataAccessLayer().ExecuteNonQuery("DELETE FROM [dbo].[Tag] WHERE Id = @Id", new[] { new SqlParameter("Id", id) });
        }
    }
}