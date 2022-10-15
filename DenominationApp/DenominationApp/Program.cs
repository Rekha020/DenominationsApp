using System;

namespace DenominationApp
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter currency amount");
            int amount = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter price of product");
            string pricevalue = Console.ReadLine();
            var denominations = new Denominations();
            var result = denominations.CalculateDenominations(amount, pricevalue);
            Console.WriteLine(result);
        }
    }

}
