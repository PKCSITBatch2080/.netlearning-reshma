using System;
using System.IO;
class FDHandling
{
    //file IO
    public static void CreateFile()
    {
        var folderPath=@"C:\PKCSIT-GIT\.netlearning-reshma\FirstConsoleApp\G.FileIO";
        var filePath=$"{folderPath}\\student.txt";
        
        File.WriteAllText(filePath, "This is first line of text");
        
        Directory.CreateDirectory($"{folderPath}\\Dummy");

        //create 10 files with names file1.cs, file2.cs,file3.cs.....
        //each file should contain a varaiable 'age with value as 1,2,3....'

        for(int counter=1;counter<=10;counter++)
        {
            var file=$"File{counter}";

            var fileP=$"{folderPath}\\Dummy\\File{counter}.cs";
            File.WriteAllText(fileP, "class" +file + "{}");
        }

        //reading
        string content =File.ReadAllText(@"C:\Users\shres\Downloads\text");
        var words=content.Split([',',',',':','-']);
        Console.WriteLine(words.Length);

    }

}