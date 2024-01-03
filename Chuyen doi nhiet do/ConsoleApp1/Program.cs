using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("Nhap lua chon");
                choice = int.Parse(Console.ReadLine());
                while (choice != 0)
                {
                    switch (choice)
                    {
                        case 1:
                            {
                               Console.WriteLine(CelsiusToFahrenheit());
                            }
                            break;
                        case 2:
                            {
                                FahrenheitToCelsius();
                            }
                            break;
                        case 3:
                            {
                                Environment.Exit(0);
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Vui long nhap lai");
                            }
                            break;
                    }
                }
            }
        }
         static double CelsiusToFahrenheit()
        {
            Console.WriteLine("Nhap do C");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = 9 / 5 * celsius + 32;
            return fahrenheit;
        }
        static double FahrenheitToCelsius()
        {
            Console.WriteLine("Nhap do F");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = 5 / 9 * (fahrenheit - 32); ;
            return celsius;
        }
    }
}