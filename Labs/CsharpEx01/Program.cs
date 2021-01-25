using System;

namespace CSharpExcersice01
{
    class MainClass
    {
        public const double pi = System.Math.PI;



        static void Main(string[] args)
        {
            Console.WriteLine("Part 1, circumference and area of a circle.");
            Console.WriteLine("Enter an integer for the radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double circumference = 2 * (pi * radius);
            Console.WriteLine($"The circumference is { circumference }");

            Console.WriteLine("Enter an integer for the radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            //double area = pi * (System.Math.Pow(radius2,2));
            double area = pi * (radius * radius);
            Console.WriteLine($"The area is { area }");



            //END PART 1



            Console.WriteLine("Part 2, volume of a hemisphere. Enter an integer for the radius:");
            double volume = Convert.ToDouble(Console.ReadLine());
            volume = (Convert.ToDouble(4) / Convert.ToDouble(3) * (pi * (System.Math.Pow(volume, 3)))) / 2;
            Console.WriteLine($"The volume is { volume }");






            //END PART 2




            Console.WriteLine("Part 3, Area of a triangle (Heron's Formula).");
            Console.WriteLine("Enter an integer for side 1:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter an Integer for side 2:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Eneter an integer for side 3:");
            double c = Convert.ToDouble(Console.ReadLine());
            double p = (Convert.ToDouble(a) + Convert.ToDouble(b) + Convert.ToDouble(c)) / 2;
            double triangleArea = Convert.ToDouble(Math.Sqrt(p * ((p - a) * (p - b) * (p - c))));
            Console.WriteLine($"The area is { triangleArea }");



            //END PART 3



            Console.WriteLine("Part 4, solving a quadratic equation");
            Console.WriteLine("Enter an integer for coefficient a:");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter an integer for coefficient b:");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter an integer for coefficient c:");
            double c1 = Convert.ToDouble(Console.ReadLine());



            //Quadratic Formula: x = (-b + -sqrt(b ^ 2 - 4ac)) / 2a




            double positive_num;
            double negative_num;
            double denominator = Convert.ToDouble(2 * a1);


            double x = Convert.ToDouble(b1 * b1) - 4 * a1 * c1;
            //just addded()



            if (x < 0)
            {
                
                positive_num = double.NaN;
                negative_num = double.NaN;
            }

            else
            {

                
                double sqrt = Math.Sqrt(x);
                positive_num = (-b1 + sqrt) / (denominator);
                negative_num = (-b1 - sqrt) / (denominator);



                double bs = Convert.ToDouble(a1 * Math.Pow(x, 2)) + (b1 * x) + c1;
                Console.WriteLine($"bs{bs}");
                Console.WriteLine($"The positive solution is {positive_num}");
                Console.WriteLine($"The negative solution is {negative_num}");













            }



        }
    }

}