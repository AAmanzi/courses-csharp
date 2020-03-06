using System;

namespace excercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var areInputsValid = false;
            var firstNumber = 0;
            var secondNumber = 0;
            while (!areInputsValid)
            {
                Console.WriteLine("Please input first whole number:");
                var isFirstNumberValid = Int32.TryParse(Console.ReadLine(), out firstNumber);

                Console.WriteLine("Please input second whole number:");
                var isSecondNumberValid = Int32.TryParse(Console.ReadLine(), out secondNumber);

                if (!isFirstNumberValid || !isSecondNumberValid)
                {
                    Console.WriteLine("Both numbers must be whole.");
                }

                if (isSecondNumberValid && secondNumber == 0)
                {
                    Console.WriteLine("Second number cannot be zero due to division.");
                }

                areInputsValid = isFirstNumberValid && isSecondNumberValid && secondNumber != 0;
            }

            Console.WriteLine("_____________________________________");

            var divisionResult = (double)firstNumber / secondNumber;
            var divisionResultWhole = firstNumber / secondNumber;

            Console.WriteLine($"Currency: {divisionResult.ToString("C")}");
            Console.WriteLine($"Integer: {divisionResultWhole}");
            Console.WriteLine($"Scientific: {divisionResult.ToString("E")}");
            Console.WriteLine($"Fixed-point: {divisionResult.ToString("F")}");
            Console.WriteLine($"General: {divisionResult.ToString("G")}");
            Console.WriteLine($"Number: {divisionResult.ToString("N")}");
            Console.WriteLine($"Hexadecimal: 0x{divisionResultWhole.ToString("x")}");
        }
    }
}
