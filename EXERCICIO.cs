* Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 05/04/2023
 * Autores do Projeto: Isaac de Olveira Souza
 *   
 * Turma: 3H
 * Atividade Proposta em aula
 * Observação: <colocar se houver>
 * 
 * 
 * ******************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asdfghjklç
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int desenha = 0;
        int cont = 0;
        int x0 = 0;
        int y0 = 0;
        int x1 = 0;
        int y1 = 0;
        public Color cor(PaintEventArgs e, int r, int g, int b)
        {
            return Color.FromArgb(r, g, b);
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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color cores = cor(e, 255, 0, 0);
            Pen pen = caneta(e, cores, 2);
            DesenhaLinha(e, pen, x0, y0, x1, y1);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (cont < 1)
            {
                x0 = e.X;
                y0 = e.Y;
                cont++;
            }
            else
            {
                desenha = 1;
                x1 = e.X;
                y1 = e.Y;
                Invalidate();
                cont++;
                if (cont == 2)
                {
                    cont = 0;
                }

            }
        }
    }
}
