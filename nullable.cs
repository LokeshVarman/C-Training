using System;
//program to accept user details.
class MainClass {
public static void Main (string[] args) {
int? a=null;
// nullable coalascing operator
int b=a??4;
Console.WriteLine(b);
}
}