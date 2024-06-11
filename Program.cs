using System;

namespace IdentifyAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year of birth: ");
            int yearOfBirth = Convert.ToInt16(Console.ReadLine());

            int age = AgeCalculator(yearOfBirth);
            string generation = GettingGeneration(age);
            string stage = GettingStage(age);

            Console.WriteLine($"You are {age} years old, {generation}, {stage}");
        }

        public static int AgeCalculator(int yearOfBirth)
        {
            int age = 2024 - yearOfBirth;
            string generation = GettingGeneration(age);
            string stage = GettingStage(age);

            return age;

        }
        public static string GettingGeneration(int age)
        {
            string generation = age >= 79 && age <= 96 ? "The Silent Generation" :
                         age >= 60 && age <= 78 ? "Baby Boomers" :
                         age >= 44 && age <= 59 ? "Gen X" :
                         age >= 28 && age <= 43 ? "Millenials" :
                         age >= 12 && age <= 27 ? "Gen Z" :
                         age >= 0 && age <= 11 ? "Gen Alpha" : "";

            return generation;
        }
        public static string GettingStage(int age)
        {
            string stage = age >= 0 && age <= 3 ? "Infant" :
                           age >= 4 && age <= 6 ? "Early Childhood" :
                           age == 7 || age == 8 ? "Middle Childhood" :
                           age >= 9 && age <= 11 ? "Late Childhood" :
                           age >= 12 && age <= 20 ? "Adolescence" :
                           age >= 21 && age <= 35 ? "Early Adulthood" :
                           age >= 36 && age <= 50 ? "Midlife" :
                           age >= 51 && age <= 80 ? "Mature Adulthood" :
                           age > 80 ? "Late Adulthood" : "";

            return stage;
        }
    }
}