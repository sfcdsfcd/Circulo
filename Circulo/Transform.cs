using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulo
{
    class Transform
    {
        public Point Position { get; set; }
        public List<Point> Pontos { get; set; }
        public Transform(int x, int y, int Width, int Height,int Raio)
        {
            Position = new Point(x, y);
            Pontos = new List<Point>();
            AddList(Width,Height, Raio);
        }
        public void Draw(Graphics graphics)
        {

            foreach (var item in Pontos)
            {
                graphics.FillEllipse(new SolidBrush(Color.Black), item.X, item.Y, 6, 6);
            }
    
            graphics.FillEllipse(new SolidBrush(Color.Red), Position.X, Position.Y, 6, 6);
        }

        public void AddList(int Width, int Height, int Raio)
        {
            for (int x = 0; x < Width; ++x)
            {
                for (int y = 0; y < Height; ++y)
                {
                    Point PontoAleatorio = new Point(x, y);
                    if (EquacaoCirco(Position, PontoAleatorio) == Raio)
                    {
                        Pontos.Add(PontoAleatorio);
                    }

                }

            };
        }
        public int EquacaoCirco(Point Inicial, Point PontoAleatorio)
        {


            return (int)Math.Sqrt(Math.Pow((PontoAleatorio.X - Inicial.X), 2) + Math.Pow((PontoAleatorio.Y - Inicial.Y), 2));

        }
    }
}
