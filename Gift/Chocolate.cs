using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public enum ChocolateColor { BlackChocolate, WhiteChocolate };
    public class Chocolate : Sweet
    {
        public ChocolateColor color;
        public Chocolate(string chocoName, int chocoWeight, int chocoSugar, int chocoCalories, ChocolateColor chocoColor) 
            : base(chocoName, chocoWeight, chocoSugar, chocoCalories)
        {
            this.color = chocoColor;
        }
        public override void TypeSweet()
        {
            Console.WriteLine(color.ToString());
        }
    }
}
