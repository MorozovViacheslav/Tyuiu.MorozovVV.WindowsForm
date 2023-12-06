using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.MorozovVV.WindowsForm
{
    public partial class Form1Main : Form
    {
        public Form1Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void labelVarX_Click(object sender, EventArgs e)
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
                int x = Convert.ToInt32(textBoxVarX.Text);
                int y = Convert.ToInt32(textBoxVarY.Text);

                if (radioButton1.Checked)
                {
                    double result = (3 + Math.Exp(y - 1)) / (1 + Math.Pow(x, 2) * Math.Abs(y - Math.Tan(x)));
                    textBoxRes.Text = Convert.ToString(Math.Round(result, 3));
                }
                else if (radioButton2.Checked)
                {
                    double result = (Math.Pow(y, 2) - Math.Cos(Math.Pow(x, 2)) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(y, 2)) + 12);
                    textBoxRes.Text = Convert.ToString(Math.Round(result, 3));
                }
                else
                {
                    MessageBox.Show("Для проведения расчётов\nнеобходимо выбрать\nхотя бы одной уравнение!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Во время проведения расчётов произошла ошибка!\nПроверьте введённые данные!\nВыполните проверку деления на ноль!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVarX_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVarZ_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxFunc1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxFunc2_Click(object sender, EventArgs e)
        {

        }
    }
}
