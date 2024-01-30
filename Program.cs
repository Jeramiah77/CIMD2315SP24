namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("Enter a letter grade (A, B, C, D, F): ");
        char letterGrade = Console.ReadKey().KeyChar; // maakes the letter that is imputed into a Upper case
        
        int gpaPoints;

        if (char.ToUpper(letterGrade) == 'A')
        {
            gpaPoints = 4;
        }
        else if (char.ToUpper(letterGrade) == 'B')
        {
            gpaPoints = 3;
        }
        else if (char.ToUpper(letterGrade) == 'C')
        {
            gpaPoints = 2;
        }
        else if (char.ToUpper(letterGrade) == 'D')
        {
            gpaPoints = 1;
        }
        else if (char.ToUpper(letterGrade) == 'F')
        {
            gpaPoints = 0;
        }
        else
        {
            Console.WriteLine("\nWrong Letter Grade!");
            return;
        }

        Console.WriteLine($"\nGPA Points for {letterGrade}: {gpaPoints}");
    
       
       
       //Q2
       Console.WriteLine("Enter three  random numbers:");

        Console.Write("Enter your first number: ");
             int num1 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter your second number: ");
            int num2 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter the last number: ");
             int num3 = Convert.ToInt16(Console.ReadLine());

                int smallest = FindSmallest(num1, num2, num3);

        Console.WriteLine($"The smallest number is: {smallest}");
    }

    static int FindSmallest(int a, int b, int c )
    {
        int smallest = a;

        if (b < smallest)
        {
            smallest = b;
        }

        if (c < smallest)
        {
            smallest = c;
        }

        return smallest;
    }
       
    }



 

    
    
    
    
    

