using System;

namespace ChetuCalculator
{
    public class Cal
    {
        public void Add(decimal num1,decimal num2)
        {
            Console.WriteLine("Sum : "+(num1 + num2));
        }
        public void Sub(decimal num1, decimal num2)
        {
            Console.WriteLine("Sub : " + (num1 - num2));
        }
        public void Mult(decimal num1, decimal num2)
        {
            Console.WriteLine("Mult : " + (num1*num2));
        }
        public void Div(decimal num1, decimal num2)
        {
            Console.WriteLine("Div : " + (num1/num2));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cal cal = new Cal();
            Console.WriteLine("Enter Numbers ..");
            decimal num1 =Decimal.Parse( Console.ReadLine());
            decimal num2 = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter operation ..");
            string opp = Console.ReadLine();
            switch (opp)
            {
                case "add":
                    cal.Add(num1, num2);
                    break;
                case "sub":
                    cal.Sub(num1, num2);
                    break;
                case "mult":
                    cal.Mult(num1, num2);
                    break;
                case "di":
                    cal.Div(num1, num2);
                    break;
                default:
                    Console.WriteLine("Looking For Valid Operation");
                    break;
            }
        }
    }
}
