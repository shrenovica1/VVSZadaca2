using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManager
{
    public class Dbmanager
    {

        SqlConnection connection;
        SqlCommand command;



        public Dbmanager()
        {
            connection = new SqlConnection();
            connection.ConnectionString = @"Server=localhost;Database=FakultetDb;Trusted_Connection=True;";
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
        }
        public void dodajPredmet(String naziv, int brojVjezbi, int brojPredavanja, int brojStudenata, int brojEtcs, String opis, string studijskaGodina)
        {
            string insert = "insert into Predmeti ([naziv],[brojVjezbi],[brojPredavanja],[brojStudenata],[brojEtcs],[Opis],[studijskaGodina]) values(@naziv,@brojVjezbi,@brojPredavanja,@brojStudenata,@brojEtcs,@opis,@studijskaGodina)";
            connection.ConnectionString = @"Server=localhost;Database=FakultetDb;Trusted_Connection=True;";
            using (connection) {
                connection.Open();
                SqlCommand insertPredmeti = new SqlCommand(insert, connection);
                insertPredmeti.Parameters.AddWithValue("@naziv", naziv);
                insertPredmeti.Parameters.AddWithValue("@brojVjezbi", brojVjezbi);
                insertPredmeti.Parameters.AddWithValue("@brojPredavanja", brojPredavanja);
                insertPredmeti.Parameters.AddWithValue("@brojStudenata", brojStudenata);
                insertPredmeti.Parameters.AddWithValue("@brojEtcs", brojEtcs);
                insertPredmeti.Parameters.AddWithValue("@opis", opis);
                insertPredmeti.Parameters.AddWithValue("@studijskaGodina", studijskaGodina);
                int affectedRows = insertPredmeti.ExecuteNonQuery();
            }
            connection.Close();
        }
        public void dodajNastavnika(string ime, string prezime, DateTime datumRodjenja, string maticniBroj, string pozicija, string strucnaSprema, string titula, decimal plata, string korisnickoIme, string lozinka) {
            string insert = "insert into NastavnoOsoblje ([ime],[prezime],[datumRodjenja],[maticniBroj],[pozicija],[strucnaSprema],[titula],[plata],[korisnickoIme],[lozinka]) values(@ime,@prezime,@datumRodjenja,@maticniBroj,@pozicija,@strucnaSprema,@titula,@plata,@korisnickoIme,@lozinka)";

            connection.ConnectionString = @"Server=localhost;Database=FakultetDb;Trusted_Connection=True;";
            using (connection)
            {
                connection.Open();
                SqlCommand insertNastavnoO = new SqlCommand(insert, connection);
                insertNastavnoO.Parameters.AddWithValue("@ime", ime);
                insertNastavnoO.Parameters.AddWithValue("@prezime", prezime);
                insertNastavnoO.Parameters.AddWithValue("@datumRodjenja", datumRodjenja);
                insertNastavnoO.Parameters.AddWithValue("@maticniBroj", maticniBroj);
                insertNastavnoO.Parameters.AddWithValue("@pozicija", pozicija);
                insertNastavnoO.Parameters.AddWithValue("@strucnaSprema", strucnaSprema);
                insertNastavnoO.Parameters.AddWithValue("@titula", titula);
                insertNastavnoO.Parameters.AddWithValue("@plata", plata);
                insertNastavnoO.Parameters.AddWithValue("@korisnickoIme", korisnickoIme);
                insertNastavnoO.Parameters.AddWithValue("@lozinka", lozinka);
                int affectedRows = insertNastavnoO.ExecuteNonQuery();
            }
            connection.Close();
        }
        public void dodajBachelorStudenta(string ime, string prezime, DateTime datumRodjenja, string maticniBroj, DateTime prethodnoObraz, string korisnickoIme, string lozinka)
        {
            string insert = "insert into BachelorStudent ([ime],[prezime],[datumRodjenja],[maticniBroj],[prethodnoObraz],[korisnickoIme],[lozinka]) values(@ime,@prezime,@datumRodjenja,@maticniBroj,@prethodnoObraz,@korisnickoIme,@lozinka)";

            connection.ConnectionString = @"Server=localhost;Database=FakultetDb;Trusted_Connection=True;";
            using (connection)
            {
                connection.Open();
                SqlCommand insertBachelor = new SqlCommand(insert, connection);
                insertBachelor.Parameters.AddWithValue("@ime", ime);
                insertBachelor.Parameters.AddWithValue("@prezime", prezime);
                insertBachelor.Parameters.AddWithValue("@datumRodjenja", datumRodjenja);
                insertBachelor.Parameters.AddWithValue("@maticniBroj", maticniBroj);
                insertBachelor.Parameters.AddWithValue("@prethodnoObraz", prethodnoObraz);
                insertBachelor.Parameters.AddWithValue("@korisnickoIme", korisnickoIme);
                insertBachelor.Parameters.AddWithValue("@lozinka", lozinka);
                int affectedRows = insertBachelor.ExecuteNonQuery();
            }
            connection.Close();
        }

    }
}
