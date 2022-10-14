using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniTesting
{
    internal class StudentResult
    {
        public static void Main(string[] args)
        {
            var grade = new GradeCalculator();
            Console.WriteLine("Enter the percentage ");
            var per = int.Parse(Console.ReadLine());
            var g = grade.GetGradePercentage(per);
            Console.WriteLine("Grdae : {0} ", g);
        }
    }
}