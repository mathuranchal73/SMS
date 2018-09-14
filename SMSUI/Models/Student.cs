using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMSUI.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthdate { get; set; }
        public string RegNo { get; set; }
        public string AadharNo { get; set; }
        public string Email { get; set; }
        public string CellPhone { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual Profile Profile { get; set; }

    }
}
