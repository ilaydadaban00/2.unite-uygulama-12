using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.unite_uygulama_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            int ses = trackBar1.Value;
            if(ses ==0)
            {
                label1.Text = ("ses  yok");
            }  if  (ses >= 0 && ses <=10)
            {
                label1.Text= ("ses   normal");
            }  if(ses >= 11)
            {
                label1.Text = ("ses   yüksek");
            }                                                   
        }
    }
}
