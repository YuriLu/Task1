using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class Sweet : IEnumerator
    {
        private string Name { get; set; }
        private int Weight { get; protected set; }
        private int Sugar { get; protected set; }
        private int Calories { get; protected set; }

        public Sweet(string sName, int sWeight, int sSugar, int sCalories)
        {
            this.Name = sName;
            this.Weight = sWeight;
            this.Sugar = sSugar;
            this.Calories = sCalories;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

    }
}
