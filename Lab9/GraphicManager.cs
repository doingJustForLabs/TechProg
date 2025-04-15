using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Lab9
{
    class GraphicManager
    {
        public ZedGraphControl zedGraphControl;

        public GraphicManager(ZedGraphControl zedGraphControl)
        {
            this.zedGraphControl = zedGraphControl;
            DrawGraph();
        }

        private void DrawGraph()
        {
            GraphPane pane = zedGraphControl.GraphPane;
            pane.CurveList.Clear();

            int itemscount = 5;

            Random rnd = new Random();

            // Высоты столбиков
            double[] YValues1 = new double[itemscount];
            double[] YValues2 = new double[itemscount];
            double[] YValues3 = new double[itemscount];

            double[] XValues = new double[itemscount];

            // Заполним данные
            for (int i = 0; i < itemscount; i++)
            {
                XValues[i] = i + 1;

                YValues1[i] = rnd.NextDouble();
                YValues2[i] = rnd.NextDouble();
                YValues3[i] = rnd.NextDouble();
            }

            // Создадим три гистограммы
            // Так как для всех гистограмм мы передаем одинаковые массивы координат по X,
            // то столбики будут группироваться в кластеры в этих точках.
            BarItem bar1 = pane.AddBar("Values1", XValues, YValues1, Color.Blue);
            BarItem bar2 = pane.AddBar("Values2", XValues, YValues2, Color.Red);
            BarItem bar3 = pane.AddBar("Values3", XValues, YValues3, Color.Yellow);

            // !!! Расстояния между столбиками в кластере (группами столбиков)
            //pane.BarSettings.MinBarGap = 0.0f;

            // !!! Увеличим расстояние между кластерами в 2.5 раза
            //pane.BarSettings.MinClusterGap = 3f;


            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            zedGraphControl.AxisChange();

            // Обновляем график
            zedGraphControl.Invalidate();
        }
    }
}
