using System;
namespace pattern{
class sample{
 static void printpattern1(int n){
   for(int i=1;i<n;i++){
     for(int j=1;j<=i;j++){
       Console.Write("*");
     }
     Console.WriteLine();
   }
 }
static void printfactors(int n){
  for(int i=1;i<=n;i++){
    if(n%i==0){
      Console.WriteLine(i);
    }
  }
}

public static void Main(string [] args){
  public delegate void job(int a);
  job job1=printpattern1;
  job1(4);
  job1+=printfactors;
  job1(12);
  job1-=printpattern1;
  job1(10);
 // job job2=printfactors;
  //job2(30);
}


}
}
