using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SApp02
{
    public partial class CheckNumberControl : UserControl
    {
        public CheckNumberControl()
        {
            InitializeComponent();
            UpdateUI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(inputNumberTextBox.Text, out int number))
            {
                if (MessageBox.Show($"Вы ввели корректное число {number}.\nВывести подробную информацию?",
                    "Проверка данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show(number >= 0 ? "Больше или равен нулю" : "Меньше нуля",
                    "Проверка данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show($"Вы ввели некорректное число",
                    "Проверка данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            checkButton.Enabled = inputNumberTextBox.Text == string.Empty ? false : true;
        }
    }
}
