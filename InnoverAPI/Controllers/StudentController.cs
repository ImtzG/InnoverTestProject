using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Cors;

namespace InnoverAPI.Controllers
{
    [Route("api/student")]
    [ApiController]
    [Produces("application/json")]
    [EnableCors("corspolicy")]
    public class StudentController : ControllerBase
    {
        private static readonly List<Student> student = new List<Student>
        {
            new Student { Name ="Alice", Age=20, Hobbies=new List<Hobby> { new Hobby { HobbyName="reading" }, { new Hobby { HobbyName="swimming"} }, { new Hobby { HobbyName="coding"} } }},
            new Student { Name ="Bob", Age=22, Hobbies=new List<Hobby> { new Hobby { HobbyName="painting" }, { new Hobby { HobbyName="dancing"} }, { new Hobby { HobbyName="singing"} } }},

        };
        public StudentController()
        {}

        [HttpPost]
        [Route("data")]
        public IActionResult GetStudentList()
        {
            return Ok(student);
        }
    }
}