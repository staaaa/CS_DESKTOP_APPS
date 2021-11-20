﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zegar_analogowy
{
    enum TYPWSKAZOWKI { SEKUNDOWA, MINUTOWA, GODZINOWA };
    public partial class Form1 : Form
    {
        int x0;
        int y0;
        int Lh, Lm, Ls;
        void Params()
        {
            x0 = pictureBox1.Width / 2;
            y0 = pictureBox1.Height / 2;
            Lh = x0 / 3;
            Lm = (int)(x0 / 1.5f);
            Ls = x0 / 2;
        }
        void wskazowka(Graphics g, Color k, int grubosc, int wspX, int wspY, int dl, int czas, TYPWSKAZOWKI typ)
        {
            int wartoscNaTarczy = 0;
            switch (typ)
            {
                case TYPWSKAZOWKI.SEKUNDOWA: wartoscNaTarczy = (czas % 60) * 360 / 60; break;
                case TYPWSKAZOWKI.MINUTOWA: wartoscNaTarczy = (czas % 60) * 360 / 60; break;
                case TYPWSKAZOWKI.GODZINOWA: wartoscNaTarczy = (czas % 12) * 360 / 12; break;
            }
            float alfa = (float)(wartoscNaTarczy) - 90;
            float radiany = 3.14f * alfa / 180;
            int yk = (int)(dl * Math.Sin(radiany));
            int xk = (int)(dl * Math.Cos(radiany));
            g.DrawLine(new Pen(k, grubosc), wspX, wspY, wspX + xk, wspY + yk);
        }
        private void rysuj(IntPtr uchwyt, int wspX, int wspY, int Lh, int Lm, int Ls)
        {
            int x0 = wspX;
            int y0 = wspY;
            string t = DateTime.Now.ToString("T");
            DateTime czas = DateTime.Now;
            Graphics g = Graphics.FromHwnd(uchwyt);
            Color c = Color.FromArgb(255, 255, 255, 255);
            g.Clear(c);
            c = Color.FromArgb(255, 255, 179, 25    );
            wskazowka(g, c, 5, wspX, wspY, Lh, czas.Hour, TYPWSKAZOWKI.GODZINOWA);
            wskazowka(g, c, 3, wspX, wspY, Lm, czas.Minute, TYPWSKAZOWKI.MINUTOWA);
            wskazowka(g, c, 1, wspX, wspY, Ls, czas.Second, TYPWSKAZOWKI.SEKUNDOWA);
            g.Dispose();
        }
        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            Params();
            rysuj(pictureBox1.Handle, x0, y0, Lh, Lm, Ls);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rysuj(pictureBox1.Handle, x0, y0, Lh, Lm, Ls);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Params();
        }

        
        public Form1()
        {
            InitializeComponent();
        }
        
    }
}
