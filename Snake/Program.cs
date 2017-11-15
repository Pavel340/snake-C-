using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();*/

            HorizontalLine line1 = new HorizontalLine(3, 19, 5, '+');
            line1.Drow();

            HorizontalLine line2 = new HorizontalLine(3, 19, 15, '+');
            line2.Drow();

            VerticalLine vLine1 = new VerticalLine(2, 5, 15, '-');
            vLine1.VerticalLineDrow();

            VerticalLine vLine2 = new VerticalLine(20, 5, 15, '-');
            vLine2.VerticalLineDrow();

            Console.ReadLine();
        }
    }
}
