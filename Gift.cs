using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Gift
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

        public void RemoveCandy(Sweet sw)
        {
            gift.Remove(sw);
        }

        public int GiftWeight(Sweet sw)
        {
            int weight = 0;
            foreach (var i in sw)
            {
                weight += sw;
            }
            return 0;
        }
    }
}
