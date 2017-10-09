using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Raidiate
{
    public partial class radiate : Form
    {
        Disk disk;

        public radiate()
        {
            // init
            InitializeComponent();
            disk = new Disk();

            // populating disk + partition + volume
            diskComboBox.DataSource = disk.DiskNames;
            partitionComboBox.DataSource = disk.PartitionNames;
            
        }

        private void diskComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            partitionComboBox.DataSource = disk.GetPartitionNames(diskComboBox.SelectedIndex);
        }

        private void rescanButton_Click(object sender, EventArgs e)
        {
            disk = new Disk();
            diskComboBox.DataSource = disk.DiskNames;
            partitionComboBox.DataSource = disk.PartitionNames;
        }

        //Disk Information
        private void diskButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(disk.GetDiskInfo(diskComboBox.SelectedIndex), diskComboBox.SelectedValue.ToString());
        }

        private void partitionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(disk.GetPartitionInfo(diskComboBox.SelectedIndex, partitionComboBox.SelectedIndex + 1),
                diskComboBox.SelectedValue.ToString() + " - " + partitionComboBox.SelectedValue.ToString() + ":\\");
        }

        private void filesystemButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(disk.GetFSInfo(diskComboBox.SelectedIndex, partitionComboBox.SelectedIndex + 1),
                diskComboBox.SelectedValue.ToString() + " - " + partitionComboBox.SelectedValue.ToString() + ":\\");
        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        /*
        string command = textBox1.Text;
        string exe = command.Substring(0, command.IndexOf(' '));
        string args = command.Substring(command.IndexOf(' ')+1);

        Process process = new Process();
        try
        {
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.FileName = exe;
            process.StartInfo.Arguments = args;
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

            richTextBox1.Text = op;

        }
        catch (Exception ex)
        {
            textBox1.Text = ex.Message;
            //Console.ReadKey();
        }
        */

        //}
    }
}
