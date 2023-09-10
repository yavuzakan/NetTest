using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetTest
{
    public partial class Form1 : Form
    {
        public static string newline = Environment.NewLine;
        string path = @"data.txt";
        public Form1()
        {
            InitializeComponent();
            ping();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ping();
        }

        public void ping()
        {
            button1.Enabled = false;
            Ping ping = new Ping();
            PingReply cevap = ping.Send(textBox1.Text);

            if (cevap.Status == IPStatus.Success)
            {
                //  textBox3.Text += gelenip + newline;
                // string time = DateTime.Now.ToString("h:mm:ss tt");
                // textBox2.Text +=  "tamam" + newline;


            }
            else
            {

                string time = DateTime.Now.ToString(" dd/MM/yyyy h:mm:ss tt");
                textBox2.Text += "Hatalı "+ time + newline;
            }




            button1.Enabled = true;
       

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ping();
        }

        public void data(String text2)
        {
            StreamWriter sw = File.AppendText(path);
            sw.WriteLine(text2);

        }


    }
}
