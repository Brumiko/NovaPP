using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Globalization;
using System.Windows.Forms;

namespace NovaPP
{
    public partial class NadzornaForma : NovaPP.TemeljnaForma
    {
        public NadzornaForma()
        {
            InitializeComponent();
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            txtRegOzn.Text = txtRegOzn.Text.Trim();
            if (txtRegOzn.Text == String.Empty)
            {
                MessageBox.Show("Upiši registarsku oznaku auta.");
                return;
            }

            SqlCeConnection conn = new SqlCeConnection(Program.ConnString);
            String sqlQry =
                "SELECT " +
                    "Vozilo.ID AS VoziloID, " +
                    "Vlasnik.Ime + ' ' + Vlasnik.Prezime AS Vlasnik, " +
                    "Vozilo.Model, " +
                    "Boja.Naziv AS Boja, " +
                    "Vozilo.Registrirano, " +
                    "Vozilo.DatReg AS [Datum registracije] " +
                "FROM " +
                    "Vlasnik INNER JOIN Vozilo ON Vlasnik.ID = Vozilo.VlasnikID " +
                    "INNER JOIN Boja ON Vozilo.BojaID = Boja.ID " +
                    "WHERE (Vozilo.RegOzn = '@regOzn');";

            try
            {
                SqlCeParameter regOzn = new SqlCeParameter("regOzn", SqlDbType.NVarChar);
                regOzn.Value = txtRegOzn.Text;
                regOzn.Direction = ParameterDirection.Input;

                SqlCeCommand cmd = new SqlCeCommand(sqlQry, conn);
                cmd.Parameters.Add(regOzn);

                conn.Open();

                SqlCeDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    lblBojaValue.Text = reader["Boja"].ToString();
                    lblDatRegValue.Text = Convert.ToDateTime(reader["Datum registracije"], new CultureInfo("hr-HR")).ToShortDateString();
                    lblModelValue.Text = reader["Model"].ToString();
                    lblRegValue.Text = Convert.ToBoolean(reader["Registrirano"]) == true ? "Da." : "NE!!!";
                }
                else
                {
                    lblBojaValue.Text = String.Empty;
                    lblDatRegValue.Text = String.Empty;
                    lblModelValue.Text = String.Empty;
                    lblRegValue.Text = String.Empty;
                    MessageBox.Show("Nije pronađen auto s tom registarskom oznakom!");
                }
                reader.Close();
                reader.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
                conn.Dispose();
            }
        }
    }
}

