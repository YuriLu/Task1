using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Factory
{
    public abstract class Creator
    {
        public abstract Sweet FactoryMethod(string candyName, int candyWeight, int candySugar, int candyCalories, TypeCandy type);
        public abstract Sweet FactoryMethod(string candyName, int candyWeight, int candySugar, int candyCalories, ChocolateColor color);
    }
}
