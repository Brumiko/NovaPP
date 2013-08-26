namespace NovaPP
{
    partial class ReplikacijskaForma
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
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.btnSinkroniziraj = new System.Windows.Forms.Button();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblServer
            // 
            this.lblServer.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.lblServer.Location = new System.Drawing.Point(4, 14);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(64, 27);
            this.lblServer.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.txtServer.Location = new System.Drawing.Point(74, 12);
            this.txtServer.MaxLength = 15;
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(163, 29);
            this.txtServer.TabIndex = 0;
            // 
            // btnSinkroniziraj
            // 
            this.btnSinkroniziraj.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnSinkroniziraj.Location = new System.Drawing.Point(4, 57);
            this.btnSinkroniziraj.Name = "btnSinkroniziraj";
            this.btnSinkroniziraj.Size = new System.Drawing.Size(233, 40);
            this.btnSinkroniziraj.TabIndex = 1;
            this.btnSinkroniziraj.Text = "Sinkroniziraj";
            this.btnSinkroniziraj.Click += new System.EventHandler(this.btnSinkroniziraj_Click);
            // 
            // lblPoruka
            // 
            this.lblPoruka.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.lblPoruka.Location = new System.Drawing.Point(4, 110);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(233, 150);
            // 
            // ReplikacijskaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.lblPoruka);
            this.Controls.Add(this.btnSinkroniziraj);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblServer);
            this.Name = "ReplikacijskaForma";
            this.Text = "Sinkronizacija podataka";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Button btnSinkroniziraj;
        private System.Windows.Forms.Label lblPoruka;
    }
}
