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
            // MessageBox ���������� ������ ������ ���������� �� �����
            // � ������ Show ������� ���������� ������������, � �������
            // ������� ����� ��������� ����� ���� ���������
            MessageBox.Show("��������� �� Windows Forms!");
            MessageBox.Show("��������� �� Windows Forms � ����������", "���������");
            if (MessageBox.Show("�� �������, ��� ������ ���������� ��������?", "���������",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                System.Console.WriteLine("�� ������ OK");
            else System.Console.WriteLine("�� ������ Cancel");
            System.Console.WriteLine("����� �������� ��������� � �������");
            System.Console.WriteLine("�� ����� ������ ������� ������������� �� �������� MessageBox.Show. � ��� ��� ����� ����� �����������");
            System.Console.ReadKey();
        }

    }
}
