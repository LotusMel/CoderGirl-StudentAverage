using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace StudentAverage
{
    public class Student
    {
        public string Name { get; set; }

        public int[] Scores { get; set; }

        public int GetAverage()
        {
            double avg = Scores.Average();
            int average = Convert.ToInt32(avg);
            return average;
        }
    }
}