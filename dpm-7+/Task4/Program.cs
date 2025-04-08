using System;
class Task4
{
    static void Main()
    {
        Console.Write("write down any num: "); int a = int.Parse(Console.ReadLine());
        Task4.Check(a);
    }
    static void Check(int a)
    {
        int i = 1;
        do
        {
            i *= 2;
            if (i > a)
            {
                Console.WriteLine("false");
            }
            else if (i == a)
            {
                Console.WriteLine("true");
            }
        }
        while (i < a);
    }
}