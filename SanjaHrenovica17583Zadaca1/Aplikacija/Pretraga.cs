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
    public partial class Pretraga : Form
    {
        Fakultet faks;
        public Pretraga(ref Fakultet f)
        {
            faks = f;
            InitializeComponent();
        }

        private void Pretraga_Load(object sender, EventArgs e)
        {

            

        }

       

        private void listBoxpret_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBoxZaunosPretrage.TextLength == 0) listBoxpret.Items.Clear();
        }

        private void textBoxZaunosPretrage_TextChanged(object sender, EventArgs e)
        {
            listBoxpret.Items.Clear();
            foreach (string s in faks.PretraziSve(textBoxZaunosPretrage.Text))
            {
                if(textBoxZaunosPretrage.TextLength==0) listBoxpret.Items.Clear();
               // if (listBoxpret.Items.Contains(s)==false)
                    listBoxpret.Items.Add(s);
            }
            if (textBoxZaunosPretrage.TextLength == 0) listBoxpret.Items.Clear();

        }
    }
}
