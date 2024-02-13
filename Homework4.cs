namespace Homework4;

class Program
{    
   static void Main(string[] args)
    {  
       int number1 = 100;
        int number2 = 200;

        int largestNumber = GetLargestNumber(number1, number2);
        Console.WriteLine("The largest number is: " + largestNumber);
    
    
    
    
    
    
    
    int N = 5;
        string shape = "left";  // make sure that the r or l is lower case 

        Console.WriteLine($"N: {N}");
        Console.WriteLine($"Shape: {shape}");

        if (shape == "left")
        {
            Console.WriteLine($"Printing left triangle:");
            PrintLeftTriangle(N);
        }
        else if (shape == "right")
        {
            Console.WriteLine($"Printing right triangle:");
            PrintRightTriangle(N);
        }
        
    }

    static void PrintLeftTriangle(int N) // gives the way to make the triangle left 
    {
        for (int i = 1; i <= N; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void PrintRightTriangle(int N) // give the code to make the triangle  right 
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = N - i; j > 1; j--)
            {
                Console.Write(" ");
            }
            for (int k = 0; k <= i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static int GetLargestNumber(int num1, int num2)
    {
        return Math.Max(num1, num2);
    }
}  
