using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace notatnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nOWEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rezultat = MessageBox.Show("Czy na pewno chcesz zamknąc program?", "Uwaga!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rezultat == DialogResult.Yes) this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void zaznaczWszystkoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void kopiujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            toolStripComboBox1.Items.Insert(0,"8");
            toolStripComboBox1.Items.Insert(1,"9");
            toolStripComboBox1.Items.Insert(2,"10");
            toolStripComboBox1.Items.Insert(3,"12");
            toolStripComboBox1.Items.Insert(4,"14");
            toolStripComboBox1.Items.Insert(5,"16");
            toolStripComboBox1.Items.Insert(6,"18");
            toolStripComboBox1.Items.Insert(7,"20");
            toolStripComboBox1.Items.Insert(8,"22");
            toolStripComboBox1.Items.Insert(9,"24");
            toolStripComboBox1.Items.Insert(10,"26");
            toolStripComboBox1.Items.Insert(11,"28");
            toolStripComboBox1.Items.Insert(12,"36");
            toolStripComboBox1.Items.Insert(13,"48");
            toolStripComboBox1.Items.Insert(14,"72");
            toolStripComboBox1.SelectedItem = "8";

            toolStripComboBox2.Items.Insert(0, "Arial Black");
            toolStripComboBox2.Items.Insert(1, "Microsoft Sans Serif");
            toolStripComboBox2.Items.Insert(2, "Times New Roman");
            toolStripComboBox2.Items.Insert(2, "Courier New");
            toolStripComboBox2.SelectedItem = "Microsoft Sans Serif";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rezultat = MessageBox.Show("Czy na pewno chcesz zamknąc program?", "Uwaga!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rezultat == DialogResult.Yes) e.Cancel = false;
            else e.Cancel = true;
        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer sp1 = new SoundPlayer(Properties.Resources.ygc);
            sp1.Play();
            MessageBox.Show("COCONUT MALLED", "YOU JUST GOT");
            MessageBox.Show("COCONUT MALLED", "YOU JUST GOT");
            MessageBox.Show("COCONUT MALLED", "YOU JUST GOT");
            MessageBox.Show("COCONUT MALLED", "YOU JUST GOT");
            MessageBox.Show("COCONUT MALLED", "YOU JUST GOT");
            MessageBox.Show("COCONUT MALLED", "YOU JUST GOT");
            MessageBox.Show("COCONUT MALLED", "YOU JUST GOT");
            MessageBox.Show("COCONUT MALLED", "YOU JUST GOT");
            MessageBox.Show("COCONUT MALLED", "YOU JUST GOT");
            MessageBox.Show("COCONUT MALLED", "YOU JUST GOT");
            MessageBox.Show("COCONUT MALLED", "YOU JUST GOT");
            MessageBox.Show("COCONUT MALLED", "YOU JUST GOT");
            MessageBox.Show("COCONUT MALLED", "YOU JUST GOT");
            MessageBox.Show("COCONUT MALLED", "YOU JUST GOT");
            MessageBox.Show("COCONUT MALLED", "YOU JUST GOT");
            MessageBox.Show("COCONUT MALLED", "YOU JUST GOT");
            MessageBox.Show("COCONUT MALLED", "YOU JUST GOT");
            MessageBox.Show("COCONUT MALLED", "YOU JUST GOT");
            MessageBox.Show("COCONUT MALLED", "YOU JUST GOT");
            MessageBox.Show("COCONUT MALLED", "YOU JUST GOT");
            MessageBox.Show("COCONUT MALLED", "YOU JUST GOT");
        }

        private void zapiszToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Pliki tekstowe .txt|*.txt|Wszystkie pliki *.*|*.*";
            saveFileDialog1.Title = "Zapisz dokument...";
            saveFileDialog1.DefaultExt = "txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter plik = new StreamWriter(saveFileDialog1.FileName);
                plik.WriteLine(textBox1.Text);
                plik.Close();
            }
        }

        private void otworzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Pliki tekstowe .txt|*.txt|Wszystkie pliki *.*|*.*";
            openFileDialog1.Title = "Otwórz dokument...";
            openFileDialog1.DefaultExt = "txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = null;
                StreamReader plik = new StreamReader(openFileDialog1.FileName);
                string wiersz;
                while((wiersz = plik.ReadLine()) != null)
                {
                    textBox1.AppendText(wiersz);
                }
                plik.Close();
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.SelectedItem)
            {
                case "8":
                    Font fnt = new Font(textBox1.Font.FontFamily, 8);
                    textBox1.Font = fnt; break;
                case "9":
                    Font fnt1 = new Font(textBox1.Font.FontFamily, 9);
                    textBox1.Font = fnt1; break;
                case "10":
                    Font fnt2 = new Font(textBox1.Font.FontFamily, 10);
                    textBox1.Font = fnt2; break;
                case "11":
                    Font fnt3 = new Font(textBox1.Font.FontFamily, 11);
                    textBox1.Font = fnt3; break;
                case "12":
                    Font fnt4 = new Font(textBox1.Font.FontFamily, 12);
                    textBox1.Font = fnt4; break;
                case "14":
                    Font fnt5 = new Font(textBox1.Font.FontFamily, 14);
                    textBox1.Font = fnt5; break;
                case "16":
                    Font fnt6 = new Font(textBox1.Font.FontFamily, 16);
                    textBox1.Font = fnt6; break;
                case "18":
                    Font fnt15 = new Font(textBox1.Font.FontFamily, 18);
                    textBox1.Font = fnt15; break;
                case "20":
                    Font fnt7 = new Font(textBox1.Font.FontFamily, 20);
                    textBox1.Font = fnt7; break;
                case "22":
                    Font fnt8 = new Font(textBox1.Font.FontFamily, 22);
                    textBox1.Font = fnt8; break;
                case "24":
                    Font fnt9 = new Font(textBox1.Font.FontFamily, 24);
                    textBox1.Font = fnt9; break;
                case "26":
                    Font fnt10 = new Font(textBox1.Font.FontFamily, 26);
                    textBox1.Font = fnt10; break;
                case "28":
                    Font fnt11 = new Font(textBox1.Font.FontFamily, 28);
                    textBox1.Font = fnt11; break;
                case "36":
                    Font fnt12 = new Font(textBox1.Font.FontFamily, 36);
                    textBox1.Font = fnt12; break;
                case "48":
                    Font fnt13 = new Font(textBox1.Font.FontFamily, 48);
                    textBox1.Font = fnt13; break;
                case "72":
                    Font fnt14 = new Font(textBox1.Font.FontFamily, 72);
                    textBox1.Font = fnt14; break;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
  
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            int column;
            int kol;

            string text = textBox1.Text;

            column = textBox1.SelectionStart + 1;

            if (Convert.ToString(e.KeyCode) == "Return")
            {
                liczby.checkcolumn = column - 1;
                liczby.row++;
            }
            kol = (column - liczby.checkcolumn);

            if (kol <= 0)
            {
                liczby.row--;
                int count = 0;
                liczby.checkcolumn = 0;
                foreach (char c in text)
                {
                    if (c != Convert.ToChar("\n"))
                    {
                        liczby.checkcolumn++;
                    }
                    else
                    
                    count = 0;
                }
                liczby.checkcolumn += (liczby.row - 1) * 2;
                kol = (column - liczby.checkcolumn);
            }

            toolStripStatusLabel1.Text = "Kolumna : " + Convert.ToString(kol);
            toolStripStatusLabel2.Text = "Rząd : " + Convert.ToString(liczby.row);
            toolStripStatusLabel3.Text = "checkcolumn:" + Convert.ToString(liczby.checkcolumn);
            toolStripStatusLabel4.Text = "pozycja Karetki:" + Convert.ToString(textBox1.SelectionStart + 1);
        }
    

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int column;
            int kol;

            string text = textBox1.Text;

            column = textBox1.SelectionStart + 1;


            kol = (column - liczby.checkcolumn);

            if (kol <= 0)
            {
                liczby.row--;
                int count = 0;
                int countlast = 0;
                liczby.checkcolumn = 0;
                foreach (char c in text)
                {
                    if (c != Convert.ToChar("\n"))
                    {
                        count++;
                    }
                    else
                    {
                        liczby.checkcolumn += count+1;
                        countlast = count;
                        count = 0;
                    } 
                }
                liczby.checkcolumn = liczby.checkcolumn - countlast - 1;
                kol = (column - liczby.checkcolumn);
            }

            toolStripStatusLabel1.Text = "Kolumna : " + Convert.ToString(kol);
            toolStripStatusLabel2.Text = "Rząd : " + Convert.ToString(liczby.row);
            toolStripStatusLabel3.Text = "checkcolumn:" + Convert.ToString(liczby.checkcolumn);
            toolStripStatusLabel4.Text = "pozycja Karetki:" + Convert.ToString(textBox1.SelectionStart + 1);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                textBox1.Focus();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
                textBox1.Focus();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Pliki tekstowe .txt|*.txt|Wszystkie pliki *.*|*.*";
            saveFileDialog1.Title = "Zapisz dokument...";
            saveFileDialog1.DefaultExt = "txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter plik = new StreamWriter(saveFileDialog1.FileName);
                plik.WriteLine(textBox1.Text);
                plik.Close();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Pliki tekstowe .txt|*.txt|Wszystkie pliki *.*|*.*";
            saveFileDialog1.Title = "Zapisz dokument...";
            saveFileDialog1.DefaultExt = "txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter plik = new StreamWriter(saveFileDialog1.FileName);
                plik.WriteLine(textBox1.Text);
                plik.Close();
            }
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (toolStripComboBox2.SelectedItem)
            {
                case "Arial Black": textBox1.Font = new Font ("Arial Black",textBox1.Font.Size);break;
                case "Courier New": textBox1.Font = new Font("Courier New", textBox1.Font.Size); break;
                case "Times New Roman": textBox1.Font = new Font("Times New Roman", textBox1.Font.Size); break;
                case "Microsoft Sans Serif": textBox1.Font = new Font("Micorosoft Sans Serif", textBox1.Font.Size); break;
            }
        }
    }
    public static class liczby
    {
        static public int checkcolumn = 0;
        static public int row = 1;
    }
}
