using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PencilClassEx
{
    class Program
    {
        static void Main(string[] args)
        {

            Pencil p1 = new Pencil();
            Pencil p2 = new Pencil();
            // Pencil(int serialNo, String model, String type, boolean hasEraser)
            Pencil p3 = new Pencil(103, "Walmart", "B+", false);
            Pencil p4 = new Pencil(104, "Walmart", "BH+", true);
            Pencil p5 = new Pencil(105, "Costco", "B++", true);

            Console.WriteLine(p1);


            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);
            Console.WriteLine(p5);

            Console.ReadKey();

            /*
            p1.hasEraser = false;
            p1.model = "Dixon";
            p1.serialNo = 1;
            p1.type = "HB";
            p1.canWrite();

            int x = 10;
            Console.WriteLine(x);


            Pencil p2 = new Pencil();

            p2.hasEraser = true;
            p2.model = "Dixon";
            p2.serialNo = 2;
            p2.type = "HB2";
            p2.canWrite();

            Pencil p3 = new Pencil();
            p3.hasEraser = true;
            p3.model = "BIC";
            p3.serialNo = 3;
            p3.type = "HB";
            p3.canWrite();

            Pencil p4 = new Pencil();
            p4.hasEraser = true;
            p4.model = "Write";
            p4.serialNo = 4;
            p4.type = "HB";
            p4.canWrite();

            Pencil p5 = new Pencil();

            p5.hasEraser = true;
            p5.model = "Zebra";
            p5.serialNo = 0;
            p5.type = "M301";
            p5.canWrite();
            Console.WriteLine("=============");

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);
            Console.WriteLine(p5);
    */

        }
    }
}
