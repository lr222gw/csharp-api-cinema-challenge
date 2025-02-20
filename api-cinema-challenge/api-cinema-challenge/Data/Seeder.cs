﻿using System.Collections.Generic;
using System.Numerics;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public class Seeder
    {

        private List<Customer> _Customers = new();
        private List<Movie> _Movies = new();
        private List<Screening> _Screenings = new();
        private List<Ticket> _Tickets = new();


        private int incr(ref int count)
        {
            return ++count;
        }
        public Seeder()
        {
            int movieCount = 0;
            _Movies.Add(
                new Movie{Id = incr(ref movieCount), Title = "The Shawshank Redemption", Rating = "R", Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", RuntimeMins = 142});
            _Movies.Add(
                new Movie{Id = incr(ref movieCount),Title = "The Godfather", Rating = "R", Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", RuntimeMins = 175});
            _Movies.Add(
                new Movie{Id = incr(ref movieCount),Title = "The Dark Knight", Rating = "PG-13", Description = "When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", RuntimeMins = 152});
            _Movies.Add(
                new Movie{Id = incr(ref movieCount),Title = "Forrest Gump", Rating = "PG-13", Description = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an extraordinary, though simple, life.", RuntimeMins = 142});
            _Movies.Add(
                new Movie{Id = incr(ref movieCount),Title = "Inception", Rating = "PG-13", Description = "A thief who enters the dreams of others to steal secrets from their subconscious is given the inverse task of planting an idea into the mind of a CEO.", RuntimeMins = 148});

            int customerCount = 0;
            _Customers.Add(new Customer { Id = incr(ref customerCount), Name = "John Doe", Email = "johndoe@example.com", Phone = "555-1234" });
            _Customers.Add(new Customer { Id = incr(ref customerCount), Name = "Jane Smith", Email = "janesmith@example.com", Phone = "555-5678" });
            _Customers.Add(new Customer { Id = incr(ref customerCount), Name = "Michael Johnson", Email = "michaelj@example.com", Phone = "555-9876" });
            _Customers.Add(new Customer { Id = incr(ref customerCount), Name = "Emily Davis", Email = "emilyd@example.com", Phone = "555-4321" });
            _Customers.Add(new Customer { Id = incr(ref customerCount), Name = "Chris Williams", Email = "chriswilliams@example.com", Phone = "555-8765" });

            int screenCount = 0;

            _Screenings.AddRange(
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 1, MovieId = 1, StartsAt = DateTime.Now.AddHours(1).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 1, MovieId = 1, StartsAt = DateTime.Now.AddHours(2).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 1, MovieId = 1, StartsAt = DateTime.Now.AddHours(3).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 1, MovieId = 1, StartsAt = DateTime.Now.AddHours(4).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 1, MovieId = 2, StartsAt = DateTime.Now.AddHours(5).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 2, MovieId = 2, StartsAt = DateTime.Now.AddHours(1).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 2, MovieId = 2, StartsAt = DateTime.Now.AddHours(2).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 2, MovieId = 2, StartsAt = DateTime.Now.AddHours(3).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 2, MovieId = 2, StartsAt = DateTime.Now.AddHours(4).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 2, MovieId = 2, StartsAt = DateTime.Now.AddHours(5).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 3, MovieId = 3, StartsAt = DateTime.Now.AddHours(1).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 3, MovieId = 3, StartsAt = DateTime.Now.AddHours(2).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 3, MovieId = 3, StartsAt = DateTime.Now.AddHours(3).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 3, MovieId = 3, StartsAt = DateTime.Now.AddHours(4).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 3, MovieId = 3, StartsAt = DateTime.Now.AddHours(5).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 1, MovieId = 1, StartsAt = DateTime.Now.AddHours(5 + 1).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 1, MovieId = 1, StartsAt = DateTime.Now.AddHours(5 + 2).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 1, MovieId = 1, StartsAt = DateTime.Now.AddHours(5 + 3).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 1, MovieId = 1, StartsAt = DateTime.Now.AddHours(5 + 4).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 1, MovieId = 2, StartsAt = DateTime.Now.AddHours(5 + 5).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 2, MovieId = 2, StartsAt = DateTime.Now.AddHours(5 + 1).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 2, MovieId = 2, StartsAt = DateTime.Now.AddHours(5 + 2).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 2, MovieId = 2, StartsAt = DateTime.Now.AddHours(5 + 3).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 2, MovieId = 2, StartsAt = DateTime.Now.AddHours(5 + 4).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 2, MovieId = 2, StartsAt = DateTime.Now.AddHours(5 + 5).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 3, MovieId = 3, StartsAt = DateTime.Now.AddHours(5 + 1).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 3, MovieId = 3, StartsAt = DateTime.Now.AddHours(5 + 2).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 3, MovieId = 3, StartsAt = DateTime.Now.AddHours(5 + 3).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 3, MovieId = 3, StartsAt = DateTime.Now.AddHours(5 + 4).ToUniversalTime() },
                new Screening { Id = incr(ref screenCount), Capacity = 50, ScreenNumber = 3, MovieId = 3, StartsAt = DateTime.Now.AddHours(5 + 5).ToUniversalTime() }
                );

            int ticketCount = 0;
            _Tickets.AddRange(
                new Ticket { Id = incr(ref ticketCount), CustomerId = 1, ScreeningId = 1, NumSeats = 4 },
                new Ticket { Id = incr(ref ticketCount), CustomerId = 2, ScreeningId = 2, NumSeats = 2 },
                new Ticket { Id = incr(ref ticketCount), CustomerId = 3, ScreeningId = 2, NumSeats = 4 },
                new Ticket { Id = incr(ref ticketCount), CustomerId = 4, ScreeningId = 3, NumSeats = 1 },
                new Ticket { Id = incr(ref ticketCount), CustomerId = 5, ScreeningId = 3, NumSeats = 1 },
                new Ticket { Id = incr(ref ticketCount), CustomerId = 5, ScreeningId = 3, NumSeats = 1 }
                );

        }



        public List<Customer>   Customers   {get => _Customers; }
        public List<Movie>      Movies      {get => _Movies    ;}
        public List<Screening>  Screenings  {get => _Screenings;}
        public List<Ticket>     Tickets     {get => _Tickets   ;}


    }
}

