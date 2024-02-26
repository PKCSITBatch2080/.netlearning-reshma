using System;
using System.Data;

class student
{
    //Default constructor
    public student()
    {
    }

    public student(string n,byte rn)
    {
        name=n;
        RollNumber= rn;
    }
    string name; //field
    byte rollnumber;
    public byte RollNumber
    {
      get
      {
        return rollnumber;
      }
      set
      {
        if (value<=100)
        {
            rollnumber=value;
        }
      }
    }
    public string address{get;set;} //auto implemented property
    DateTime dob;
    
    public void DisplayInfo()
    {
        Console.WriteLine($"student Name: {name}");
        Console.WriteLine($"student RollNumber: {rollnumber}");
        Console.WriteLine($"DOB: {dob}");
        Console.WriteLine($"Address: {address}");


    }
}