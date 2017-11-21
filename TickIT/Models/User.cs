using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TickIT.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public UserType Type { get; set; }

    }

    public enum UserType
    {
        CLIENT = 1, ADMINISTRATOR = 2
    };
}