using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using SMSUI.Models;

namespace SMSUI.Controllers
{
    public class HomeController : Controller
    {
        string Baseurl = "http://localhost:50528/";

        public async Task<ActionResult> Index()
        {
            List<Student> StuInfo = new List<Student>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("api/students");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                
                {
                    //Storing the response details recieved from web api   
                    var StuResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    StuInfo = JsonConvert.DeserializeObject<List<Student>>(StuResponse);

                }
                //returning the employee list to view  
                return View(StuInfo);
                

            }
        }

        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            List<Student> StuInfo = new List<Student>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("api/students/" + id);

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                
                    {
                        //Storing the response details recieved from web api   
                        var StuResponse = Res.Content.ReadAsStringAsync().Result;

                        //Deserializing the response recieved from web api and storing into the Employee list  
                        StuInfo = JsonConvert.DeserializeObject<List<Student>>(StuResponse);

                    }
                    //returning the employee list to view  
                    return View(StuInfo);
                
               
            }
        }

       

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Message = "Create Page";

            return View();
        }

        public ActionResult Edit()
        {
            ViewBag.Message = "Edit Page";

            return View();
        }
    }
}