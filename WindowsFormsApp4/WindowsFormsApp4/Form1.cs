using System;
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
            Array.Sort(mas); //сортировка методом Sort
            for (int i = 0; i < mas.Length; i++)
                dataGridView1.Rows[0].Cells[i].Value = mas[i]; // заполнение ячеек dataGridViev
        }
        public void rndmas_Click(object sender, EventArgs e) //рандомное заполнение массива
        {
            dataGridView1.ColumnCount = 36; // кол-во столбцов
            Random rnd = new Random(); // рандом
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(-100, 100);// заполнение массива рандомными числами
                dataGridView1.Rows[0].Cells[i].Value = mas[i];} // заполнение ячеек 
            }
        

        private void clear_Click(object sender, EventArgs e) //очистка
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                dataGridView1.Rows[0].Cells[i].Value = ""; //очистка dataGridView
            label2.Text = "";
            label3.Text = ""; // очистка меток

        }

        private void off_Click(object sender, EventArgs e) // закрытие программы
        {
            if (MessageBox.Show("Вы уверены?", "Предупреждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close(); // диалоговое окно с подтверждением действия о закрытии программы
            
        }

        private void quest_Click(object sender, EventArgs e) // задание
        {
            int min1;
            int min2;
            min1 = min2 = mas[0];
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > 0 && min1 > mas[i]) // нахождение первого минимального элемента
                {
                    min1 = mas[i];
                    int index1 = i + 1; // индекс этого элемента
                    label2.Text = "Минимальный элемент №1 :" + min1.ToString() + " Его индекс : " + index1;//вывод на метку
                }
                if (mas[i] > min1 && min2 > mas[i])//нахождение второго минимального элемента
                {
                    min2 = mas[i];
                    int index2 = i + 1;//его индекс
                    label3.Text = "Минимальный элемент №2 :" + min2.ToString() + " Его индекс : " + index2;//вывод на метку
                }
            }
                if (mas[0] < 0)
                    MessageBox.Show("Первый элемент должен быть положительным!");
            

        }

        private void graph_Click(object sender, EventArgs e) //работа с графиком
        {
            int[] x = mas;//данные по оси Х
            int[] y = new int[36];// данные по Y
            for (int i = 0; i < 36; i++)
            {
                y[i] = mas[i];
                x[i] = i;
                chart1.ChartAreas[0].AxisY.MajorGrid.Interval = 1; //интервал по оси Y
                chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 2; //интервал по оси Х
                chart1.Series[0].Points.DataBindXY(x, y); // построение графика
            }
        }

        private void file_Click(object sender, EventArgs e) //файловый ввод 
        {
            try
            {
                StreamReader f = new StreamReader(@"C:\\file.txt");//объявление стримридера

                string[] a = f.ReadToEnd().Split('\n'); //чтение данных из файла
                for (int i = 0; i < 36; i++)
                {
                    dataGridView1.Rows[0].Cells[i].Value = a[i]; //заполнение ячеек
                    mas[i] = Convert.ToInt32(a[i]);//заполнение массива
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл не найден!");// исключение при отсутствии файла
            }
        }

        

        public void toolStripMenuItem2_Click(object sender, EventArgs e)// переход на 3 форму
        {
            Form1.ActiveForm.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();   
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e) //переход на 2 форму
        {
            Form1.ActiveForm.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
            
        }
    }
}