/* Programmed by Interpreter#1338 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace IP_sorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebClient web = new WebClient();
            string[] array = new string[2];

            array[1] = "Not going to include an IP for you";

            foreach (string ip in array)
            {
                /* iterate through each proxy and return their results */
                ipbox.Text += Environment.NewLine + web.DownloadString("http://ip-api.com/json/" + ip);
                ipbox.Text += Environment.NewLine;
            }
        }

        private void ipbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
