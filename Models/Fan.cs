using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M3gogo.Models
{
    public class Fan
    {
        public String name { get; set; }
        public String username { get; set; }
        public String password { get; set; }

        public String nationalId { get; set; }
        public int phoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public String Adress { get; set; }

    }
}