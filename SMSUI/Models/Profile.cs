using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMSUI.Models
{
    public class Profile
    {

        public int StudentID { get; set; }
        public string Gender { get; set; }
        public Nullable<decimal> HighSchoolGPA { get; set; }
        public Nullable<byte> HeightFt { get; set; }
        public Nullable<byte> HeightIn { get; set; }
        public string BirthPlace { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public string BloodGroup { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }

        public virtual Student Student { get; set; }
    }
}