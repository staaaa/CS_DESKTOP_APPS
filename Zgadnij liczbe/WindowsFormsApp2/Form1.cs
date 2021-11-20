using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        static Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int cos;
            if (!int.TryParse(textBox1.Text, out cos))
            {
                MessageBox.Show("Proszę wprowadzić poprawną wartość.");
            }
            else {
                int Text = Convert.ToInt32(textBox1.Text);
                if (Losowa.liczba > Text)
                {
                    MessageBox.Show("Liczba jest za mała", "Spróbuj jeszcze raz");
                    Losowa.ilosc++;
                }
                else if (Text > Losowa.liczba)
                {
                    MessageBox.Show("Liczba jest za duża", "Spróbuj jeszcze raz");
                    Losowa.ilosc++;
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show(string.Format("BRAWO\nOdgadłeś w {0} próbach!\nCzy chcesz kontynuować grę?", Losowa.ilosc), "ODGADŁEŚ LICZBĘ", MessageBoxButtons.YesNo))
                    {
                        Losowa.liczba = random.Next(1, 100);
                        Losowa.ilosc = 1;
                    }
                    else this.Close();

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public static class Losowa
        {
            public static int liczba = random.Next(1,100);
            public static int ilosc=1;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.PROGRAM LOSOWO GENERUJE LICZBĘ\nTWOIM ZADANIEM JEST ODGADNIĘCIE\nCO TO ZA LICZBA.", "ZASADY");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }
        private void KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }
    }
}
