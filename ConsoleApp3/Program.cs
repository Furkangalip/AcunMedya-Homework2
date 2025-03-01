using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int sum = 0;
        for (; number > 0; number /= 10)
            sum += number % 10;
        Console.WriteLine(sum);
        
        int input;
        do
        {
            Console.Write("Enter a number between 10 and 100: ");
            input = int.Parse(Console.ReadLine());
        } while (input < 10 || input > 100);
        Console.WriteLine(input);
        
        int[] ages = { 5, 17, 25, 70 };
        foreach (int age in ages)
        {
            if (age <= 12) Console.WriteLine(age + " Child");
            else if (age <= 19) Console.WriteLine(age + " Teen");
            else if (age <= 64) Console.WriteLine(age + " Adult");
            else Console.WriteLine(age + " Elderly");
        }
        
        int[] numbers = { 1, 2, 3, 4, 2, 3, 5, 6, 1 };
        var duplicates = numbers.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key);
        Console.WriteLine(string.Join(", ", duplicates));
        
        string[] words = { "apple", "pear", "strawberry", "watermelon" };
        string longest = words.OrderByDescending(w => w.Length).First();
        string shortest = words.OrderBy(w => w.Length).First();
        Console.WriteLine(longest);
        Console.WriteLine(shortest);
        
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        string[] sentenceWords = sentence.Split(' ');
        Array.Sort(sentenceWords);
        Console.WriteLine(string.Join(", ", sentenceWords));
        
        List<string> dynamicList = new List<string>();
        dynamicList.Add("Hello");
        dynamicList.Add("World");
        Console.WriteLine(string.Join(", ", dynamicList));
        
        List<string> wordsList = new List<string>();
        Console.Write("Enter a word: ");
        wordsList.Add(Console.ReadLine());
        wordsList.Reverse();
        Console.WriteLine(string.Join(", ", wordsList));
        
        List<int> numList = new List<int> { 10, 20, 15, 5 };
        double avg = numList.Average();
        numList.Sort();
        Console.WriteLine(avg);
        Console.WriteLine(string.Join(", ", numList));
        
        numList.RemoveAll(x => x < 10);
        Console.WriteLine(string.Join(", ", numList));
        
        List<int> grades = new List<int> { 40, 55, 30, 70 };
        grades = grades.Select(g => g < 50 ? 50 : g).ToList();
        Console.WriteLine(string.Join(", ", grades));
    }

    
}
