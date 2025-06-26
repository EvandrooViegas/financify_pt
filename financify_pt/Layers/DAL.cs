using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;

namespace financify_pt
{
    public class DataAccessLayer
    {
        private SqlConnection _SqlConn;
        private SqlCommand _SqlCommand;
        private SqlDataReader _SqlReader;

        public DataAccessLayer()
        {
            _SqlConn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\124644\\Desktop\\LoginExample.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        }

        private void OpenConnection()
        {
            try
            {
                _SqlConn.Open();
            }
            catch (Exception e)
            {
                // Handle exception
            }
        }

        private void CloseConnection()
        {
            try
            {
                _SqlConn.Close();
            }
            catch (Exception e)
            {
                // Handle exception
            }
        }

        private void AssociateCommand(String sqlCmd)
        {
            _SqlCommand = new SqlCommand(sqlCmd, _SqlConn);
        }

        public DataTable ExecuteStoredProcReader(String sqlCmd, SqlParameter[] sqlParams)
        {
            DataTable returnTable = new DataTable("returnTable");

            AssociateCommand(sqlCmd);

            _SqlCommand.CommandType = CommandType.StoredProcedure;

            if (sqlParams != null)
                _SqlCommand.Parameters.AddRange(sqlParams);

            OpenConnection();

            if (_SqlConn.State == ConnectionState.Open)
            {
                _SqlReader = _SqlCommand.ExecuteReader();

                returnTable.Load(_SqlReader);

                _SqlReader.Close();
            }

            CloseConnection();

            return returnTable;
        }

        // Stored Procedure without parameters
        public DataTable ExecuteStoredProcReader(String sqlCmd)
        {
            return this.ExecuteStoredProcReader(sqlCmd, null);
        }

        public int ExecuteStoredProcNonQuery(String sqlCmd, SqlParameter[] sqlParams)
        {
            int returnValue = -1;

            AssociateCommand(sqlCmd);

            _SqlCommand.CommandType = CommandType.StoredProcedure;
            _SqlCommand.Parameters.AddRange(sqlParams);

            OpenConnection();

            if (_SqlConn.State == ConnectionState.Open)
            {
                returnValue = _SqlCommand.ExecuteNonQuery();
            }

            CloseConnection();

            return returnValue;
        }

        public object ExecuteStoredProcScalar(String sqlCmd, SqlParameter[] sqlParams)
        {
            object result = null;
            AssociateCommand(sqlCmd);
            _SqlCommand.CommandType = CommandType.StoredProcedure;
            _SqlCommand.Parameters.AddRange(sqlParams);

            OpenConnection();

            if (_SqlConn.State == ConnectionState.Open)
            {
                result = _SqlCommand.ExecuteScalar();
            }

            CloseConnection();
            _SqlCommand.Parameters.Clear();
            return result;
        }

        public DataTable ExecuteReader(String sqlCmd, SqlParameter[] sqlParams)
        {
            DataTable returnTable = new DataTable("returnTable");

            AssociateCommand(sqlCmd);

            _SqlCommand.CommandType = CommandType.Text;

            if (sqlParams != null)
                _SqlCommand.Parameters.AddRange(sqlParams);

            OpenConnection();

            if (_SqlConn.State == ConnectionState.Open)
            {
                _SqlReader = _SqlCommand.ExecuteReader();

                returnTable.Load(_SqlReader);

                _SqlReader.Close();
            }

            CloseConnection();
            _SqlCommand.Parameters.Clear();
            return returnTable;
        }

        public int ExecuteNonQuery(String sqlCmd, SqlParameter[] sqlParams)
        {
            int returnValue = -1;

            AssociateCommand(sqlCmd);

            _SqlCommand.CommandType = CommandType.Text;
            _SqlCommand.Parameters.AddRange(sqlParams);

            OpenConnection();

            if (_SqlConn.State == ConnectionState.Open)
            {
                _SqlCommand.ExecuteNonQuery();
            }

            CloseConnection();
            _SqlCommand.Parameters.Clear();
            return returnValue;
        }

        public object ExecuteScalar(String sqlCmd, SqlParameter[] sqlParams)
        {
            object result = null;
            AssociateCommand(sqlCmd);
            _SqlCommand.CommandType = CommandType.Text;
            _SqlCommand.Parameters.AddRange(sqlParams);

            OpenConnection();

            if (_SqlConn.State == ConnectionState.Open)
            {
                result = _SqlCommand.ExecuteScalar();
            }

            CloseConnection();
            _SqlCommand.Parameters.Clear();
            return result;
        }
    }
}