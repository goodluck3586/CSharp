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

namespace WinFormDB09_Tab
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            string connStr = "server=localhost;port=3306;database=world;uid=root;pwd=1111";
            conn = new MySqlConnection(connStr);

            dataAdapter = new MySqlDataAdapter("SELECT * FROM city", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "city");
            dataAdapter = new MySqlDataAdapter("SELECT * FROM countrylanguage", conn);
            dataAdapter.Fill(dataSet, "countryLanguage");
            dataAdapter = new MySqlDataAdapter("SELECT * FROM country", conn);
            dataAdapter.Fill(dataSet, "country");
            dataGridViewCity.DataSource = dataSet.Tables["city"];
            dataGridViewCountryLanguage.DataSource = dataSet.Tables["countrylanguage"];
            dataGridViewCountry.DataSource = dataSet.Tables["country"];
        }
    }
}
