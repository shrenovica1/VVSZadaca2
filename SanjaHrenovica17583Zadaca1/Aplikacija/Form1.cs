using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Threading;
using FakultetLibrary;

namespace Aplikacija
{
    public partial class Form1 : Form
    {   
        string pw, korisnickoIme;
        static Fakultet Faks = new Fakultet("Elektrotehnicki fakultet", "Sarajevo");
        Bachelor Admin;
        Master st;
        StudentiProzor studenti;
        Profesori profesoriProzor;
        FormAdmin formaZaAdmina=new FormAdmin(ref Faks);
        // string ime, prezime, jmbg, datum, dzpo, mjesto, index;
        //     new Bachelor("Sanja", "Hrenovica", Convert.ToDateTime("06.11.1996"), "0611996175013", Convert.ToDateTime("15.12.2015"),"shrenovica1", "kasika");
        System.Drawing.Graphics logo;
        private System.Threading.Timer tt = null;
        private System.ComponentModel.Container comp = null;
        private Point p;
        private const int s= 4;
        private const int v = 4;
        private const int animacija = 100;
        int y = 12, y2=15;
        //Rectangle elipsa = new Rectangle(20, 12, 90, 46);
        RectangleF eli;


        public Form1()
        {
            
           
            InitializeComponent();
            //this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
            Graphics logo;

            //p = new Point(elipsa.Location.X, elipsa.Location.Y);
            // Faks.RegistrujStudenta("Sanja", "Hrenovica", Convert.ToDateTime("06.11.1996"), "0611996175013", Convert.ToDateTime("15.12.2015"), "shrenovica1", "kasika");
            //Faks.RegistrujStudenta("Selma", "Hrenovica", Convert.ToDateTime("06.11.1996"), "0611996175021", Convert.ToDateTime("15.12.2015"), 17888, "Sarajevo", "shrenovica1", "kasika");
            // Faks.registrujNastavnoOsoblje("Sanja", )
            //formaZaAdmina = new FormAdmin(ref Faks);

            /* logo = this.CreateGraphics();
             Pen olovka = new Pen(System.Drawing.Color.Blue, 5);
             olovka.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
             SolidBrush cetka = new SolidBrush(System.Drawing.Color.LightBlue);
             logo.DrawLine(olovka, 20, 20, 70, 10);
             Rectangle pravougaonik = new Rectangle(20, 20, 20, 20);
             logo.DrawRectangle(olovka, pravougaonik);*/

        }
      
        protected override void OnPaint(PaintEventArgs pe)
        {
            logo = pe.Graphics;

            Pen olovka = new Pen(System.Drawing.Color.LightBlue, 3);
            olovka.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;


            // elipsa = new Rectangle(20, 12, 90, 46);
            eli = new RectangleF(20, y, 90, 46);
            //logo.DrawEllipse(olovka, eli);
            LinearGradientBrush cetka = new LinearGradientBrush(eli, Color.SteelBlue, Color.Blue, LinearGradientMode.BackwardDiagonal);
            SolidBrush brus = new SolidBrush(Color.LightBlue);
            logo.FillEllipse(brus, eli);
            Font f = new Font("Baskerville Old Face", 30);
            logo.DrawString("etf", f, cetka, 25,y2);
             p = new Point((int)eli.Location.X, (int)eli.Location.Y);
            base.OnPaint(pe);
        }
      
      
        public void textBoxKime_TextChanged(object sender, EventArgs e)
        {
            korisnickoIme = textBoxKime.Text;
            
        }
       

        private void textBoxLoz_TextChanged(object sender, EventArgs e)
        {
            pw = textBoxLoz.Text;
        }
        delegate void pomjeri(RectangleF pi);
        void pomjeriPliz(RectangleF pi)
        {

            y = y + 5;
            y2 = y2 + 5;
        }
        void Vratise(RectangleF pi)
        {
            y = y - 5;
            y2 = y2 - 5;
        }
        void pokreniNit()
        {
            try
            {
                int a = 0;
                while (a < 5)
                {
                    Invoke(new pomjeri(pomjeriPliz), eli);
                    this.Invalidate();
                    Thread.Sleep(400);
                    a++;
                }
                while (a > 0)
                {
                    Invoke(new pomjeri(Vratise), eli);
                    this.Invalidate();
                    Thread.Sleep(100);
                    a--;
                }
            }
            catch (Exception ex) { }
          
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          Thread nit = new Thread(new ThreadStart(pokreniNit));
            nit.Start();
        }

        private void textBoxKime_Validated(object sender, EventArgs e)
        {
            if (textBoxKime.Text == "")
            {

                errorProvidergreska.SetError(textBoxKime, "Neisparavan unos!");
                toolStripStatusLabelgr.Text = "Neispravan unos!";
            }
        }

        private void textBoxKime_Validating(object sender, CancelEventArgs e)
        {
            errorProvidergreska.Clear();
            toolStripStatusLabelgr.Text = "";

        }

        private void textBoxLoz_Validated(object sender, EventArgs e)
        {
            if (textBoxLoz.Text == "")
            {

                errorProvidergreska.SetError(textBoxLoz, "Neisparavan unos!");
                toolStripStatusLabelgr.Text = "Neispravan unos!";
            }
        }

        private void textBoxLoz_Validating(object sender, CancelEventArgs e)
        {

            errorProvidergreska.Clear();
            toolStripStatusLabelgr.Text = "";
        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {

            if (korisnickoIme == "admin" && pw == "admin")
            {
                formaZaAdmina.Show();
                //formaZaAdmina.Activate();
                textBoxLoz.Clear();
                textBoxKime.Clear();
                return;
            }
            else if (Faks.ProvjeraPrijave(korisnickoIme, pw))
            {
                if (Faks.kojiProzor(korisnickoIme, pw) == "student")
                {
                    studenti = new StudentiProzor(ref Faks, korisnickoIme);
                    studenti.Show();
                    textBoxLoz.Clear();
                    textBoxKime.Clear();
                    return;
                }
                else if (Faks.kojiProzor(korisnickoIme, pw) == "profesor")
                {
                    Predmeti p = Faks.dajPredmet(korisnickoIme);
                    profesoriProzor = new Profesori(ref Faks, ref p);
                    profesoriProzor.Show();
                    profesoriProzor.Activate();
                    textBoxLoz.Clear();
                    textBoxKime.Clear();
                    return;
                }


            }
            else
            {
                toolStripStatusLabelgr.Text = "Neispravan unos!";
             

            }
        }
    }
}
