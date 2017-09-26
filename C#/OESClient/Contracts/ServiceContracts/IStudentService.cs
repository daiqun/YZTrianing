using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Contracts.DataContracts;

namespace Contracts.ServiceContracts
{
    /// <summary>
    /// IStudentService interface
    /// </summary>
    [ServiceContract(Name = "IStudentService", Namespace = "http://www.rick.com/")]
    public interface IStudentService
    {
        /// <summary>
        /// Student exam
        /// </summary>
        /// <param name="studentSelect"></param>
        /// <returns></returns>
        [OperationContract]
        List<StudentExam> StudentExam(StudentSelect studentSelect);

        /// <summary>
        /// Student exam count
        /// </summary>
        /// <param name="studentSelect"></param>
        /// <returns></returns>
        [OperationContract]
        int StudentExamCount(StudentSelect studentSelect);

        /// <summary>
        /// Curren exam
        /// </summary>
        /// <param name="exam"></param>
        /// <returns></returns>
        [OperationContract]
        Exam CurrenExam(Exam exam);

        /// <summary>
        /// Current testing content
        /// </summary>
        /// <param name="testingContent"></param>
        /// <returns></returns>
        [OperationContract]
        List<TestingContent> CurrentTesting(TestingContent testingContent);

        /// <summary>
        /// Add a exam record
        /// </summary>
        /// <param name="examRecord"></param>
        [OperationContract]
        int AddExamRecord(ExamRecord examRecord);

        /// <summary>
        /// Student exam notice
        /// </summary>
        /// <param name="studentExam"></param>
        /// <returns></returns>
        [OperationContract]
        List<Exam> StudentExamNotice(StudentExam studentExam);

        /// <summary>
        /// Take exam about
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        ExamAbout TakeExamAbout(ExamAbout examAbout);
    }
}