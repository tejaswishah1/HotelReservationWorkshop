using System;
using System.Collections.Generic;

namespace HotelReservationSystemWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hotel Reservation System");
            HotelFunctions miami = new HotelFunctions();
            ////Adding Hotels in Miami
            miami.AddHotel();
            ////Show cheapest hotels for given dates
            DateTime[] dates = UserFunctions.EnterDate();
            miami.FindCheapestHotel(dates); 
        }
    }
}
