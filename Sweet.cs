using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class Sweet 
    {
        public string name { get; private set; }
        public int weight { get; private set; }
        public int sugar { get; private set; }
        public int calories { get; private set; }

        public Sweet(string sweetName, int sweetWeight, int sweetSugar, int sweetCalories)
        {
            this.name = sweetName;
            this.weight = sweetWeight;
            this.sugar = sweetSugar;
            this.calories = sweetCalories;
        }

        public abstract void TypeSweet();


    }
}
