using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operacion_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btRes_Click(object sender, EventArgs e)
        {
            int A = System.Convert.ToInt32(txtA.Text);
            int B = System.Convert.ToInt32(txtB.Text);
            decimal Res = 0;

            if (txtOper.Text == "+")
            {
                Res = A + B;
            }
            else if (txtOper.Text == "-") 
            {
                Res = A - B;
            }
            else if (txtOper.Text == "*")
            {
                Res = A * B;
            }
            else if (txtOper.Text == "/")
            {
                Res = A / B;
            }
            else
            {
                Res = -999999999;
            }

            if (Res == -999999999)
            {
                lblRes.Text = "ERROR";
            }
            else
            {
                lblRes.Text = Res.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A = System.Convert.ToInt32(txtA.Text);
            int B = System.Convert.ToInt32(txtB.Text);
            decimal Res = 0;

            if (txtOper.Text == "+")
            {
                Res = A + B;
            }
            else if (txtOper.Text == "-")
            {
                Res = A - B;
            }
            else if (txtOper.Text == "*")
            {
                Res = A * B;
            }
            else if (txtOper.Text == "/")
            {
                Res = A / B;
            }
            else
            {
                Res = -999999999;
            }

            if (Res == -999999999)
            {
                lblRes.Text = "ERROR";
            }
            else
            {
                lblRes.Text = Res.ToString();
            }
        }
    }
}
