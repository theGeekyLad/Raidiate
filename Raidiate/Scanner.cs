using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raidiate
{
    public class Scanner
    {
        public int i;
        public string[] arr;
        public char delimiter;

        public Scanner(string line)
        {
            i = 0;
            delimiter = ' ';
            arr = line.Split(delimiter);
        }

        public string next()
        {
            if (i < arr.Length)
                return arr[i++];
            return null;
        }
    }
}
