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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

       

     
     


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Log.Logger("Открыта форма телестоматологии");
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           // 1 true
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 3 true
        }

        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1 true
        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1 true
        }

        private void checkedListBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1 true
        }

        private void checkedListBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 2 true
        }

        private void checkedListBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1 true
        }

        private void checkedListBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 6 true
        }

        private void checkedListBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 2 true
        }

        private void checkedListBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 3 true
        }

       
       
        private void label18_Click(object sender, EventArgs e)
        {
           
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
