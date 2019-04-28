using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace StudentAverage
{
    public static class Program
    {
        public static void Main()
        {
            string filePath = @"C:\Users\mjlan\source\repos\LotusMel\CoderGirl-StudentAverage\studentdata.txt";
            List<Student> studentList = new List<Student>();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            Student student = new Student();

            foreach (string line in lines)
            {
                string[] entries = line.Split(' ');
                int[] scores = new int[entries.Length - 1];
                student.Name = entries[0];
                student.Scores = scores;
                for (int i = 1; i < entries.Length; i++)
                {
                    scores[i - 1] = int.Parse(entries[i]);
                }
                Console.WriteLine($"{student.Name} Average: {student.GetAverage()}");
            }

            Console.ReadLine();
        }
    }
}