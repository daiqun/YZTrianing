using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Contracts.DataContracts
{
    [DataContract]
    public class Exam
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
        public int TotalScore { get; set; }

        [DataMember]
        public int QuestionPoints { get; set; }

        [DataMember]
        public int QuestionQuantity { get; set; }

        [DataMember]
        public string Notice { get; set; }

        [DataMember]
        public int IsDelete { get; set; }
    }
}