using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS.Models
{
    public class StudentsRepository
    {
        private static SMSEntities dataContext = new SMSEntities();
        public static List<Student> GetAllStudents()
        {
            var query = from Student in dataContext.Students
                        select Student;
            return query.ToList();
        }



        public static List<Student> SearchStudentsByFirstName(string studentFirstName)
        {
            var query = from Student in dataContext.Students
                        where Student.FirstName.Contains(studentFirstName)
                        select Student;
            return query.ToList();
        }

        public static List<Student> SearchStudentsByLastName(string studentLastName)
        {
            var query = from Student in dataContext.Students
                        where Student.LastName.Contains(studentLastName)
                        select Student;
            return query.ToList();
        }

        public static List<Student> SearchStudentsByAadhar(string studentAadhar)
        {
            var query = from Student in dataContext.Students
                        where Student.AadharNo.Contains(studentAadhar)
                        select Student;
            return query.ToList();
        }

        public static List<Student> SearchStudentsByRegNo(string regNo)
        {
            var query = from Student in dataContext.Students
                        where Student.RegNo.Contains(regNo)
                        select Student;
            return query.ToList();
        }

        public static List<Student> SearchStudentsByEmail(string email)
        {
            var query = from Student in dataContext.Students
                        where Student.Email.Contains(email)
                        select Student;
            return query.ToList();
        }

        public static List<Student> SearchStudentsByCellPhone(string cellphone)
        {
            var query = from Student in dataContext.Students
                        where Student.CellPhone.Contains(cellphone)
                        select Student;
            return query.ToList();
        }


        public static Student GetStudent(int StudentID)
        {
            var query = from Student in dataContext.Students
                        where Student.StudentID == StudentID
                        select Student;
            return query.SingleOrDefault();
        }

        public static List<Student> InsertStudent(Student s)
        {
            dataContext.Students.Add(s);
            dataContext.SaveChanges();
            return GetAllStudents();
        }

        public static List<Student> UpdateStudent(Student s)
        {
            var stu = (from Student in dataContext.Students
                       where Student.StudentID == s.StudentID
                       select Student).SingleOrDefault();
            stu.FirstName = s.FirstName;
            stu.LastName = s.LastName;
            stu.Birthdate = s.Birthdate;
            stu.RegNo = s.RegNo;
            stu.AadharNo = s.AadharNo;
            stu.Email = s.Email;
            stu.CellPhone = s.CellPhone;
            stu.ModifiedDate = DateTime.Now;
            dataContext.SaveChanges();
            return GetAllStudents();
        }

        public static List<Student> DeleteStudent(Student s)
        {
            var stu = (from Student in dataContext.Students
                       where Student.StudentID == s.StudentID
                       select Student).SingleOrDefault();
            dataContext.Students.Remove(stu);
            dataContext.SaveChanges();
            return GetAllStudents();
        }
    }
}