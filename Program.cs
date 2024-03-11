namespace Homework7;
public class Customer
{
    private int cus_id;
    public string cus_name;
    public int cus_age;

    public Customer(int customer_id, string customer_name, int customer_age)
    {
        this.cus_id = customer_id;
        this.cus_name = customer_name;
        this.cus_age = customer_age;
    }

    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }

    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer ID: {cus_id}, Name: {cus_name}, Age: {cus_age}");
    }

    public void CompareAge(Customer objCustomer)
    {
        if (this.cus_age > objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is older than {objCustomer.cus_name}");
        }
        else if (this.cus_age < objCustomer.cus_age)
        {
            Console.WriteLine($"{objCustomer.cus_name} is older than {this.cus_name}");
        }
        else
        {
            Console.WriteLine($"{this.cus_name} and {objCustomer.cus_name} are the same age");
        }
    }
}
class Program
{


    static void Main()
    {
        Customer alice = new Customer(110, "Alice", 28);
        Customer bob = new Customer(111, "Bob", 30);

        Console.WriteLine("Initial Customer Information:");
        alice.PrintCusInfo();
        bob.PrintCusInfo();

        alice.ChangeID(220);
        bob.ChangeID(221);

        Console.WriteLine("\nUpdated Customer Information:");
        alice.PrintCusInfo();
        bob.PrintCusInfo();

        Console.WriteLine("\nComparing ages:");
        alice.CompareAge(bob);
    }
}