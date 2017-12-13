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
    public partial class Pregled : Form
    {
        Fakultet faks;
        public Pregled(ref Fakultet f)
        {
            InitializeComponent();
            faks = f;
        }

        private void Pregled_Load(object sender, EventArgs e)
        {
         //  if( treeViewpregled.NodeMouseClick
        }

        private void treeViewpregled_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
               
        }

        private void treeViewpregled_DoubleClick(object sender, EventArgs e)
        {
            listBoxpregled.Items.Clear();
            if (treeViewpregled.Nodes[0].IsSelected) {
                foreach (Osoba o in faks.dajListuUposlenih())
                    listBoxpregled.Items.Add(o.DajIme() + " " + o.dajPrezime()+" "+o.dajKorisnickoIme()+" "+o.dajLozinku()+" "+o.dajSifru());
                    }
            else if(treeViewpregled.Nodes[1].IsSelected) {
                foreach (Predmeti o in faks.dajListuPredmeta())
                    listBoxpregled.Items.Add(o.DajNazivPredmeta()+" "+o.dajSifruPredmeta());
            }
            else if (treeViewpregled.Nodes[2].IsSelected)
            {
                foreach (Bachelor o in faks.dajListuStudenata())
                    listBoxpregled.Items.Add(o.DajIme() + " " + o.dajPrezime() +" "+o.DajBrojIndexa()+ " " + o.dajKorisnickoIme() + " " + o.dajLozinku());
            }
            
        }

        private void Pregled_FormClosed(object sender, FormClosedEventArgs e)
        {
            //e.Cancel = true;
        }

        private void Pregled_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
