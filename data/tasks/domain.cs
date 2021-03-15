using System;
namespace str{
    class stringops{
        static void Main(){
            string old="lokeshvarmandev@gmail.com";
            int l=old.Length;
            int domain=old.IndexOf("@")+1;
            for(int i=domain;i<l;i++){
                Console.Write(old[i]);
            }
        }
    }
}