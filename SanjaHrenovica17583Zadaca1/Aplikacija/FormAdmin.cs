using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Xml.Serialization;
using System.IO;
using System.Xml.XPath;
using System.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FakultetLibrary;
using Validacija17583;
using System.Runtime.Serialization.Formatters.Binary;

namespace Aplikacija
{
    public partial class FormAdmin : Form
    {

        Form1 pocetna;
        Fakultet fakss;
      
    
       
        public FormAdmin(ref Fakultet faks)
        {
            
           
         
          
            fakss = faks;
            InitializeComponent();
            groupBoxBach.Visible = false;
            groupBoxPs.Visible = false;
            labelindex.Visible = false;
            labelmjesto.Visible = false;
            textBoxindex.Visible = false;
            textBoxmjesto.Visible = false;
            groupBoxOsobnip.Visible = false;
            groupBoxKvalifikacije.Visible = false;
            dateTimePickerdi.Visible = false;
            labelDI.Visible = false;
            labelDP.Visible = false;
            dateTimePickerdv.Visible = false;
            labelPredmet.Visible = false;
            textBoxPredmet.Visible = false;
            groupBoxPeedmetiS.Visible = false;
            labelAzST.Visible = false;
            textBoxAzSt.Visible = false;
            buttonAzuriranje.Visible=false;
            labelAzUp.Visible = false;
            textBoxAzUp.Visible = false;
            labelAzP.Visible = false;
            textBoxAzP.Visible=false;

        }
        private void pretražiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pretraga formica = new Pretraga(ref fakss);
            formica.Show();

            //formica.Activate();
         
        }

        private void textBoxImeS_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBoxCiklus_Enter(object sender, EventArgs e)
        {
            if (radioButtonBach.Checked) {

                groupBoxBach.Visible=true;
                groupBoxPs.Visible = true;
                labelindex.Visible = false;
                labelmjesto.Visible = false;
                textBoxindex.Visible = false;
                textBoxmjesto.Visible = false;
                groupBoxPeedmetiS.Visible = true;
           
            }
            else if (radioButtonMaster.Checked)
            {
                groupBoxBach.Visible = true;
                groupBoxPs.Visible = true;
                labelindex.Visible = true;
                labelmjesto.Visible = true;
                textBoxindex.Visible = true;
                textBoxmjesto.Visible = true;
                groupBoxPeedmetiS.Visible = true;
            }



        }
        private void groupBoxStatus_Enter(object sender, EventArgs e)
        {
            if (radioButtonNast.Checked) {
                groupBoxKvalifikacije.Visible = true;
                groupBoxOsobnip.Visible = true;
                textBoxPredmet.Visible = true;
                labelPredmet.Visible = true;
                dateTimePickerdi.Visible = false;
                labelDI.Visible = false;
                labelDP.Visible = false;
                dateTimePickerdv.Visible = false;
            }
            else if (radioButtonNNast.Checked)
            {
                groupBoxKvalifikacije.Visible = true;
                groupBoxOsobnip.Visible = true;
                textBoxPredmet.Visible = false;
                labelPredmet.Visible = false;
                dateTimePickerdi.Visible = false;
                labelDI.Visible = false;
                labelDP.Visible = false;
                dateTimePickerdv.Visible = false;

            }
            else if (radioButtonPz.Checked)
            {
                groupBoxKvalifikacije.Visible = true;
                groupBoxOsobnip.Visible = true;
                textBoxPredmet.Visible = false;
                labelPredmet.Visible = false;
                dateTimePickerdi.Visible = true;
                labelDI.Visible = true;
                labelDP.Visible = true;
                dateTimePickerdv.Visible = true;
            }
        }
       private string GenerisiKI(string ime, string prezime)
        {
            return ime.Substring(0, 1) + prezime;
        }
        private string GenerisiLozinku(string ime, string prezime)
        {
            return ime.Substring(0, 1) + prezime.Substring(0, 2);

        }
        private void buttonRegistr_Click(object sender, EventArgs e)
        {
            string ime = Convert.ToString(textBoxImeS.Text);
            string prezime = Convert.ToString(textBoxPrezimeS.Text);
            string jmbg = Convert.ToString(textBoxJmbgS.Text);
            string datum = Convert.ToString(dateTimePickerdr.Text);
            string dzpo = Convert.ToString(dateTimePickerdzpo.Text);
            string mjesto = Convert.ToString(textBoxmjesto.Text);
            string index = Convert.ToString(textBoxindex.Text);
            string pass = "pw";// ime.Substring(0, 2);
            string korIm = "ss";//ime.Substring(0, 1) + prezime;
            
            if (radioButtonBach.Checked && tabControlRS.SelectedTab == tabPageRS && toolStripStatusLabel1.Text != "Neispravan unos!")
            {
            //   XmlDocument dokument = new XmlDocument();
              //  dokument.Load(@"c:\Desktop\St.xml");
                pass = GenerisiLozinku(ime, prezime);
                korIm = GenerisiKI(ime, prezime);
                fakss.RegistrujStudenta(ime, prezime, DateTime.Parse(datum), jmbg, DateTime.Parse(dzpo), korIm, pass);
               // fakss.ucitajUdatoteku(fakss.dajStudenta(), "Studenti");
                fakss.dajStudenta().dodajSliku(unesiSlikucs1.dajSliku());
                MessageBox.Show("Negovo korisnicko ime i lozinka su:"  + korIm + " " + pass,"Uspješno ste registrovali studenta!", MessageBoxButtons.OK);
                
            }
            else if (radioButtonMaster.Checked && tabControlRS.SelectedTab == tabPageRS && toolStripStatusLabel1.Text != "Neispravan unos!")
            {
                pass = GenerisiLozinku(ime, prezime);
                korIm = GenerisiKI(ime, prezime);
                fakss.RegistrujStudenta(ime, prezime, DateTime.Parse(datum), jmbg, DateTime.Parse(dzpo), Convert.ToInt32(index), mjesto, korIm, pass);
                fakss.dajStudenta().dodajSliku(unesiSlikucs1.dajSliku());
                MessageBox.Show("Njegovo korisnicko ime i lozinka su: " + korIm + " " + pass, "Uspješno ste registrovali studenta!", MessageBoxButtons.OK);
            }
            else if (tabControlRS.SelectedTab == tabPageRP)
            {
                int brojVjezbi = Convert.ToInt32(textBoxBv.Text);
                int brojPredavanja = Convert.ToInt32(textBoxBp.Text);
                int brojStudenata = Convert.ToInt32(textBoxBs.Text);
                int brojEtcs = Convert.ToInt32(textBoxetcs.Text);
                string naziv = textBoxNaziv.Text;
                string studij = textBoxStudij.Text;
                string opis = richTextBox1.Text;
                fakss.RegistrujPredmet(naziv, brojVjezbi, brojPredavanja, brojStudenata, brojEtcs, opis, studij);
                MessageBox.Show("Njegova šifra je: " + Convert.ToString(fakss.dajPredmet().dajSifruPredmeta()) , "Uspješno ste registrovali predmet!", MessageBoxButtons.OK);
            }
           

            else if (radioButtonNast.Checked && tabControlRS.SelectedTab == tabPageRU && toolStripStatusLabel1.Text != "Neispravan unos!")
            {
               
                string imez = Convert.ToString(textBoxImeZ.Text);
                string prezimez = Convert.ToString(textBoxPrezZ.Text);
                string jmbgz = Convert.ToString(textBoxJmbgZ.Text);
                string datumz = Convert.ToString(dateTimePickerdrz.Text);
                string sSprema = textBoxss.Text;
                string titula = textBoxt.Text;
                string pozicija = textBoxp.Text;
                string plata = textBox4iznosp.Text;
                string predmet = textBoxPredmet.Text;
                pass = GenerisiLozinku(imez, prezimez);
                korIm = GenerisiKI(imez, prezimez);
                fakss.RegistrujUposlenogNastavnoO(imez, prezimez, DateTime.Parse(datumz), jmbgz, pozicija, sSprema, titula, Convert.ToDecimal(plata), korIm,pass );
                fakss.dajUposlenog().dodajSliku(unesiSlikucs1.dajSliku());
                MessageBox.Show("Njegovo korisnicko ime i lozinka su: " + korIm + " " + pass+"\nNjegova šifra je: "+ Convert.ToString(fakss.dajUposlenog().dajSifru()), "Uspješno ste registrovali uposlenika!", MessageBoxButtons.OK);
            }
            else if (radioButtonNNast.Checked && tabControlRS.SelectedTab == tabPageRU && toolStripStatusLabel1.Text != "Neispravan unos")
            {
                string imez = Convert.ToString(textBoxImeZ.Text);
                string prezimez = Convert.ToString(textBoxPrezZ.Text);
                string jmbgz = Convert.ToString(textBoxJmbgZ.Text);
                string datumz = Convert.ToString(dateTimePickerdrz.Text);
                string sSprema = textBoxss.Text;
                string titula = textBoxt.Text;
                string pozicija = textBoxp.Text;
                string plata = textBox4iznosp.Text;
                //string predmet = textBoxPredmet.Text;
                fakss.RegistrujUposlenogNenastavnoO(imez, prezimez, DateTime.Parse(datumz), jmbgz, pozicija, sSprema, titula, Convert.ToDecimal(plata));

            }
            else if (radioButtonPz.Checked && tabControlRS.SelectedTab == tabPageRU && toolStripStatusLabel1.Text != "Neispravan unos")
            {
                string imez = Convert.ToString(textBoxImeZ.Text);
                string prezimez = Convert.ToString(textBoxPrezZ.Text);
                string jmbgz = Convert.ToString(textBoxJmbgZ.Text);
                string datumz = Convert.ToString(dateTimePickerdrz.Text);
                string sSprema = textBoxss.Text;
                string titula = textBoxt.Text;
                string pozicija = textBoxp.Text;
                string plata = textBox4iznosp.Text;
                string predmet = textBoxPredmet.Text;
                string di = dateTimePickerdi.Text;
                string dv = dateTimePickerdv.Text;
                fakss.RegistrujUposlenogPrivremeno(imez, prezimez, DateTime.Parse(datumz), jmbgz, pozicija, sSprema, titula, Convert.ToDecimal(plata), DateTime.Parse(dv), DateTime.Parse(di));
            }
        }

        private void tabPageRP_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPageRU_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxBach_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {

        }

        private void buttonUcitajUpos_Click(object sender, EventArgs e)
        {

        }

        private void studentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrisanjeStudenta brisiS = new BrisanjeStudenta(ref fakss);
            //  brisiS.Select();
            brisiS.Show();
            //brisiS.Activate();
        }

        private void uposlenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrisanjeUposlenika brisiU = new BrisanjeUposlenika(ref fakss);
            brisiU.Show();
        }

        private void predmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrisanjePredmetacs brisiP = new BrisanjePredmetacs(ref fakss);
            brisiP.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxUpos_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxUpos_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void pregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pregled preg = new Pregled(ref fakss);
            preg.Show(); preg.Activate();
           

        }

        private void textBoxImeS_Validated(object sender, EventArgs e)
        {
            if (textBoxImeS.Text == "")
            {
                errorProvider1.SetError(textBoxImeS, "Neisparavan unos!");
                toolStripStatusLabel1.Text = "Neispravan unos!";
            }
            if (textBoxPrezimeS.Text == "")
            {
                
                    errorProvider1.SetError(textBoxPrezimeS, "Neisparavan unos!");
                    toolStripStatusLabel1.Text = "Neispravan unos!";
             }
            else if(radioButtonMaster.Checked && textBoxmjesto.Text == "") {
                errorProvider1.SetError(textBoxmjesto, "Neisparavan unos!");
                toolStripStatusLabel1.Text = "Neispravan unos!";
            }
            else if (radioButtonMaster.Checked && textBoxindex.Text == "")
            {
                errorProvider1.SetError(textBoxindex, "Neisparavan unos!");
                toolStripStatusLabel1.Text = "Neispravan unos!";
            }

            /* if (validacija.ValidacijaJmbgDatum(Convert.ToDateTime(textBoxJmbgS.Text)) == false
                       || validacija.ValidacijaMaticnogBroja(textBoxJmbgS.Text) == false || validacija.ValidacijaMbr(textBoxJmbgS.Text) == false ||
                       validacija.ValidacijaJedinstvenosti(textBoxJmbgS.Text) == false)

             {
                 errorProvider1.SetError(textBoxImeS, "Niste unijeli prezime studenta");
                 toolStripStatusLabel1.Text = "Niste unijeli prezime studenta";
             }
             */
            //validacija.ValidacijaMaticnogBroja(textBoxJmbgS.Text) == false ||
           else if (textBoxJmbgS.Text == "")
            {
                errorProvider1.SetError(textBoxJmbgS, "Neispravan unos!");
                toolStripStatusLabel1.Text = "Neispravan unos!";
            }
            else if (textBoxJmbgS.Text!="" &&  (validacija.ValidacijaMbr(textBoxJmbgS.Text) == false ||
                  validacija.ValidacijaJedinstvenosti(textBoxJmbgS.Text) == false))
            {
                errorProvider1.SetError(textBoxJmbgS, "Neispravan unos!");
                toolStripStatusLabel1.Text = "Neispravan unos!";
            }

        }

        private void textBoxImeS_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            toolStripStatusLabel1.Text = "";
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBoxdodajp_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* comboBoxdodajp.Items.Clear();
            foreach (Predmeti p in fakss.dajListuPredmeta())
                comboBoxdodajp.Items.Add(p.DajNazivPredmeta());*/
        }

        private void comboBoxdodajp_Click(object sender, EventArgs e)
        {
            comboBoxdodajp.Items.Clear();
            foreach (Predmeti p in fakss.dajListuPredmeta())
                comboBoxdodajp.Items.Add(p.DajNazivPredmeta());
            
        }

        private void dateTimePickerdr_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttondodajPred_Click(object sender, EventArgs e)
        {
            foreach (Predmeti p in fakss.dajListuPredmeta())
            {
                if (p.DajNazivPredmeta() == comboBoxdodajp.Text) fakss.dajStudenta().DodajAktivniPredmet(p);
            }
        }

        private void buttondodajPpred_Click(object sender, EventArgs e)
        {
            foreach (Predmeti p in fakss.dajListuPredmeta())
            {
                if (p.DajNazivPredmeta() == comboBoxdodajp.Text) fakss.dajStudenta().DodajPredmet(p);
            }
        }

        private void textBoxJmbgS_Validated(object sender, EventArgs e)
         {

        }

        private void textBoxJmbgS_Validating(object sender, CancelEventArgs e)
        {

            errorProvider1.Clear();
            toolStripStatusLabel1.Text = "";
        }

        private void textBoxImeZ_Validated(object sender, EventArgs e)
        {
            if (textBoxImeZ.Text == "")
            {
                errorProvider1.SetError(textBoxImeZ, "Neisparavan unos!");
                toolStripStatusLabel1.Text = "Neispravan unos!";
            }
            if  (textBoxPrezZ.Text=="")
            {
                errorProvider1.SetError(textBoxPrezZ, "Neisparavan unos!");
                toolStripStatusLabel1.Text = "Neispravan unos!";
            }
            if (textBoxJmbgZ.Text == "")
            {
                errorProvider1.SetError(textBoxJmbgZ, "Neisparavan unos!");
                toolStripStatusLabel1.Text = "Neispravan unos!";
            }
            if(textBoxPredmet.Text=="")
            {
                errorProvider1.SetError(textBoxPredmet, "Neisparavan unos!");
                toolStripStatusLabel1.Text = "Neispravan unos!";
            }
            if(textBoxss.Text=="")
            {
                errorProvider1.SetError(textBoxss, "Neisparavan unos!");
                toolStripStatusLabel1.Text = "Neispravan unos!";
            }
            if (textBoxp.Text == "")
            {
                errorProvider1.SetError(textBoxp, "Neisparavan unos!");
                toolStripStatusLabel1.Text = "Neispravan unos!";
            }
            if (textBoxt.Text == "")
            {
                errorProvider1.SetError(textBoxt, "Neisparavan unos!");
                toolStripStatusLabel1.Text = "Neispravan unos!";
            }
            
            if (textBox4iznosp.Text == "")
            {
                errorProvider1.SetError(textBox4iznosp, "Neisparavan unos!");
                toolStripStatusLabel1.Text = "Neispravan unos!";
            }

        }

        private void textBoxImeZ_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            toolStripStatusLabel1.Text = "";
        }

        private void textBoxNaziv_Validated(object sender, EventArgs e)
        {
            if (textBoxNaziv.Text == "")
            {
                errorProvider1.SetError(textBoxNaziv, "Neisparavan unos!");
                toolStripStatusLabel1.Text = "Neispravan unos!";
            }
            if (textBoxBp.Text == "")
            {
                errorProvider1.SetError(textBoxBp, "Neisparavan unos!");
                toolStripStatusLabel1.Text = "Neispravan unos!";
            }
            if (textBoxBv.Text == "")
            {
                errorProvider1.SetError(textBoxBv, "Neisparavan unos!");
                toolStripStatusLabel1.Text = "Neispravan unos!";
            }
            if (textBoxBs.Text == "")
            {
                errorProvider1.SetError(textBoxBs, "Neisparavan unos!");
                toolStripStatusLabel1.Text = "Neispravan unos!";
            }
            if (textBoxStudij.Text == "")
            {
                errorProvider1.SetError(textBoxStudij, "Neisparavan unos!");
                toolStripStatusLabel1.Text = "Neispravan unos!";
            }
            if (textBoxetcs.Text == "")
            {
                errorProvider1.SetError(textBoxetcs, "Neisparavan unos!");
                toolStripStatusLabel1.Text = "Neispravan unos!";
            }
            if (richTextBox1.Text == "")
            {
                errorProvider1.SetError(richTextBox1, "Neisparavan unos!");
                toolStripStatusLabel1.Text = "Neispravan unos!";
            }
        }

        private void textBoxNaziv_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            toolStripStatusLabel1.Text = "";
        }

        private void comboBoxdodajpolozeni_Click(object sender, EventArgs e)
        {
            comboBoxdodajpolozeni.Items.Clear();
            foreach (Predmeti p in fakss.dajListuPredmeta())
                comboBoxdodajpolozeni.Items.Add(p.DajNazivPredmeta());

        }

        private void linkLabelOdjava_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItemAzuriraj_Click(object sender, EventArgs e)
        {
            if (tabControlRS.SelectedTab == tabPageRS)
            {
                labelAzST.Visible = true;
                textBoxAzSt.Visible = true;
                buttonAzuriranje.Visible = true;
                foreach (Bachelor b in fakss.dajListuStudenata())
                {
                    if (b.DajBrojIndexa() == textBoxAzSt.Text)
                    {
                        textBoxImeS.Text = b.DajIme();
                        textBoxPrezimeS.Text = b.dajPrezime();
                        textBoxJmbgS.Text = b.DajMaticniBroj();
                        dateTimePickerdr.Text = b.dajDatum();
                        //dateTimePickerdzpo.Text
                        textBoxmjesto.Text = "Sarajevo";
                       

                    }
                }
            }
            else if (tabControlRS.SelectedTab == tabPageRU)
            {
                labelAzUp.Visible = true;
                textBoxAzUp.Visible = true;
                buttonAzuriranje.Visible = true;
                foreach (Osoba b in fakss.dajListuUposlenih())
                {
                    if (b.dajSifru() == textBoxAzUp.Text)
                    {
                        textBoxImeZ.Text = b.DajIme();
                        textBoxPrezZ.Text = b.dajPrezime();
                        textBoxJmbgZ.Text = b.DajMaticniBroj();
                        dateTimePickerdrz.Text = b.dajDatum();
                        textBoxss.Text = b.dajStrucnu();
                        textBoxt.Text = b.dajTitulu();
                        textBoxp.Text = b.dajPoziciju();
                        textBox4iznosp.Text = b.dajIznosPlate();

                        //dateTimePickerdzpo.Text
                        //textBoxmjesto.Text = "Sarajevo";
                        //textBoxindex.TextChanged

                    }
                }
            }
            else if (tabControlRS.SelectedTab == tabPageRP)
            {
                textBoxAzP.Visible = true;
                labelAzP.Visible = true;
                buttonAzuriranje.Visible = true;
                foreach (Predmeti p in fakss.dajListuPredmeta())
                {
                    if (Convert.ToString(p.dajSifruPredmeta()) == textBoxAzP.Text)
                    {
                        textBoxNaziv.Text = p.DajNazivPredmeta();
                        textBoxBp.Text = Convert.ToString(p.brPredavanja());
                        textBoxBv.Text = Convert.ToString(p.brVjezbi());
                        textBoxBs.Text = Convert.ToString(p.brStudenata());
                        textBoxetcs.Text = Convert.ToString(p.brETCS());
                        richTextBox1.Text = p.dajOpis();
                    }
                }
            }
            }

        private void textBoxAzSt_TextChanged(object sender, EventArgs e)
        {
            foreach (Bachelor b in fakss.dajListuStudenata())
            {
                if (b.DajBrojIndexa() == textBoxAzSt.Text)
                {
                    textBoxImeS.Text = b.DajIme();
                    textBoxPrezimeS.Text = b.dajPrezime();
                    textBoxJmbgS.Text = b.DajMaticniBroj();
                    dateTimePickerdr.Text = b.dajDatum();
                    //dateTimePickerdzpo.Text
                    textBoxmjesto.Text = b.dajMjesto();
                    textBoxindex.Text = b.DajBrojIndexa();

                }
            }
            /*foreach (Master m in fakss.dajListuStudenata())
            {
                if (m.DajBrojIndexa() == textBoxAzSt.Text)
                {
                    textBoxImeS.Text = m.DajIme();
                    textBoxPrezimeS.Text = m.dajPrezime();
                    textBoxJmbgS.Text = m.DajMaticniBroj();
                    //dateTimePickerdr.Text=
                    //dateTimePickerdzpo.Text
                    textBoxmjesto.Text = m.dajMjesto();
                    textBoxindex.Text = m.DajBrojIndexa();

                }
            }*/
        }

        private void buttonAzuriranje_Click(object sender, EventArgs e)
        {
            foreach (Bachelor b in fakss.dajListuStudenata())
            {
                if (b.DajBrojIndexa() == textBoxAzSt.Text)
                {
                    b.Ime = textBoxImeS.Text;
                    b.Prezime = textBoxPrezimeS.Text;
                    b.Jmbg =textBoxJmbgS.Text;
                    b.DatumRodjenja = DateTime.Parse(dateTimePickerdr.Text);
                    //dateTimePickerdzpo.Text
                  // b.Mjesto=textBoxmjesto.Text;
                   // textBoxindex.Text = b.DajBrojIndexa();

                }
            }
           /* foreach (Master m in fakss.dajListuStudenata())
            {
                if (m.DajBrojIndexa() == textBoxAzSt.Text)
                {
                    m.Ime = textBoxImeS.Text;
                    m.Prezime = textBoxPrezimeS.Text;
                    m.Jmbg = textBoxJmbgS.Text;
                    //dateTimePickerdr.Text=
                    //dateTimePickerdzpo.Text
                    m.Mjesto = textBoxmjesto.Text;
                    m.Index = Convert.ToInt32(textBoxindex.Text);

                }
            }*/

            labelAzST.Visible = false;
            textBoxAzSt.Visible = false;
            labelAzUp.Visible = false;
            textBoxAzUp.Visible = false;
            labelAzP.Visible = false;
            textBoxAzP.Visible = false;
            buttonAzuriranje.Visible = false;
        }

        private void textBoxAzP_TextChanged(object sender, EventArgs e)
        {
            if (tabControlRS.SelectedTab == tabPageRP)
            {
                textBoxAzP.Visible = true;
                labelAzP.Visible = true;
                foreach (Predmeti p in fakss.dajListuPredmeta())
                {
                    if (Convert.ToString(p.dajSifruPredmeta()) == textBoxAzP.Text)
                    {
                        textBoxNaziv.Text = p.DajNazivPredmeta();
                        textBoxBp.Text = Convert.ToString(p.brPredavanja());
                        textBoxBv.Text = Convert.ToString(p.brVjezbi());
                        textBoxBs.Text = Convert.ToString(p.brStudenata());
                        textBoxetcs.Text = Convert.ToString(p.brETCS());
                        richTextBox1.Text = p.dajOpis();
                    }
                }
            }

        }

        private void textBoxAzUp_TextChanged(object sender, EventArgs e)
        {
            if (tabControlRS.SelectedTab == tabPageRU)
            {
               /* labelAzUp.Visible = true;
                textBoxAzUp.Visible = true;
                buttonAzuriranje.Visible = true;*/
                foreach (Osoba b in fakss.dajListuUposlenih())
                {
                    if (b.dajSifru() == textBoxAzUp.Text)
                    {
                        textBoxImeZ.Text = b.DajIme();
                        textBoxPrezZ.Text = b.dajPrezime();
                        textBoxJmbgZ.Text = b.DajMaticniBroj();
                        dateTimePickerdrz.Text = b.dajDatum();
                        textBoxss.Text = b.dajStrucnu();
                        textBoxt.Text = b.dajTitulu();
                        textBoxp.Text = b.dajPoziciju();
                        textBox4iznosp.Text = b.dajIznosPlate();

                        //dateTimePickerdzpo.Text
                        //textBoxmjesto.Text = "Sarajevo";
                        //textBoxindex.TextChanged

                    }
                }
            }
        }

        private void comboBoxdodajp_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxdodajpolozeni_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void unesiSlikucs1_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            toolStripStatusLabel1.Text = "";
        }

        private void unesiSlikucs1_Validating(object sender, CancelEventArgs e)
        {
            if (unesiSlikucs1.dajDatum().AddMonths(3) <= DateTime.Now)
            {
                
                errorProvider1.SetError(unesiSlikucs1, "Neispravan datum");
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text = "Neispravan datum";
                e.Cancel = true;
            }
        }

        private void učitajPutemDatotekeToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void učitajIzDatotekeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void ucitajXML(string s)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Bachelor>));
            StreamWriter writer = new StreamWriter(s);
            x.Serialize(writer, fakss.dajListuStudenata());
            writer.Close();
        }
        private Task PokreniUcitavanjeStudentiXML(string file)
        {
            return Task.Factory.StartNew(() =>
            {
                ucitajXML(file);
            });
        }
        private async void studentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            string s = Path.Combine(fbd.SelectedPath, @"Studenti.xml");
            await PokreniUcitavanjeStudentiXML(s);
          
        }
    private void ucitajXMLUposlene(string s)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Osoba>));
            StreamWriter writer = new StreamWriter(s);
            x.Serialize(writer, fakss.Uposleni);
            writer.Close();
        }
        private Task PokreniUcitavanje(string ime)
        {
            return Task.Factory.StartNew(() =>
            {
                ucitajXMLUposlene(ime);
            });
        }
        private async void studentiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            // StalniUposleni no= new StalniUposleni();
          
            string s = Path.Combine(fbd.SelectedPath, @"Uposleni.xml");
            await PokreniUcitavanje(s);
        }

        private void izXmlDatotekeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UcitajPrikazi dato = new UcitajPrikazi(ref fakss);
            dato.Show();
            
        }
        private void BinarnoStudenti(string s)
        {
            FileStream fs = new FileStream(s, FileMode.Create);
            BinaryFormatter b = new BinaryFormatter();

            b.Serialize(fs, fakss.Studenti);
            fs.Close();
        }
        private Task UcitajBinStudente(string ime)
        {
            return Task.Factory.StartNew(() =>
            {
                BinarnoStudenti(ime);
            });
        }

        private async void uposleniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            string s = Path.Combine(fbd.SelectedPath, @"Studenti.bin");
            await UcitajBinStudente(s);
        }

        private void BinarnoUposleni(string s)
        {
            FileStream fs = new FileStream(s, FileMode.Create);
            BinaryFormatter b = new BinaryFormatter();

            b.Serialize(fs, fakss.Uposleni);
            fs.Close();
        }
        private Task UcitBinUpos(string s)
        {
            return Task.Factory.StartNew(() =>
            {
                BinarnoUposleni(s);
            });
        }
        private  async void uposleniToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            string s = Path.Combine(fbd.SelectedPath, @"Uposleni.bin");
            await UcitBinUpos(s);
        }

        private void izBinarneDatotekeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UcitajPrikaziStudenteBin StudentiBin = new UcitajPrikaziStudenteBin(ref fakss);
            StudentiBin.Show();
          
        }

        private void izXmlDatotekeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            XmlUpolseniIz upoxml = new XmlUpolseniIz(ref fakss);
            upoxml.Show();
        }

        private void učitajUposlenikeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void izBinarneDatotekeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UposleniIzBincs upoBin= new UposleniIzBincs(ref fakss);
            upoBin.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PretrzaiPoImenu forama = new PretrzaiPoImenu(ref fakss);
            forama.Show();
        }

        /*private void right(object sender, MouseEventArgs e)
        {
            contextMenuStrip1.Text = "hejhe";
        }*/
    }
}
