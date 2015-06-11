using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Factory
{
    public class CandyCreator : Creator
    {
        public override Sweet FactoryMethod()
        {
            return new Candy("ChupaChups", 25, 75, 70, TypeCandy.Lollipop);
        }
    }
}
