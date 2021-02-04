using System;
namespace //Hello{


class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Enter how many elements:");
    int n=Convert.ToInt32(Console.ReadLine());
    int [] arr = new int[n];
    for (int i=0;i<n;i++){
        Console.WriteLine("enter no:");
        arr[i]=Convert.ToInt32(Console.ReadLine());
    }
    
    Console.WriteLine("3rd digit is"+arr[2]);
  }
}
}