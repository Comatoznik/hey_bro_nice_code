using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Log.Logger("Открыта форма 3D печати");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ConsoleApp4.exe");

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            //TEST 1 TRUE
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            //TEST 2 TRUE
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            //TEST 4 TRUE
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            //TEST 3 TRUE
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

       

       
    }
}
