using System;
class Numbers
{
  int [] arrnum;
  int size;

  public Numbers(int s)
  {
    size=s;
    arrnum=new int[size];
  }

  public void setData()
  {
    for(int i=0;i<size;i++)
    {
      Console.WriteLine("Enter a number");
      arrnum[i]=Convert.ToInt32(Console.ReadLine());
    }
  }

  public void printData()
  {
    for(int i=0;i<size;i++)
    {
      Console.WriteLine(arrnum[i]);
    }
  }
  
  public int this[int index]{
    get{
      return arrnum[index];
      }

      set{
        arrnum[index]=value;
      }
  }
}
class Program
{
  public static void Main(string [] args)
  {
    Numbers obj=new Numbers(3);
    obj.setData();
    obj.printData();
    Console.WriteLine("Do you want to update any  value, if yes enter position number, else -1:");
    int index=Convert.ToInt32(Console.ReadLine());
    if(index==-1)
    {
      Console.WriteLine("OK!, No change made!");
    }
    else
    {
      Console.WriteLine("Enter the value to update:");
      int val=Convert.ToInt32(Console.ReadLine());
      obj[index]=val;
      Console.WriteLine("Updated array of object");
      obj.printData();
    }

  }
}