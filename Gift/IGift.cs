using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public interface IGift
    {
        IEnumerable<Sweet> Items{get;}
        void Add(Sweet sweets);
        int GiftWeight();
        void Sort();
        //void ShowItems();
        IEnumerable<Sweet> FindCandyBySugar(int min, int max);
        //void FindCandyBySugar(int min, int max);
    }
}
