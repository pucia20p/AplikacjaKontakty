using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaKontakty
{
    public partial class addContact : Form
    {
        int selectedIndex = -1;
        public addContact()
        {
            InitializeComponent();
        }

        public addContact(string imie, string nazwisko, string nrTel, string data, int selectedIndex)
        {
            InitializeComponent();
            textBox1.Text = imie;
            textBox2.Text = nazwisko;
            textBox3.Text = nrTel;
            DateTime dataUrodzenia = DateTime.Parse(data);
            dateTimePicker1.Value = dataUrodzenia;
            this.selectedIndex = selectedIndex;
        }

        private bool isNameValid(string name)
        {
            return name.Length > 0 && name.Length < 100 && !name.Contains(";");
        }

        private bool isPhoneValid(string phone)
        {
            return phone.Length > 0 && phone.Length < 20 && !phone.Contains(";");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string imie = textBox1.Text.Trim();
            string nazwisko = textBox2.Text.Trim();
            string nrTel = textBox3.Text.Trim();
            if(isNameValid(imie) && isNameValid(nazwisko) && isPhoneValid(nrTel))
            {
                DateOnly dataUrodzenia = DateOnly.FromDateTime(dateTimePicker1.Value);
                Form1? main = Owner as Form1;
                main?.dodajNowyRekord(imie, nazwisko, nrTel, dataUrodzenia, selectedIndex);
                this.Close();
            } else
            {
                MessageBox.Show("Niepoprawne dane!");
            }
        }
    }
}
