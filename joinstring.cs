using System;

class MainClass {

  static string funCreateList (string [] nameArr){
    string nameList = String.Join(",",nameArr);
    return nameList;
  }

  public static void Main (string[] args) {
    // string menu = "MENU";
    // menu = menu.PadLeft(7,'*').PadRight(10,'*');
    // Console.WriteLine (menu);

    string [] nameArr = new string[5];

    Console.WriteLine("Enter 5 names,");

    for (int i = 0;i<5;i++){
        nameArr[i] = Console.ReadLine();
    }

    Console.WriteLine(funCreateList(nameArr));

  }
}