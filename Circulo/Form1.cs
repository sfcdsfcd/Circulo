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

            RenderizarTela(graphics);



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
                for (int x = 0; x < Pcb.Width; ++x)
                {

                    for (int y = 0; y < Pcb.Height; ++y)
                    {
                        Point PontoAleatorio = new Point(x, y);
                        if (EquacaoCirco(ponto2, PontoAleatorio) == raio)
                        {
                            graphics.FillEllipse(new SolidBrush(Color.Black), PontoAleatorio.X, PontoAleatorio.Y, 6, 6);

                        }

                    }

                };

            }
            else
            {
                Result.Text = "Ponto está dentro da circunferência";
                
            }
        }

        public int EquacaoCirco(Point Inicial, Point PontoAleatorio)
        {

            
            return (int)Math.Sqrt(Math.Pow((PontoAleatorio.X - Inicial.X), 2) + Math.Pow((PontoAleatorio.Y - Inicial.Y), 2));
            
        }
        public void RenderizarTela(Graphics graphics)
        {
            Point EixoX1 = new Point(0, 200);
            Point EixoX2 = new Point(600, 200);
            Point EixoY1 = new Point(300, 0);
            Point EixoY2 = new Point(300, 400);
            graphics.DrawLine(new Pen(Color.Black), EixoX1.X, EixoX1.Y, EixoX2.X, EixoX2.Y);
            graphics.DrawLine(new Pen(Color.Black), EixoY1.X, EixoY1.Y, EixoY2.X, EixoY2.Y);
            graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(0, 0, 599, 399));
        }

    }
}

