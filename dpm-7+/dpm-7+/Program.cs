using System;
class Task1
{
    static void Main()
    {
        string[] words = { "shy", "shock", "shrek" };
        Task1.Pref(words);
    }
    static void Pref(string[] words)
    {
        string pref = "";
        int i = 0;
        while (true)
        {
            char a = words[0][i];
            foreach (string word in words)
            {
                if (a != word[i]) { Console.WriteLine(""); }
                if (i >= word.Length || word[i] != a)
                {
                    goto Result;
                }
            }
            pref += a;
            i++;
        }
        Result: Console.WriteLine($"The longest prefix is: {pref}");
    }
}
