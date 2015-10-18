using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Gift : IGift
    {
        private ICollection<Sweet> items;

        public Gift()
        {
            items = new List<Sweet>();
        }

        public void Add(Sweet sweets)
        {
            items.Add(sweets);
        }

        public int GiftWeight()
        {
            return items.Sum(x=>x.weight);
        }

        public void Sort()
        {
            var temp = items.OrderBy(x => x.weight).ToList();
            items.Clear();
            foreach (var item in temp)
            {
                items.Add(item);
            }
        }

        public IEnumerable<Sweet> FindCandyBySugar(int min, int max)
        {
            return items.Where(x => (x.sugar >= min) && (x.sugar <= max)).ToList();
        }

        public IEnumerable<Sweet> Items
        {
            get { return this.items; }
        }
    }
}
