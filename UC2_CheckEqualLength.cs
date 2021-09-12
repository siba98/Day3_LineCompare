﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day3_LineCompare
{
    class UC2_CheckEqualLength
    {
        public static void CheckEqualLength()
        {
            int x1, x2, y1, y2;
            Console.WriteLine("Enter values of the coordinates for first point(x1,y1)");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values of the coordinates for second point(x2,y2)");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            float line1length;
            line1length = (float)(Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2))));
            Console.WriteLine("Length of the line1 is: " + line1length);
            string lengthOfLine1 = Convert.ToString(line1length);

            int a1, a2, b1, b2;
            Console.WriteLine("Enter values of the coordinates for first point(a1,b1)");
            a1 = Convert.ToInt32(Console.ReadLine());
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values of the coordinates for second point(a2,b2)");
            a2 = Convert.ToInt32(Console.ReadLine());
            b2 = Convert.ToInt32(Console.ReadLine());

            float line2length;
            line2length = (float)(Math.Sqrt((Math.Pow(a2 - a1, 2)) + (Math.Pow(b2 - b1, 2))));
            Console.WriteLine("Length of the line2 is: " + line2length);
            string lengthOfLine2 = Convert.ToString(line2length);

            if(lengthOfLine1 .Equals (lengthOfLine2))
            {
                Console.WriteLine("Value of both the lines are equal");
            }
            else
            {
                Console.WriteLine("Value of both the values are not equal");
            }
        }
    }
}
