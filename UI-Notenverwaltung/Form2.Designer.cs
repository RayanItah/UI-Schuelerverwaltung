
namespace UI_Notenverwaltung
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nachname = new System.Windows.Forms.TextBox();
            this.Alter = new System.Windows.Forms.TextBox();
            this.Straße = new System.Windows.Forms.TextBox();
            this.Hausnummer = new System.Windows.Forms.TextBox();
            this.Ort = new System.Windows.Forms.TextBox();
            this.PLZ = new System.Windows.Forms.TextBox();
            this.speichern = new System.Windows.Forms.Button();
            this.Vorname = new System.Windows.Forms.TextBox();
            this.Geschlecht = new System.Windows.Forms.ComboBox();
            this.Liste = new System.Windows.Forms.Button();
            this.endo = new System.Windows.Forms.RichTextBox();
            this.download = new System.Windows.Forms.Button();
            this.Position = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Nachname
            // 
            this.Nachname.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Nachname.Location = new System.Drawing.Point(198, 124);
            this.Nachname.Name = "Nachname";
            this.Nachname.Size = new System.Drawing.Size(100, 20);
            this.Nachname.TabIndex = 2;
            this.Nachname.Text = "Name";
            this.Nachname.TextChanged += new System.EventHandler(this.Name_TextChanged);
            this.Nachname.Enter += new System.EventHandler(this.Nachname_Enter);
            this.Nachname.Leave += new System.EventHandler(this.Nachname_Leave);
            // 
            // Alter
            // 
            this.Alter.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Alter.Location = new System.Drawing.Point(410, 124);
            this.Alter.Name = "Alter";
            this.Alter.Size = new System.Drawing.Size(100, 20);
            this.Alter.TabIndex = 4;
            this.Alter.Text = "Alter";
            this.Alter.TextChanged += new System.EventHandler(this.Alter_TextChanged);
            this.Alter.Enter += new System.EventHandler(this.Alter_Enter);
            this.Alter.Leave += new System.EventHandler(this.Alter_Leave);
            // 
            // Straße
            // 
            this.Straße.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Straße.Location = new System.Drawing.Point(92, 252);
            this.Straße.Name = "Straße";
            this.Straße.Size = new System.Drawing.Size(100, 20);
            this.Straße.TabIndex = 6;
            this.Straße.Text = "Straße";
            this.Straße.TextChanged += new System.EventHandler(this.Straße_TextChanged);
            this.Straße.Enter += new System.EventHandler(this.Straße_Enter);
            this.Straße.Leave += new System.EventHandler(this.Straße_Leave);
            // 
            // Hausnummer
            // 
            this.Hausnummer.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Hausnummer.Location = new System.Drawing.Point(198, 252);
            this.Hausnummer.Name = "Hausnummer";
            this.Hausnummer.Size = new System.Drawing.Size(100, 20);
            this.Hausnummer.TabIndex = 7;
            this.Hausnummer.Text = "Hausnummer";
            this.Hausnummer.TextChanged += new System.EventHandler(this.Hausnummer_TextChanged);
            this.Hausnummer.Enter += new System.EventHandler(this.Hausnummer_Enter);
            this.Hausnummer.Leave += new System.EventHandler(this.Hausnummer_Leave);
            // 
            // Ort
            // 
            this.Ort.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Ort.Location = new System.Drawing.Point(304, 252);
            this.Ort.Name = "Ort";
            this.Ort.Size = new System.Drawing.Size(100, 20);
            this.Ort.TabIndex = 8;
            this.Ort.Text = "Ort";
            this.Ort.TextChanged += new System.EventHandler(this.Ort_TextChanged);
            this.Ort.Enter += new System.EventHandler(this.Ort_Enter);
            this.Ort.Leave += new System.EventHandler(this.Ort_Leave);
            // 
            // PLZ
            // 
            this.PLZ.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.PLZ.Location = new System.Drawing.Point(410, 252);
            this.PLZ.Name = "PLZ";
            this.PLZ.Size = new System.Drawing.Size(100, 20);
            this.PLZ.TabIndex = 9;
            this.PLZ.Text = "plz";
            this.PLZ.TextChanged += new System.EventHandler(this.plz_TextChanged);
            this.PLZ.Enter += new System.EventHandler(this.PLZ_Enter);
            this.PLZ.Leave += new System.EventHandler(this.PLZ_Leave);
            // 
            // speichern
            // 
            this.speichern.Location = new System.Drawing.Point(651, 308);
            this.speichern.Name = "speichern";
            this.speichern.Size = new System.Drawing.Size(109, 43);
            this.speichern.TabIndex = 10;
            this.speichern.Text = "Erstellen!";
            this.speichern.UseVisualStyleBackColor = true;
            this.speichern.Click += new System.EventHandler(this.speichern_Click);
            // 
            // Vorname
            // 
            this.Vorname.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Vorname.Location = new System.Drawing.Point(92, 124);
            this.Vorname.Name = "Vorname";
            this.Vorname.Size = new System.Drawing.Size(100, 20);
            this.Vorname.TabIndex = 1;
            this.Vorname.Text = "Vorname";
            this.Vorname.TextChanged += new System.EventHandler(this.Name_TextChanged);
            this.Vorname.Enter += new System.EventHandler(this.Vorname_Enter);
            this.Vorname.Leave += new System.EventHandler(this.Vorname_Leave);
            // 
            // Geschlecht
            // 
            this.Geschlecht.BackColor = System.Drawing.SystemColors.Window;
            this.Geschlecht.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Geschlecht.ForeColor = System.Drawing.Color.DarkGray;
            this.Geschlecht.FormattingEnabled = true;
            this.Geschlecht.Items.AddRange(new object[] {
            "Weiblich",
            "Männlich",
            "Divers(Attack Helicopter)"});
            this.Geschlecht.Location = new System.Drawing.Point(304, 124);
            this.Geschlecht.Name = "Geschlecht";
            this.Geschlecht.Size = new System.Drawing.Size(100, 21);
            this.Geschlecht.TabIndex = 3;
            // 
            // Liste
            // 
            this.Liste.Location = new System.Drawing.Point(668, 366);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(75, 23);
            this.Liste.TabIndex = 11;
            this.Liste.Text = "Show List";
            this.Liste.UseVisualStyleBackColor = true;
            this.Liste.Click += new System.EventHandler(this.Liste_Click);
            // 
            // endo
            // 
            this.endo.Location = new System.Drawing.Point(12, 12);
            this.endo.Name = "endo";
            this.endo.ReadOnly = true;
            this.endo.Size = new System.Drawing.Size(622, 426);
            this.endo.TabIndex = 0;
            this.endo.Text = "";
            this.endo.Visible = false;
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(668, 395);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(75, 23);
            this.download.TabIndex = 0;
            this.download.Text = "Speichern";
            this.download.UseVisualStyleBackColor = true;
            this.download.Visible = false;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // Position
            // 
            this.Position.BackColor = System.Drawing.SystemColors.Window;
            this.Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Position.ForeColor = System.Drawing.Color.DarkGray;
            this.Position.FormattingEnabled = true;
            this.Position.Items.AddRange(new object[] {
            "Schüler",
            "Lehrer",
            "Referendar"});
            this.Position.Location = new System.Drawing.Point(516, 123);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(100, 21);
            this.Position.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.download);
            this.Controls.Add(this.endo);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.Geschlecht);
            this.Controls.Add(this.speichern);
            this.Controls.Add(this.Alter);
            this.Controls.Add(this.Vorname);
            this.Controls.Add(this.Nachname);
            this.Controls.Add(this.PLZ);
            this.Controls.Add(this.Ort);
            this.Controls.Add(this.Hausnummer);
            this.Controls.Add(this.Straße);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form2";
            this.Text = "Erstellung der Schüler";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Nachname;
        private System.Windows.Forms.TextBox Alter;
        private System.Windows.Forms.TextBox Straße;
        private System.Windows.Forms.TextBox Hausnummer;
        private System.Windows.Forms.TextBox Ort;
        private System.Windows.Forms.TextBox PLZ;
        private System.Windows.Forms.Button speichern;
        private System.Windows.Forms.TextBox Vorname;
        private System.Windows.Forms.ComboBox Geschlecht;
        private System.Windows.Forms.Button Liste;
        private System.Windows.Forms.RichTextBox endo;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.ComboBox Position;
    }
}