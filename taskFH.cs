using System;
using System.IO;

class filehan
{
  static void Main(string[] args)
  {
    string name ="";
    do{
      Console.WriteLine("Menu \n 1. Add text \n 2. Display content \n3. Copy Content \n 0. Exit");
      
      name=Console.ReadLine();
      if (name=="1"){
        Console.WriteLine("Enter Path to add:");
        string path=Console.ReadLine();
        Console.WriteLine("Enter Texts to add:");
        string adds= Console.ReadLine();
        if (File.Exists(path))
        {
          File.AppendAllText(path,adds);
          Console.WriteLine("Text Added in the file!");
        }
        else
        {
          Console.WriteLine("no File exists in that name ");
        }

      }
      else if(name=="2"){
        Console.WriteLine("Enter Path to read:");
        string path=Console.ReadLine();
        string text = File.ReadAllText( path ) ;
        Console.WriteLine( "File Read from : " + path + "\n" ) ;
        Console.WriteLine( text + "\n" ) ;

      }
      else if(name=="3"){
        Console.WriteLine("Enter Source Path to read:");
        string path=Console.ReadLine();
        string text = File.ReadAllText(path) ;
        Console.WriteLine( "File Read from : " + path + "\n" ) ;
        Console.WriteLine("Enter Destination Path to write:");
        string dpath=Console.ReadLine();
        File.AppendAllText(dpath,text);
        Console.WriteLine("Text Added in the file!");
      }
      else{
        Console.WriteLine("Incorrect Choice.");
      }
    }
    while(name!="0");
  }
}