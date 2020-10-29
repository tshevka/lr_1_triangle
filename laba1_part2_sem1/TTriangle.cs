using System;
using System.Collections.Generic;
using System.Text;

namespace laba1_part2_sem1
{
    class TTriangle
    {
        protected double sideA;
        protected double sideB;
        protected double sideC;


        public TTriangle(double a, double b, double c)
        {
            if (b > 0 & c > 0 & a > 0)
            {
                if (a + b > c || a + c > b || b + c > a)
                {
                    sideA = a;
                    sideB = b;
                    sideC = c;
                }
            }
            else Console.WriteLine("The triangle doesn't exist");
        }

        public static void Show(double sideA, double sideB, double sideC)
        {
            double P = Perimeter(sideA, sideB, sideC);
            double S = Square(sideA, sideB, sideC);
            Console.WriteLine("The perimetr of the triangle is: " + P);
            Console.Write("The square of the triangle is: " + S);
        }

        public double a
        {
            get { return sideA; }
            set
            {
                if (value > 0 ||( sideB + sideC >= value || value + sideB >= sideC || value + sideC >= sideB))
                {
                    sideA = value;
                }
            }
        }

        public double b
        {
            get { return sideB; }
            set
            {
                if (value > 0 || ( sideA + sideC >= value || value + sideC >= sideA || value + sideA >= sideC))
                {
                    sideB = b;
                }
            }
        }

        public double c
        {
            get { return sideC; }
            set
            {
                if (value > 0 || (sideB + sideA >= value || value + sideB >= sideA || value + sideA >= sideB))
                {
                    sideC = value;
                }
            }
        }

        static double Perimeter(double sideA, double sideB, double sideC)
        {

            double P = sideA + sideB + sideC;
            return P;


        }

        static double Square(double sideA, double sideB, double sideC)
        {

            Perimeter(sideA, sideB, sideC);
            double p = (sideA + sideB + sideC) / 2;

            double S = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            return S;

        }


    }
}
