using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace TickIT.Models
{
    [DataContract]
    public class User : Person
    {
        [DataMember]
        public int UserID { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}