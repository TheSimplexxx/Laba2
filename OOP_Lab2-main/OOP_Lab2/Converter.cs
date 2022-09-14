using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class Converter
    {
        public static Currency USD { get; set; } = new Currency();
        public static Currency EUR { get; set; } = new Currency();
        public static Currency RUB { get; set; } = new Currency();
        public Converter()
        {

        }
        public Converter(double usd, double eur, double rub)
        {
            USD.Rate = usd;
            EUR.Rate = eur;
            RUB.Rate = rub;
        }
        public double UahTo(double uah, Currency cur) => uah / cur.Rate;
        public double GetUah(double money, Currency cur) => money * cur.Rate;
    }
}
