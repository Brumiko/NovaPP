using System;
using System.Windows.Forms;

namespace NovaPP
{
    public partial class TemeljnaForma : Form
    {
        public TemeljnaForma()
        {
            InitializeComponent();
        }

        private void optionProvjeraVozila_Click(object sender, EventArgs e)
        {
            NadzornaForma f = new NadzornaForma();
            f.Show();
        }

        private void optionEvidencijaPrekrsaja_Click(object sender, EventArgs e)
        {
            PrekrsajnaForma f = new PrekrsajnaForma();
            f.Show();
        }

        private void optionReplikacija_Click(object sender, EventArgs e)
        {
            ReplikacijskaForma f = new ReplikacijskaForma();
            f.Show();
        }
    }
}