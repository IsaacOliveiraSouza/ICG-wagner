using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
        int desenha = 0;
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


       /* void retas(int xi, int yi, int xf, int yf, PaintEventArgs e)
        {

        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            desenha = 1;
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {   
            if(desenha == 1) {
                int xa = int.Parse(textBox1.Text);
                int ya = int.Parse(textBox2.Text);
                int xb = int.Parse(textBox3.Text);
                int yb = int.Parse(textBox4.Text);
                int xc = int.Parse(textBox5.Text);
                int yc = int.Parse(textBox6.Text);

                Color cor = color(100, 0, 0);
                Pen caneta = new Pen(cor, 0);

                e.Graphics.DrawLine(caneta, xa, ya, xb, yb);
                e.Graphics.DrawLine(caneta, xb, yb, xc, yc);
                e.Graphics.DrawLine(caneta, xc, yc, xa, ya);
            }

        }
    }
}
