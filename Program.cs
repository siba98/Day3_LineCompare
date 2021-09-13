using System;

namespace Day3_LineCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            start.Welcome();
            Console.WriteLine("Welcome to line comparison computation program");
            UC1_CalculatingLength.Line1Length();
            UC2_CheckEqualLength.CheckEqualLength();
            UC3_Comparing2Lengths.CompareTwoLengths();
        }
    }
}
