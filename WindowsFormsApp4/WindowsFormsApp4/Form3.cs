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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void наГлавнуюФормуToolStripMenuItem_Click(object sender, EventArgs e)// переход на главную
        {
            Form3.ActiveForm.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e) // переход на справку
        {
            Form3.ActiveForm.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
