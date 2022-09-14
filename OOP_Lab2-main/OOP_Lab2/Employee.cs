using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public enum Positions
    {
        Director = 1000,
        Manager = 500,
        Salesman = 300,
        Kasir = 100,
        Accountant = 200
    }

    public class Employee : Person
    {
        public Positions Position { get; set; } = Positions.Kasir;
        public double Experience { get; set; } = 1;
        public double CountOfTax { get; set; } = 18;
        public double Tax { get; set; }
        public double Payment { get; set; }
        public Employee(string name, string lastName) : base(name, lastName)
        {

        }
        public double GetPayment()
        {
            Payment = Position.GetHashCode() * (Experience * 0.2) * 100;
            Tax = Payment * (CountOfTax / 100);
            return Payment;
        }
        public void GetPositionValue(string p) => Position = (Positions)Enum.Parse(typeof(Positions), p);
    }
}
