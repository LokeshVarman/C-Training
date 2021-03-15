using System;
class Program
{
    static void sorts(string[] list){
        Array.Sort(list);
        foreach(string name in list){
            Console.WriteLine(name);
        }
    }
    static void Main()
    {
        string[] names = new string[5];
        for(int i=0;i<5;i++){
            names[i]=Console.ReadLine();
        }
        sorts(names);
    }
}