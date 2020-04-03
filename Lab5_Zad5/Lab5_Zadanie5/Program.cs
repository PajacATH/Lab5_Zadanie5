using Lab5_Zadanie5.Models;
using System;
using System.Linq;

namespace Lab5_Zadanie5
{
    class Program
    {
        static void baza()
        {
            var band = new Band
            {
                Nazwa = "Coldplay",
                Address = new Address
                {
                    Phone = 756352446,
                    Street = "ThisStreet",
                    City = new City
                    {
                        Name = "London",
                        Voivodeship = "asdaas"
                    }
                }
            };
            var nowyEvent = new Event
            {
                Band = band,
                City = new City
                {
                    Name = "HecznarowiceAngielskie",
                    Voivodeship = "Sląskie"
                },
                Date = DateTime.Now,
                Tickets = new[]
                {
                    new Ticket
                    {
                        Price = 25,
                        Type = TicketType.Standard
                    },
                    new Ticket
                    {
                        Price = 100,
                        Type = TicketType.VIP
                    }
                } 
            };
            var dbContext = new ConcertContext();
            dbContext.Add(band);
            dbContext.Add(nowyEvent);
            dbContext.SaveChanges();


        }
        static void szukaj()
        {
            var dbContext = new ConcertContext();
            var komenda = dbContext
                .Events
                .Select(x => x.Band)
                .Where(x => x.Nazwa == "Coldplay");

            foreach (var item in komenda)
            {
                Console.WriteLine($"{item.Nazwa}");
            }
        }

        static void aktualizuj()
        {
            var dbContext = new ConcertContext();
            var aktualizacja = dbContext.Tickets
                .Where(x => x.Type == TicketType.VIP);

            foreach (var item in aktualizacja)
            {
                item.Price = 200;
            }
            dbContext.SaveChanges();
        }
        
        static void Main(string[] args)
        {
            //baza();
            //szukaj();
            aktualizuj();
        }
    }
}
