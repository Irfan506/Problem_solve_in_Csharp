﻿using System;

namespace Round_690_Div_3_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Cint t = Convert.ToInt32(Console.ReadLine());
            while (t > 0)
            {
                t--;
                int n = Convert.ToInt32(Console.ReadLine()); ;
                string str = Console.ReadLine();
                bool flag = (str.StartsWith("2020") || str.EndsWith("2020"))
                    || (str.StartsWith("2") && str.EndsWith("020"))
                    || (str.StartsWith("20") && str.EndsWith("20"))
                    || (str.StartsWith("202") && str.EndsWith("0"));
                if (flag)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
    }
}
