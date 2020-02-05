using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaygroundApi.Dto
{
    public class AddressDto
    {
        public string Country { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
    }
}
