namespace Homework3;

class Program
{
    static void Main(string[] args)
    
    {
        
         Console.Write("input a integer: ");
        int num = Convert.ToInt32(Console.ReadLine());

        bool isPrime = true;

        if (num <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break; // stop the loop when a divisor is found
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine($"{num} is prime.");
        }
        else
        {
            Console.WriteLine($"{num} is non-prime.");
        }
   
       
        Console.Write("Enter the value of N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        if (N > 0)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Please enter a positive integer.");
         }
    
       int n;

        // Get user input for N
        Console.Write("Enter an integer N: ");
        n = int.Parse(Console.ReadLine());

        // Nested loop to print the square pattern
        for (int row = 1; row <= N; row++)
        {
            for (int col = 1; col <= N; col++)
            {
                // Check if the current position is on the first or last row/column or not
                if (row == 1 || row == N || col == 1 || col == N || row == col || col == N - row + 1)
                {
                    Console.Write("* "); // Print '*' for specified positions
                }
                else
                {
                    Console.Write("  "); // Print two spaces for other positions
                }
            }
            Console.WriteLine(); // Move to the next line after each row is printed
        }
            





    }

}   
         
   
   
       
       
       




