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
            BE.Operacion pepe = new BE.Operacion(txtA.Text, txtB.Text);
            lblRes.Text = pepe.Calcular(txtOper.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BE.Operacion pepito = new BE.Operacion(textBox3.Text, textBox2.Text);
            label1.Text = pepito.Calcular(textBox1.Text);

            //int A = System.Convert.ToInt32(txtA.Text);
            //int B = System.Convert.ToInt32(txtB.Text);
            //decimal Res = 0;

            //if (oper == "+")
            //{
            //    Res = A + B;
            //}
            //else if (oper == "-")
            //{
            //    Res = A - B;
            //}
            //else if (oper == "*")
            //{
            //    Res = A * B;
            //}
            //else if (oper == "/")
            //{
            //    Res = A / B;
            //}
            //else
            //{
            //    Res = -999999999;
            //}

            //if (Res == -999999999)
            //{
            //    lblRes.Text = "ERROR";
            //}
            //else
            //{
            //    lblRes.Text = Res.ToString();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BE.Operacion pepito = new BE.Operacion(10, 20);
            label1.Text = pepito.Calcular("*");

        }
    }
}
