using Custify.Domain.Dtos;
using Custify.Domain.Entities;
using Custify.Domain.Enums;
using Custify.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Custify.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        CustomerService customerService = new();
            
        [HttpPost]

        public void Add(Customer customer)
        {
            customerService.Add(customer);
        }

        [HttpGet]

        public List<GetCustomerDto> GetAll()
        {
            var customers = customerService.GetAll()
            .Select(c => new GetCustomerDto()
            {
                Id = c.Id,
                Name = c.Name,
                Surname = c.Surname,
                Email = c.Email,
                Gender = c.Gender,
            }).ToList();

            foreach (var customer in customers)
            {
              if (customer.Gender == Gender.Male)
                    customer.GenderText = "Male";

              else if (customer.Gender == Gender.Female)
                    customer.GenderText = "Female";

                else if (customer.Gender == Gender.PreferNotToSay)
                    customer.GenderText = "PreferNotToSay";

                else if (customer.Gender == Gender.Unknown)
                    customer.GenderText = "Unknown";

             

            }
            return customers;
        }

        [HttpPut]
        public void Update(Customer customer)
        {
            customerService.Update(customer);
        }

        [HttpDelete]
        public void Delete(Guid id)
        {
            customerService.Delete(id);
        }

    }
}
