using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork7_HW2
{
    /*Щукин Андрей
    2. Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток.Компьютер говорит, больше или меньше загаданное число введенного.
    a) Для ввода данных от человека используется элемент TextBox;
    б) ** Реализовать отдельную форму c TextBox для ввода числа.
     Старайтесь разбивать программы на подпрограммы.Переписывайте в начало программы условие и свою фамилию.Все программы сделать в одном решении.
    В свойствах проектах в качестве запускаемого проекта укажите “Текущий выбор”.*/
    public partial class Form1 : Form
    {
        private int targetNum;
        public static int currentInput;

        public Form1()
        {
            InitializeComponent();
            SetRandomNumber();            
            StartForm2(null, null);
            btnStart.Enabled = false;
        }

        private void SetRandomNumber()
        {
            Random random = new Random();
            targetNum = random.Next(0, 101);
        }

        public void StartForm2(object sender, EventArgs e)
        {            
            Form2 inputForm = new Form2();
            inputForm.Show();
            inputForm.btnEnter.Click += StartForm2;
            if (currentInput > targetNum) lblInfo.Text =  $"Ваше число {currentInput} больше загаданного {targetNum}";
            else if (currentInput < targetNum) lblInfo.Text = $"Ваше число {currentInput} меньше загаданного {targetNum}";
            else
            {
                lblInfo.Text = "Вы угадали!!";
                inputForm.Close();
                btnStart.Enabled = true;
            } 
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            SetRandomNumber();
            StartForm2(null, null);
        }
    }
}
