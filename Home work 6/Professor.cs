using System.Security.Cryptography.X509Certificates;


class Professor{
    public string name;
    public string Class;
    public double salary;
    public void PrintInfo(){
        Console.WriteLine($"Professor {name} teaches {Class} and the salary of :{salary}");
        
       
    }
}
