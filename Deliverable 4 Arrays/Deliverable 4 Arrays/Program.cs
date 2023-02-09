using System;

public class Fibonacci
{
    public static void Main(string [] args)
    {
        // Declare variables
        int n1 = 0, n2 = 1, n3, i;

        // Empty arrays that store our Fibonacci series
        int[] series = new int[25];

        // Calculate (adding n1 and n2)
        series[0] = n1; // adds 0
        series[1] = n2; // adds 1

        // Start loop; remember to start from 2
        for (i = 2; i < 25; ++i)  
        {
            n3 = n1 + n2;
            series[i] = n3;
            n1 = n2;
            n2 = n3;
        }
        // Display elements
        for (i = 0; i < 25; i++)
        {
            Console.WriteLine("Fibonacci number (" + i + ") = " + series[i]);
        }
    }
}
