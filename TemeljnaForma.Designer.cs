namespace NovaPP
{
    partial class TemeljnaForma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu glavniIzbornik;

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
            this.glavniIzbornik = new System.Windows.Forms.MainMenu();
            this.menuRoot = new System.Windows.Forms.MenuItem();
            this.optionReplikacija = new System.Windows.Forms.MenuItem();
            this.optionEvidencijaPrekrsaja = new System.Windows.Forms.MenuItem();
            this.optionProvjeraVozila = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // glavniIzbornik
            // 
            this.glavniIzbornik.MenuItems.Add(this.menuRoot);
            // 
            // menuRoot
            // 
            this.menuRoot.MenuItems.Add(this.optionReplikacija);
            this.menuRoot.MenuItems.Add(this.optionEvidencijaPrekrsaja);
            this.menuRoot.MenuItems.Add(this.optionProvjeraVozila);
            this.menuRoot.Text = "Poslovi";
            // 
            // optionReplikacija
            // 
            this.optionReplikacija.Text = "Sinkronizacija podataka";
            this.optionReplikacija.Click += new System.EventHandler(this.optionReplikacija_Click);
            // 
            // optionEvidencijaPrekrsaja
            // 
            this.optionEvidencijaPrekrsaja.Text = "Evidencija prekršaja";
            this.optionEvidencijaPrekrsaja.Click += new System.EventHandler(this.optionEvidencijaPrekrsaja_Click);
            // 
            // optionProvjeraVozila
            // 
            this.optionProvjeraVozila.Text = "Provjera vozila";
            this.optionProvjeraVozila.Click += new System.EventHandler(this.optionProvjeraVozila_Click);
            // 
            // TemeljnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.Menu = this.glavniIzbornik;
            this.Name = "TemeljnaForma";
            this.Text = "Nova PP";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuRoot;
        private System.Windows.Forms.MenuItem optionReplikacija;
        private System.Windows.Forms.MenuItem optionProvjeraVozila;
        private System.Windows.Forms.MenuItem optionEvidencijaPrekrsaja;
    }
}

