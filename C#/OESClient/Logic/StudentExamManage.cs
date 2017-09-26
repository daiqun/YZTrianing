using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logic.StudentServiceReference;
using Logic.ExceptionDeal;

namespace Logic
{
    /// <summary>
    /// Student exam manage.
    /// </summary>
    public class StudentExamManage
    {
        private StudentServiceClient client;

        public StudentExamManage()
        { 
           client = new StudentServiceClient();
        }

        /// <summary>
        /// Student exam list.
        /// </summary>
        /// <param name="studentSelect">
        /// Include StudentSortName, StudentSortDirction, CurrentPage, PageSize, IsFinished, Id
        /// </param>
        /// <returns>Search student exam list</returns>
        public StudentExam[] StudentExam(StudentSelect studentSelect)
        {
            try
            {
                return client.StudentExam(studentSelect);
            }
            catch (RequestExceprion ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Search student exam count.
        /// </summary>
        /// <param name="studentSelect">Operation(if = 0)</param>
        /// <returns>student exam count</returns>
        public int StudentExamCount(StudentSelect studentSelect)
        {
            try
            {
                return client.StudentExamCount(studentSelect);
            }
            catch (RequestExceprion ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Select current exam information.
        /// </summary>
        /// <param name="exam">Include int examId</param>
        /// <returns>Exam</returns>
        public Exam CurrentExam(Exam exam)
        {
            try
            {
                return client.CurrenExam(exam);
            }
            catch (RequestExceprion ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Current testing.
        /// </summary>
        /// <param name="testingContent">Include exam id</param>
        /// <returns>All question in this question</returns>
        public TestingContent[] CurrentTesting(TestingContent testingContent)
        {
            try
            {
                return client.CurrentTesting(testingContent);
            }
            catch (RequestExceprion ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Add exam record
        /// </summary>
        /// <param name="examRecord">
        /// ExamRecord include ExamScore, IsPass, UserId, ExamId, UserAnwser, EffectiveTime, SubmitTime
        /// </param>
        /// <returns>Influence row</returns>
        public int AddExamRecord(ExamRecord examRecord)
        {
            try
            {
                return client.AddExamRecord(examRecord);
            }
            catch (RequestExceprion ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Student exam notice
        /// </summary>
        /// <param name="studentExam"></param>
        /// <returns></returns>
        public Exam[] StudentExamNotice(StudentExam studentExam)
        {
            try
            {
                return client.StudentExamNotice(studentExam);
            }
            catch (RequestExceprion ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Take exam about
        /// </summary>
        /// <param name="examAbout"></param>
        /// <returns></returns>
        public ExamAbout TakeExamAbout(ExamAbout examAbout)
        {
            try
            {
                return client.TakeExamAbout(examAbout);
            }
            catch (RequestExceprion ex)
            {
                throw ex;
            }
        }
    }
}