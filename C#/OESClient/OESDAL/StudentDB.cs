using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts.DataContracts;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    /// <summary>
    /// StudentDB
    /// </summary>
    public class StudentDB
    {
        public string CONNECTION_STRING = DAL.Properties.Settings.Default.connectionString;

        /// <summary>
        /// Student exam list
        /// </summary>
        /// <param name="studentSelect"></param>
        /// <returns></returns>
        public List<StudentExam> StudentExam(StudentSelect studentSelect)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            SqlCommand command = new SqlCommand("spStudentExam", connection);
            command.CommandType = CommandType.StoredProcedure;
            List<StudentExam> studentExamList = new List<StudentExam>();

            command.Parameters.Add(new SqlParameter("@Id", studentSelect.Id));
            command.Parameters.Add(new SqlParameter("@CurrentPage", studentSelect.CurrentPage));
            command.Parameters.Add(new SqlParameter("@PageSize", studentSelect.PageSize));
            command.Parameters.Add(new SqlParameter("@StudentSortName", studentSelect.StudentSortName));
            command.Parameters.Add(new SqlParameter("@StudentSortDirction", studentSelect.StudentSortDirction));
            command.Parameters.Add(new SqlParameter("@IsFinished", studentSelect.IsFinished));

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    StudentExam studentExam = new StudentExam();

                    studentExam.ExamName = reader.GetString(0);
                    studentExam.Id = reader.GetInt32(1);
                    studentExam.EffectiveTime = reader.GetDateTime(2);
                    studentExam.Duration = reader.GetInt32(3);
                    studentExam.PassCriteria = reader.GetInt32(4);
                    studentExam.Operation = reader.GetInt32(5);
                    studentExam.ExamSocre = reader[6] == System.DBNull.Value ? 0 : reader.GetInt32(6);
                    studentExam.RowNumber = reader.GetInt64(7);

                    studentExamList.Add(studentExam);
                }
            }

            return studentExamList;
        }

        /// <summary>
        /// Student Exam Count
        /// </summary>
        /// <param name="studentSelect"></param>
        /// <returns></returns>
        public int StudentExamCount(StudentSelect studentSelect)
        {
            int res = 0;

            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            SqlCommand command = new SqlCommand("spStudentExamCount", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Id", studentSelect.Id));
            command.Parameters.Add(new SqlParameter("@IsFinished", studentSelect.IsFinished));

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    res = reader.GetInt32(0);
                }
            }

            return res;
        }

        /// <summary>
        /// Current exam information
        /// </summary>
        /// <param name="exam"></param>
        /// <returns></returns>
        public Exam CurrentExam(Exam exam)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            SqlCommand command = new SqlCommand("spCurrentExam", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Id", exam.Id));
            Exam currentExam = new Exam();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    currentExam.Id = reader.GetInt32(0);
                    currentExam.ExamName = reader.GetString(1);
                    currentExam.EffectiveTime = reader.GetDateTime(2);
                    currentExam.Duration = reader.GetInt32(3);
                    currentExam.TotalScore = reader.GetInt32(5);
                    currentExam.QuestionPoints = reader.GetInt32(6);
                    currentExam.QuestionQuantity = reader.GetInt32(7);
                    currentExam.Notice = reader.GetString(8);
                }
            }

            return currentExam;
        }

        /// <summary>
        /// Testing content
        /// </summary>
        /// <param name="testing"></param>
        /// <returns></returns>
        public List<TestingContent> CurrentTesting(TestingContent testing)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            SqlCommand command = new SqlCommand("spTestingContent", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@examId", testing.ExamId));
            List<TestingContent> testList = new List<TestingContent>();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    TestingContent test = new TestingContent();
                    test.Id = reader.GetInt32(0);
                    test.QuestionContent = reader.GetString(1);
                    test.ChoiceA = reader.GetString(2);
                    test.ChoiceB = reader.GetString(3);
                    test.ChoiceC = reader.GetString(4);
                    test.ChoiceD = reader.GetString(5);
                    test.CorrectAnwser = reader.GetString(6);
                    testList.Add(test);
                }
            }

            return testList;
        }

        /// <summary>
        /// Add exam record
        /// </summary>
        /// <param name="examRecord"></param>
        public int AddExamRecord(ExamRecord examRecord)
        {
            int row = 0;

            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            SqlCommand command = new SqlCommand("spAddExamRecord", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Operation", examRecord.IsPass));
            command.Parameters.Add(new SqlParameter("@ExamScore", examRecord.ExamScore));
            command.Parameters.Add(new SqlParameter("@IsPass", examRecord.IsPass));
            command.Parameters.Add(new SqlParameter("@UserId", examRecord.UserId));
            command.Parameters.Add(new SqlParameter("@ExamId", examRecord.ExamId));
            command.Parameters.Add(new SqlParameter("@UserAnwser", examRecord.UserAnwser));
            command.Parameters.Add(new SqlParameter("@EffectiveTime", examRecord.EffectiveTime));
            command.Parameters.Add(new SqlParameter("@SubmitTime", examRecord.SubmitTime));

            row = command.ExecuteNonQuery();

            return row;
        }

        /// <summary>
        /// Student exam notice
        /// </summary>
        /// <param name="studentExam"></param>
        /// <returns></returns>
        public List<Exam> StudentExamNotice(StudentExam studentExam)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            SqlCommand command = new SqlCommand("spStudentExamNotice", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@UserId", studentExam.UserId));
            command.Parameters.Add(new SqlParameter("@Operation", studentExam.Operation));
            List<Exam> exams = new List<Exam>();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Exam exam = new Exam();
                    exam.Id = reader.GetInt32(0);
                    exam.ExamName = reader.GetString(1);
                    exam.EffectiveTime = reader.GetDateTime(2);
                    exams.Add(exam);
                }
            }

            return exams;
        }

        /// <summary>
        /// Take exam about
        /// </summary>
        /// <returns></returns>
        public ExamAbout TakeExamAbout(ExamAbout examAbout)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            SqlCommand command = new SqlCommand("spExamAbout", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@Id", examAbout.Id));
            ExamAbout exam = null;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    exam = new ExamAbout();
                    exam.ExaminationRules = reader.GetString(1);
                    exam.SystemInformation = reader.GetString(2);
                    exam.ContactUs = reader.GetString(3);
                }
            }

            return exam;
        }
    }
}