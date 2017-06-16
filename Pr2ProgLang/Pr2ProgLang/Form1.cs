using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr2ProgLang
{
    public partial class fmMain : Form
    {
        public int Iter = 0;
        public double SumS = 0;
        public double SumS2 = 0;
        public fmMain()
        {
            InitializeComponent();
        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
            Form dlgAbout = new HelpAboutForm();
            dlgAbout.ShowDialog();
        }

        private void Edit1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Edit2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Edit3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label m1;
            double a, b, s1, s2, h, x, eps;
            int i, j, n;
            double[] f = new double[1000];
            a = Convert.ToDouble(Edit1.Text);
            b = Convert.ToDouble(Edit2.Text);
            eps = Convert.ToDouble(Edit3.Text);
            s1 = 0.0; s2 = 0.0;
            n = 4;
            h = (b - a) / n;
            x = a + h/ 2;
            for (i = 1; i < n; i++)
            {
                f[i] = Math.Tan(0.1) * (x * x + Math.Sqrt((1 + 0.2 * x)));
                s1 = s1 + (h * Math.Abs(f[i]));
                x = x + h;
                Iter++;
                SumS = s1;
            }
        m1: n = n * 2;
            h = (b - a) / n;
            x = a + h/ 2;
            for (j = 1; j <= n; j++)
            {
                f[j] = (Math.Tan(0.1) * (x * x + Math.Sqrt((1 + 0.2 * x))));
                s2 = s2 + (h * Math.Abs(f[j]));
                x = x + h;
                Iter++;
                SumS2 = s2;
            }
            if (Math.Abs(s1 - s2) < eps) Edit4.Text = Convert.ToString(s2);
            else
            {
                s1 = s2; s2 = 0.0;
                goto m1;//
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit1.Text = "";
            Edit2.Text = "";
            Edit3.Text = "";
            Edit4.Text = "";
            EditIter.Text = "";
            EditS.Text = "";
            EditS2.Text = "";
        }

        private void btnIter_Click(object sender, EventArgs e)
        {
            EditIter.Text = Convert.ToString(Iter);
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            EditS.Text = SumS.ToString("F3");
        }

        private void btnS2_Click(object sender, EventArgs e)
        {
            EditS2.Text = SumS2.ToString("F3");
        }
    }
}
