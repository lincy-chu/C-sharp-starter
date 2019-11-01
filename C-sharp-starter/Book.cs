using System;
using System.Collections.Generic;
using static System.Console;

namespace CSharpStarter
{
    public class Book
    {
        public void ShowInfo(IEnumerable<int> intYear)
        {
            foreach (var year in intYear)
            {
                Write(year + "\t");
            }
        }

        public void ShowInfo(IEnumerable<string> strName)
        {
            foreach (var str in strName)
            {
                Write(str + "\t");
            }
        }

        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}