namespace HotelReservationSystemWorkshop
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Hotel
    {
        /// <summary>
        /// Declaring name of hotel
        /// </summary>
       public  string mNameOfHotel;
        /// <summary>
        /// Rate of Hotel
        /// </summary>
       public int mRegularRate;
        /// <summary>
        /// Constructor to assign default values
        /// </summary>

        public Hotel()
        {
            this.mNameOfHotel = null;
            this.mRegularRate = 0;
        }
        /// <summary>
        /// Constructor to assign values given by user
        /// </summary>
        public Hotel(string name, int regularRate)
        {
            this.mNameOfHotel = name;
            this.mRegularRate = regularRate;
        }
    }
}
