﻿using System;

namespace Problem_2.Black_Box_Integer
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(new BlackBoxIntegerTests().Run(typeof(BlackBoxInt)));
        }
    }
}
