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
    /// TeacherService
    /// </summary>
    public class TeacherService : ITeacherService
    {
        private TeacherDB teacherDB;

        public TeacherService()
        {
            teacherDB = new TeacherDB();
        }

        /// <summary>
        /// ExamList
        /// </summary>
        /// <param name="teacherSelect"></param>
        /// <returns></returns>
        public List<TeacherManage> ExamList(TeacherSelect teacherSelect)
        {
            return teacherDB.ExamList(teacherSelect);
        }

        /// <summary>
        /// Exam list count
        /// </summary>
        /// <param name="teacherSelect"></param>
        /// <returns></returns>
        public int ExamListCount(TeacherSelect teacherSelect)
        {
            return teacherDB.ExamListCount(teacherSelect);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="examSelect"></param>
        /// <returns></returns>
        public List<ExamDetails> ExamJoinDetails(ExamSelect examSelect)
        {
            return teacherDB.ExamJoinDetails(examSelect);
        }
    }
}