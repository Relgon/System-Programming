using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class MetaSymbolList : List<MetaSymbol>
    {
        public new void Add(MetaSymbol m)
        {

            if (Count == 0)
            {
                base.Add(m);
                return;
            }


            MetaSymbol topElem = this.ElementAt(Count - 1);
            MetaSymbol curentElem = m;
            if (topElem.end + 1 == curentElem.start && topElem.symbol.Equals(curentElem.symbol))
            {
                topElem.count += curentElem.count;
                topElem.end = curentElem.end;
                return;
            }
            base.Add(m);
        }
        public void ShiftAll(int startFrom, int shift)
        {
            if (startFrom >= Count || startFrom < 0)
            {
                throw new Exception();
            }
            for (int i = startFrom; i < Count; i++)
            {
                this.ElementAt(i).shift(shift);
            }
        }

        public MetaSymbolList clone()
        {
            MetaSymbolList temp = new MetaSymbolList();
            for (int i = 0; i < Count; i++)
            {
                temp.Add(new MetaSymbol(this.ElementAt(i)));
            }
            return temp;
        }
    }
}
