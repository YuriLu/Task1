using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Chocolate : Sweet
    {
        private string color { get; set; }
        public Chocolate(string chocoName, int chocoWeight, int chocoSugar, int chocoCalories, string chocoColor) 
            : base(chocoName, chocoWeight, chocoSugar, chocoCalories)
        {
            this.color = chocoColor;
        }

    }
}
