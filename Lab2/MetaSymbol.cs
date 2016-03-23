using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class MetaSymbol
    {
        public int start { get; set; }
        public int end { get; set; }
        public char symbol { get; set; }
        public int count { get; set; }

        public MetaSymbol(int start, int end, string symbol, string count)
        {
            this.start = start;
            this.end = end;
            this.symbol = Convert.ToChar(symbol);
            this.count = Convert.ToInt32(count);
        }
        public MetaSymbol(MetaSymbol m)
        {
            start = m.start;
            end = m.end;
            symbol = m.symbol;
            count = m.count;
        }
        public void shift(int shift)
        {
            start += shift;
            end += shift;
        }
        public override string ToString()
        {

            return "Start : " + start + " ,End : " + end + " ,Symbol : " + symbol + " ,Count : " + count;
        }
    }
}
