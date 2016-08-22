using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pares_e_impares
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,ci,cp,dig,sp,si;
        Console.WriteLine("introdusca un numero");
        num=Convert.ToInt32(Console.ReadLine());
        ci=0;
        cp=0;
        sp=0;
        si=0;
        dig=0;
        do{
            dig= num%10;
            num= num/10;
            if((dig%2)==0){
            cp=cp+1;
            sp=dig+sp;
        }
        else{
                ci=ci+1;
                si=dig+si;
            }
        }while(num>0);
                Console.WriteLine("LA CANTIDAD DE LOS IMPARES "+ci+"...........LAS CANTIDAD DE LOS PARES "+cp);
                Console.WriteLine("suma de pares"+sp);
                Console.WriteLine("suma deimpares"+si);
            Console.ReadKey();
        }
    }
}
   