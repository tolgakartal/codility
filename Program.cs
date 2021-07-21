using System;

namespace iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            // *-----------------------------------------*
            // |----------FACTORIAL CALCULATION----------|
            // *-----------------------------------------*
            // var userNumber = Helper.InputNumber();
            // var factorial = Factorial.calculateFactorial(userNumber);
            // Console.WriteLine($"\nFactorial of the number {userNumber} is {factorial}");

            // *-----------------------------------------*
            // |-----------FACTORIAL ASTERIXES-----------|
            // *-----------------------------------------*
            // var userNumber = Helper.InputNumber();
            // for (int i = 1; i <= userNumber; i++)
            // {
            //     var factorialOfTheStep = Factorial.calculateFactorial(i);
            //     Console.Write($"\n{factorialOfTheStep}\t-> ");
            //     for (int x = 0; x < factorialOfTheStep; x++)
            //     {
            //         Console.Write("*");
            //     }
            // }
            // *-----------------------------------------*
            // |-------FACTORIAL ASTERIX TRIANGLE--------|
            // *-----------------------------------------*
            var userNumber = Helper.InputNumber();
            for (int i = 1; i <= userNumber; i++)
            {
                var factorialOfTheStep = Factorial.calculateFactorial(i);
                Console.Write($"\n{factorialOfTheStep}\t-> ");
                for (int x = 0; x < factorialOfTheStep; x++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}
