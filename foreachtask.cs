using System;
class MainClass {
  public static void Main (string[] args) {
  string [ ] names = new string [ 10 ];
  for(int i=0;i<10;i++){
    names[i]=Console.ReadLine();

  }
  foreach(string n in names){
    Console.WriteLine(n);
  }
   
  
}
}