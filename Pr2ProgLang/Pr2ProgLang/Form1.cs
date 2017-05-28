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
    }
}
