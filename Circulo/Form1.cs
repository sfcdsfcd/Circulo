using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Text;

namespace Circulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            
            Draw();
            
        }

        
        private void Draw()
        {
            Graphics graphics = Pcb.CreateGraphics();
            Pcb.Refresh();
            Point ponto1 = new Point(Convert.ToInt32(Txt1.Text), Convert.ToInt32(Txt2.Text));
            float raio = 50;
            Point ponto2 = new Point(Convert.ToInt32(Txt3.Text), Convert.ToInt32(Txt4.Text));
            graphics.SmoothingMode = SmoothingMode.HighQuality;


            for (int x = 0; x < Pcb.Width; ++x)
            {

                for (int y = 0; y < Pcb.Height; ++y)
                {
                    Point PontoAleatorio = new Point(x, y);
                    if (EquacaoCirco(ponto1, PontoAleatorio) == raio)
                    {
                        graphics.FillEllipse(new SolidBrush(Color.Black), PontoAleatorio.X, PontoAleatorio.Y, 6, 6);

                    }

                }

            };


            graphics.FillEllipse(new SolidBrush(Color.Red), ponto1.X, ponto1.Y, 6, 6);

            graphics.FillEllipse(new SolidBrush(Color.Red), ponto2.X, ponto2.Y, 6, 6);
            graphics.DrawLine(new Pen(Color.Red), new Point(ponto1.X+3, ponto1.Y) , new Point(ponto2.X+3, ponto2.Y));

            if ((EquacaoCirco(ponto1, ponto2) == raio))
            {
                Result.Text = "Ponto está dentro da circunferência";
            }else if ((EquacaoCirco(ponto1, ponto2) > raio))
            {
                Result.Text = "Ponto está fora da circunferência";
            }else
            {
                Result.Text = "Ponto está dentro da circunferência";
            }
        }

        public int EquacaoCirco(Point Inicial, Point PontoAleatorio)
        {

            
            return (int)Math.Sqrt(Math.Pow((PontoAleatorio.X - Inicial.X), 2) + Math.Pow((PontoAleatorio.Y - Inicial.Y), 2));
            
        }

    }
}

