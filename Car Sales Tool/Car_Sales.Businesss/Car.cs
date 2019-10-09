using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Sales.Businesss
{
    public class Car
    {
        public string RegisterNumber { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public string Yearmodel { get; set; }
        public int Speed { get; set; }
        public int TotalKmDrived { get; set; }
        public int HorsePower { get; set; }
        public int Price { get; set; }
        public bool Secondhand { get; set; }
    }
}
