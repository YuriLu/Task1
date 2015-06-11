using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Factory;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator[] creators = new Creator[2];
            creators[0] = new CandyCreator();
            creators[1] = new ChocolateCreator();

            IGift gift = new Gift();

            foreach (Creator i in creators)
            {
                if (i is CandyCreator)
                {
                    gift.AddCandy(i.FactoryMethod("ChupaChups", 25, 75, 70, TypeCandy.Lollipop));
                }

                if (i is ChocolateCreator)
                {
                    gift.AddCandy(i.FactoryMethod("Alpen Gold", 100, 115, 250, ChocolateColor.WhiteChocolate));
                }
            }

            gift.Sort();
            gift.ShowItems();
            gift.FindCandyBySugar(20, 100);

            Console.WriteLine();
            Console.WriteLine("Вес подарка: {0}", gift.GiftWeight());
            Console.ReadKey();

        }
    }
}
