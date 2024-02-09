using System;

namespace NccLabSadhana
{
    class Circle
    {
        private double radius = 7.5;

        //property
        /*
        //While there is nothing to check:
        public double Radius
        {
            get; set;
        }
        */

        public double Radius
        {
            //get accessor
            get
            {
                if (radius > 0)
                    return radius;
                else return 0;
            }
            //set acessor
            set
            {
                radius = value;
            }

        }
        /*//getter method
        public double GetRadius()
        {
            return radius;
        }
        //setter method
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }*/
    }
    internal class PropertyDemo
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            /*c1.SetRadius(12.5); //used for setter
            Console.WriteLine("value of radius=" + c1.radius);
            Console.WriteLine("value of radius=" + c1.GetRadius());//used for getter */
            c1.Radius = 12.5;
            Console.WriteLine("value of radius=" + c1.Radius);
        }

    }
}
