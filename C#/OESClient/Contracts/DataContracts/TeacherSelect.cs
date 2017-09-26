using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Contracts.DataContracts
{
    /// <summary>
    /// Teacher select entity
    /// </summary>
    [DataContract]
    public class TeacherSelect
    {
        [DataMember]
        public string TeacherSortName { get; set; }

        [DataMember]
        public string TeacherSortDirction { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int CurrentPage { get; set; }

        [DataMember]
        public int PageSize { get; set; }

        [DataMember]
        public DateTime StartTime { get; set; }

        [DataMember]
        public DateTime EndTime { get; set; }
    }
}