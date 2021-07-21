using System;

public static class Helper
{
    /// When user fails to insert a valid number 5 times in a row
    /// program is terminated
    public static int InputNumber()
    {
        int castedNumber = 0;
        int tries = 1;

        while (castedNumber == default(int))
        {
            Console.WriteLine($"\nSession nr {tries}\n########################\nPlease type in a number\n########################");
            int.TryParse(Console.ReadLine(), out castedNumber);

            if (castedNumber == default(int))
            {
                Console.WriteLine("Input is not a number or it is zero\nPlease input a valid number");
                if (tries == 5)
                {
                    Console.WriteLine("5 failed sessions reached. Terminating...");
                    Environment.Exit(1);
                }
            }

            tries++;
        }

        return castedNumber;
    }
}