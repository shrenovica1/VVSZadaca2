using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using FakultetLibrary;
using Validacija17583;
using System.Runtime.Serialization.Formatters.Binary;

namespace Aplikacija
{
    public partial class UcitajPrikaziStudenteBin : Form
    {
        Fakultet faks;
        public UcitajPrikaziStudenteBin( ref Fakultet fakss)
        {
            InitializeComponent();
            faks = fakss;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UcitajPrikaziStudenteBin_Load(object sender, EventArgs e)
        {
           
        }
        private void UcitajS(string s)
        {
            List<Bachelor> rtn1 = new List<Bachelor>();
            FileStream fileStream1 = new FileStream(s, FileMode.Open);
            BinaryFormatter bf1 = new BinaryFormatter();
            faks.Studenti = (List<Bachelor>)bf1.Deserialize(fileStream1);
            fileStream1.Close();
        }
        private Task Ucitaj(string ime)
        {
            return Task.Factory.StartNew(() =>
            {
                UcitajS(ime);
            });
        }
        private async void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            DialogResult result = fd.ShowDialog();
            string s = (fd.FileName);
            await Ucitaj(s);
            foreach (Bachelor b in faks.Studenti)
            {
                listBox1.Items.Add(b);
            }
          
        }
    }
}
