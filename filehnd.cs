using System;
using System.IO;

class fileWriting
{
  static void Main(string[] args)
  {
    string path="/home/runner/Cdemos/data/datafile.txt";
    string text="Modified text to be added";
    string [] description= new string[]{
    "\tIn Debtors' Yard the stones are hard" ,
    "\tAnd the dripping wall is high"
    } ;
    if (File.Exists(path))
    {
      File.AppendAllText(path,text);
      Console.WriteLine("Text Added in the file!");
    }
    else
    {
      //File.WriteAllText(path,text);
      File.WriteAllLines(path,description);
      Console.WriteLine("File created Successfully");
    }
  }
}