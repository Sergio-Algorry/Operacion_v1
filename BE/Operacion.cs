using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Operacion
    {
        public int A { get; set; }
        public int B { get; set; }
        public decimal Res { get; set; } = 0;
        public string Oper { get; set; }


        //int A = System.Convert.ToInt32(textBox1.Text);
        //int B = System.Convert.ToInt32(textBox2.Text);
        //decimal Res = 0;


        public Operacion(int a, int b)
        {
            A = a;
            B = b;
        }

        public Operacion(string a, string b)
        {
            A=System.Convert.ToInt32(a);
            B=System.Convert.ToInt32(b);
        }

        public string Calcular(string oper)
        {
            string respuesta = "";
            if (oper == "+")
            {
                Res = A + B;
            }
            else if (oper == "-")
            {
                Res = A - B;
            }
            else if (oper == "*")
            {
                Res = A * B;
            }
            else if (oper == "/")
            {
                Res = A / B;
            }
            else
            {
                Res = -999999999;
            }

            if (Res == -999999999)
            {
                respuesta = "ERROR";
            }
            else
            {
                respuesta = Res.ToString();
            }


            return respuesta;
        }
    }
}
