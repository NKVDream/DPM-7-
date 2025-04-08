using System;
class Task2
{
    static void Main()
    {
        Console.Write("write down anything:");string word = Console.ReadLine();
        Task2.Change(word);
    }
    static void Change(string word)
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == word.ToUpper()[i])
            {
                Console.Write(word.ToLower()[i]);
            }
            else if (word[i] == word.ToLower()[i])
            {
                Console.Write(word.ToUpper()[i]);
            }
        }
    }
}