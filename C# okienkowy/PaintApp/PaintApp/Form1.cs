using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{

    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Point startPoint, currentPoint;
        private Pen pen = new Pen(Color.Black, 5);
        private Bitmap drawingBitmap;
        private Graphics graphics;
        private string drawingMode = "Ołówek";
        private Color backGroundColor = Color.White;
        public Form1()
        {
            InitializeComponent();
            InitCanvas();
            panelCanvas.Paint += panelCanvas_Paint;

            comboBoxShape.SelectedItem = "Ołówek";
        }

        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            startPoint = currentPoint = e.Location;
        }

        private void panelCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                currentPoint = e.Location;

                if (drawingMode == "Ołówek")
                {
                    using (Graphics g = Graphics.FromImage(drawingBitmap))
                    {
                        g.DrawLine(pen, startPoint, currentPoint);
                        startPoint = currentPoint;
                    }
                    panelCanvas.Invalidate(new Rectangle(currentPoint.X - 10, currentPoint.Y - 10, 20, 20));
                }
                else
                {
                    panelCanvas.Invalidate();
                }
            }
        }

        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;

            using (Graphics g = Graphics.FromImage(drawingBitmap))
            {
                if (drawingMode == "Linia")
                {
                    g.DrawLine(pen, startPoint, currentPoint);
                }
                else if( drawingMode == "Prostokąt")
                {
                    int width = Math.Abs(currentPoint.X - startPoint.X);
                    int height = Math.Abs(currentPoint.Y - startPoint.Y);
                    g.DrawRectangle(pen, Math.Min(startPoint.X, currentPoint.X), Math.Min(startPoint.Y, currentPoint.Y), width, height);
                }
                else if (drawingMode == "Okrąg")
                {
                    int diameter = Math.Max(Math.Abs(currentPoint.X - startPoint.X), Math.Abs(currentPoint.Y - startPoint.Y));
                    g.DrawEllipse(pen, Math.Min(startPoint.X, currentPoint.X), Math.Min(startPoint.Y, currentPoint.Y), diameter, diameter);
                }
            }
            panelCanvas.Invalidate();
        }

        private void InitCanvas()
        {
            drawingBitmap = new Bitmap(panelCanvas.Width, panelCanvas.Height);
            graphics = Graphics.FromImage(drawingBitmap);
            graphics.Clear(Color.White);
            panelCanvas.BackgroundImage = drawingBitmap;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            panelCanvas.Invalidate();

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pen.Color = dlg.Color;
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sdlg = new SaveFileDialog())
            {
                sdlg.Filter = "Pliki PNG|*.png|Pliki JPG|*.jpg";
                if (sdlg.ShowDialog() == DialogResult.OK)
                {
                    drawingBitmap.Save(sdlg.FileName);
                    MessageBox.Show("Obraz zapisany!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnBackgroundColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    backGroundColor = dlg.Color;
                }
            }
        }

        private void comboBoxShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            drawingMode = comboBoxShape.SelectedItem.ToString();

        }

        private void trackBarSize_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackBarSize.Value;
            lblSize.Text = "Grubość" + trackBarSize.Value.ToString();

        }

        private void panelCanvas_Paint(object sender, PaintEventArgs e)
        {
            if ( isDrawing && (drawingMode == "Linia" || drawingMode == "Prostokąt" || drawingMode == "Okrąg"))
            {
                using (Pen previewPen = new Pen(pen.Color, pen.Width))
                {
                    previewPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                    if (drawingMode == "Linia")
                    {
                        e.Graphics.DrawLine(pen, startPoint, currentPoint);
                    }
                    else if (drawingMode == "Prostokąt")
                    {
                        int width = Math.Abs(currentPoint.X - startPoint.X);
                        int height = Math.Abs(currentPoint.Y - startPoint.Y);
                        e.Graphics.DrawRectangle(pen, Math.Min(startPoint.X, currentPoint.X), Math.Min(startPoint.Y, currentPoint.Y), width, height);
                    }
                    else if (drawingMode == "Okrąg")
                    {
                        int diameter = Math.Max(Math.Abs(currentPoint.X - startPoint.X), Math.Abs(currentPoint.Y - startPoint.Y));
                        e.Graphics.DrawEllipse(pen, Math.Min(startPoint.X, currentPoint.X), Math.Min(startPoint.Y, currentPoint.Y), diameter, diameter);
                    }
                }
            }
        }

        

    }
}
