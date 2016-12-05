using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int pos = rnd.Next(10,20);

            while (pos > 1) {
                pos = HailstormPart1.getPosition(pos);
                Console.Out.WriteLine("The hailstone is " + pos + " feet off the ground.");
            }

            Console.Out.WriteLine("The hailstone has landed.");
            Console.Out.WriteLine("Hit any key to close...");

            Console.ReadKey();
        }
    }
}
