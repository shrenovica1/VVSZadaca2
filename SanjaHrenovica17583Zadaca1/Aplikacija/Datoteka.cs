using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija
{
    public partial class Datoteka : Form
    {
        public Datoteka()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            FileDialog dat= new OpenFileDialog();
            dat.ShowDialog();

            DialogResult result = new DialogResult(); 
                result = ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                //string file = openFileDialog1.FileName;
                
                  //  string text = File.ReadAllText(file);
                   // size = text.Length;
                
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
