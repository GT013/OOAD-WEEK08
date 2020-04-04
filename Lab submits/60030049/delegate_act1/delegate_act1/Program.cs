using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_act1
{
    delegate void deleHello(string value);
    class Program
    {
        

        static void Main(string[] args)
        {
            /*deleHello delH = hello;
            delH();
            deleHello delH_new = new deleHello(hello);
            deleHello delH_short = hello;

            delH_new();
            delH_short();*/
            deleHello delH = hello;
           // delH("Sawasdee krub");
            deleHello delG = goodbye;
            //delG("bye bye");
            deleHello delX = delH + delG+delH+delG;
            delX("ha ha ha.");
            Console.ReadLine();
        }

        public static void hello(string value)
        {
            Console.WriteLine("From Hello : {0}",value);
        }
        public static void goodbye(string value)
        {
            Console.WriteLine("From Goodbye : {0}", value);
        }
    }
}
