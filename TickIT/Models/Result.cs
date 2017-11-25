using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace TickIT.Models
{
    [DataContract]
    public class Result
    {
        [DataMember]
        public User user;
        [DataMember]
        public Ticket ticket;
    }
}