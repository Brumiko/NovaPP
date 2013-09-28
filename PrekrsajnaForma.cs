using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NovaPP
{
    public partial class PrekrsajnaForma : NovaPP.TemeljnaForma
    {
        private int intVozacID = -1;

        public PrekrsajnaForma()
        {
            InitializeComponent();

            // Dohvat popisa prekršaja.
            SqlCeConnection conn = new SqlCeConnection(Program.ConnString);
            string sqlQry =
                "SELECT " +
                    "ID, " +
                    "Naziv " +
                "FROM " +
                    "Prekrsaj;";

            try
            {
                DataTable dt = new DataTable("Prekrsaji");
                SqlCeCommand cmd = new SqlCeCommand(sqlQry, conn);
                SqlCeDataAdapter da = new SqlCeDataAdapter(sqlQry, conn);

                conn.Open();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    lbxPrekrsaji.DataSource = dt;
                    //lbxPrekrsaji.Refresh();
                }
                else
                {
                    throw new Exception("WTF! (What a Terrible Failure). Katalog prekršaja je prazan!");
                }
                da.Dispose();
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

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            txtVozacID.Text = txtVozacID.Text.Trim();
            if (txtVozacID.Text == String.Empty)
            {
                MessageBox.Show("Upiši vozačev identifikator.");
                return;
            }
            Regex regex = new Regex("[0-9]{1,9}", RegexOptions.CultureInvariant);
            if (!regex.IsMatch(txtVozacID.Text))
            {
                MessageBox.Show("Vozačev identifikator mora biti cijeli broj.");
                return;
            }

            SqlCeConnection conn = new SqlCeConnection(Program.ConnString);
            string sqlQry =
                "SELECT " +
                    "ID, " +
                    "Ime, " +
                    "Prezime " +
                "FROM " +
                    "Vlasnik " +
                "WHERE ID = @vozacID;";

            try
            {
                SqlCeParameter vozacID = new SqlCeParameter("vozacID", SqlDbType.Int);
                vozacID.Value = Convert.ToInt32(txtVozacID.Text);
                vozacID.Direction = ParameterDirection.Input;

                SqlCeCommand cmd = new SqlCeCommand(sqlQry, conn);
                cmd.Parameters.Add(vozacID);

                conn.Open();

                SqlCeDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblVozacIliPoruka.Text = reader["Ime"].ToString() + " " + reader["Prezime"].ToString();
                    intVozacID = Convert.ToInt32(reader["ID"]);
                    lbxPrekrsaji.Enabled = true;
                }
                else
                {
                    lblVozacIliPoruka.Text = String.Empty;
                    lbxPrekrsaji.Enabled = false;
                    MessageBox.Show("Nije pronađen vozač s tim identifikatorom!");
                }
                reader.Close();
                reader.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                lbxPrekrsaji.Enabled = false;
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

        private void lbxPrekrsaji_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnEvidentiraj.Visible == false)
                btnEvidentiraj.Visible = true;
        }

        private void btnEvidentiraj_Click(object sender, EventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(Program.ConnString);
            string sqlCmd =
                "INSERT INTO Kazna (" +
                    "VlasnikID, " +
                    "PrekrsajID, " +
                    "DatKazne" +
                ") " +
                "VALUES (" +
                    "@vozacID, " +
                    "@prekrsajID, " +
                    "@datKazne" +
                ");";
            try
            {
                SqlCeParameter vozacID = new SqlCeParameter("vozacID", SqlDbType.Int);
                vozacID.Value = intVozacID;
                vozacID.Direction = ParameterDirection.Input;

                SqlCeParameter prekrsajID = new SqlCeParameter("prekrsajID", SqlDbType.Int);
                prekrsajID.Value = lbxPrekrsaji.SelectedValue;
                prekrsajID.Direction = ParameterDirection.Input;

                SqlCeParameter datKazne = new SqlCeParameter("datKazne", SqlDbType.DateTime);
                datKazne.Value = DateTime.Now;
                datKazne.Direction = ParameterDirection.Input;

                SqlCeCommand cmd = new SqlCeCommand(sqlCmd, conn);
                cmd.Parameters.Add(vozacID);
                cmd.Parameters.Add(prekrsajID);
                cmd.Parameters.Add(datKazne);

                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Prekršaj '" + lbxPrekrsaji.Text + "' je evidentiran.");
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

