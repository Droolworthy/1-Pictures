using System;

namespace CS4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int picturesRow = 3;
            int picturesАlbum = 52;
            int filledRow = picturesАlbum/picturesRow;
            int beyondMeasure = 52;
            Console.WriteLine(filledRow);
            Console.WriteLine(beyondMeasure);
        }
    }
}
