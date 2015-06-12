using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public interface IGift
    {
        void AddCandy(Sweet sweets);
        int GiftWeight();
        void Sort();
        void ShowItems();
        void FindCandyBySugar(int min, int max);
    }
}
