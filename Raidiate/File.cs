using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raidiate
{
    public class File
    {
        public string path;

        public File(string path)
        {
            this.path = path;
        }

        public bool write(string s)
        {            
            try
            {
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(s);
                sw.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public string read()
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);

                string s = "", t;
                while ((t = sr.ReadLine()) != null)
                    s += t;
                sr.Close();
                return s;
            }
            catch (Exception e)
            {
                return null;
            }            
        }
    }
}
