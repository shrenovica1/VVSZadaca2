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
using System.Xml;
using System.Xml.Serialization;

namespace Aplikacija
{
    public partial class XmlUpolseniIz : Form
    {
        Fakultet fakss;
        public XmlUpolseniIz(ref Fakultet faks)
        {
            fakss = faks;   
            InitializeComponent();
        }

        private void XmlUpolseniIz_Load(object sender, EventArgs e)
        {

        }
        private void UcitajU(string s)
        {
            XmlTextReader citac = new XmlTextReader(s);
            XmlSerializer deserijalizacija = new XmlSerializer(typeof(List<Osoba>));
            FileStream str = new FileStream(s, FileMode.Open);
            fakss.Uposleni = (List<Osoba>)deserijalizacija.Deserialize(str);
            str.Close();

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
            /* XmlTextReader citac = new XmlTextReader(s);
             XmlSerializer deserijalizacija = new XmlSerializer(typeof(List<Osoba>));
             FileStream str = new FileStream(s, FileMode.Open);
             fakss.Uposleni = (List<Osoba>)deserijalizacija.Deserialize(str);
             str.Close();*/
            await Ucitaj(s);

            foreach (Osoba b in fakss.Uposleni)
            {
                listBox1.Items.Add(b);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
