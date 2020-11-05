using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystemWorkshop
{
    /// <summary>
    /// Checking date
    /// </summary>
    public class UserFunctions
    {
        public static DateTime[] EnterDate()
        {
            DateTime[] dates = new DateTime[2];
            try
            {
                Console.Write("Enter starting date :");
                dates[0] = DateTime.Parse(Console.ReadLine());
                Console.Write("\nEnter end date :");
                dates[1] = DateTime.Parse(Console.ReadLine());
            }
            catch
            {
                if (dates == null)
                {
                    throw new System.ArgumentNullException("Invalid Date entered");
                }
            }
            return dates;
        }
    }
}