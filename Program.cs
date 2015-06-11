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
            //Sweet lollipop = new Candy("ChupaChups", 25, 75, 70, TypeCandy.Lollipop);
            //Sweet candy = new Candy("M&M", 75, 45, 70, TypeCandy.ChocolateCandy);
            //Sweet choco = new Chocolate("Alpen Gold", 100, 115, 250, ChocolateColor.WhiteChocolate);
            Creator[] creators = new Creator[2];
            creators[0] = new CandyCreator();
            creators[1] = new ChocolateCreator();

            IGift gift = new Gift();

            foreach (var i in creators)
            {
                Sweet sweets = i.FactoryMethod();
                gift.AddCandy(i.FactoryMethod());
                //gift.AddCandy(candy);
                //gift.AddCandy(choco); 
            }

            gift.ShowItems();
            gift.FindCandyBySugar(20, 100);
            gift.Sort();

            Console.WriteLine();
            Console.WriteLine("Вес подарка: {0}", gift.GiftWeight());
            Console.ReadKey();

        }
    }
}
