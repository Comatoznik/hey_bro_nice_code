using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void наГлавнуюФормуToolStripMenuItem_Click(object sender, EventArgs e) //переход на главную
        {
            Form2.ActiveForm.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void посланиеОтРазработчикаToolStripMenuItem_Click(object sender, EventArgs e) // переход на послание от разработчика
        {
            Form2.ActiveForm.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }
    }
}
