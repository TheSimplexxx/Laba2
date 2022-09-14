using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class Address
    {
        public int Index { get; set; } = 22222;
        public string Country { get; set; } = "Ukraine";
        public string City { get; set; } = "Kyiv";
        public string Street { get; set; } = "Troeshchyna";
        public int House { get; set; } = 81;
        public int Apartment { get; set; } = 12345;
        public void Print()
        {
            Console.WriteLine($"Index: {Index}");
            Console.WriteLine($"Country: {Country}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"Street: {Street}");
            Console.WriteLine($"House: {House}");
            Console.WriteLine($"Apartment: {Apartment}");
        }
    }
}
