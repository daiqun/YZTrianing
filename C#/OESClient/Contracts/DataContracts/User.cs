using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Contracts.DataContracts
{
    /// <summary>
    /// User entity
    /// </summary>
    [DataContract]
    public class User
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string Gender { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }

        [DataMember]
        public string Eamil { get; set; }

        [DataMember]
        public string ChineseName { get; set; }

        [DataMember]
        public string Avator { get; set; }

        [DataMember]
        public DateTime LastLoginTime { get; set; }

        [DataMember]
        public int IsDelete { get; set; }
    }
}