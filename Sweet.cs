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
        public string Name { get; private set; }
        public int Weight { get; private set; }
        public int Sugar { get; private set; }
        public int Calories { get; private set; }

        public Sweet(string sName, int sWeight, int sSugar, int sCalories)
        {
            this.Name = sName;
            this.Weight = sWeight;
            this.Sugar = sSugar;
            this.Calories = sCalories;
        }

        public abstract void TypeSweet();


    }
}
