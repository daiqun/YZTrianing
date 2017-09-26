using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Contracts.DataContracts
{
    [DataContract]
    public class ExamDetails
    {
        [DataMember]
        public long RowNumber { get; set; }

        [DataMember]
        public string UserName{ get; set; }

        [DataMember]
        public int PassCriteria{ get; set; }

        [DataMember]
        public int ExamScore{ get; set; }

        [DataMember]
        public int TotalScore{ get; set; }

        [DataMember]
        public int IsPass{ get; set; }
    }
}