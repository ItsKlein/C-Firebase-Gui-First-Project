using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Http;
using System.ServiceProcess;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();

            //C0n Or Disc0 color
            label4.BackColor = Color.Red;




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                
                string xamppPath = @"C:\xampp\apache\bin\httpd.exe";
                string xamppPath2 = @"C:\xampp\mysql\bin\mysqld.exe";

                // Start the XAMPP application.
                Process.Start(xamppPath);
                Process.Start(xamppPath2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string url = "http://localhost/phpmyadmin/index.php?route=/sql&pos=0&db=final_db_medical&table=appointments";

            
            Process.Start(url);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = "http://localhost/phpmyadmin/index.php?route=/database/export&db=final_db_medical";

            Process.Start(url);

        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string xamppPath = @"C:\xampp\xampp-control.exe";
                Process.Start(xamppPath);
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string url = "https://www.apachefriends.org/";

            Process.Start(url); 
        }

        private void label4_Click(object sender, EventArgs e)
        {
            string processName = "httpd";

            if (IsProcessRunning(processName))
            {
                label4.Text = "CONNECTED";
                label4.BackColor = Color.Green;

            }else if (!IsProcessRunning(processName))
            {
                label4.Text = "Disconnected";
                label4.BackColor = Color.Red;
            }
            else
            {
                label4.Text = "error";
                label4.BackColor = Color.Blue;
            }
        }
        private bool IsProcessRunning(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            return processes.Length > 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
