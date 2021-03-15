using System;
namespace str{
    class stringops{
        static void Main(){
            int alphabet=0,digit=0,specialchar=0,i=0;
            string old="This is beautiful World. here, we go to explore, 1, 2, 3....";
            int l = old.Length;
 
            while (i < l)
            {
                if ((old[i] >= 'a' && old[i] <= 'z') || (old[i] >= 'A' && old[i] <= 'Z'))
                {
                    alphabet++;
                }
                else if (old[i] >= '0' && old[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    specialchar++;
                }
                i++;
            }
            Console.WriteLine(alphabet);
            Console.WriteLine(digit);
            Console.WriteLine(specialchar);
            Console.WriteLine("Removing......");
            old=old.Replace("beautiful","");
            old=old.Replace("1, 2, 3....","");
            Console.WriteLine(old);
        }
    }
}