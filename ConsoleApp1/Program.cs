using ConsoleApp1.Enums;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01

            //Console.Write($"Enter a day number (1-7): ");
            //bool days = int.TryParse(Console.ReadLine(), out int day);
            //DaysOfWeek dayOfWeek = (DaysOfWeek)day;
            //Console.WriteLine($"Day: {dayOfWeek}");

            //string howDay = dayOfWeek switch
            //{
            //    DaysOfWeek.Saturday or DaysOfWeek.Friday => "It's the Weekend",
            //    _ => "It's a Workday"
            //};
            //Console.WriteLine(howDay); 
            #endregion

            #region Part 2: Arrays

            #region Question 02

            //Console.Write("Please enter array size: ");
            //int[] arr;
            //int sum =0;
            //int max,min;
            //double average = 0 ;
            //if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
            //{
            //    arr = new int[size];
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Enter element [{i}]:");
            //        arr[i] = int.Parse(Console.ReadLine());

            //        sum += arr[i]; 
            //    }
            //    average = sum / arr.Length;
            //    max = arr[0];
            //    min = arr[0];
            //    for (int j = 0; j < size; j++)
            //    {
            //        if (arr[j] > max)
            //            max = arr[j];
            //        if (arr[j] < min)
            //            min = arr[j];
            //    }

            //    Console.WriteLine($"Sum = {sum}");
            //    Console.WriteLine($"Average = {average}");
            //    Console.WriteLine($"Max = {max}");
            //    Console.WriteLine($"Min = {min}");

            //    Console.Write("Reverse =");
            //    for (int r = size - 1 ; r >= 0 ; r--)
            //    {
            //        Console.Write($" {arr[r]}, ");

            //    }

            //}

            #endregion

            #region Question 03
            
            //int[,] grades = new int[3,4];
            //for (int i = 0; i < grades.GetLength(0); i++) 
            //{
            //    int sum = 0;
            //    double average;
            //    Console.WriteLine($"Student {i}: ");
            //    for (int j = 0; j < grades.GetLength(1); j++)
            //    {
            //        bool isTrue = int.TryParse(Console.ReadLine(), out grades[i, j]);
            //        sum += grades[i, j];
            //    }
            //    average = sum / 4;
            //    Console.WriteLine($"Average of {i} = {average}");
            //}

            //int totalGrades = 0;
            //foreach (var item in grades)
            //{
            //    totalGrades += item;
            //}
            //int totalAverage = totalGrades / grades.Length;
            //Console.WriteLine($"the overall class averal = {totalAverage}");

            #endregion

            #endregion
        }
    }
}
