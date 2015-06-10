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

        public void AddCandy(Sweet sw)
        {
            gift.Add(sw);
        }

        public int GiftWeight()
        {
            int giftWeight = 0;
            foreach (var i in gift)
            {
                giftWeight += i.Weight;
            }
            return giftWeight;
        }

        public void Sort()
        {
            gift = gift.OrderBy(x => x.Weight).ToList();
        }

        public void ShowItems()
        {
            Console.WriteLine("Набор конфет: ");
            foreach(var i in gift)
            {
                Console.WriteLine(i.Name + " " + "Вес конфеты: " + i.Weight + " " + "Сахар:" + i.Sugar + " " + "Калории: " + i.Calories);
            }
        }

    }
}
