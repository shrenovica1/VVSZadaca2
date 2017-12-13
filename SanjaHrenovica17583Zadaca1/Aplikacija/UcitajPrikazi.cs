using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Xml.Serialization;
using System.IO;
using System.Xml.XPath;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FakultetLibrary;
using Validacija17583;
using System.Xml;

namespace Aplikacija
{
    public partial class UcitajPrikazi : Form
    {
        Fakultet fakss;
        public UcitajPrikazi( ref Fakultet f)
        {
            fakss = f;
            InitializeComponent();
        }

        private void UcitajPrikazi_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*
             * Serializer deserijalizacija = new XmlSerializer(typeof(List<Bachelor>));
            FileStream lcitac = new FileStream(datoteka, FileMode.Open);
            Studenti = (List<Bachelor>)deserijalizacija.Deserialize(lcitac);
            lcitac.Close();*/
            OpenFileDialog fd = new OpenFileDialog();
            DialogResult result = fd.ShowDialog();
            string s = (fd.FileName);
            XmlTextReader citac = new XmlTextReader(s);
            XmlSerializer deserijalizacija = new XmlSerializer(typeof(List<Bachelor>));
            FileStream str = new FileStream(s, FileMode.Open);
            fakss.Studenti = (List<Bachelor>)deserijalizacija.Deserialize(str);
            str.Close();
            citac.Close();
            listBox1.HorizontalScrollbar = true;
            foreach(Bachelor b in fakss.Studenti)
            {
                listBox1.Items.Add(b);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
