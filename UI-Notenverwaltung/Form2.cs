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
using System.Diagnostics;

namespace UI_Notenverwaltung
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        //Eingabe
        #region TextChanged
        private void Vorname_TextChanged(object sender, EventArgs e)
        {

        }
        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Alter_TextChanged(object sender, EventArgs e)
        {

        }

        private void Position_TextChanged(object sender, EventArgs e)
        {

        }

        private void Straße_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hausnummer_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ort_TextChanged(object sender, EventArgs e)
        {

        }

        private void plz_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion 

        //Buttons
        #region Click
        private void speichern_Click(object sender, EventArgs e)
        {
            String vorname = Vorname.Text;
            String nachname = Nachname.Text;
            String geschlecht = Geschlecht.Text;
            String alter = Alter.Text;
            String position = Position.Text;
            String strasse = Straße.Text;
            String hausnummer = Hausnummer.Text;
            String ort = Ort.Text;
            String plz = PLZ.Text;

            if (vorname == "Vorname" || vorname == "" || nachname == "Name" || nachname == "" || geschlecht == "Geschlecht" || alter == "Alter" || alter == "" || position == "Position" || position == "" || strasse == "Straße" || strasse == "" || hausnummer == "Hausnummer" || hausnummer == "" || ort == "Ort" || plz == "PLZ" || plz == "")
            {

                String Fehler = "";

                if(vorname == "Vorname" || vorname == "") { Fehler = "Vorname "; }

                if (nachname == "Name" || nachname == "") { Fehler = Fehler + "Name "; }

                if(geschlecht == "") { Fehler = Fehler + "Geschlecht "; }

                if(alter == "Alter" || alter == "") { Fehler = Fehler + "Alter "; }

                if (position == "") { Fehler = Fehler + "Position "; }
                
                if(strasse == "Straße" || strasse == "") { Fehler = Fehler + "Straße "; }

                if(hausnummer == "Hausnummer" || hausnummer == "") { Fehler = Fehler + "Hausnummer "; }

                if(ort == "Ort" || ort == "") {Fehler = Fehler + "Ort ";}

                if(plz == "PLZ" || plz == "") { Fehler = Fehler + "PLZ"; }

                MessageBox.Show($"Fehlende Eingaben bei\n{Fehler}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            person Person = new person(vorname, nachname, geschlecht, alter, new Adresse(strasse, hausnummer, ort, plz), position);
            Personenverwaltung.addList(Person);

            MessageBox.Show($"Die Person \"{vorname} {nachname}\" wurde erstellt!", "Erfolgreich!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            Vorname.Text = "Vorname";
            Nachname.Text = "Name";
            Geschlecht.Text = "Geschlecht";
            Alter.Text = "Alter";
            Position.Text = "Position";
            Straße.Text = "Straße";
            Hausnummer.Text = "Hausnummer";
            Ort.Text = "Ort";
            PLZ.Text = "plz";
        }

        public void Liste_Click(object sender, EventArgs e)
        {
            if (Liste.Text == "Show List")
            {
                download.Visible = true;
                Liste.Text = "Hide List";
                speichern.Hide();
                Vorname.Hide();
                Nachname.Hide();
                Geschlecht.Hide();
                Alter.Hide();
                Position.Hide();
                Straße.Hide();
                Hausnummer.Hide();
                Ort.Hide();
                PLZ.Hide();

                string path = Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE") + @"\Downloads\Notenverwaltung.txt");

                String PATH = File.ReadAllText(path);

                endo.Text = PATH;

                foreach (person x in Personenverwaltung.Personenliste)
                {

                    String value = $"{x.getPosition()}\nVorname: {x.getvName()}\nName: {x.getName()}\nGeschlecht: {x.getGeschlecht()}\nAlter: {x.getAlter()}\nAdresse: {x.GetAdresseString()}\n\n";
          
                    String xer = File.ReadAllText(path);

                    if (xer.Contains(value))
                    {
                        endo.Text = xer;
                    }

                    else 
                    {
                        endo.Text = xer + value;



                        File.WriteAllText(path, endo.Text);
                    }
                }

                string text = File.ReadAllText(path);
                
                endo.Visible = true;

                if (endo.Text == "")
                {

                }
                else
                {
                    File.WriteAllText(path, endo.Text);
                }
            }
            else
            {
                download.Visible = false;
                Liste.Text = "Show List";
                Vorname.Show();
                Nachname.Show();
                Geschlecht.Show();
                Alter.Show();
                Position.Show();
                Straße.Show();
                Hausnummer.Show();
                Ort.Show();
                PLZ.Show();
                endo.Hide();
                speichern.Visible = true;
            }
        }

        private void Vorname_Enter(object sender, EventArgs e)
        {

            if (Vorname.Text == "Vorname") { Vorname.Text = ""; }

        }

        private void Vorname_Leave(object sender, EventArgs e)
        {
            if (Vorname.Text == "") { Vorname.Text = "Vorname"; }
        }

        private void Nachname_Enter(object sender, EventArgs e)
        {
            if (Nachname.Text == "Name") { Nachname.Text = ""; }
        }

        private void Nachname_Leave(object sender, EventArgs e)
        {
            if (Nachname.Text == "") { Nachname.Text = "Name"; }
        }

        private void Alter_Enter(object sender, EventArgs e)
        {
            if (Alter.Text == "Alter") { Alter.Text = ""; }
        }

        private void Alter_Leave(object sender, EventArgs e)
        {
            if (Alter.Text == "") { Alter.Text = "Alter"; }
        }

        private void Straße_Enter(object sender, EventArgs e)
        {
            if (Straße.Text == "Straße") { Straße.Text = ""; }
        }

        private void Straße_Leave(object sender, EventArgs e)
        {
            if (Straße.Text == "") { Straße.Text = "Straße"; }
        }

        private void Hausnummer_Enter(object sender, EventArgs e)
        {
            if (Hausnummer.Text == "Hausnummer") { Hausnummer.Text = ""; }
        }

        private void Hausnummer_Leave(object sender, EventArgs e)
        {
            if (Hausnummer.Text == "") { Hausnummer.Text = "Hausnummer"; }
        }

        private void Ort_Enter(object sender, EventArgs e)
        {
            if (Ort.Text == "Ort") { Ort.Text = ""; }
        }

        private void Ort_Leave(object sender, EventArgs e)
        {
            if (Ort.Text == "") { Ort.Text = "Ort"; }
        }

        private void PLZ_Enter(object sender, EventArgs e)
        {
            if (PLZ.Text == "plz") { PLZ.Text = ""; }
        }

        private void PLZ_Leave(object sender, EventArgs e)
        {

            if (PLZ.Text == "") { PLZ.Text = "plz"; }
        }

        private void download_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE")+ @"\Downloads\Notenverwaltung.txt");
            string values = File.ReadAllText(path);


            if (File.Exists(path))
            {
                MessageBox.Show($"Datei wurde im vorhandenen Pfad gespeichert!\n{path}", "Erfolgreich!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            else
            {
                MessageBox.Show($"Ein Fehler ist unterlaufen!\n{path}", "Erfolgreich!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }





    #endregion

    #region class
    class person
    {
        private String vName, nName;
        private String geschlecht;
        private String alter;
        private Adresse adr; //Konstruktor => Straße, Hausnummer, Ort, plz
        private String Position;

        public person(String vName, String name, String geschlecht, String alter, Adresse adr, String Position)
        {
            this.vName = vName;
            this.nName = name;
            this.geschlecht = geschlecht;
            this.alter = alter;
            this.adr = adr;
            this.Position = Position;
        }

        #region set/get
        public void setvName(String n)
        {
            this.vName = n;
        }
        public void setName(String n)
        {
            this.nName = n;
        }
        public void setGeschlecht(String n)
        {
            this.geschlecht = n;
        }
        public void setAlter(String n)
        {
            this.alter = n;
        }
        public void setAdresse(Adresse n)
        {
            this.adr = n;
        }

        public String getvName()
        {
            return this.vName;
        }
        public String getName()
        {
            return this.nName;
        }
        public String getGeschlecht()
        {
            return this.geschlecht;
        }
        public String getAlter()
        {
            return this.alter;
        }

        public String getPosition()
        {
            return this.Position;
        }

        public String GetAdresseString()
        {
            String v = $"{this.adr.getStraße()}, {this.adr.getHausnummer()}, {this.adr.getOrt()}, {this.adr.getplz()}";
            return v;
        }
        #endregion

    }

    class Personenverwaltung
    {
        static public List<person> Personenliste = new List<person>();

        static public void addList(person n)
        {
            Personenliste.Add(n);
        }

    }
    class Adresse
    {
        private String Straße, Hausnummer, Ort, plz, Alles;

        public Adresse(String Straße, String Hausnummer, String Ort, String plz)
        {
            this.Straße = Straße;
            this.Hausnummer = Hausnummer;
            this.Ort = Ort;
            this.plz = plz;
        }

        public Adresse(String Alles)
        {
            this.Alles = Alles; //CUTTEN!!!!!!
        }

        #region set/get
        public void setStraße(String n)
        {
            this.Straße = n;
        }
        public void setHausnummer(String n)
        {
            this.Hausnummer = n;
        }
        public void setOrt(String n)
        {
            this.Ort = n;
        }
        public void setplz(String n)
        {
            this.plz = n;
        }

        public String getStraße()
        {
            return this.Straße;
        }
        public String getHausnummer()
        {
            return this.Hausnummer;
        }
        public String getOrt()
        {
            return this.Ort;
        }
        public String getplz()
        {
            return this.plz;
        }
        #endregion
    }
    #endregion
}
