using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        delegate double MyDeligate(double r);
        static void Main(string[] args)
        {
            MyDeligate myDeligate = Get_Length;
            double r = myDeligate(2);
            Console.WriteLine(r);

            myDeligate = Get_Area;
            double a = myDeligate(2);
            Console.WriteLine(a);

            myDeligate = Get_Volume;
            double v = myDeligate(2);
            Console.WriteLine(v);

            Console.ReadKey();
        }

        public static double Get_Length(double r)
        {
            double length;
            length = Math.PI * 2 * r;
            return length;
        }

        public static double Get_Area(double r)
        {
            double area;
            area = Math.PI * r * r;
            return area;
        }

        public static double Get_Volume(double r)
        {
            double volume;
            volume = 4.0 / 3.0 * Math.PI * r * r * r;
            return volume;
        }
    }
}
