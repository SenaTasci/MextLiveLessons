// See https://aka.ms/new-console-template for more information
using TicketApp.Domain.Services;

Console.WriteLine("Hello, World!");


TicketService ticketService = new();
ticketService.SaveTickettoTextFile("Sena", 100, "5A");


