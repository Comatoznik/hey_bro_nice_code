using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Diplom
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(@"Data Source = localhost; Initial Catalog = dantist; User Id = root; Password = 123123;Integrated Security = True");


            DataSet ds = new DataSet();


            MySqlDataAdapter ad = new MySqlDataAdapter("Select name as Имя, phone as Телефон from clients", con);// параметры- команда для выполнения + connection
            ad.Fill(ds, "Table"); // заполнение DataSet данными из БД
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
