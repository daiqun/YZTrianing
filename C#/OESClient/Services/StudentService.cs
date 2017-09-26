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
    /// StudentService
    /// </summary>
    public class StudentService : IStudentService
    {
        private StudentDB studentDb;

        public StudentService()
        {
            studentDb = new StudentDB();
        }

        /// <summary>
        /// Student Exam
        /// </summary>
        /// <param name="studentSelect"></param>
        /// <returns></returns>
        public List<StudentExam> StudentExam(StudentSelect studentSelect)
        {
            return studentDb.StudentExam(studentSelect);
        }

        /// <summary>
        /// Student Exam Count
        /// </summary>
        /// <param name="studentSelect"></param>
        /// <returns></returns>
        public int StudentExamCount(StudentSelect studentSelect)
        {
            return studentDb.StudentExamCount(studentSelect);
        }

        /// <summary>
        /// Curren exam
        /// </summary>
        /// <param name="exam"></param>
        /// <returns></returns>
        public Exam CurrenExam(Exam exam)
        {
            return studentDb.CurrentExam(exam);
        }

        /// <summary>
        /// Current testing
        /// </summary>
        /// <param name="testingContent"></param>
        /// <returns></returns>
        public List<TestingContent> CurrentTesting(TestingContent testingContent)
        {
            return studentDb.CurrentTesting(testingContent);
        }

        /// <summary>
        /// Add exam record
        /// </summary>
        /// <param name="examRecord"></param>
        /// <returns></returns>
        public int AddExamRecord(ExamRecord examRecord)
        {
            return studentDb.AddExamRecord(examRecord);
        }

        /// <summary>
        /// Student exam notice
        /// </summary>
        /// <param name="studentExam"></param>
        /// <returns></returns>
        public List<Exam> StudentExamNotice(StudentExam studentExam)
        {
            return studentDb.StudentExamNotice(studentExam);
        }

        /// <summary>
        /// Take exam about
        /// </summary>
        /// <returns></returns>
        public ExamAbout TakeExamAbout(ExamAbout examAbout)
        {
            return studentDb.TakeExamAbout(examAbout);
        }
    }
}