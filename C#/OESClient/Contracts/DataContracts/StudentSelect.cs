using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Contracts.DataContracts
{
    /// <summary>
    /// Sudent select entity
    /// </summary>
    [DataContract]
    public class StudentSelect
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int CurrentPage { get; set; }

        [DataMember]
        public int PageSize { get; set; }

        [DataMember]
        public string StudentSortName { get; set; }

        [DataMember]
        public string StudentSortDirction { get; set; }

        [DataMember]
        public string IsFinished { get; set; }

        public StudentSelect()
        { }

        /// <summary>
        /// Student Exam count entity
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isFinished"></param>
        public StudentSelect(int id, string isFinished)
        {
            this.Id = id;
            this.IsFinished = isFinished;
        }
    }
}