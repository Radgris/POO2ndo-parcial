using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2ndparcialform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (trackBar1.Value > 4 && trackBar2.Value > 4) 
            {
                label1.Text = "warning";
            }

            else
            {
                label1.Text = "ok";
            }
        }
    }
}
