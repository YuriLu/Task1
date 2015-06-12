using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Gift : IGift
    {
        private List<Sweet> gift;

        public Gift()
        { 
            gift = new List<Sweet>();
        }

        public void AddCandy(Sweet sweets)
        {
            gift.Add(sweets);
        }

        public int GiftWeight()
        {
            int giftWeight = 0;
            foreach (var i in gift)
            {
                giftWeight += i.weight;
            }
            return giftWeight;
        }

        public void Sort()
        {
            gift = gift.OrderBy(x => x.weight).ToList();
        }

        public void ShowItems()
        {
            Console.WriteLine("Набор конфет: ");
            foreach(var i in gift)
            {
                Console.WriteLine(i.name + " " + "Вес конфеты: " + i.weight + " " + "Сахар:" + i.sugar + " " + "Калории: " + i.calories);
            }
        }

        public void FindCandyBySugar(int min, int max)
        {
            List<Sweet> resultSweet = new List<Sweet>();
            Console.WriteLine();
            Console.WriteLine("Избранная(-ые) конфета(-ы): ");
            foreach(var i in gift)
            {
                if (i.sugar >= min && i.sugar <= max) 
                {
                    resultSweet.Add(i);
                    Console.WriteLine(i.name + " " + "Вес конфеты: " + i.weight + " " + "Сахар:" + i.sugar + " " + "Калории: " + i.calories);
                }
                
            }
            

        }
    }
}
