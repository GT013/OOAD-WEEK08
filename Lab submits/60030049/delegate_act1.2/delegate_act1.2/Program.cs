using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_act1._2
{
    class Program
    {
        delegate void delmove();
        static void Main(string[] args)
        {
            delmove L= turnleft;
            delmove R = turnRight;
            delmove gotoschool = L;
            /*gotoschool += L;
            gotoschool += R;
            gotoschool += L;
            gotoschool += R;
            gotoschool += L;
            gotoschool += R;*/

            delmove[] arrdel = new delmove[10];
            arrdel[0] = L;
            arrdel[1] = L;
            arrdel[2] = R;
            arrdel[3] = L;
            arrdel[4] = L;
            arrdel[5] = R;
            arrdel[6] = L;
            arrdel[7] = L;
            arrdel[8] = L;
            arrdel[9] = R;

            foreach (delmove x in arrdel)
            {
                gotoschool += x;
            }

            gotoschool();

            Console.ReadLine();
        }
        static public void turnleft()
        {
            Console.WriteLine("Turn Left.");
        }
        static public void turnRight()
        {
            Console.WriteLine("Turn Right.");
        }
    }
}
