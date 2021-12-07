using System;
using System.IO;

namespace _2
{
    class Program
    {
        public static void PartOne()
        {
            string[] textFile = File.ReadAllLines(@"C:\Users\fredd\OneDrive\.NET Developer\AdventOfCode\2\input.txt");

            int horizontal = 0;
            int depth = 0;
            foreach (var text in textFile)
            {
                if (text.Contains(" "))
                {
                    string direction = text.Split(' ')[0];
                    int step = int.Parse(text.Split(' ')[1]);

                    if (direction == "forward")
                    {
                        horizontal += step;
                    }
                    else if (direction == "up")
                    {
                        depth -= step;
                    }
                    else if (direction == "down")
                    {
                        depth += step;
                    }
                }
            }
            Console.WriteLine(depth * horizontal);
        }
        public static void PartTwo()
        {
            string[] textFile = File.ReadAllLines(@"C:\Users\fredd\OneDrive\.NET Developer\AdventOfCode\2\input.txt");

            //int horizontal = 0;
            //int depth = 0;
            //int aim = 0;
        }

        static void Main(string[] args)
        {
            PartOne();

            //forward + (horisontal)
            //up -      (depth)
            //down +    (depth)


            /*
            (forward, steg) ->
            ----------------------
            (up, steg) /\
            (down, steg) \/
            */
        }
    }
}



