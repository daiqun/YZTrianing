using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Contracts.DataContracts
{
    [DataContract]
    public class TestingContent
    {
        [DataMember]
        public int Id{ get; set; }

        [DataMember]
        public string QuestionContent { get; set; }

        [DataMember]
        public string ChoiceA { get; set; }

        [DataMember]
        public string ChoiceB { get; set; }

        [DataMember]
        public string ChoiceC { get; set; }

        [DataMember]
        public string ChoiceD { get; set; }

        [DataMember]
        public string CorrectAnwser { get; set; }

        [DataMember]
        public int IsDelecte { get; set; }

        [DataMember]
        public int ExamId { get; set; }
    }
}