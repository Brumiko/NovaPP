namespace NovaPP
{
    partial class PrekrsajnaForma
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
            this.pnlPretragaVozaca = new System.Windows.Forms.Panel();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.txtVozacID = new System.Windows.Forms.TextBox();
            this.lblVozacID = new System.Windows.Forms.Label();
            this.pnlVozaceviPodaci = new System.Windows.Forms.Panel();
            this.lblVozacIliPoruka = new System.Windows.Forms.Label();
            this.pnlPrekrsaji = new System.Windows.Forms.Panel();
            this.btnEvidentiraj = new System.Windows.Forms.Button();
            this.lbxPrekrsaji = new System.Windows.Forms.ListBox();
            this.lblPrekrsaj = new System.Windows.Forms.Label();
            this.pnlPretragaVozaca.SuspendLayout();
            this.pnlVozaceviPodaci.SuspendLayout();
            this.pnlPrekrsaji.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPretragaVozaca
            // 
            this.pnlPretragaVozaca.Controls.Add(this.btnTrazi);
            this.pnlPretragaVozaca.Controls.Add(this.txtVozacID);
            this.pnlPretragaVozaca.Controls.Add(this.lblVozacID);
            this.pnlPretragaVozaca.Location = new System.Drawing.Point(0, 3);
            this.pnlPretragaVozaca.Name = "pnlPretragaVozaca";
            this.pnlPretragaVozaca.Size = new System.Drawing.Size(240, 80);
            // 
            // btnTrazi
            // 
            this.btnTrazi.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnTrazi.Location = new System.Drawing.Point(3, 45);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(234, 30);
            this.btnTrazi.TabIndex = 1;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // txtVozacID
            // 
            this.txtVozacID.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.txtVozacID.Location = new System.Drawing.Point(101, 10);
            this.txtVozacID.MaxLength = 9;
            this.txtVozacID.Name = "txtVozacID";
            this.txtVozacID.Size = new System.Drawing.Size(136, 29);
            this.txtVozacID.TabIndex = 0;
            // 
            // lblVozacID
            // 
            this.lblVozacID.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.lblVozacID.Location = new System.Drawing.Point(3, 10);
            this.lblVozacID.Name = "lblVozacID";
            this.lblVozacID.Size = new System.Drawing.Size(92, 29);
            this.lblVozacID.Text = "ID vozača";
            // 
            // pnlVozaceviPodaci
            // 
            this.pnlVozaceviPodaci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlVozaceviPodaci.Controls.Add(this.lblVozacIliPoruka);
            this.pnlVozaceviPodaci.Location = new System.Drawing.Point(3, 84);
            this.pnlVozaceviPodaci.Name = "pnlVozaceviPodaci";
            this.pnlVozaceviPodaci.Size = new System.Drawing.Size(234, 40);
            // 
            // lblVozacIliPoruka
            // 
            this.lblVozacIliPoruka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVozacIliPoruka.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblVozacIliPoruka.Location = new System.Drawing.Point(0, 0);
            this.lblVozacIliPoruka.Name = "lblVozacIliPoruka";
            this.lblVozacIliPoruka.Size = new System.Drawing.Size(234, 40);
            this.lblVozacIliPoruka.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlPrekrsaji
            // 
            this.pnlPrekrsaji.Controls.Add(this.btnEvidentiraj);
            this.pnlPrekrsaji.Controls.Add(this.lbxPrekrsaji);
            this.pnlPrekrsaji.Controls.Add(this.lblPrekrsaj);
            this.pnlPrekrsaji.Location = new System.Drawing.Point(3, 127);
            this.pnlPrekrsaji.Name = "pnlPrekrsaji";
            this.pnlPrekrsaji.Size = new System.Drawing.Size(234, 141);
            // 
            // btnEvidentiraj
            // 
            this.btnEvidentiraj.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.btnEvidentiraj.Location = new System.Drawing.Point(191, 23);
            this.btnEvidentiraj.Name = "btnEvidentiraj";
            this.btnEvidentiraj.Size = new System.Drawing.Size(40, 114);
            this.btnEvidentiraj.TabIndex = 3;
            this.btnEvidentiraj.Text = ">";
            this.btnEvidentiraj.Visible = false;
            this.btnEvidentiraj.Click += new System.EventHandler(this.btnEvidentiraj_Click);
            // 
            // lbxPrekrsaji
            // 
            this.lbxPrekrsaji.DisplayMember = "Naziv";
            this.lbxPrekrsaji.Location = new System.Drawing.Point(4, 23);
            this.lbxPrekrsaji.Name = "lbxPrekrsaji";
            this.lbxPrekrsaji.Size = new System.Drawing.Size(181, 114);
            this.lbxPrekrsaji.TabIndex = 2;
            this.lbxPrekrsaji.ValueMember = "ID";
            this.lbxPrekrsaji.SelectedIndexChanged += new System.EventHandler(this.lbxPrekrsaji_SelectedIndexChanged);
            // 
            // lblPrekrsaj
            // 
            this.lblPrekrsaj.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblPrekrsaj.Location = new System.Drawing.Point(4, 4);
            this.lblPrekrsaj.Name = "lblPrekrsaj";
            this.lblPrekrsaj.Size = new System.Drawing.Size(227, 16);
            this.lblPrekrsaj.Text = "Odaberi prekršaj pa evidentiraj gumbom \'>\'";
            // 
            // PrekrsajnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.pnlPrekrsaji);
            this.Controls.Add(this.pnlVozaceviPodaci);
            this.Controls.Add(this.pnlPretragaVozaca);
            this.Name = "PrekrsajnaForma";
            this.Text = "Evidencija prekršaja";
            this.pnlPretragaVozaca.ResumeLayout(false);
            this.pnlVozaceviPodaci.ResumeLayout(false);
            this.pnlPrekrsaji.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPretragaVozaca;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.TextBox txtVozacID;
        private System.Windows.Forms.Label lblVozacID;
        private System.Windows.Forms.Panel pnlVozaceviPodaci;
        private System.Windows.Forms.Label lblVozacIliPoruka;
        private System.Windows.Forms.Panel pnlPrekrsaji;
        private System.Windows.Forms.Label lblPrekrsaj;
        private System.Windows.Forms.ListBox lbxPrekrsaji;
        private System.Windows.Forms.Button btnEvidentiraj;

    }
}
