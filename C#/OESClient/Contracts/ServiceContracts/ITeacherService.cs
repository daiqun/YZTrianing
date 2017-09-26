using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Contracts.DataContracts;

namespace Contracts.ServiceContracts
{
    /// <summary>
    /// ITeacherService interface
    /// </summary>
    [ServiceContract(Name = "ITeacherService", Namespace = "http://www.rick.com/")]
    public interface ITeacherService
    {
        /// <summary>
        /// Teacher manage exam list
        /// </summary>
        /// <param name="teacherSelect"></param>
        /// <returns></returns>
        [OperationContract]
        List<TeacherManage> ExamList(TeacherSelect teacherSelect);

        /// <summary>
        /// Teacher manage exam list count
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [OperationContract]
        int ExamListCount(TeacherSelect teacherSelect);

        /// <summary>
        /// ExamJoinDetails
        /// </summary>
        /// <param name="examRecord"></param>
        /// <returns></returns>
        [OperationContract]
        List<ExamDetails> ExamJoinDetails(ExamSelect examSelect);
    }
}