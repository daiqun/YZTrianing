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
    /// TeacherDB
    /// </summary>
    public class TeacherDB
    {
        public string CONNECTION_STRING = DAL.Properties.Settings.Default.connectionString;

        /// <summary>
        /// Exam list
        /// </summary>
        /// <param name="teacherSelect"></param>
        /// <returns></returns>
        public List<TeacherManage> ExamList(TeacherSelect teacherSelect)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            SqlCommand command = new SqlCommand("spTeacherManage", connection);
            command.CommandType = CommandType.StoredProcedure;
            List<TeacherManage> teacherManageExam = new List<TeacherManage>();

            command.Parameters.Add(new SqlParameter("@TeacherSortName", teacherSelect.TeacherSortName));
            command.Parameters.Add(new SqlParameter("@TeacherSortDirction", teacherSelect.TeacherSortDirction));
            command.Parameters.Add(new SqlParameter("@Name", teacherSelect.Name));
            command.Parameters.Add(new SqlParameter("@CurrentPage", teacherSelect.CurrentPage));
            command.Parameters.Add(new SqlParameter("@PageSize", teacherSelect.PageSize));
            command.Parameters.Add(new SqlParameter("@StartDate", teacherSelect.StartTime));
            command.Parameters.Add(new SqlParameter("@EndDate", teacherSelect.EndTime));

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    TeacherManage teacherManage = new TeacherManage();

                    teacherManage.ExamName = reader.GetString(0);
                    teacherManage.Id = reader.GetInt32(1);
                    teacherManage.EffectiveTime = reader.GetDateTime(2);
                    teacherManage.QuestionQuantity = reader.GetInt32(3);
                    teacherManage.AvgScore = reader[4] == System.DBNull.Value ? 0 : reader.GetDecimal(4);
                    teacherManage.ExamineeCount = reader[5] == System.DBNull.Value ? 0 : reader.GetInt32(5);
                    teacherManage.NumOfQualified = reader[6] == System.DBNull.Value ? 0 : reader.GetInt32(6);
                    teacherManage.PassRate = reader[7] == System.DBNull.Value ? 0 : reader.GetDecimal(7);
                    teacherManage.RowNumber = reader.GetInt64(8);

                    teacherManageExam.Add(teacherManage);
                }
            }

            return teacherManageExam;
        }

        /// <summary>
        /// Teacher manage exam list count
        /// </summary>
        /// <param name="teacherSelect"></param>
        /// <returns></returns>
        public int ExamListCount(TeacherSelect teacherSelect)
        {
            int res = 0;

            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            SqlCommand command = new SqlCommand("spTeacherManageTotal", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@Name", teacherSelect.Name));
            command.Parameters.Add(new SqlParameter("@StartDate", teacherSelect.StartTime));
            command.Parameters.Add(new SqlParameter("@EndDate", teacherSelect.EndTime));

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
        /// ExamJoinDetails
        /// </summary>
        /// <param name="ExamSelect"></param>
        /// <returns></returns>
        public List<ExamDetails> ExamJoinDetails(ExamSelect ExamSelect)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            SqlCommand command = new SqlCommand("spExamJoinDetails", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@examId", ExamSelect.ExamId));
            command.Parameters.Add(new SqlParameter("@pageSize", ExamSelect.PageSize));
            command.Parameters.Add(new SqlParameter("@pageIndex", ExamSelect.PageIndex));
            command.Parameters.Add(new SqlParameter("@sortWay", ExamSelect.SortWay));
            command.Parameters.Add(new SqlParameter("@sortFields", ExamSelect.SortFields));
            List<ExamDetails> CurrenExamDetails = new List<ExamDetails>();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ExamDetails examDetail = new ExamDetails();
                    examDetail.RowNumber = reader.GetInt64(5);
                    examDetail.UserName = reader.GetString(0);
                    examDetail.PassCriteria = reader.GetInt32(1);
                    examDetail.ExamScore = reader.GetInt32(2);
                    examDetail.TotalScore = reader.GetInt32(3);
                    examDetail.IsPass = reader.GetInt32(4);
                    CurrenExamDetails.Add(examDetail);
                }
            }

            return CurrenExamDetails;
        }
    }
}