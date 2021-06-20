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
    public partial class Doc : Form
    {
        public Doc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=localhost;userid=root;password=123123;database=dantist";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = new MySqlCommand("insert into clients(name,phone) values (@name, @phone)")
                {
                    Connection = connection
                };
                command.Parameters.AddWithValue("name", name.Text);
                command.Parameters.AddWithValue("phone", phone.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Запись прошла успешно");
                Log.Logger("Удачная запись");
            }
            catch (MySqlException)
            {
                MessageBox.Show("Возникла ошибка при подключении к БД");
                Log.Logger("Неудачная запись");
            }
        }
    }
}
