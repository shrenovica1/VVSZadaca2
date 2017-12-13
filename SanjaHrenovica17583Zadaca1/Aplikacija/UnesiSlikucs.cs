using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija
{
    public partial class UnesiSlikucs : UserControl
    {
        DateTime sad;
        DateTime slika;
        public UnesiSlikucs()
        {
           
            InitializeComponent();
            
        }

        private void UnesiSlikucs_Load(object sender, EventArgs e)
        {

        }

        private void buttonUcitaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            if (d.ShowDialog() == DialogResult.OK && !String.IsNullOrWhiteSpace(d.FileName))
            {
                pictureBoxSlika.Image = Image.FromFile(d.FileName);
            }

        }
        public Image dajSliku()
        {
            return pictureBoxSlika.Image;
        }
        public DateTime dajDatum() { return DateTime.Parse(dateTimePickerSlika.Text); }
        private void dateTimePickerSlika_ValueChanged(object sender, EventArgs e)
        {
           

        }

    }
}
