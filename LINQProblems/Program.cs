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

            foreach (string value in queryedWords)
            {
                Console.WriteLine(value);
            }



            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };

            //where
            var queryedNames = names.Distinct().ToList();

            foreach (string value in queryedNames)
            {
                Console.WriteLine(value);
            }


            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"   };





            




            List<double> averages = new List<double>();
            int counter = 0;

            foreach (string value in classGrades)
            {
                string[] newList = value.Split(',');
                int[] splitArray = new int[newList.Length];
                for (int i = 0; i < newList.Length; i++)
                {
                    int toInt = Convert.ToInt32(newList[i]);
                    splitArray[i] = toInt;
                }

                int[] sortedCopy = splitArray.OrderByDescending(i => i).ToArray();
                splitArray = splitArray.Take(splitArray.Count() - 1).ToArray();

                double totalPoints = 0;
                double averageGrade;

                for (int i = 0; i < splitArray.Length; i++)
                {
                    totalPoints += splitArray[i];
                }

                averageGrade = (totalPoints / splitArray.Length);
                averages.Add(averageGrade);
                Console.WriteLine(averages[counter]);
                counter++;
                
            }

            double totalPointsAgain = 0;

            for (int i = 0; i < averages.Count; i++)
            {
                totalPointsAgain += averages[i];
            }

            double finalAverage = totalPointsAgain / averages.Count;
            Console.WriteLine(finalAverage);




            //Fourth Problem
            string theName = "Terrill";
            char[] letters = theName.ToCharArray();
            //var letters = from element in name orderby element ascending select element;
            foreach (char character in letters)
            {
                Console.WriteLine(character);
            }

            Console.ReadLine();

        }
    }
}
