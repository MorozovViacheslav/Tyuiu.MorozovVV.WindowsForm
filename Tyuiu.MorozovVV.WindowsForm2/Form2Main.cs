using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.MorozovVV.WindowsForm._2
{
    public partial class Form2Main : Form
    {
        public Form2Main()
        {
            InitializeComponent();
        }

        public double[] GetMassFunction(int startValue, int stopValue)

        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((Math.Pow(x, 3) - 15 * x) != 0)
                {
                    y = Math.Round(Math.Abs(Math.Pow(x, 2) - Math.Pow(x, 3)) - (Math.Cos(Math.Pow(x, 3)) + 7 * Math.Pow(x, 2)) / (Math.Pow(x, 3) - 15 * x), 2);

                    valueArray[count] = y;
                    count++;
                }
                else
                {

                    count++;
                }

            }
            return valueArray;

        }

            private void pictureBoxFunc_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonDev_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы НТм-22-1\t\nМорозов Вячеслав Валерьевич\t", "Разработчик", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(numericStart.Text);
                int finish = Convert.ToInt32(numericFinish.Text);


                double[] valueArray = GetMassFunction(start, finish);

                textBoxRes.Clear();


                for (int i = 0; i < valueArray.Length; i++)
                {
                    textBoxRes.AppendText($"{valueArray[i]}\r\n");
                }

                chartRes.Series.Clear();

                Series series = new Series("Graph");
                series.ChartType = SeriesChartType.Line;

                for (int i = 0; i < valueArray.Length; i++)
                {
                    series.Points.AddXY(i + start, valueArray[i]);
                }

                chartRes.Series.Add(series);

            }
            catch
            {
                MessageBox.Show("Что-то пошло не так...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericFinish_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRes_TextChanged(object sender, EventArgs e)
        {

        }

        private void chartRes_Click(object sender, EventArgs e)
        {

        }

        private void labelStart_Click(object sender, EventArgs e)
        {

        }

        private void labelFinish_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
