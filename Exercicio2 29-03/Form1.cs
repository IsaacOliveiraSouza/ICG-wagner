﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2_29_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color color(int r, int g, int b)
        {
            Color color = new Color();
            color = Color.FromArgb(r, g, b);
            return color;
        }

        void ponto(int x, int y, Color cor, PaintEventArgs e)
        {
            Pen caneta = new Pen(cor, 0);
            e.Graphics.DrawLine(caneta, x, y, x + 1, y);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color cor = color(100, 0, 0);
            Pen caneta = new Pen(cor, 0);

            int x1 = 200;
            int y1 = 200;
            int x2 = 400;
            int y2 = 300;

            int y3 = y1+(y2 - y1);
            int x3 = x1;
            int x4 = x1+(x2 - x1);
            int y4 = x1;



            e.Graphics.DrawLine(caneta, x1, y1, x3, y3);
            e.Graphics.DrawLine(caneta, x1, y1, x4, y4);
            e.Graphics.DrawLine(caneta, x3, y2, x2, y2);
            e.Graphics.DrawLine(caneta, x4, y4, x2, y2);
        }
    }/*200 200                   400 200*/
    /*200 300                    400 300*/
}
