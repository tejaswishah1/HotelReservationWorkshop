﻿using System;
using System.Collections.Generic;

namespace HotelReservationSystemWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hotel Reservation System");
            ////Creating list to store values:
            List<Hotel> hotels = new List<Hotel>();

            ////Adding Hotel names
            hotels.Add(new Hotel("Lakewood", 110));
            hotels.Add(new Hotel("Bridgewood", 160));
            hotels.Add(new Hotel("Ridgewood", 220));
        }
    }
}
