using System;
class Task3
{
    static void Main()
    {
        Console.WriteLine(); int N = int.Parse(Console.ReadLine());
        Console.WriteLine(Task3.Fibonachi(N));
    }
    static int Fibonachi(int n)
    {
        if (n <= 0) return 1;
        int a = 1;
        int b = 1;
        for (int i = 2; i <= n; i++)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }
}