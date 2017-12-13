using FakultetLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Aplikacija
{
    public partial class BrisanjeUposlenika : Form
    {
        Fakultet fakss;
        public BrisanjeUposlenika(ref Fakultet faks)
        {
            fakss = faks;
            InitializeComponent();
        }

        private void BrisanjeUposlenika_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           /*if (checkBox1.Checked==true && checkBox2.Checked==false) fakss.BrisiUposlenog(textBoxBuI.Text);
            else if (checkBox1.Checked == false && checkBox2.Checked == true) fakss.BrisiUposlenog(Convert.ToInt32(textBoxBuS.Text));
            else if(checkBox1.Checked == true && checkBox2.Checked == true)
            {
                fakss.BrisiUposlenog(textBoxBuI.Text);
                fakss.BrisiUposlenog(Convert.ToInt32(textBoxBuS.Text));
            }*/
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonBrisanjeU_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Da li ste sigurni da želite izbirsati uposlenika?", "Brisanje uposlenika", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes && checkBox1.Checked == true && checkBox2.Checked == false) fakss.BrisiUposlenog(textBoxBuI.Text);
            else if(dr==DialogResult.Yes && checkBox1.Checked == false && checkBox2.Checked == true) fakss.BrisiUposlenog(Convert.ToInt32(textBoxBuS.Text));
            else if (dr == DialogResult.Yes && checkBox1.Checked == true && checkBox2.Checked == true)
            {
                fakss.BrisiUposlenog(textBoxBuI.Text);
                fakss.BrisiUposlenog(Convert.ToInt32(textBoxBuS.Text));
            }

        }
    }
}
