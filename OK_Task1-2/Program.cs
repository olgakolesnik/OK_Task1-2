﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OK_Task1_2
{
    class Program
    {
        public static double GetRandomDouble(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
        public static double AskDoubleValue()
        {
            for (int i = 0; i < 3; i++)
            {
                String input = Console.ReadLine();
               
                double OutVal;
            
                if (double.TryParse(input, out OutVal))
                {
                    return Math.Round(OutVal, 2);
                }
                else {
                        Console.WriteLine("Error: Can NOt convert value to double: {0}, input again:", OutVal);  
                    
                }

            }
            double defaultRandom = Math.Round(GetRandomDouble(0.5, 5), 2);
            Console.WriteLine("3 retries are failed, taking default value {0}", defaultRandom);
            return defaultRandom;
        }



        class Circle {
            double radius;
            public Circle()
            {
                Console.WriteLine("INput circle radius ");
               
                radius = AskDoubleValue();
            }
            public double getArea()
            {
                return Math.Round(radius * radius * Math.PI, 2);
            }
        }
        class Square {
            double side;
            public Square()
            {
                Console.WriteLine("INput square side  ");
                String input = Console.ReadLine();
                side = AskDoubleValue();
            }
            public double getArea()
            {
                return Math.Round(side * side);
            }
        }
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Console.WriteLine("Cicrcle area: {0}",circle.getArea());

            Square sq = new Square();
            Console.WriteLine("Square area: {0}", sq.getArea());

            Console.ReadKey();
             
            
        }

       

        
    }
}
