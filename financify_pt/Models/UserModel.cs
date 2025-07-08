using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace financify_pt
{
    public class UserModel
    {
            public int Id { get; set; }
            public string Email { get; set; } = null!;
            public string Password { get; set; } = null!;
            public string Salt { get; set; } = null!;
            public bool IsAdmin { get; set; }
            public string Username { get; set; }
        public bool IsLocked { get; set; }
            public DateTimeOffset? LastLoginDate { get; set; }
            public DateTimeOffset? LockedDate { get; set; }
    }
}
