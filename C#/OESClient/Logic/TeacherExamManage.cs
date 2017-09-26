using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logic.TeacherServiceReference;
using Logic.ExceptionDeal;

namespace Logic
{
    /// <summary>
    /// Teacher manage student exam.
    /// </summary>
    public class TeacherExamManage
    {
        private TeacherServiceClient client;

        public TeacherExamManage()
        {
            client = new TeacherServiceClient();
        }

        /// <summary>
        /// Teacher manage student list.
        /// </summary>
        /// <param name="teacherSelect">
        /// Include TeacherSortName, TeacherSortDirction, Name, PageSize, CurrentPage
        /// </param>
        /// <returns>Select exam result</returns>
        public TeacherManage[] ExamList(TeacherSelect teacherSelect)
        {
            try
            {
                return client.ExamList(teacherSelect);
            }
            catch (RequestExceprion ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Exam List count.
        /// </summary>
        /// <param name="teacherSelect">
        /// Include Name
        /// </param>
        /// <returns>Search exam list count</returns>
        public int ExamListCount(TeacherSelect teacherSelect)
        {
            try
            {
                return client.ExamListCount(teacherSelect);
            }
            catch (RequestExceprion ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="examSelect"></param>
        /// <returns></returns>
        public ExamDetails[] ExamJoinDetails(ExamSelect examSelect)
        {
            try
            {
                return client.ExamJoinDetails(examSelect);
            }
            catch (RequestExceprion ex)
            {
                throw ex;
            }
        }
    }
}