using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Contracts.DataContracts;

namespace Contracts.ServiceContracts
{
    /// <summary>
    /// IUserLogin interface
    /// </summary>
    [ServiceContract(Name = "IUserLogin", Namespace = "http://www.rick.com/")]
    public interface ILoginService
    {
        /// <summary>
        /// Verify user login
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [OperationContract]
        User VerifyUserLogin(User user);

        /// <summary>
        /// Judge user type
        /// </summary>
        /// <param name="userRole"></param>
        /// <returns></returns>
        [OperationContract]
        List<int> JudgeUserType(UserRole userRole);
    }
}