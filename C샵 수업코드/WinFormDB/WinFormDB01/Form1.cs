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

namespace WinFormDB01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection connection;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // MySqlConnection 생성자는 연결 문자열을 매개 변수 중 하나로 사용한다. 
                // 연결 문자열은 MySQL 데이터베이스에 연결하는 데 필요한 정보를 제공한다.

                string connectionString = "Server=localhost;port=3306;username=root;password=1111"; 
                //string connectionString = "server=127.0.0.1;uid=root;pwd=12345;database=test";
                // 1. MySqlConnection connection = new MySqlConnection(connectionString);

                connection = new MySqlConnection(connectionString);  // 2
                connection.Open();
                ShowConnectionState();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDBOpen_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                ShowConnectionState();
            }
        }
        private void btnDBClose_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                ShowConnectionState();
            }
        }

        private void ShowConnectionState()
        {
            if (connection.State == ConnectionState.Open)
            {
                label1.Text = "Connected";
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.Text = "Not Connected";
                label1.ForeColor = Color.Red;
            }
        }
    }
}
