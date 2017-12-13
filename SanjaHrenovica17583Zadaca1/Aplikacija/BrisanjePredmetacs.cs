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
    public partial class BrisanjePredmetacs : Form
    {
        Fakultet fakss;
        public BrisanjePredmetacs(ref Fakultet faks)
        {
           
            fakss=faks;
            InitializeComponent();
        }

        private void BrisanjePredmetacs_Load(object sender, EventArgs e)
        {
          
        }

        private void buttonBrisiPredmet_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr=MessageBox.Show("Da li ste sigurni da želite izbirsati predmet?","Brisanje Predmeta", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
            
            if(dr==DialogResult.Yes) fakss.BrisiPredmet(textBoxBrisiPredmet.Text);
        }
    }
}
