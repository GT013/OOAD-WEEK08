using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_act1._3
{
    delegate int addDel(int a, int b);
    delegate int xDel(int x);
    class Program
    {
        /*public static int add(int a, int b)
        {
            return a + b;
        }*/
      
        static void Main(string[] args)
        {
            //Console.WriteLine("result = {0}",add(2,3));
            addDel adel = (int a ,int b)=>{return a + b;};
            Console.WriteLine("Result = {0}",adel(2,3));

            xDel xx =  x => x + 3; 
            Console.WriteLine("Result of xDel {0}",xx(5));
            Console.ReadLine();
        }
    }
}
