public static class Factorial
{

    /// * Factorial of n is n!
    /// * 1 x 2 x ... n
    public static int calculateFactorial(int n)
    {
        var factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            // 1st 1 = 1 x 1
            // 2nd 1 = 1 x 2
            // 3rd 2 = 2 x 3
            // 4th 6 = 6 x 4
            // 5th 24 = 24 x 5 
            // and so on ...
            factorial *= i;
        }
        return factorial;
    }
}