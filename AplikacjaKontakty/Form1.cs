using System.ComponentModel.Design;
using System.DirectoryServices.ActiveDirectory;
using System.Linq.Expressions;

namespace AplikacjaKontakty
{
    public partial class Form1 : Form
    {
        List<string[]> dataBazych = new List<string[]>();
        bool sortowaniePoNazwisku = false;
        public Form1()
        {
            InitializeComponent();
            odczytajBaze();
            aktualizujStanListy();
        }

        private void wyswietlBaze() // wyświetla całą aktualną datęBazych w MessageBox
        {
            string komunikat = "";
            foreach (string[] s in dataBazych)
            {
                komunikat += s[0] + " " + s[1] + " " + s[2] + " " + s[3] + "\n";
            }
            MessageBox.Show(komunikat);
        }

        public void dodajNowyRekord(string imie, string nazwisko, string nrTel, DateOnly dataUrodzenia, int selectedIndex = -1) // dodaje nowy rekord do datyBazych, jeśli podano selectedIndex to usuwa podany index
        {
            if (selectedIndex != -1)
            {
                dataBazych.RemoveAt(selectedIndex);
            }
            dataBazych.Add([imie, nazwisko, nrTel, dataUrodzenia.ToString()]);
            sortuj(sortowaniePoNazwisku);
            aktualizujStanListy();
        }

        private void odczytajBaze() // przypisuje informacje z pliki kontakty.kel do datyBazych
        {
            StreamReader plik = new StreamReader("kontakty.kel");
            while (!plik.EndOfStream)
            {
                string[] linia;
                string[] dane = ["", "", "", ""];
                linia = plik.ReadLine().Split(';');

                for (int i = 0; i < 4; i++)
                {
                    dane[i] = (i < linia.Length ? linia[i] : "");
                }

                dataBazych.Add(dane);
            }
            plik.Close();
        }

        private void zapiszBaze() // zapisuje informacje z datyBazych do pliku kontakty.kel
        {
            try
            {
                StreamWriter plik = new StreamWriter("kontakty.kel", false);
                foreach (string[] dane in dataBazych)
                {
                    plik.WriteLine(dane[0] + ';' + dane[1] + ';' + dane[2] + ';' + dane[3]);
                }
                plik.Close();
                MessageBox.Show("Zapisano bazę!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void aktualizujStanListy() // aktualizuje stan listy wyświetlającej elementy
        {
            listBox1.Items.Clear();
            foreach (string[] dane in dataBazych)
            {
                listBox1.Items.Add(dane[0] + " " + dane[1]);
            }
        }

        private void sortuj(bool sortujPoNazwisku = false)
        {
            dataBazych.Sort((string[] arg1, string[] arg2) => String.Compare(arg1[sortujPoNazwisku ? 1 : 0], arg2[sortujPoNazwisku ? 1 : 0]));
        }

        public void wybierzRekord(int index)
        {
            listBox1.SelectedIndex = index;
        }

        private void eddycjaRekorduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] dane = dataBazych[listBox1.SelectedIndex];
            addContact okno = new addContact(dane[0], dane[1], dane[2], dane[3], listBox1.SelectedIndex);
            okno.Show(this);
        }

        private void dodajNowyRekordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addContact okno = new addContact();
            okno.Show(this);
        }

        private void koniecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zapiszKontaktyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zapiszBaze();
        }

        private void nowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataBazych.Clear();
            zapiszBaze();
            aktualizujStanListy();
        }

        private void sortowaniePoImieniuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortowaniePoNazwisku = false;
            sortuj();
            aktualizujStanListy();
        }

        private void sortowaniePoNazwiskuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortowaniePoNazwisku = true;
            sortuj(true);
            aktualizujStanListy();
        }

        private void wyszukiwanieKontaktuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchContact okno = new searchContact(dataBazych);
            okno.Show(this);
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jedyna ważna informacja o tym programie to jego data ważności: 25/10/2024");
        }

        private void dokumentacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= dataBazych.Count || listBox1.SelectedIndex < 0)
                return;

            string[] selected = dataBazych[listBox1.SelectedIndex];
            label5.Text = selected[0];
            label6.Text = selected[1];
            label7.Text = selected[2];
            label8.Text = selected[3];

        }
    }
}
