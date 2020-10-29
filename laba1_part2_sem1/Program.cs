using System;


namespace laba1_part2_sem1
{
    class Program
    {
        static void Main(string[] args)
        {

            TTriangle triangle = new TTriangle(3, 4, 5);

            Console.Write("Введіть сторону а: ");
            triangle.a = double.Parse(Console.ReadLine());

            Console.Write("Введіть сторону b: ");
            triangle.b = double.Parse(Console.ReadLine());

            Console.Write("Введіть сторону b: ");
            triangle.c = double.Parse(Console.ReadLine());

            TTriangle.Show(triangle.a, triangle.b, triangle.c);
            Console.ReadKey();

        }

       
    }
}


