using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweet lollipop = new Candy("ChupaChups", 25, 75, 70, TypeCandy.Lollipop);
            Sweet candy = new Candy("M&M", 75, 45, 70, TypeCandy.ChocolateCandy);
            Sweet choco = new Chocolate("Alpen Gold", 100, 115, 250, ChocolateColor.WhiteChocolate);
            IGift gift = new Gift();

            gift.AddCandy(candy);
            gift.AddCandy(lollipop);
            gift.AddCandy(choco);
            gift.Sort();
            gift.ShowItems();
            gift.FindCandyBySugar(20, 74);

            Console.WriteLine();
            Console.WriteLine("Вес подарка: {0}", gift.GiftWeight());
            Console.ReadKey();

        }
    }
}
