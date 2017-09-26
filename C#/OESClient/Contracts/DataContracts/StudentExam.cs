using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Contracts.DataContracts
{
    /// <summary>
    /// Student exam entity
    /// </summary>
    [DataContract]
    public class StudentExam
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string ExamName { get; set; }

        [DataMember]
        public DateTime EffectiveTime { get; set; }

        [DataMember]
        public int Duration { get; set; }

        [DataMember]
        public int PassCriteria { get; set; }

        [DataMember]
        public int Operation { get; set; }

        [DataMember]
        public int ExamSocre { get; set; }

        [DataMember]
        public long RowNumber { get; set; }

        [DataMember]
        public int UserId { get; set; }
    }
}