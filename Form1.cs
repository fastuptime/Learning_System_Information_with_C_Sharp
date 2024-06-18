using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Management; // !!!! NUGET PAKET YÖNETİCİSİNDEN MANAGEMENT YÜKLEYİNİZ !!!!!!


namespace softwareHome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            ListSystemInfo();
        }

        private void ListSystemInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Operating System Information:");
            sb.AppendLine(GetManagementObject("Win32_OperatingSystem", "Caption"));
            sb.AppendLine(GetManagementObject("Win32_OperatingSystem", "Version"));
            sb.AppendLine(GetManagementObject("Win32_OperatingSystem", "Manufacturer"));
            sb.AppendLine();

            sb.AppendLine("Processor Information:");
            sb.AppendLine(GetManagementObject("Win32_Processor", "Name"));
            sb.AppendLine(GetManagementObject("Win32_Processor", "Manufacturer"));
            sb.AppendLine(GetManagementObject("Win32_Processor", "Description"));
            sb.AppendLine();

            sb.AppendLine("Memory Information:");
            sb.AppendLine(GetManagementObject("Win32_PhysicalMemory", "Capacity"));
            sb.AppendLine(GetManagementObject("Win32_PhysicalMemory", "Speed"));
            sb.AppendLine();

            sb.AppendLine("Disk Drive Information:");
            sb.AppendLine(GetManagementObject("Win32_DiskDrive", "Model"));
            sb.AppendLine(GetManagementObject("Win32_DiskDrive", "InterfaceType"));
            sb.AppendLine(GetManagementObject("Win32_DiskDrive", "MediaType"));
            sb.AppendLine();

            sb.AppendLine("Network Adapter Information:");
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                sb.AppendLine($"Name: {ni.Name}");
                sb.AppendLine($"Description: {ni.Description}");
                sb.AppendLine($"Status: {ni.OperationalStatus}");
                sb.AppendLine($"Speed: {ni.Speed}");
                sb.AppendLine();
            }

            richTextBox1.Text = sb.ToString();
        }

        private string GetManagementObject(string query, string property)
        {
            StringBuilder sb = new StringBuilder();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher($"SELECT {property} FROM {query}");
            foreach (ManagementObject obj in searcher.Get())
            {
                sb.AppendLine($"{property}: {obj[property]}");
            }
            return sb.ToString();
        }
    }
}
