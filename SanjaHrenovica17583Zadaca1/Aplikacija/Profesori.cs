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
    public partial class Profesori : Form
    {
        //Form1 f= new Form1();
        Fakultet faks;
        Predmeti p;
        List<NastavnoOsoblje> ansamblPredmeta = new List<NastavnoOsoblje>();
        public Profesori(ref Fakultet f, ref Predmeti pr)
        {
            InitializeComponent();
            faks = f;
            p = pr;
           
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void Profesori_Load(object sender, EventArgs e)
        {
            int i = 0;
            ansamblPredmeta = faks.dajNastavniAnsambl(p);
            TreeNode ans;
            TreeNode[] lista = new TreeNode[ansamblPredmeta.Count()];
            foreach (NastavnoOsoblje n in ansamblPredmeta)
            {
                lista[i] = new TreeNode(n.DajIme() + " " + n.dajPrezime());
                i++;
            }
            ans = new TreeNode("Ansambl", lista);
            treeView1.Nodes.Add(ans);
            labeltextetcs.Text = Convert.ToString(p.BrETCS());
            labeltextp.Text = Convert.ToString(p.BrojPredavanja);
            labeltextv.Text = Convert.ToString(p.BrojVjezbi);
            labelbsText.Text = Convert.ToString(p.BrojStudenata);
        }

        private void labeltextetcs_Click(object sender, EventArgs e)
        {
           
        }

        private void labeltextp_Click(object sender, EventArgs e)
        {

        }

        private void labeltextv_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelodjava_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void labelbsText_Click(object sender, EventArgs e)
        {

        }
    }
}
