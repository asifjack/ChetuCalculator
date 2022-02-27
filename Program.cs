using System;

namespace ChetuCalculator
{
    public class Cal
    {
        public void Add(decimal num1,decimal num2)
        {
            Console.WriteLine("Sum : "+(num1 + num2));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numbers ..");
            decimal num1 =Decimal.Parse( Console.ReadLine());
            decimal num2 = Decimal.Parse(Console.ReadLine());
            Cal cal = new Cal();
            cal.Add(num1, num2);
            

        }
    }
}
