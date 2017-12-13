using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms;
using FakultetLibrary;
using Validacija17583;
using System.Runtime.Serialization.Formatters.Binary;

namespace Aplikacija
{
    public partial class UposleniIzBincs : Form
    {
        Fakultet faks;
        public UposleniIzBincs( ref Fakultet fakss)
        {
            faks = fakss;
            InitializeComponent();
        }
        private void UcitajU(String s)
        {
            List<Osoba> rtn1 = new List<Osoba>();
            FileStream fileStream1 = new FileStream(s, FileMode.Open);
            BinaryFormatter bf1 = new BinaryFormatter();
            faks.Uposleni = (List<Osoba>)bf1.Deserialize(fileStream1);
            fileStream1.Close();
        }
        private Task Ucitaj(string ime)
        {
            return Task.Factory.StartNew(() =>

            {
                UcitajU(ime);
            });
        }

        private async void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            DialogResult result = fd.ShowDialog();
            string s = (fd.FileName);
            await Ucitaj(s);   
            foreach (Osoba b in faks.Uposleni)
            {
                listBox1.Items.Add(b);
            }
            
        }

        private void UposleniIzBincs_Load(object sender, EventArgs e)
        {

        }
    }
}
