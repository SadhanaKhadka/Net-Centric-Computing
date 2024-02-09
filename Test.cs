using System;

namespace NccLabSadhana
{
    class Box
    {
        public static int count; //static  variable
        double length, breadth, height;

        //constructor
        public Box()
        {
            length = 6.5;
            breadth = 4.5;
            height = 5.5;
            count++;
        }
        public Box(double length, double breadth, double height)
        {
            this.length = length;
            this.breadth = breadth;
            this.height = height;
            count++;
        }

        public void SetDimension(double l, double b, double h)
        {
            length = l;
            breadth = b;
            height = h;
        }
        public void Display()
        {
            Console.WriteLine("Length=" + length + "Breadth=" + breadth + "Height=" + height);
        }

        public static void ShowCount()
        {
            Console.WriteLine("No. of objects created=" + Box.count);

        }
    }
    internal class Test
    {
        static void Main(string[] args)
        {
            Box.ShowCount();
            //Box box1;
            Box box1 = new Box();
            Box box2 = new Box(34.5, 6.9, 7.7);
            box1.Display();
            box1.SetDimension(33.5, 56.8, 99.1);
            box2.Display();
            //Console.WriteLine("No. of objects created=" + Box.count);
            Box.ShowCount();
        }
    }
}
