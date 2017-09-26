using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logic.LoginServiceReference;
using Logic.ExceptionDeal;

namespace Logic
{
    /// <summary>
    /// User login manage.
    /// </summary>
    public class UserLogin
    {
        private UserLoginClient client;

        public UserLogin()
        {
            client = new UserLoginClient();
        }

        /// <summary>
        /// Verify user login.
        /// </summary>
        /// <param name="user">include username and password</param>
        /// <returns>user result</returns>
        public User VerifyUserLogin(User user)
        {
            try
            {
                return client.VerifyUserLogin(user);
            }
            catch (RequestExceprion ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Judge user type
        /// </summary>
        /// <param name="userRole"></param>
        /// <returns></returns>
        public int[] JudgeUserType(UserRole userRole)
        {
            try
            {
                return client.JudgeUserType(userRole);
            }
            catch (RequestExceprion ex)
            {
                throw ex;
            }
        }
    }
}