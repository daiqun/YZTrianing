using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Contracts.DataContracts;
using System.Data;

namespace DAL
{
    /// <summary>
    /// LoginDB manage user login
    /// </summary>
    public class LoginDB
    {
        public string CONNECTION_STRING = DAL.Properties.Settings.Default.connectionString;

        /// <summary>
        /// Verify user login
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public User VerifyUserLogin(User user)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            SqlCommand command = new SqlCommand("spVerifyUserLogin", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@Username", user.Username));
            command.Parameters.Add(new SqlParameter("@Password", user.Password));

            User us = null;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    us = new User();
                    us.Id = reader.GetInt32(0);
                    us.Username = reader.GetString(1);
                }
            }

            return us;
        }

        /// <summary>
        /// Judge user type
        /// </summary>
        /// <param name="userRole"></param>
        /// <returns></returns>
        public List<int> JudgeUserType(UserRole userRole)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            SqlCommand command = new SqlCommand("spJudgeUserType", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@UserId", userRole.UserId));
            List<int> allRole = new List<int>();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int roleId = reader.GetInt32(0);
                    allRole.Add(roleId);
                }
            }

            return allRole;
        }
    }
}