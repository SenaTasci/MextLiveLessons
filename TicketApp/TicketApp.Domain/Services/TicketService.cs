using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using TicketApp.Domain.Models;

namespace TicketApp.Domain.Services
{
    public class TicketService
    {


        public void SaveTickettoTextFile(string ownerNameSurname, decimal price, string sideCode)
        {
             Random random = new();


            Ticket ticket = new()
            {
                Id = $"{random.Next(1, 1000)}",
                OwnerNameSurname = ownerNameSurname,
                Price = price,
                SideCode = sideCode,
            };

            string ticketInfo = $"{ticket.Id}, {ticket.OwnerNameSurname}, {ticket.Price}, {ticket.SideCode}";

            File.AppendAllText("C:\\Users\\Legion\\source\\repos\\TicketApp\\TicketApp.Domain\\ticket.txt", ticketInfo);

        }


    }
}
