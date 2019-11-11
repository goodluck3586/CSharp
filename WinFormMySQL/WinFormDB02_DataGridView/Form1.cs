using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDB02_DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=1111");
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM world.city", connection);

            connection.Open();
            try
            {
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "city");
                dataGridView1.DataSource = dataSet.Tables["city"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }
    }
}
