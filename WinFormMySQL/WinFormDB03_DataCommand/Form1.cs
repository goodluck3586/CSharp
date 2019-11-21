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
                if (conn.State == ConnectionState.Open)
                {
                    labelDBConnStatus.Text = "연결 성공";
                    labelDBConnStatus.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM city WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32);
                cmd.Parameters["@id"].Value = int.Parse(txtId.Text);
                //cmd.Parameters.AddWithValue("@id", txtId.Text);
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
                string sql = $"INSERT INTO city (Name, CountryCode, District, Population) VALUES(@Name, @CountryCode, @District, @Population)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@Name", MySqlDbType.VarChar);
                cmd.Parameters.Add("@CountryCode", MySqlDbType.VarChar, 3);
                cmd.Parameters.Add("@District", MySqlDbType.VarChar);
                cmd.Parameters.Add("@Population", MySqlDbType.Int32);
                cmd.Parameters["@Name"].Value = txtName.Text;
                cmd.Parameters["@CountryCode"].Value = txtCountryCode.Text;
                cmd.Parameters["@District"].Value = txtDistrict.Text;
                cmd.Parameters["@Population"].Value = int.Parse(txtPopulation.Text);

                // SQL 문을 실행하고 영향을 받은 행 수를 리턴한다.
                if (cmd.ExecuteNonQuery()==1)
                {
                    ShowInsertedData("Data Inserted");
                    TextBoxClear();
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

        /* 새로운 데이터를 추가하고 MessageBox로 보여주는 메소드 */
        void ShowInsertedData(string caption)
        {
            try
            {
                string sql = "SELECT * FROM city WHERE name=@name AND countrycode=@countrycode";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@name", MySqlDbType.VarChar);
                cmd.Parameters.Add("@countrycode", MySqlDbType.VarChar, 3);
                cmd.Parameters["@name"].Value = txtName.Text;
                cmd.Parameters["@countrycode"].Value = txtCountryCode.Text;

                MySqlDataReader reader = cmd.ExecuteReader();
                string result="";
                if (reader.Read())
                {
                    result = $"id = {reader.GetString("Id")}\n";
                    result += $"Name = {reader.GetString("Name")}\n";
                    result += $"CountryCode = {reader.GetString("CountryCode")}\n";
                    result += $"District = {reader.GetString("District")}\n";
                    result += $"Population = {reader.GetInt32("Population")}\n";
                }
                reader.Close();
                MessageBox.Show(result, caption);
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
                string sql = "UPDATE city SET name=@name, countrycode=@countrycode, district=@district, population=@population where id=@id";  
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@id", MySqlDbType.VarChar);
                cmd.Parameters.Add("@Name", MySqlDbType.VarChar);
                cmd.Parameters.Add("@CountryCode", MySqlDbType.VarChar, 3);
                cmd.Parameters.Add("@District", MySqlDbType.VarChar);
                cmd.Parameters.Add("@Population", MySqlDbType.Int32);
                cmd.Parameters["@id"].Value = txtId.Text;
                cmd.Parameters["@Name"].Value = txtName.Text;
                cmd.Parameters["@CountryCode"].Value = txtCountryCode.Text;
                cmd.Parameters["@District"].Value = txtDistrict.Text;
                cmd.Parameters["@Population"].Value = int.Parse(txtPopulation.Text);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    ShowInsertedData("Data Updated.");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "DELETE FROM city WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@id", MySqlDbType.VarChar);
                cmd.Parameters["@id"].Value = txtId.Text;

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
    }
}
