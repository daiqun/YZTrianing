using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Contracts.DataContracts
{
    [DataContract]
    public class ExamAbout
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string ExaminationRules { get; set; }

        [DataMember]
        public string SystemInformation { get; set; }

        [DataMember]
        public string ContactUs { get; set; }
    }
}