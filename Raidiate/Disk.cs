using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raidiate
{
    public class Disk
    {
        string[] grepArr;

        // accessible fields
        public int DiskCount;
        public string[] DiskNames;

        public Disk()
        {
            // diskpart ~ list disk | getting disk count
            grepArr = diskpart("list disk").Split('\n');
            DiskCount = getDiskCount();

            // diskpart ~ select disk X ~ detail disk
            DiskNames = getDiskNames();
        }

        void script(string cmd)
        {
            File file = new File(Constants.SCRIPT_PATH);
            file.write(cmd);
        }

        string diskpart(string cmd)
        {
            script(cmd);
            Process process = new Process();
            try
            {
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.FileName = "diskpart";
                process.StartInfo.Arguments = "/s "+Constants.SCRIPT_PATH;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.CreateNoWindow = false;
                process.StartInfo.RedirectStandardOutput = true;

                process.Start();
                process.WaitForExit();

                StreamReader streamReader = process.StandardOutput;

                string op = "", t; ;
                while ((t = streamReader.ReadLine()) != null)
                {
                    op += t + "\n";
                }

                return op;

            }
            catch (Exception e)
            {
                return null;
            }
        }

        int getDiskCount()
        {
            int c = 0;
            for (int i = 0; i < grepArr.Length; i++)
                if (grepArr[i].Trim().StartsWith("Disk"))
                    c++;
            c--;
            new File(Constants.LOGS_DIR_PATH + "/disk-count.txt").write(c + ""); // debugging
            return c;
        }

        string[] getDiskNames()
        {
            string[] diskNames = new string[DiskCount];
            for (int i = 0; i < DiskCount; i++)
            {
                new File(Constants.LOGS_DIR_PATH + "/" + i + "th-disk-name.txt").write(diskNames[i] = diskpart("select disk " + i + "\ndetail disk").Split('\n')[8]);
            }
            return diskNames;
        }
    }
}
