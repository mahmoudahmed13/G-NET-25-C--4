namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int[] stScores = new int[5];
            //for (int i = 0; i < stScores.Length; i++)
            //{
            //    while (true)
            //    {
            //        Console.Write($"Enter score student {i}:");
            //        if(int.TryParse(Console.ReadLine(), out int score) && score >= 0 && score <= 100)
            //        {
            //            stScores [i] = score;
            //            break;
            //        }
            //        Console.ForegroundColor = ConsoleColor.Red; 
            //        Console.WriteLine("Invalid input. Please enter a positive number from 0 to 100.");
            //        Console.ResetColor();
            //    }
            //}
            //Console.WriteLine("--- Report ---");
            //int sum = 0;
            //double average;
            //int max = 0;
            //for (int i = 0; i < stScores.Length; i++)
            //{
            //    Console.WriteLine($"Student {i}: {stScores[i]} -> Grade: {GetGrade(stScores[i])}");
            //    sum += stScores [i];
            //    max = stScores [0];
            //    if (stScores[i] > max)
            //        max = stScores [i];
            //}
            //average = sum / stScores.Length;
            //Console.WriteLine($"Average: {average}");
            //Console.WriteLine($"Highest Score: {max}");
        }

        //static string GetGrade(int score)
        //{
        //    Grade grade1;
        //    if (score >= 90)
        //        grade1 = Grade.A;
        //    else if (score >= 80)
        //        grade1 = Grade.B;
        //    else if (score >= 70)
        //        grade1 = Grade.C;
        //    else if (score >= 60)
        //        grade1 = Grade.D;
        //    else 
        //        grade1 = Grade.F;

        //    return grade1.ToString();
        //}

    }
}
