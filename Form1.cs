/* Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 09/05
 * Autores do Projeto: Isaac de Olveira Souza
 *   
 * Turma: 3H
 * Atividade Proposta em aula
 * 
 * 
 * ******************************************************************/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ICG_EXERCICIOS
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

        public Pen caneta(PaintEventArgs e, Color cor, int esp)
        {
            Pen caneta = new Pen(cor, esp);
            return caneta;
        }

        public void DesenhaLinha(PaintEventArgs e, Pen caneta, int x0, int y0, int x1, int y1)
        {
            e.Graphics.DrawLine(caneta, x0, y0, x1, y1);
        }

        void ponto(int x, int y, Color cor, PaintEventArgs e)
        {
            Pen caneta = new Pen(cor, 0);
            DesenhaLinha(e, caneta, x, y, x + 1, y);
        }

        void dArc(PaintEventArgs e, int xc, int yc, int raio)
        {
            Color cor = color(100, 0, 0);
            int x;
            int y;
            double teta;

            for (int i = 0; i < 360; i++)
            {
                teta = i * Math.PI / 180;
                x = (int)(xc + raio * Math.Cos(teta));
                y = (int)(yc + raio * Math.Sin(teta));
                ponto(x, y, cor, e);

            }
        }

        void d_elipse(PaintEventArgs e, int xc, int yc, int raiox, int raioy)
        {
            Color cor = color(100, 0, 0);
            int x;
            int y;
            double teta;
            for (int i = 0; i < 360; i++)
            {
                teta = i * Math.PI / 180;
                x = (int)(xc + raiox * Math.Cos(teta));
                y = (int)(yc + raioy * Math.Sin(teta));
                ponto(x, y, cor, e);

            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color cor = color(100, 0, 0);
            Pen pen = new Pen(cor, 0);

            dArc(e, 540, 540, 100);

        }

    
    }
}