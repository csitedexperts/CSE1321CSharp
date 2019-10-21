using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PencilClassEx
{
    class Pencil
    {
        public int serialNo;
        public String model;

        public String type;// { get; set; }
        //public string Type { get => type; set => type = value; }

        public bool hasEraser;

        
        public String getModel()
        {
            return model;
        }
        public void setModel(String model)
        {
            this.model = model;

        }

        public Pencil()
        {
            serialNo = 101;
            model = "Amazon";
            type = "HB";
            hasEraser = true;
            // System.out.println("The Pencil() constructor is called.....");
        }

        public Pencil(int SerialNo, String model, String type, bool hasEraser)
        {
            this.serialNo = SerialNo;
            this.model = model;
            this.type = type;
            this.hasEraser = hasEraser;
            // System.out.println("The Pencil() constructor is called.....");
        }

        public void canWrite()
        {
            Console.WriteLine("This pencil can write");
        }
        //Returns a string representation of the object. 
        //In general, the toString method returns a string
        //that "textually represents" this object.

        // In Java @Override
        public override String ToString()
        {

            return serialNo + " " + model + " " + type + " " + hasEraser;
        }

    }
}
