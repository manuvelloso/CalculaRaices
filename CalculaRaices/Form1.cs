using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaRaices
{
    public partial class Raices : Form
    {
        int A, B, C;
        Roots R1 = new Roots();
        Roots R2 = new Roots();

        public Raices()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_A.Text = "";
            txt_B.Text = "";
            txt_C.Text = "";
        }

        private string QuadraticEquation()
        {
            int B_abs = B;
            int C_abs = C;

            if (B < 0)
                B_abs = Math.Abs(B);
            if (C < 0)
                C_abs = Math.Abs(C);

            string equation ="";
            string quadratic = (A+ "x²").ToString();
            string linear = (B_abs+"x").ToString();
            string cte = C_abs.ToString();

            if (B == 0)
                equation = quadratic + " + " + cte;
            if (C == 0)
                equation = quadratic + " + " + linear;

            if (B == 0 && C < 0)
                if (equation.Contains('+'))
                    equation = equation.Replace('+', '-');

            if (C == 0 && B < 0)
                if (equation.Contains(" + "))
                    equation = equation.Replace(" + ", " - ");

            if (B < 0 && C < 0)
                equation = quadratic + " - " + linear + " - " + cte;
            else if (B > 0 && C < 0)
                equation = quadratic + " + " + linear + " - " + cte;
            else if (B > 0 && C > 0)
                equation = quadratic + " + " + linear + " + " + cte;
            else if (B < 0 && C > 0)
                equation = quadratic + " - " + linear + " + " + cte;

            return equation;
        }

        private void TryCalculation()
        {
            if (A == 0)
                throw new Exception("No es un polinomio cuadrático.");
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_A.Text, out _))
                A = int.Parse(txt_A.Text);
            else
                A = 0;

            if (int.TryParse(txt_B.Text, out _))
                B = int.Parse(txt_B.Text);
            else
                B = 0;

            if (int.TryParse(txt_C.Text, out _))
                C = int.Parse(txt_C.Text);
            else
                C = 0;

            try
            {
                TryCalculation();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                msg += "\nIngrese nuevas constantes.";

                MessageBox.Show(msg);

                return;
            }

            float D = (float)(Math.Pow(B, 2) - (4 * A * C));

            if (D == 0) 
            {
                R1.ent = -B / (2 * A);
                R2.ent = R1.ent;
                R1.img = 0;
                R2.img = 0;
                MessageBox.Show(QuadraticEquation() + "\nRaíz Doble:\nR1 = R2 = " + R1.ent);
            }
            else if( D> 0)
            {
                R1.ent = (float)(-B + Math.Sqrt(D)) / (2 * A);
                R1.img = 0;

                R2.ent = (float)(-B - Math.Sqrt(D)) / (2 * A);
                R2.img = 0;

                MessageBox.Show(QuadraticEquation() + "\nRaíces Simples:\nR1 = " + R1.ent+"\nR2 = "+ R2.ent);
            }
            else
            {
                R1.ent = (float)(-B / (2 * A));
                R1.img= (float)Math.Sqrt(-1*D) / (2 * A);

                R2.ent = (float)(-B / (2 * A));
                R2.img = (float)Math.Sqrt(-1 * D) / (2 * A);
               
                MessageBox.Show(QuadraticEquation() + "\nRaíces Complejas:\nR1 = " + R1.ent + "+ i" + R1.img +
                                                             "\nR2 = " + R2.ent+ "- i" + R2.img);
            }
        }
    }
}
