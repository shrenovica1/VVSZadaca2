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
using Validacija17583;
using System.Xml;
using System.Threading;

namespace Aplikacija
{
    public partial class PretrzaiPoImenu : Form
    {
        Fakultet faks;

        public int ParallelThreads { get; private set; }

        public PretrzaiPoImenu( ref Fakultet fakss)
        {
           faks = fakss;
            InitializeComponent();
        }

        List<Bachelor> ls;
        List<Osoba> lu;
        void PretragaStudenti()
        {
            ls = faks.dajListuStudenata();
        }
        void PretragaUposleni()
        {
            lu = faks.dajListuUposlenih();
        }
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Parallel.Invoke(

                () => PretragaStudenti(),
                () => PretragaUposleni()
                );
            foreach (Bachelor b in ls)
            { 
                if(b.DajIme().Contains(textBox2.Text))listBox1.Items.Add(b.DajIme());
            }
            foreach (Osoba b in lu)
            {
                if (b.DajIme().Contains(textBox2.Text)) listBox2.Items.Add(b.DajIme());
            }
            if (textBox2.Text == "")
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PretrzaiPoImenu_Load(object sender, EventArgs e)
        {

        }
    }
}
