using System;

class Program
{
    static void Main()
    {
        Console.Write("\nNhap so thu nhat: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("\nNhap so thu hai: ");
        int num2 = int.Parse(Console.ReadLine());

        int sum = num1 + num2;

        Console.WriteLine($"Tong cua hai so la:{sum}");
    }
}
