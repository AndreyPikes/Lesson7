using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork7_HW1
{
    public partial class Form1 : Form
    {
        private  int counter = 0;
        private Stack<int> currentNum = new Stack<int>();
        private int targetNum = 0;
        private bool isPlaying = false;

        public Form1()
        {
            InitializeComponent();      
            lblCounter.Text = "Количество \n нажатий";

            currentNum.Push(1);
            tbNumber.Text = currentNum.Peek().ToString();
        }

        private void IncorectInput()
        {
            MessageBox.Show($"Вы ввели некорректное число",
                   "Проверка данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LostGame()
        {
            MessageBox.Show($"Вы превысили заданное число. \n Начинаем сначала",
                   "Вы проиграли", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            btnReset_Click(null, null);
        }

        private void UpdateCounter()
        {
            counter++;
            lblCounter.Text = $"Количество \n нажатий:  {counter}";
        }

        private bool IsFinishedGame(int target, int input)
        {
            if (isPlaying)
            {
                if (input > target)
                {
                    LostGame();
                    return true;
                }
                else if (input == target)
                {
                    isPlaying = false;
                    MessageBox.Show($"Вы подобрали число за {counter} попыток");
                    lblTargetNumber.Text = "Сыграйте заново!";
                    return true;
                }
                return false;
            }
            return false;
        }

        private void btnComand1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbNumber.Text, out int number))
            {
                currentNum.Push(currentNum.Peek() + 1);

                tbNumber.Text = currentNum.Peek().ToString();
                UpdateCounter();
                if (IsFinishedGame(targetNum, int.Parse(tbNumber.Text)) && isPlaying) btnReset_Click(null, null);
            }
            else IncorectInput();
        }

        private void btnComand2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbNumber.Text, out int number))
            {
                currentNum.Push(currentNum.Peek() * 2);

                tbNumber.Text = currentNum.Peek().ToString();
                UpdateCounter();
                if (IsFinishedGame(targetNum, int.Parse(tbNumber.Text)) && isPlaying) btnReset_Click(null, null);
            }
            else IncorectInput();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbNumber.Text = "1";
            UpdateCounter();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            isPlaying = true;
            counter = 0;
            tbNumber.Text = "0";
            Random random = new Random();
            targetNum = random.Next(0, 101);
            MessageBox.Show($"Загаданное число: {targetNum}");
            lblTargetNumber.Text = $"Загаданное число: {targetNum}";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (currentNum.Count > 1)
            {
                currentNum.Pop();
            }
            else MessageBox.Show($"Далее отменить нельзя");
            tbNumber.Text = currentNum.Peek().ToString();
        }
    }
}
