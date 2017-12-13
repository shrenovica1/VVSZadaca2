using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FakultetLibrary;

namespace Aplikacija
{
    public partial class BrisanjeStudenta : Form
    {
        Fakultet fakul;
        string unos;
        public BrisanjeStudenta(ref Fakultet faks)
        {
            fakul = faks;
            InitializeComponent();
           
        }

        private void BrisanjeStudenta_Load(object sender, EventArgs e)
        {

        }

        private void buttonBrisanjeS_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Da li ste sigurni da želite izbirsati Studenta?", "Brisanje Studenta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes) fakul.BrisiStudetnta(unos);
        }

      
    }
}
