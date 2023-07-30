//На экране, в специальной зоне, выводятся картинки, по 3 в ряд. Всего у пользователя в альбоме 52 картинки. Код должен вывести, сколько полностью заполненных рядов можно будет вывести, и сколько картинок будет сверх меры.
//В качестве решения ожидаются объявленные переменные с необходимыми значениями и, основываясь на значениях переменных, вывод необходимых данных..
using System;

namespace CS4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int picturesRow = 3;
            int picturesАlbum = 52;
            int filledRow = picturesАlbum / picturesRow;
            int beyondMeasure = picturesАlbum % picturesRow;
            Console.WriteLine(filledRow);
            Console.WriteLine(beyondMeasure);
        }
    }
}
