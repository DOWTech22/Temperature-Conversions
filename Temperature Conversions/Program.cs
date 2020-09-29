using System;

namespace Temperature_Conversions
{
    class Program
    {
            // A short bit of code easy code.

        static void Main(string[] args)
        {
            //using a double type because I am using a decimal(1.8) in my code.
            double celsius, fahrenheit, kelvin;


            Console.Write("Enter the amount of Celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());

            // formula
            kelvin = celsius + 273;
            fahrenheit = 1.8 * (celsius) + 32;

            // Displays output.
            Console.WriteLine("Kelvin = {0}", kelvin);
            Console.WriteLine("Fahrenheit = {0}", fahrenheit);


        }
    }
}
