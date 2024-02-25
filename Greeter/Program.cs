namespace Greeter;

class Program
{
    static void Main(string[] args)
    {
        string fullname="Reshma Shrestha";
        Console.WriteLine(fullname);
        string cfullname="hello, reshma shrestha ji";
        Console.WriteLine(cfullname.ToUpper());
        
         Console.WriteLine("What is your name");
        var fullname1 =Console.ReadLine();
        Console.WriteLine($"Your name is {fullname1}.");

        
    }
}
