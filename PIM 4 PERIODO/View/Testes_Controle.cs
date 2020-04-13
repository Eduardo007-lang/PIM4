using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;

namespace PIM_4_PERIODO.View
{
    public partial class Testes_Controle : Form
    {
        public Testes_Controle()
        {
            InitializeComponent();
        }

        private void Testes_Controle_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // Create a pen and font
            Graphics g = e.Graphics;
            Pen blackPen = new Pen(Color.Black, 2);
            Font verdanaFont = new Font("Verdana", 60, FontStyle.Bold);
            // Create points that define polygon.
            Point[] curvePoints1 = { new Point(200, 15),
                new Point(200, 200), new Point(375, 250) };
            Point[] curvePoints2 = { new Point(0, 250),
                new Point(200, 200), new Point(375, 250) };
            Point[] curvePoints3 = { new Point(200, 15),
                new Point(200, 200), new Point(0, 250) };
            // Create linear gradient brushes
            Point pt1 = new Point(10, 10);
            Point pt2 = new Point(30, 30);
            LinearGradientBrush lgBrush1 = new LinearGradientBrush(pt1, pt2, Color.Red, Color.Blue);
            LinearGradientBrush lgBrush2 = new LinearGradientBrush(pt1, pt2, Color.Red, Color.Green);
            LinearGradientBrush lgBrush3 = new LinearGradientBrush(pt1, pt2, Color.Blue, Color.Green);
            // If you want to draw three lines
            //e.Graphics.DrawLine(blackPen, 200, 55, 200, 200);
            //e.Graphics.DrawLine(blackPen, 50, 250, 200, 200);
            //e.Graphics.DrawLine(blackPen, 345, 260, 200, 200);
            // Set quality of text and shape
            g.TextRenderingHint = TextRenderingHint.AntiAlias;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            // Draw three polygons and string
            e.Graphics.FillPolygon(new SolidBrush(Color.FromArgb(80, 255, 0, 0)), curvePoints1);
            e.Graphics.FillPolygon(new SolidBrush(Color.FromArgb(80, 0, 255, 0)), curvePoints2);
            e.Graphics.FillPolygon(new SolidBrush(Color.FromArgb(80, 0, 0, 255)), curvePoints3);
            // Draw C# using the DrawString method
            // Starting @ point 140, 150
            g.DrawString("C#", verdanaFont, lgBrush1, new PointF(140, 150));
            // Dispose Graphics
            g.Dispose();
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
