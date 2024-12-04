//giaihephuongtrinhbac1
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("\nNhap a1: ");
        double a1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap b1: ");
        double b1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap c1: ");
        double c1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap a2: ");
        double a2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap b2: ");
        double b2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap c2: ");
        double c2 = Convert.ToDouble(Console.ReadLine());

        double determinant = a1 * b2 - a2 * b1;

        if(determinant != 0)
        {
            double x = (c1 * b2 - c2 * b1) / determinant;
            double y = (a1 * c2 - a2 * c1) / determinant;

            Console.WriteLine("\nNghiem cua he phuong trinh la: ");
            Console.Write("x = " + x);
            Console.Write("y = " + y);
        }
        else
        {
            Console.WriteLine("He phuong trinh vo nghiem hoac co vo so nghiem");
        }
        Console.ReadKey();
    }
}
