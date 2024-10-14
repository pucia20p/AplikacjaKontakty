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
    public partial class searchContact : Form
    {
        List<string[]> dataBazych = new List<string[]>();
        public searchContact()
        {
            InitializeComponent();
        }

        public searchContact(List<string[]> dataBazych)
        {
            InitializeComponent();
            this.dataBazych = dataBazych;
        }

        private int szukaj()
        {
            int index = -1;
            foreach ((string[] dane, int i) in dataBazych.Select((dane, i) => (dane, i)))
            {
                if (
                    dane[0].ToLower().Contains(textBox1.Text.ToLower()) && 
                    dane[1].ToLower().Contains(textBox2.Text.ToLower()) &&
                    dane[2].ToLower().Contains(textBox3.Text.ToLower()) 
                    )
                {
                    index = i; 
                    break;
                }
            }

            return index;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int znaleziono = szukaj();
            if(znaleziono < 0)
            {
                MessageBox.Show("Nie znaleziono");
            } else
            {
                Form1? main = Owner as Form1;
                main?.wybierzRekord(znaleziono);
                this.Close();
            }
        }
    }
}
