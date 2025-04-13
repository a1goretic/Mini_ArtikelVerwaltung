namespace Mini_ArtikelVerwaltung
{
    public partial class Form1 : Form
    {
        // Artikelliste
        private List<Artikel> artikelListe = new List<Artikel>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHinzufuegen_Click(object sender, EventArgs e)
        {
            try
            {
                // Eingaben auslesen
                string name = txtArtikelName.Text;
                decimal preis = decimal.Parse(txtPreis.Text);
                int bestand = int.Parse(txtLagerBestand.Text);

                // Neuen Artikel erstellen
                Artikel a = new Artikel
                {
                    Name = name,
                    Preis = preis,
                    Bestand = bestand
                };

                // Zur Liste hinzufügen
                artikelListe.Add(a);

                // Tabelle (DataGridView) aktualisieren
                dgvArtikel.DataSource = null;   //Binding aufheben
                dgvArtikel.DataSource = artikelListe;   // Neu binden
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Hinzufügen: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}