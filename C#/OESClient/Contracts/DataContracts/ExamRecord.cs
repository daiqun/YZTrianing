using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Contracts.DataContracts
{
    [DataContract]
    public class ExamRecord
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int ExamScore { get; set; }

        [DataMember]
        public int IsPass { get; set; }

        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public int ExamId { get; set; }

        [DataMember]
        public string UserAnwser { get; set; }

        [DataMember]
        public int IsDelete { get; set; }

        [DataMember]
        public DateTime EffectiveTime { get; set; }

        [DataMember]
        public DateTime SubmitTime { get; set; }
    }
}