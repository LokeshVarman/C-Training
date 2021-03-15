using System; 

class HelloWorld { 

  static void Main() { 

      Console.WriteLine("Enter your name:");
      string name = Console.ReadLine();
      Console.WriteLine(name);
      Console.WriteLine("Enter your age:");
      int age = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine(age);
      Console.WriteLine("Enter your Salary:");
       
      int sal = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(sal);
      DateTime now = DateTime.Now ;
      Console.Write( "Current Date And Time: "+ now ) ;
      Console.WriteLine("Name|Age|Salary|Date");
      //Console.WriteLine(name +"|" +age +"|" +sal +"|{0:t}" ,now);
      //Console.WriteLine("{0} | {1} | {2} | {3:t}",name,age,sal,now);
      Console.WriteLine($"{name}|{age}|{sal}|{now:t}");


  } 

} 