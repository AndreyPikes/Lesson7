using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SApp00
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // MessageBox простейший способ вывода информации на экран
            // У метода Show большое количество перезагрузок, с помощью
            // которых можно управлять видом окна сообщения
            MessageBox.Show("Сообщение из Windows Forms!");
            MessageBox.Show("Сообщение из Windows Forms с заголовком", "Заголовок");
            if (MessageBox.Show("Вы уверены, что хотите продолжить обучение?", "Заголовок",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                System.Console.WriteLine("Вы нажали OK");
            else System.Console.WriteLine("Вы нажали Cancel");
            System.Console.WriteLine("Можно выводить сообщения в консоль");
            System.Console.WriteLine("Не стоит сейчас слишком задерживаться на изучение MessageBox.Show. У вас еще будет такая возможность");
            System.Console.ReadKey();
        }

    }
}
