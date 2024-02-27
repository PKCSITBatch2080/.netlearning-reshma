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
        var fullname1 =Console.ReadLine();                   //string fullName = Console.ReadLine().ToUpper();
        Console.WriteLine($"Your name is {fullname1}.");
        
        Console.WriteLine("Enter his/her Date of Birth as YYYY/MM/DD");
        var db=Console.ReadLine();
        DateTime dob =DateTime.Parse(db);

        DateTime today=DateTime.Today;
        
        TimeSpan age = today - dob;
        int totalDays = Convert.ToInt32(age.TotalDays);
        
        int years = totalDays / 365;
        int months = (totalDays % 365) / 30;
        int weeks = (totalDays % 365 % 30) / 7;
        int days = totalDays % 365 % 30 % 7;

        Console.WriteLine($"Hello, {cfullname} Ji!");

        Console.WriteLine($"Your DOB is {dob.ToString("dddd, dd MMMM yyyy")}.");

        Console.WriteLine($"You are {years} years {months} months {weeks} weeks and {days} days old.");
        
        
        

    
        
    }
}
