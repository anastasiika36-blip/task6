using System;

class Program
{
    static void Main()
    {
        string originalWord = "гардероб";

        string word1 = GetFirstWord(originalWord);
        string word2 = GetSecondWord(originalWord);

        Console.WriteLine($"Исходное слово: {originalWord}");
        Console.WriteLine($"Первое слово: {word1}");
        Console.WriteLine($"Второе слово: {word2}");
    }

    static string GetFirstWord(string word)
    {


        return word.Substring(3, 1) +  
               word.Substring(2, 1) +  
               word.Substring(1, 1) +  
               word.Substring(0, 1) +  
               word.Substring(1, 1);   
    }

    static string GetSecondWord(string word)
    {


        return word.Substring(7, 1) +  
               word.Substring(4, 1) +  
               word.Substring(3, 1) +  
               word.Substring(5, 1) +  
               word.Substring(6, 1);   
    }
}