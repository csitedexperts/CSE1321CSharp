using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PencilClassEx
{
    class PencilMain
    {
        static void Main(string[] args)
        {

            Pencil p1 = new Pencil();
            Pencil p2 = new Pencil();
            // Pencil(int serialNo, String model, String type, boolean hasEraser)
            Pencil p3 = new Pencil(103, "Walmart", "B+", false);
            Pencil p4 = new Pencil(104, "Walmart", "BH+", true);
            
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.ReadKey();

            Console.WriteLine(p3);
            Console.WriteLine(p4);


            Console.WriteLine("=============");

            Pencil p5 = new Pencil();
            
            p5.hasEraser = true;
            p5.setModel("Zebra");
            p5.serialNo = 110;
            p5.type = "M301";
            p5.canWrite();

            Console.WriteLine(p5);


            Pencil p6 = new Pencil();

            p6.hasEraser = true;
            p6.serialNo = 111;
            p6.setModel("OfficeDepot");
            
            p6.type = "HB12";
            p6.canWrite();


            Console.WriteLine(p6);


            Console.ReadKey();


        }
    }
}
