using Custify.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custify.Domain.Dtos
{
    public class GetCustomerDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        //public string PhoneNumber { get; set; }

        //public string Address { get; set; }

        public Gender Gender { get; set; }

        public string GenderText { get; set; }
    }
}

