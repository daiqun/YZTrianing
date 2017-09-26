using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts.ServiceContracts;
using DAL;
using Contracts.DataContracts;

namespace Services
{
    /// <summary>
    /// LoginService
    /// </summary>
    public class LoginService : ILoginService
    {
        private LoginDB userLogin;

        public LoginService()
        {
            userLogin = new LoginDB();
        }

        /// <summary>
        /// Verify user login
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public User VerifyUserLogin(User user)
        {
            return userLogin.VerifyUserLogin(user);
        }

        /// <summary>
        /// Judge user type
        /// </summary>
        /// <param name="userRole"></param>
        /// <returns></returns>
        public List<int> JudgeUserType(UserRole userRole)
        {
            return userLogin.JudgeUserType(userRole);
        }
    }
}