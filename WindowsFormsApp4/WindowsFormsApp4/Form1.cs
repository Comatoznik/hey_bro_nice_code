﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        int[] mas = new int[36];
        public Form1()
        {
            InitializeComponent();

        }
        private void sort_Click(object sender, EventArgs e) // сортировка массива
        {
            Array.Sort(mas);
            for (int i = 0; i < mas.Length; i++)
                dataGridView1.Rows[0].Cells[i].Value = mas[i];
        }
        public void rndmas_Click(object sender, EventArgs e) //рандомное заполнение массива
        {
            dataGridView1.ColumnCount = 36;
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(-100, 100);
                dataGridView1.Rows[0].Cells[i].Value = mas[i];} // заполнение ячеек 
            }
        

        private void clear_Click(object sender, EventArgs e) //очистка
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                dataGridView1.Rows[0].Cells[i].Value = "";
            label2.Text = "";
            label3.Text = "";

        }

        private void off_Click(object sender, EventArgs e) // закрытие программы
        {
            if (MessageBox.Show("Вы уверены?", "Предупреждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
            
        }

        private void quest_Click(object sender, EventArgs e) // задание
        {
            int min1;
            int min2;
            min1 = min2 = mas[0];
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > 0 && min1 > mas[i])
                {
                    min1 = mas[i];
                    int index1 = i + 1;
                    label2.Text = "Минимальный элемент №1 :" + min1.ToString() + " Его индекс : " + index1;
                }
                if (mas[i] > min1 && min2 > mas[i])
                {
                    min2 = mas[i];
                    int index2 = i + 1;
                    label3.Text = "Минимальный элемент №2 :" + min2.ToString() + " Его индекс : " + index2;
                }
            }
                if (mas[0] < 0)
                    MessageBox.Show("Первый элемент должен быть положительным!");
            

        }

        private void graph_Click(object sender, EventArgs e) //работа с графиком
        {
            int[] x = mas;
            int[] y = new int[36];
            for (int i = 0; i < 36; i++)
            {
                y[i] = mas[i];
                x[i] = i;
                chart1.ChartAreas[0].AxisY.MajorGrid.Interval = 1;
                chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 2;
                chart1.Series[0].Points.DataBindXY(x, y);
            }
        }

        private void file_Click(object sender, EventArgs e) //файловый ввод 
        {
            try
            {
                StreamReader f = new StreamReader(@"C:\\file.txt");

                string[] a = f.ReadToEnd().Split('\n');
                for (int i = 0; i < 36; i++)
                {
                    dataGridView1.Rows[0].Cells[i].Value = a[i];
                    mas[i] = Convert.ToInt32(a[i]);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл не найден!");
            }
        }

        

        public void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();   
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
            
        }
    }
}