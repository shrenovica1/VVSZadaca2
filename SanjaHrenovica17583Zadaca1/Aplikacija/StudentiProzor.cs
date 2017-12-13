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
    public partial class StudentiProzor : Form
    {
        Fakultet fakss;
        string ime;
        TreeNode cvor;
        TreeNode[] predmeti; //= new TreeNode[pred.Count()];
        TreeNode[] Aktivnipred;
        System.Collections.Generic.List<Predmeti> Arhivapred = new System.Collections.Generic.List<Predmeti>();
        System.Collections.Generic.List<Predmeti> Aktivni = new System.Collections.Generic.List<Predmeti>();
        public StudentiProzor( ref Fakultet faks, string kime)
        {
            fakss = faks;
            ime = kime;
            
            InitializeComponent();
            

        }

        private void Studenti_Load(object sender, EventArgs e)
        {
            int i = 0;
            Arhivapred = fakss.spisakPPredmeta(ime);
            Aktivni = fakss.aktivniPredmeti(ime);
           predmeti = new TreeNode[Arhivapred.Count()];
           Aktivnipred = new TreeNode[Aktivni.Count()];
            //label2.Text = "";
            //linkLabelprijava.Visible = false;
            //linkLabelodjava.Visible = false;

            treeViewp.Nodes.Add("Aktuelni predmeti");
            treeViewp.Nodes.Add("Arhivirani predmeti");
            
            foreach (Predmeti p in Arhivapred)
            {
                treeViewp.Nodes[1].Nodes.Add(p.DajNazivPredmeta());
               
            }
            
            foreach (Predmeti p in Aktivni)
            {
                treeViewp.Nodes[0].Nodes.Add(p.DajNazivPredmeta());
               
            }

        }

        private void treeViewp_AfterSelect(object sender, TreeViewEventArgs e)
        {

           
        }

        private void treeViewp_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void comboBoxPpredmetiP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPpredmetiP_Click(object sender, EventArgs e)
        {
            comboBoxPpredmetiP.Items.Clear();
            foreach (Predmeti p in fakss.dajListuPredmeta()) comboBoxPpredmetiP.Items.Add(p.DajNazivPredmeta());

        }

        private void comboBoxO_Click(object sender, EventArgs e)
        {
            comboBoxO.Items.Clear();
            foreach (Predmeti p in fakss.dajListuPredmeta()) comboBoxO.Items.Add(p.DajNazivPredmeta());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void buttonPrijavi_Click(object sender, EventArgs e)
        {
            foreach (Predmeti p in fakss.dajListuPredmeta())
            {
                if (p.DajNazivPredmeta() == comboBoxPpredmetiP.Text && Aktivni.Contains(p)==false) treeViewp.Nodes[0].Nodes.Add(p.DajNazivPredmeta());
              
            }
         
        }

        private void buttonOdjavise_Click(object sender, EventArgs e)
        {
            foreach (Predmeti p in fakss.dajListuPredmeta())
            {
                if (p.DajNazivPredmeta() == comboBoxPpredmetiP.Text)
                {    
                            fakss.ukloniPredmet(comboBoxPpredmetiP.Text, ime);
                            Aktivni.Remove(p);
                      
                }
            }
            

        }



    }
}
