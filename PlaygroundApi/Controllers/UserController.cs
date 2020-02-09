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
        public JsonResult Get(string firstName = "Gertraude", string lastName = "Get", string username = "Gerti")
        {

            var user = new UserDto() { firstName = firstName, lastName = lastName, userName = username};

            return Json(user);
        }

        [HttpPost]
        public JsonResult Post(string firstName = "Paul", string lastName = "Post", string username = "Pauli")
        {
            var user = new UserDto() { firstName = firstName, lastName = lastName, userName = username };

            return Json(user);
        }

        [HttpPut]
        public JsonResult Put(string firstName = "Peter", string lastName = "Put", string username = "Peet")
        {
            var user = new UserDto() { firstName = firstName, lastName = lastName, userName = username };

            return Json(user);
        }

        [HttpDelete]
        public JsonResult Delete(string firstName = "David", string lastName = "Delete", string username = "Daweed")
        {
            var user = new UserDto() { firstName = firstName, lastName = lastName, userName = username };

            return Json(user);
        }

    }
}