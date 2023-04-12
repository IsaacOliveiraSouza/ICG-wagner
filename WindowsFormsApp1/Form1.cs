/* Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 12/04
 * Autores do Projeto:Isaac Oliveira Souza
 *   
 * Turma: 3H
 * Atividade Proposta em aula
 * Observação: <colocar se houver>
 * 
 * 
 * ******************************************************************/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
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
        public void DesenhaRetangulo(PaintEventArgs e, Pen caneta, int x,int y, int altura, int largura)
        {
            e.Graphics.DrawRectangle(caneta, x, y, altura, largura);
        }          
        public void desenhaTriangulo(PaintEventArgs e, Pen caneta, int x1,int y1, int x2, int y2, int x3, int y3)
        {
            int a = (int)Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            int b = (int)Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            int c = (int)Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2));
            if (b + a> c && b + c> a && a + c >b)
            {

                if (a == b && b == c)
                {
                    
                    DesenhaLinha(e, caneta, x1, y1, x2, y2);
                    DesenhaLinha(e, caneta, x2, y2, x3, y3);
                    DesenhaLinha(e, caneta, x3, y3, x1, y1);
                    MessageBox.Show("equilatero");
                }
                else if (a == b || b == c || a == c)
                {
                    
                    DesenhaLinha(e, caneta, x1, y1, x2, y2);
                    DesenhaLinha(e, caneta, x2, y2, x3, y3);
                    DesenhaLinha(e, caneta, x3, y3, x1, y1);
                    MessageBox.Show("isoceles");
                }
                else
                {
                    
                    DesenhaLinha(e, caneta, x1, y1, x2, y2);
                    DesenhaLinha(e, caneta, x2, y2, x3, y3);
                    DesenhaLinha(e, caneta, x3, y3, x1, y1);
                    MessageBox.Show("escaleno");
                }
            }
            else
            {
                //MessageBox.Show(a.ToString() + " | " + b.ToString() + " | " + c.ToString());
                MessageBox.Show("nao é triangulo");
            }

        }       

        
        public Pen estiloLinha(PaintEventArgs e, Color cor, int esp, float[] valores)
        {
            float[] dashdot = valores;
            Pen caneta = new Pen(cor, esp);
            caneta.DashPattern = dashdot;
            return caneta;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color cores = cor(e, 255, 0, 0);
            float[] valoresLinha  = { 5, 2, 1, 2 };
            Pen caneta = estiloLinha(e, cores, 2, valoresLinha);
            desenhaTriangulo(e, caneta, 200,200, 200, 400, 600, 400);

        }
    }
}

