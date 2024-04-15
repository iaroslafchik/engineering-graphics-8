using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics_lab_8
{
    public partial class Form1 : Form
    {
        Letter К = new Letter();
        Letter Я = new Letter();
        Letter С = new Letter();

        public Form1()
        {
            InitializeComponent();
            К.AddLine(new Point(0, 0), new Point(0, 80));
            К.AddLine(new Point(0, 40), new Point(40, 0));
            К.AddLine(new Point(0, 40), new Point(40, 80));

            Я.AddLine(new Point(0, 0), new Point(40, 0));
            Я.AddLine(new Point(0, 0), new Point(0, 20));
            Я.AddLine(new Point(40, 0), new Point(40, 80));
            Я.AddLine(new Point(40, 40), new Point(0, 80));
            Я.AddLine(new Point(40, 40), new Point(20, 40));
            Я.AddLine(new Point(20, 40), new Point(0, 20));

            С.AddLine(new Point(0, 0), new Point(40, 0));
            С.AddLine(new Point(0, 0), new Point(0, 80));
            С.AddLine(new Point(0, 80), new Point(40, 80));
        }


        class Letter {
            public Letter() { }
            public List<List<Point>> lines = new List<List<Point>>();

            public void AddLine(Point A, Point B) {
                lines.Add(new List<Point>() { A, B });
            }
            
            
            public void DrawLetter(Form1 parent, int x, int y) {
                Graphics letter = parent.CreateGraphics();
                Pen style = new Pen(Color.Black);
                Point from;
                Point to;
                foreach (var line in lines) {
                    from = new Point(line[0].X + x, line[0].Y + y);
                    to = new Point(line[1].X + x, line[1].Y + y);
                    letter.DrawLine(style, from, to);
                    }
                }
            }

        private void Form1_Paint(object sender, PaintEventArgs e) {
            К.DrawLetter(this, 20, 30);
            Я.DrawLetter(this, 80, 30);
            С.DrawLetter(this, 140, 30);
        }
    }
    }
