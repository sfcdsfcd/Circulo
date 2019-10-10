using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Text;
using System.Collections.Generic;

namespace Circulo
{
    public partial class Form1 : Form
    {

        Graphics graphics;
        int Raio;
        List<Transform> Transform;
        bool jogoiniciado;
        public Form1()
        {
            InitializeComponent();
            graphics = Pcb.CreateGraphics();
            Raio = 50;
            Transform = new List<Transform>();
            Transform.Add(new Transform(300,200,Pcb.Width,Pcb.Height,Raio));
        }

        

        
        private void Draw()
        {
            foreach (var item in Transform)
            {
                item.Draw(graphics);
            }
        }

        
        public void RenderizarTela()
        {
            Point EixoX1 = new Point(0, 200);
            Point EixoX2 = new Point(600, 200);
            Point EixoY1 = new Point(300, 0);
            Point EixoY2 = new Point(300, 400);
            graphics.DrawLine(new Pen(Color.Black), EixoX1.X, EixoX1.Y, EixoX2.X, EixoX2.Y);
            graphics.DrawLine(new Pen(Color.Black), EixoY1.X, EixoY1.Y, EixoY2.X, EixoY2.Y);
            graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(0, 0, 599, 399));
        }

        private void Pcb_MouseClick(object sender, MouseEventArgs e)
        {
            if (jogoiniciado)
            {
                Transform.Add(new Transform(e.X, e.Y, Pcb.Width, Pcb.Height, Raio));
                Draw();
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Draw();
            jogoiniciado = true;
        }
    }
}

