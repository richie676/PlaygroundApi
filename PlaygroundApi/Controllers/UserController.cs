using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlaygroundApi.DTO;

namespace PlaygroundApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        [HttpGet]
        public JsonResult Get(string identcode)
        {

            var user = new UserDto() { firstName = "Gertraude", lastName = "Get", userName = "Gerti" };

            return Json(user);
        }

        [HttpPost]
        public JsonResult Post(string email)
        {
            var user = new UserDto() { firstName = "Paul", lastName = "Post", userName = "Pauli" };

            return Json(user);
        }

        [HttpPut]
        public JsonResult Put(string identcode, string newStatus)
        {
            var user = new UserDto() { firstName = "Peter", lastName = "Put", userName = "Peet" };

            return Json(user);
        }
    }
}