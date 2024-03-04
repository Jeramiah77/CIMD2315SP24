using System.Runtime.CompilerServices;

namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
    
       
       Professor p1 = new Professor();
        p1.name = "Alice";
        p1.Class= "Jave";
        p1.salary = 9000;
        
        p1.PrintInfo();
      
      Professor p2 = new Professor();
      p2.name = "Bob";
        p2.Class= "Math";
        p2.salary = 8000;
        p2.PrintInfo();

      
      
      
      Student s1 = new Student();

       s1.Name = "Lisa";
       s1.enrolled = "Jave";
       s1.grade = 90;
        s1.PrintInfo();
      
       Student s2 = new Student();
       s2.Name= "Tom";
       s2.enrolled = "Math";
       s2.grade= 80;
       s2.PrintInfo();
     
       
       int result = 9000 - 8000;
        Console.WriteLine("The salary diffentes betten Alice and Bod is: " + result);
      
        int total = 90+ 80;
        Console.WriteLine("The total grade of Lisa and Tom is  : " + total) ;

    }
}

    

