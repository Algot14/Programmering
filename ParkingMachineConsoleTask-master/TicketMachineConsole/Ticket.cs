using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingMachineConsole
{
    public class Ticket
    {
        private DateTime purchaseTime;
        private readonly int costPerHour;
        private readonly int price;

        /// <summary>
        /// A ticket. Cannot be changed once created.
        /// </summary>
        /// <param name="price">The amount of money payed for the ticket. A hole number.</param>
        /// <param name="costPerHour">The cost per hour to park. A hole number.</param>
        public Ticket(int price, int costPerHour)
        {
            // Your code here
        }


        /// <summary>
        /// Property to read cost per hour.
        /// </summary>
        public int CostPerHour
        {
            get
            {
                return costPerHour;
            }
        }

        /// <summary>
        /// Property to read the amout payed for the ticket.
        /// </summary>
        public int Price
        {
            get
            {
                return price;
            }
        }


        /// <summary>
        /// Returns the amount of time the ticket is valid for. 
        /// </summary>
        public DateTime PurchaseTime
        {
            get
            {
                return purchaseTime;
            }
        }

        /// <returns>TimeSpan object with days, hours and minutes. 
        /// The number of seconds is set to zero.</returns>
        public TimeSpan GetParkingTimeSpan()
        {
            int antalDagar = price / (costPerHour * 24);
            int rest = price % (costPerHour * 24);
            int antalTimmar = rest / costPerHour;
            int timmarRest = rest % costPerHour;
            int antalMinuter = timmarRest * 60 / costPerHour;
            int minuterRest = timmarRest * 60 % costPerHour;
            TimeSpan timeSpan = new TimeSpan(days: antalDagar, hours: antalTimmar, minutes: antalMinuter, seconds: 0);
            return timeSpan;
        }



        /// <summary>
        /// Returns the date and time the ticket is valid to.
        /// </summary>
        /// <returns>A DateTime object for the validity date.</returns>
        public DateTime GetValidTo()
        {
            DateTime date = DateTime.Now;
            TimeSpan time = GetParkingTimeSpan();
            date = date.Add(time);

            return date;
        }

        public string ToString()
        {
            DateTime date = GetValidTo();
            TimeSpan time = GetParkingTimeSpan();
            return ("Parking ticket valid for:" + Environment.NewLine + 
            time.Days + " days" + Environment.NewLine + 
            time.Hours + " hours" + Environment.NewLine + 
            time.Minutes + " minutes" + Environment.NewLine + Environment.NewLine + "Valid to: " + date);
        }


    }
}
