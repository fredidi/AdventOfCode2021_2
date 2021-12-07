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
            Console.WriteLine("Part 1 solution:\n" +
                depth * horizontal);
        }
        public static void PartTwo()
        {
            string[] textFile = File.ReadAllLines(@"C:\Users\fredd\OneDrive\.NET Developer\AdventOfCode\2\input.txt");

            int horizontal = 0;
            int depth = 0;
            int aim = 0;

            foreach (var text in textFile)
            {
                if (text.Contains(" "))
                {
                    string direction = text.Split(' ')[0];
                    int step = int.Parse(text.Split(' ')[1]);

                    if (direction == "forward")
                    {
                        horizontal += step;
                        depth += aim * step;
                    }
                    else if (direction == "up")
                    {
                        aim -= step;
                    }
                    else if (direction == "down")
                    {
                        aim += step;
                    }
                }
            }
            Console.WriteLine("Part 2 solution:\n" +
                depth * horizontal);
        }

        static void Main(string[] args)
        {
            PartOne();
            Console.WriteLine();
            PartTwo();

            //forward + (horisontal)
            //up -      (depth)
            //down +    (depth)


            /*
            (forward, steg) ->
            ----------------------
            (up, steg) /\
            (down, steg) \/
            */

            /*
            down X increases your aim by X units.       down aim +X
            up X decreases your aim by X units.         up aim -X
            forward X does two things:
            It increases your horizontal position by X units.   horizontal +X
            It increases your depth by your aim multiplied by X.        depth = aim * X
            */
        }
    }
}



