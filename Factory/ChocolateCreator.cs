using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Factory
{
    public class ChocolateCreator : Creator
    {
        public override Sweet FactoryMethod()
        {
            return new Chocolate("Alpen Gold", 100, 115, 250, ChocolateColor.WhiteChocolate);
        }
    }
}
