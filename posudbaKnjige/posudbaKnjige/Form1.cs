using System.ComponentModel;
using System.Windows.Forms;

namespace posudbaKnjige
{
    public partial class Form1 : Form
    {
        private BindingList<Korisnik> korisnici = new BindingList<Korisnik>();
        public Form1()
        {
            InitializeComponent();
            dataGridViewUsers.DataSource = korisnici;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            Korisnik newKorisnik = new Korisnik(
                 txIme.Text,
                 txPrezime.Text,
                 txEmail.Text,
                 txOIB.Text,
                 txBrojtelefona.Text,
                 txAdresa.Text
                );

            korisnici.Add(newKorisnik);

            MessageBox.Show(
               "Vaši podaci su spremljeni",
               "Rezultat",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information
             );

            txIme.Clear();
            txPrezime.Clear();  
            txEmail.Clear();    
            txOIB.Clear();
            txBrojtelefona.Clear();
            txAdresa.Clear();
        }


        private void Form1_Load (object sender, EventArgs e)
        {
            dataGridViewUsers.DataSource = korisnici;
            
        }

    }
}
