using System;
class Program
{
    static long rand(int a, int b)
    {
        DateTime dt = DateTime.Now;
        return a + dt.Ticks % (b - a);
    }
    static void Main()
    {
        Console.Write("Граница a = ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Граница b = ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("{0}", rand(a, b));
        }
    }
}
