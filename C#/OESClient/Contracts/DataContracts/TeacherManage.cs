using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Contracts.DataContracts
{
    /// <summary>
    /// Teacher manage entity
    /// </summary>
    [DataContract]
    public class TeacherManage
    {
        [DataMember]
        public string ExamName { get; set; }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime EffectiveTime { get; set; }

        [DataMember]
        public int QuestionQuantity { get; set; }

        [DataMember]
        public Decimal AvgScore { get; set; }

        [DataMember]
        public int ExamineeCount { get; set; }

        [DataMember]
        public int NumOfQualified { get; set; }

        [DataMember]
        public Decimal PassRate { get; set; }

        [DataMember]
        public long RowNumber { get; set; }
    }
}