using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Candy : Sweet
    {
        private string color { get; set; }
        public Candy(string candyName, int candyWeight, int candySugar, int candyCalories, string candyColor)
            : base(candyName, candyWeight, candySugar, candyCalories)
        {
            this.color = candyColor;
        }

        public override void StructureCandy()
        {
            Console.WriteLine("Состав конфеты: {0}, {1}, {2}, {3}, {4}");
        }
    }
}
