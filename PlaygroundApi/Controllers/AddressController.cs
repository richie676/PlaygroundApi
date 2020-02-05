using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlaygroundApi.Dto;
using PlaygroundApi.DTO;

namespace PlaygroundApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : Controller
    {
        [HttpGet]
        public JsonResult Get(string country = "Austria", string postcode = "1120", string city = "Wien", string street = "Am Europlatz 2")
        {

            var address = new AddressDto() { Country = country, PostCode = postcode, City = city, Street = street};

            return Json(address);
        }

        [HttpPost]
        public JsonResult Post(string country = "Austria", string postcode = "1120", string city = "Wien", string street = "Am Europlatz 2")
        {
            var address = new AddressDto() { Country = country, PostCode = postcode, City = city, Street = street };

            return Json(address);
        }

        [HttpPut]
        public JsonResult Put(string country = "Austria", string postcode = "1120", string city = "Wien", string street = "Am Europlatz 2")
        {
            var address = new AddressDto() { Country = country, PostCode = postcode, City = city, Street = street };

            return Json(address);
        }

        [HttpDelete]
        public JsonResult Delete(string country = "Austria", string postcode = "1120", string city = "Wien", string street = "Am Europlatz 2")
        {
            var address = new AddressDto() { Country = country, PostCode = postcode, City = city, Street = street };

            return Json(address);
        }
    }
}