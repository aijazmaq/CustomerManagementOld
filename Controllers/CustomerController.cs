using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Model;
using Service.Implementation;
using Service.Interfaces;

namespace CustomerManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomer _icustomer; 
        public CustomerController(ICustomer customer) 
        {
            _icustomer = customer;
        }

        [HttpGet("GetCustomer")]
        public CustomerResponse GetCustomer()
        {
            return _icustomer.GetCustomer();
        }

    }
}
