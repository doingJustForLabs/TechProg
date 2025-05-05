using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Lab9
{
    static class GraphicManager
    {
        public static void CreateGraph(ZedGraphControl zgc, List<string> headers, List<List<double>> series, ChartType chartType, string title)
        {
            GraphPane pane = zgc.GraphPane;
            pane.CurveList.Clear();
            pane.Title.Text = title;
            pane.XAxis.Title.Text = headers[0];

            var x = series[0];

            for (int i = 1; i < series.Count; i++)
            {
                var y = series[i];
                PointPairList points = new PointPairList(x.ToArray(), y.ToArray());
                CurveItem curve = null;

                switch (chartType)
                {
                    case ChartType.Line:
                        curve = pane.AddCurve(headers[i], points, GetColor(i), SymbolType.None);
                        break;
                    case ChartType.Bar:
                        curve = pane.AddBar(headers[i], points, GetColor(i));
                        break;
                    case ChartType.Scatter:
                        LineItem myCurve = pane.AddCurve("Scatter", points, GetColor(i), SymbolType.Diamond);
                        myCurve.Line.IsVisible = false;
                        break;
                }
            }

            zgc.AxisChange();
            zgc.Invalidate();
        }

        private static Color GetColor(int index)
        {
            Color[] colors = { Color.Blue, Color.Red, Color.Green, Color.Orange, Color.Purple, Color.Brown };
            return colors[index % colors.Length];
        }
    }

    public enum ChartType
    {
        Scatter,
        Bar,
        Line,
    }
}
