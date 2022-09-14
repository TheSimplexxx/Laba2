using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class Program
    {
       
        static void UahTo(Converter converter)
        {
            Console.Write("Input count of uah: ");
            double uah = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input currency: ");
            string selectedCur = Console.ReadLine();
            Currency selected;
            switch (selectedCur.ToLower())
            {
                case "usd":
                    {
                        Console.WriteLine($"result: {converter.UahTo(uah, Converter.USD) }");
                        break;
                    }
                case "eur":
                    {
                        Console.WriteLine($"result: {converter.UahTo(uah, Converter.EUR) }");
                        break;
                    }
                case "rub":
                    {
                        Console.WriteLine($"result: {converter.UahTo(uah, Converter.RUB) }");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Incorrect currency");
                        break;
                    }
            }
            Console.ReadKey();
        }

        static void ToUah(Converter converter)
        {
            Console.Write("Input count of money: ");
            double money = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input currency: ");
            string selectedCur = Console.ReadLine();
            Currency selected;
            switch (selectedCur.ToLower())
            {
                case "usd":
                    {
                        Console.WriteLine($"result: {converter.GetUah(money, Converter.USD) }");
                        break;
                    }
                case "eur":
                    {
                        Console.WriteLine($"result: {converter.GetUah(money, Converter.EUR) }");
                        break;
                    }
                case "rub":
                    {
                        Console.WriteLine($"result: {converter.GetUah(money, Converter.RUB) }");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Incorrect currency");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
