//Single Inheritance


class CSStudent :student,IGradeable  //Multiple Inheritance
{
    public CSStudent(string name,byte rn,string pTitle) : base(name,rn ) 
    {
        ProjectTitle=pTitle;
        
    }
    public string ProjectTitle { get; set; }   //prop for property
    public string InternWork { get; set; }
    public double GetGrade()=>3.6;
}