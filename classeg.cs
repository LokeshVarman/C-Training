using System;

class item
{
  public int id{get; set;}
  public string name{get; set;}

  public item(int i,string s)
  {
    id=i;
    name=s;
  }
  static void display(item nq){
    Console.WriteLine("from display id:{0},name{1}",nq.id,nq.name);
  }
public static void Main(String [] args)
{
  item n=new item(1,"Lokesh");
  Console.WriteLine("from main id:{0},name{1}",n.id,n.name);
  display(n);
}
}