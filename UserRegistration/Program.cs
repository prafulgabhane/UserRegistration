﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserResgistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration\n");

            RegexPattern.Email();
            Console.WriteLine("\nUser Registration Program Ends");
            Console.ReadLine();
        }
    }
}