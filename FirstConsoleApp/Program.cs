using System;

Console.WriteLine("I am main method");

DataTypes dt = new();
dt.Learn();


Methods m = new();
m.Greet("Hi");
m.CalculateBMI(233.33f,343.34f);
var highest=m.GetMax(3.4,5.6,78,23.4);
var highest2=m.GetMax(3.4,5.6);
var highest3=m.GetMax(3.4,5.6,78.5,23.4);
var highest4=m.GetMax(3.4,5.6,78);

Generics g=new();
g.Display<string>("jhhfd");
g.Display<int>(786);

//var reshma=new student();
//var smriti=new student("smriti kc",13);

//reshma.RollNumber=22;  //Assigned
//smriti.RollNumber=223;  //not assign

//smriti.Dob=DateTime.Now;
CSStudent rekha=new CSStudent("rekha aryal",24,"Hospital Management System");
rekha.DisplayInfo();

//var sapana=new CyberSecurityStudent("Sapana Shrestha",11,"HMS","Redhat");
//sapana.DisplayInfo();

// var sapana=new CyberSecurityStudent{"Sapana Shrestha",11,"HMS","RedHat"};
// sapana.DisplayInfo();

CyberSecurityStudent.Do();
FDHandling.CreateFile();
