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
        public string[] DiskNames;
        public string[] PartitionNames;

        public Disk()
        {
            DiskNames = GetDiskNames();
            PartitionNames = GetPartitionNames(0);
        }

        void Script(string cmd)
        {
            File file = new File(Constants.SCRIPT_PATH);
            file.Write(cmd);
        }

        public string Diskpart(string cmd)
        {
            Script(cmd);
            Process process = new Process();
            try
            {
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.FileName = "diskpart";
                process.StartInfo.Arguments = "/s "+Constants.SCRIPT_PATH;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardOutput = true;

                process.Start();
                process.WaitForExit();

                StreamReader streamReader = process.StandardOutput;

                string op = "", t; ;
                while ((t = streamReader.ReadLine()) != null)
                {
                    op += t + "\n";
                }

                grepArr = op.Split('\n');
                return op;

            }
            catch (Exception e)
            {
                return null;
            }
        }

        int GetDiskCount()
        {
            Diskpart("list disk");
            int c = 0;
            for (int i = 0; i < grepArr.Length; i++)
                if (grepArr[i].Trim().StartsWith("Disk"))
                    c++;
            c--;
            Log("disk_count", c + "");
            return c;
        }

        int GetPartitionCount(int diskNo)
        {
            Diskpart("select disk " + diskNo + "\nlist partition");
            int c = 0;
            for (int i = 0; i < grepArr.Length; i++)
                if (grepArr[i].Trim().StartsWith("Partition"))
                    c++;
            c--;
            Log("partition_count", c + "");
            return c;
        }

        public string[] GetDiskNames()
        {
            int n = GetDiskCount();
            string[] diskNames = new string[n];
            for (int i = 0; i < n; i++)
            {
                Log(i + "th_disk_count", diskNames[i] = Diskpart("select disk " + i + "\ndetail disk").Split('\n')[8]);
            }
            return diskNames;
        }

        public string[] GetPartitionNames(int diskNo)
        {
            int n = GetPartitionCount(diskNo), k = 0;
            string[] partitionNames = new string[n];
            string t;

            for (int i = 1; i <= n; i++)
            {
                string[] lines = Diskpart("select disk " + diskNo + "\n" +
                    "select partition " + i + "\n" +
                    "detail partition").Trim().Split('\n');
                string line = lines[lines.Length - 1].Trim();                
                Scanner scanner = new Scanner(line);
                scanner.Next(); scanner.Next(); scanner.Next();
                Log(i + "th_partition_name", partitionNames[k++] = ((t=scanner.Next()).Length == 1) ?t:"unassigned");
            }
            return partitionNames;
        }

        public string GetDiskInfo(int diskNo = 0)
        {
            string op = Diskpart("select disk " + diskNo + "\n" +
                    "detail disk").Trim();
            string[] opArr = op.Split('\n');

            op = "";
            for (int i = 8; i <= opArr.Length - 46; i++)
                op += opArr[i] + "\n";
            op = op.Trim();
            
            return op;
        }

        public string GetPartitionInfo(int diskNo = 0, int partitionNo = 0)
        {
            string op = Diskpart("select disk " + diskNo + "\n" +
                "select partition " + partitionNo + "\n" +
                "detail partition").Trim();
            string[] opArr = op.Split('\n');

            op = "";
            for (int i = 9; i < opArr.Length; i++)
                op += opArr[i] + "\n";
            op = op.Trim();

            return op;
        }

        public string GetFSInfo(int diskNo = 0, int partitionNo = 0)
        {
            string op = Diskpart("select disk " + diskNo + "\n" +
                "select partition " + partitionNo + "\n" +
                "filesystem").Trim();
            string[] opArr = op.Split('\n');

            op = "";
            for (int i = 9; i <= opArr.Length-46; i++)
                op += opArr[i] + "\n";
            op = op.Trim();

            return op;
        }

        void Log(string fileName, string message)
        {
            new File(Constants.LOGS_DIR_PATH + "/" + fileName + ".txt").Write(message);
        }
    }
}
