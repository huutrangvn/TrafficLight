using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGiaoThong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Timer t = new Timer();
        int ss = 20;
        bool denxanh = true;
        bool dendo=false;
        bool denvang = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }
        private void t_Tick(object sender, EventArgs e)
        {
            ss = ss - 1;
            if (ss < 5 && ss > 0 && denxanh==true)
            {
                label2.Text = "Vang";
                denvang = true;
                denxanh = false;
                dendo = false;
            }
                
            if (ss < 0 && denvang==true)
            {
                label2.Text = "Do";
                ss = 20;
                dendo = true;
                denxanh = false;
                denvang = false;
            }
            if(ss < 0 && dendo==true)
            {
                label2.Text = "Xanh";
                ss = 20;
                dendo = false;
                denxanh = true;
                denvang = false;
            }
            label1.Text = ss.ToString();
        }
    }
}
