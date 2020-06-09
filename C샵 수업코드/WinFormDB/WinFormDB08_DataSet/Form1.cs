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

namespace WinFormDB08_DataSet
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

        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;port=3306;database=world;uid=root;pwd=1111";
            conn = new MySqlConnection(connStr);
            dataAdapter = new MySqlDataAdapter("SELECT * FROM city", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "city");
            dataGridView1.DataSource = dataSet.Tables["city"];
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string queryStr = "SELECT * FROM city WHERE countryCode = @countryCode";  // SelectCommand.Parameters 사용

            dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.SelectCommand.Parameters.Add("@countryCode", MySqlDbType.VarChar, 3);  // 매개변수 추가(형식 지정)  // SelectCommand.Parameters 사용
            dataAdapter.SelectCommand.Parameters["@countryCode"].Value = txtCountryCode.Text;  // 매개변수에 값 저장  // SelectCommand.Parameters 사용  
            
            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, "city") > 0)
                    dataGridView1.DataSource = dataSet.Tables["city"]; 
                else
                    MessageBox.Show("찾는 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            #region Parameter를 이용한 처리
            //string queryStr = "INSERT INTO city (name, countrycode, district, population) " +
            //    "VALUES(@name, @countrycode, @district, @population)";

            //dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
            //dataAdapter.InsertCommand.Parameters.AddWithValue("@name", txtName.Text);
            //dataAdapter.InsertCommand.Parameters.AddWithValue("@countrycode", txtCountryCode.Text);
            //dataAdapter.InsertCommand.Parameters.AddWithValue("@district", txtDistrict.Text);
            //dataAdapter.InsertCommand.Parameters.AddWithValue("@population", txtPopulation.Text);

            //try
            //{
            //    conn.Open();
            //    dataAdapter.InsertCommand.ExecuteNonQuery();

            //    dataSet.Clear();  // 이전 데이터 지우기
            //    dataAdapter.Fill(dataSet, "city");
            //    dataGridView1.DataSource = dataSet.Tables["city"];
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    conn.Close();
            //}
            #endregion

            #region Update를 이용한 처리
            string queryStr = "INSERT INTO city (name, countrycode, district, population) " +
                "VALUES(@name, @countrycode, @district, @population)";

            dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@name", txtName.Text);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@countrycode", txtCountryCode.Text);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@district", txtDistrict.Text);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@population", txtPopulation.Text);

            DataRow newRow = dataSet.Tables["city"].NewRow();
            newRow["name"] = txtName.Text;
            newRow["countrycode"] = txtCountryCode.Text;
            newRow["district"] = txtDistrict.Text;
            newRow["population"] = txtPopulation.Text;
            dataSet.Tables["city"].Rows.Add(newRow);

            dataAdapter.Update(dataSet, "city");

            dataSet.Clear();
            dataAdapter.Fill(dataSet, "city");
            dataGridView1.DataSource = dataSet.Tables["city"];
            #endregion
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region Parameter를 이용한 처리
            //string sql = "UPDATE city SET name=@name, countrycode=@countrycode, district=@district, population=@population WHERE id=@id";
            //dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            //dataAdapter.UpdateCommand.Parameters.AddWithValue("@id", dataGridView1.SelectedRows[0].Cells["id"].Value);
            //dataAdapter.UpdateCommand.Parameters.AddWithValue("@name", txtName.Text);
            //dataAdapter.UpdateCommand.Parameters.AddWithValue("@countrycode", txtCountryCode.Text);
            //dataAdapter.UpdateCommand.Parameters.AddWithValue("@district", txtDistrict.Text);
            //dataAdapter.UpdateCommand.Parameters.AddWithValue("@population", txtPopulation.Text);

            //try
            //{
            //    conn.Open();
            //    dataAdapter.UpdateCommand.ExecuteNonQuery();

            //    dataSet.Clear();  // 이전 데이터 지우기
            //    dataAdapter.Fill(dataSet, "city");
            //    dataGridView1.DataSource = dataSet.Tables["city"];
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    conn.Close();
            //}
            #endregion

            #region Update() 이용
            string sql = "UPDATE city SET name=@name, countrycode=@countrycode, district=@district, population=@population WHERE id=@id";
            dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@id", dataGridView1.SelectedRows[0].Cells["id"].Value);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@name", txtName.Text);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@countrycode", txtCountryCode.Text);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@district", txtDistrict.Text);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@population", txtPopulation.Text);

            //  하나의 row만 수정
            int id = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
            string filter = "id=" + id;
            DataRow[] findRows = dataSet.Tables["city"].Select(filter);
            findRows[0]["id"] = id;
            findRows[0]["name"] = txtName.Text;
            findRows[0]["countrycode"] = txtCountryCode.Text;
            findRows[0]["district"] = txtDistrict.Text;
            findRows[0]["population"] = txtPopulation.Text;

            // 선택된 다수의 rows 수정
            var selectedRows = dataGridView1.SelectedRows;
            int id;
            string filter;
            for (int i = 0; i < selectedRows.Count; i++)
            {
                id = (int)dataGridView1.SelectedRows[i].Cells["id"].Value;
                filter = "id=" + id;
                DataRow[] findRows = dataSet.Tables["city"].Select(filter);
                findRows[0]["id"] = id;
                findRows[0]["name"] = (string)dataGridView1.SelectedRows[i].Cells["name"].Value;
                findRows[0]["countrycode"] = (string)dataGridView1.SelectedRows[i].Cells["countrycode"].Value;
                findRows[0]["district"] = txtDistrict.Text;
                findRows[0]["population"] = (int)dataGridView1.SelectedRows[i].Cells["population"].Value;
            }

            dataAdapter.Update(dataSet, "city");
            dataSet.Clear();
            dataAdapter.Fill(dataSet, "city");
            dataGridView1.DataSource = dataSet.Tables["city"];
            #endregion
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            #region Parameter를 이용한 처리
            //string sql = "DELETE FROM city WHERE id=@id";
            //dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
            //dataAdapter.DeleteCommand.Parameters.AddWithValue("@id", dataGridView1.SelectedRows[0].Cells["id"].Value);

            //try
            //{
            //    conn.Open();
            //    dataAdapter.DeleteCommand.ExecuteNonQuery();

            //    dataSet.Clear();
            //    dataAdapter.Fill(dataSet, "city");
            //    dataGridView1.DataSource = dataSet.Tables["city"];
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    conn.Close();
            //}
            #endregion

            #region Update() 이용
            string sql = "DELETE FROM city WHERE id=@id";
            dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@id", dataGridView1.SelectedRows[0].Cells["id"].Value);

            int id = (int)dataGridView1.CurrentRow.Cells["id"].Value;

            string filter = "id=" + id;
            DataRow[] findRows = dataSet.Tables["city"].Select(filter);
            findRows[0].Delete();

            dataAdapter.Update(dataSet, "city");

            dataSet.Clear();
            dataAdapter.Fill(dataSet, "city");
            dataGridView1.DataSource = dataSet.Tables["city"];
            #endregion
        }
    }
}
