namespace posudbaKnjige
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            List<Korisnik> korisnici = new List<Korisnik>();

            korisnici.Add(new(
                 txIme.Text,
                 txPrezime.Text,
                 txEmail.Text,
                 txOIB.Text,
                 txBrojtelefona.Text,
                 txAdresa.Text)
                );

            MessageBox.Show(
               "Vaši podaci su spremljeni",
               "Rezultat",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information

           );
           
        }

    }
}
