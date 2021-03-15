using System;

class MainClass {
  enum days{Monday, Tuesday, Wednesday, Thursday, Friday};
  public static void Main (string[] args) {
    // WAP to modify the below code using enumeration:
    int num = 1;
    // var daystype=typeof(days);
    string day = " ";
    days dr = (days)num;

    switch( dr )
    {
    case days.Monday : day = "Monday" ; break ;
    case days.Tuesday : day = "Tuesday" ; break ;
    case days.Wednesday : day = "Wednesday" ; break ;
    case days.Thursday : day = "Thursday" ; break ;
    case days.Friday : day = "Friday" ; break ;
    // Default statement to be inserted here (Step 5).
    }

    Console.WriteLine(" Day: " + day);
    
    
    // Console.WriteLine(num);
    // string day = Enum.GetName(daystype,num-1);
    // Console.WriteLine("num: " + num + " Day: " + day);

    // for(int i=1;i<=5;i++){
    //   day = Enum.GetName(daystype,i-1);
    //   Console.WriteLine("num: " + i + " Day: " + day);
    // }    
  }
}