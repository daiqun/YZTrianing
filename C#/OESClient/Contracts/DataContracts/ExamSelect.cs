using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Contracts.DataContracts
{
    [DataContract]
    public class ExamSelect
    {
        [DataMember]
        public int ExamId { get; set; }

        [DataMember]
        public int PageSize { get; set; }

        [DataMember]
        public int PageIndex { get; set; }

        [DataMember]
        public string SortWay { get; set; }

        [DataMember]
        public string SortFields { get; set; }
    }
}