using System;


namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadi skaitli x: ");
            double x;
            
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Kļūda. Ievadi skaitli x: ");
            }

            Console.Write("Ievadi skaitli y: ");
            double y;

            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.Write("Kļūda. Ievadi skaitli y: ");
            }

            Console.Write("Ievadi aritmētisko operāciju ( + - * / ): ");
            string math = Console.ReadLine();

            while (!math.Equals("+") && !math.Equals("-") && !math.Equals("*") && !math.Equals("/"))
            {
                Console.Write("Kļūda. Ievadi aritmētisko operāciju ( + - * / ): ");
                math = Console.ReadLine();
            }


            switch(math)
            {
                case "+":
                    Console.WriteLine($"{x} + {y} = {Utils.Add(x, y)}");
                    break;
                case "-":
                    Console.WriteLine($"{x} - {y} = {Utils.Subtract(x, y)}");
                    break;
                case "*":
                    Console.WriteLine($"{x} x {y} = {Utils.Multiply(x, y)}");
                    break;
                case "/":
                    Console.WriteLine($"{x} / {y} = {Utils.Divide(x, y)}");
                    break;
                default:
                    Console.WriteLine("Nekorekti ievadīta aritmētiskā operācija");
                    break;
            }
        }
    }
}
