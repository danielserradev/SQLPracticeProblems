using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            //where
            var queryedWords = words.Where(s => s.Contains("th")).ToList();
            for (int i = 0; i < queryedWords.Count; i++)
            {
                Console.WriteLine(queryedWords[i]);
            }
            Console.ReadLine();
        }
    }
}
