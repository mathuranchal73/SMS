using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using SMS.Models;

namespace SMS.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class StudentAPIController : ApiController
    {

        // GET api/students
        [Route("api/students")]
        public HttpResponseMessage Get()
        {
            var students = StudentsRepository.GetAllStudents();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, students);
            return response;
        }


        [Route("api/students")]
        public HttpResponseMessage Post(Student s)
        {
            var students = StudentsRepository.InsertStudent(s);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, students);
            return response;
        }

        [Route("api/students")]
        public HttpResponseMessage Put(Student s)
        {
            var students = StudentsRepository.UpdateStudent(s);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, students);
            return response;
        }

        [Route("api/students")]
        public HttpResponseMessage Delete(Student e)
        {
            var students = StudentsRepository.DeleteStudent(e);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, students);
            return response;
        }

        // GET api/students/{id}
        [Route("api/students/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var students = StudentsRepository.GetStudent(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, students);
            return response;
        }

        // GET api/StudentAPI?fname={fname}
        [ActionName("StudentByFirstname")]
        public HttpResponseMessage GetStudentByFirstname(string fname)
        {
            
            var students = StudentsRepository.SearchStudentsByFirstName(fname);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, students);
            return response;
        }

        //GET api/StudentAPI?lname={lname}
        [ActionName("StudentByLastname")]
        public HttpResponseMessage GetStudentByLastname(string lname)
        {

            var students = StudentsRepository.SearchStudentsByLastName(lname);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, students);
            return response;
        }

        //GET api/StudentAPI?aadhar={aadhar}
        [ActionName("StudentByAadhar")]
        public HttpResponseMessage GetStudentByAadhar(string aadhar)
        {

            var students = StudentsRepository.SearchStudentsByAadhar(aadhar);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, students);
            return response;
        }

        //GET api/StudentAPI?regNo={regNo}
        [ActionName("StudentByRegNo")]
        public HttpResponseMessage GetStudentByRegNo(string regNo)
        {

            var students = StudentsRepository.SearchStudentsByRegNo(regNo);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, students);
            return response;
        }

        //GET api/StudentAPI?email={email}
        [ActionName("StudentByEmail")]
        public HttpResponseMessage GetStudentByEmail(string email)
        {

            var students = StudentsRepository.SearchStudentsByEmail(email);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, students);
            return response;
        }


        //GET api/StudentAPI?phoneNo={phoneNo}
        [ActionName("StudentByCellPhone")]
        public HttpResponseMessage GetStudentByCellPhone(string phoneNo)
        {

            var students = StudentsRepository.SearchStudentsByEmail(phoneNo);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, students);
            return response;
        }

    }
}