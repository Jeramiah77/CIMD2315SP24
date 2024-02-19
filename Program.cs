namespace Homework5;

class Program
{
    static void Main (string[] args) 
    {
         createAccount();
         
          int[] numbers = new int[4];
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int largest = GetLargest(numbers);
        Console.WriteLine($"The largest number is: {largest}");




        int number1 = 100;
        int number2 = 200;

        int largestNumber = GetLargestNumber(number1, number2);
        Console.WriteLine("The largest number is: " + largestNumber);
    
    }

    static bool checkAge(int birth_year)
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birth_year;
        return age >= 18;
    }

    static void createAccount()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password1 = Console.ReadLine();

        Console.Write("Enter password again: ");
        string password2 = Console.ReadLine();

        Console.Write("Enter birth year: ");
        int birthYear = int.Parse(Console.ReadLine());

        if (checkAge(birthYear))
        {
            if (password1 == password2)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }
          static int GetLargest(int[] numbers)
    {
        int largest = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }
        return largest;
    }
        

  static int GetLargestNumber(int num1, int num2)
    {
        return Math.Max(num1, num2);
    }

    }

