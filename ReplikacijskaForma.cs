using System;
using System.Data.SqlServerCe;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NovaPP
{
    public partial class ReplikacijskaForma : NovaPP.TemeljnaForma
    {
        public ReplikacijskaForma()
        {
            InitializeComponent();
        }

        private void btnSinkroniziraj_Click(object sender, EventArgs e)
        {
            lblPoruka.Text = String.Empty;
            lblPoruka.ForeColor = SystemColors.ControlText;

            txtServer.Text = txtServer.Text.Trim();
            if (txtServer.Text == String.Empty)
            {
                MessageBox.Show("Naziv servera je obavezan.");
                return;
            }

            SqlCeReplication r = new SqlCeReplication();

            r.InternetUrl = "http://" + txtServer.Text + "/merge-replication-novapp/sqlcesa35.dll";
            r.InternetLogin = String.Empty;
            r.InternetPassword = String.Empty;
            r.Publisher = txtServer.Text;
            r.PublisherDatabase = "NovaPP";
            r.Publication = "NovaPP";
            r.PublisherSecurityMode = SecurityType.DBAuthentication;
            r.PublisherLogin = "MobKorisnik";
            r.PublisherPassword = "mob.korisn1k";
            r.SubscriberConnectionString = Program.ConnString;
            r.Subscriber = "DlanovnikPP";
            r.ExchangeType = ExchangeType.BiDirectional;

            try
            {
                if (File.Exists(Program.PathToLocalDB))
                {
                    r.ReinitializeSubscription(true);
                }
                else
                {
                    r.AddSubscription(AddOption.CreateDatabase);
                }
                r.Synchronize();
                lblPoruka.Text = "Sinkronizacija podataka je uspješno provedena.";
            }
            catch (Exception ex)
            {
                lblPoruka.Text = ex.Message;
                lblPoruka.ForeColor = Color.Red;
            }
            finally
            {
                r.Dispose();
            }
        }
    }
}

