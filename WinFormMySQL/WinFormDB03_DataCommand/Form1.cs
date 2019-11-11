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

namespace WinFormDB03_DataCommand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn;

        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;port=3306;username=root;database=world;password=1111";
            conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                ShowConnectionState();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ShowConnectionState()
        {
            if (conn.State == ConnectionState.Open)
            {
                labelDBConnStatus.Text = "연결 성공";
                labelDBConnStatus.ForeColor = Color.Green;
            }
            else
            {
                labelDBConnStatus.Text = "연결 실패";
                labelDBConnStatus.ForeColor = Color.Red;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"SELECT * FROM city WHERE id='{txtId.Text}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtName.Text = reader.GetString("Name");
                    txtCountryCode.Text = reader.GetString("CountryCode");
                    txtDistrict.Text = reader.GetString("District");
                    txtPopulation.Text = reader.GetInt32("Population").ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                txtPopulation.Text = txtPopulation.Text == "" ? "0" : txtPopulation.Text;
                string sql = $"INSERT INTO city (Name, CountryCode, District, Population) VALUES('{txtName.Text}', '{txtCountryCode.Text}', '{txtDistrict.Text}', '{txtPopulation.Text}')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                // SQL 문을 실행하고 영향을 받은 행 수를 리턴한다.
                if (cmd.ExecuteNonQuery()==1)
                {
                    ShowDataAfterInserted();
                    MessageBox.Show("Data Inserted.");
                }
                else
                {
                    MessageBox.Show("Data Not Inserted.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        void ShowDataAfterInserted()
        {
            try
            {
                string sql = $"SELECT * FROM city WHERE Name='{txtName.Text}' AND CountryCode='{txtCountryCode.Text}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text = reader.GetString("Id");
                    txtName.Text = reader.GetString("Name");
                    txtCountryCode.Text = reader.GetString("CountryCode");
                    txtDistrict.Text = reader.GetString("District");
                    txtPopulation.Text = reader.GetInt32("Population").ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"UPDATE city SET Name='{txtName.Text}', CountryCode='{txtCountryCode.Text}', District='{txtDistrict.Text}', Population='{txtPopulation.Text}' WHERE ID='{txtId.Text}'";  
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    ShowDataAfterInserted();
                    MessageBox.Show("Data Updated.");
                }
                else
                {
                    MessageBox.Show("Data Not Updated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTextBoxClear_Click(object sender, EventArgs e)
        {
            TextBoxClear();
        }

        private void TextBoxClear()
        {
            txtId.Clear();
            txtName.Clear();
            txtCountryCode.Clear();
            txtDistrict.Clear();
            txtPopulation.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"DELETE FROM city WHERE id='{txtId.Text}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    TextBoxClear();
                    MessageBox.Show("Data Deleted.");
                }
                else
                {
                    MessageBox.Show("Data Not Deleted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
