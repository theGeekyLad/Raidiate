using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raidiate
{
    public class Scanner
    {
        int i;
        List<string> list;
        string[] arr;

        public int Length
        {
            get
            {
                return arr.Length;
            }
        }

        public Scanner(string line)
        {
            i = 0;
            list = new List<string>();

            int k = 0;
            string s = "";

            line = line.Trim();
            for (int j = 0; j < line.Length; j++)
            {
                if (line[j] == ' ')
                {
                    list.Add(s);
                    s = "";
                    while (++j < line.Length && line[j] == ' ') ; j--;
                    continue;
                }
                s += line[j];
            }
            list.Add(s);
            arr = list.ToArray();
        }

        public string Next()
        {
            if (i < arr.Length)
                return arr[i++];
            return null;
        }        
    }
}
