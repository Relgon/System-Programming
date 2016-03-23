using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class RegExp
    {
        public readonly string pattern;
        public readonly MetaSymbolList allSymbols;

        public RegExp(string pattern)
        {
            this.pattern = pattern;
            allSymbols = getMetaSymbolsFromPattern();
        }

        public bool test(string word)
        {
            if (allSymbols.Count == 0)
            {
               // Console.WriteLine("Каунт==0");
                return pattern.Equals(word);
            }

            MetaSymbolList list = allSymbols.clone();
            string pat = pattern;
            for (int i = 0; i < allSymbols.Count; i++)
            {
                StringBuilder buffer = new StringBuilder();
                MetaSymbol curentMetaSymbol = list.ElementAt(i);

                string inWord;
                string inPattern;
                try
                {
                    inWord = word.Substring(0, curentMetaSymbol.start);
                    inPattern = pat.Substring(0, curentMetaSymbol.start);
                }
                catch (Exception)
                {
                    Console.WriteLine("2");
                    return false;
                }

                if (!inWord.Equals(inPattern))
                {
                    Console.WriteLine("3");
                    return false;
                }

                buffer.Append(inWord); //До шаблона
                string repeatedSymbols = new String(curentMetaSymbol.symbol, curentMetaSymbol.count);
                buffer.Append(repeatedSymbols); //Повторяющиеся символы
                int count = 0;
                int nextSymbolPosition = curentMetaSymbol.start + curentMetaSymbol.count;
                while (nextSymbolPosition + count < word.Length && word.ToCharArray()[nextSymbolPosition + count] == curentMetaSymbol.symbol)
                {
                    buffer.Append(curentMetaSymbol.symbol);
                    count++;
                }

                buffer.Append(pat.Substring(curentMetaSymbol.end + 1));
                int nextMetaSymbol = i + 1;
                if (nextMetaSymbol < list.Count)
                {
                    int metaSymbolLength = curentMetaSymbol.end - curentMetaSymbol.start + 1;
                    int lengthOfStringCreatedByMetaSymbol = curentMetaSymbol.count + count;
                    list.ShiftAll(nextMetaSymbol, lengthOfStringCreatedByMetaSymbol - metaSymbolLength);
                }

                pat = buffer.ToString();
            }

            var a = word.ToCharArray();
            var b = pat.ToCharArray();
            for (int j = 0; j < word.Length; j++)
            {
                //Console.WriteLine("word :" + a[j] + " , pat : " + b[j] + " - " + (b[j] == a[j]).ToString());
            }
            //Console.WriteLine("Word : " +  + " ,pat: " + pat +" , word==pat : " + (word==pat).ToString()+" ,word length : "+word.Length+" pat length " +pat.Length );
            return pat.Equals(word);
        }

        private MetaSymbolList getMetaSymbolsFromPattern()
        {
            MetaSymbolList metaSymbolsList = new MetaSymbolList();
            Console.WriteLine(pattern);
            for (int i = 0; i < pattern.Length; i++)
            {
                try
                {
                    string temp = "";
                    if (pattern.ElementAt(i) == '{')
                    {
                        int k = i + 1;
                        while (char.IsDigit(pattern.ElementAt(k)))
                        {
                            temp += pattern.ElementAt(k);
                            k++;
                        }
                        if (temp.Length != 0 && pattern.ElementAt(k) == ','
                                && pattern.ElementAt(k + 2) == '}')
                        {
                            int start = i;
                            int end = k + 2;
                            string ch = pattern.ElementAt(k + 1).ToString();
                            string number = temp;
                            metaSymbolsList.Add(new MetaSymbol(start, end, ch, number));
                        }

                    }
                }
                catch (Exception e)
                {
                    break;
                }
            }
            return metaSymbolsList;
        }
    }
}

