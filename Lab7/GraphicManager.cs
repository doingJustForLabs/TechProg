using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7
{
    class GraphicManager
    {
        private Dictionary<string, Bitmap> functionGraphs = new Dictionary<string, Bitmap>();

        public void PreRenderGraphs()
        {
            functionGraphs["exp(x)"] = DrawFunctionGraph(
                x => Math.Exp(x),
                -2, 2,
                "y = exp(x)",
                yMin: -0.5,
                yMax: 8
            );

            functionGraphs["ln(x)"] = DrawFunctionGraph(
                x => Math.Log(x),
                0.01, 3,
                "y = ln(x)",
                yMin: -4,
                yMax: 2,
                isLogarithmic: true
            );

            functionGraphs["lg(x)"] = DrawFunctionGraph(
                x => Math.Log10(x),
                0.01, 3,
                "y = lg(x)",
                yMin: -2,
                yMax: 1,
                isLogarithmic: true
            );
        }

        private Bitmap DrawFunctionGraph(Func<double, double> func, double xMin, double xMax, string title,
                               double yMin, double yMax, bool isLogarithmic = false)
        {
            int width = 200;
            int height = 150;
            Bitmap bmp = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                Pen axisPen = new Pen(Color.Black, 1);
                Pen graphPen = new Pen(Color.Blue, 2);
                Font font = new Font("Arial", 8);
                Brush textBrush = Brushes.Black;

                int originX = (int)(width * (-xMin) / (xMax - xMin));
                int originY = (int)(height * (yMax) / (yMax - yMin));

                g.DrawLine(axisPen, 10, originY, width - 10, originY); // Ось X
                g.DrawLine(axisPen, originX, 10, originX, height - 10); // Ось Y

                g.DrawString("x", font, textBrush, width - 15, originY - 15);
                g.DrawString("y", font, textBrush, originX + 5, 5);

                SizeF titleSize = g.MeasureString(title, font);
                g.DrawString(title, font, textBrush, (width - titleSize.Width) / 2, 5);

                if (isLogarithmic)
                {
                    // Асимптота при x=0
                    g.DrawLine(new Pen(Color.Red, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash },
                              originX, 10, originX, height - 10);

                    // Точка (1,0)
                    int x1 = (int)(originX + (1 - xMin) * (width - 20) / (xMax - xMin));
                    int y1 = originY;
                    g.FillEllipse(Brushes.Red, x1 - 2, y1 - 2, 4, 4);
                }

                // Рисуем график
                List<PointF> points = new List<PointF>();
                double scaleX = (width - 20) / (xMax - xMin);
                double scaleY = height / (yMax - yMin);

                for (double x = xMin; x <= xMax; x += 0.01)
                {
                    try
                    {
                        double y = func(x);
                        float px = (float)(10 + (x - xMin) * scaleX);
                        float py = (float)(originY - y * scaleY);

                        if (py >= 10 && py <= height - 10)
                        {
                            points.Add(new PointF(px, py));
                        }
                    }
                    catch { }
                }

                if (points.Count > 1)
                {
                    g.DrawLines(graphPen, points.ToArray());
                }

                // Добавляем сетку
                Pen gridPen = new Pen(Color.LightGray, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dot };

                // Вертикальные линии сетки
                for (double x = Math.Ceiling(xMin); x <= Math.Floor(xMax); x++)
                {
                    if (x == 0) continue;
                    int xPos = (int)(10 + (x - xMin) * scaleX);
                    g.DrawLine(gridPen, xPos, 10, xPos, height - 10);
                    g.DrawString(x.ToString("0.#"), font, textBrush, xPos - 10, originY + 3);
                }

                for (double y = Math.Ceiling(yMin); y <= Math.Floor(yMax); y++)
                {
                    if (y == 0) continue;
                    int yPos = (int)(originY - y * scaleY);
                    g.DrawLine(gridPen, 10, yPos, width - 10, yPos);
                    g.DrawString(y.ToString("0.#"), font, textBrush, originX + 5, yPos - 8);
                }
            }

            return bmp;
        }

        public void UpdateFunctionGraphs(FlowLayoutPanel graphsPanel, string[] selectedFunctions)
        {
            graphsPanel.Controls.Clear();

            if (selectedFunctions == null) return;

            foreach (var funcName in selectedFunctions)
            {
                if (functionGraphs.ContainsKey(funcName))
                {
                    var pictureBox = new PictureBox
                    {
                        Image = functionGraphs[funcName],
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Width = 180,
                        Height = 130,
                        Margin = new Padding(5)
                    };
                    graphsPanel.Controls.Add(pictureBox);
                }
            }
        }
    }
}
