using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Taxi
    {
        // Properties
        public string DriverName { get; set; }
        public int NumPassenger { get; set; }
        public bool OnDuty { get; set; }
        public string status { get; set; }
        //method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name          : {0} ", DriverName);
            if (OnDuty == true)
            {
                status = "Yes";
            }
            else
            {
                status = "No";
            }
            Console.WriteLine("On Duty              : {0} ", status);
            Console.WriteLine("Number of Passenger  : {0}\n", NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} sedang mengantar penumpang", DriverName);
        }
    }
}
