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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void btnEnter_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbEnter.Text, out int number))
            {
                Form1.currentInput = number;
            }
            this.Close();
        }

        private void tbEnter_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Enter)
            {
                btnEnter.PerformClick();
            }
        }
    }
}
