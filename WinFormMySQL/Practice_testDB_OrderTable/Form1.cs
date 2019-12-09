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

namespace Practice_testDB_OrderTable
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlDataAdapter dataAdapter, adapterCompany;
        DataSet dataSet;
        int selectedRowIndex;
        string selectedTabName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;port=3306;database=testdb;uid=root;pwd=1111";
            conn = new MySqlConnection(connStr);
            dataAdapter = new MySqlDataAdapter("SELECT * FROM orders", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "orders");
            adapterCompany = new MySqlDataAdapter("SELECT * FROM company", conn);
            adapterCompany.Fill(dataSet, "company");

            dataGridView1.DataSource = dataSet.Tables["orders"];
            dataGridView3.DataSource = dataSet.Tables["company"];
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string queryStr = "INSERT INTO orders VALUES(@memberId, @productNum, @orderNum, @orderQuantity, @orderDate, @shippingAddress)";

            dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.InsertCommand.Parameters.Add("@memberId", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@productNum", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@orderNum", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@orderQuantity", MySqlDbType.Int32);
            dataAdapter.InsertCommand.Parameters.Add("@orderDate", MySqlDbType.Date);
            dataAdapter.InsertCommand.Parameters.Add("@shippingAddress", MySqlDbType.VarChar);

            #region Parameter를 이용한 처리
            //dataAdapter.InsertCommand.Parameters["@name"].Value = txtName.Text;
            //dataAdapter.InsertCommand.Parameters["@countrycode"].Value = txtCountryCode.Text;
            //dataAdapter.InsertCommand.Parameters["@district"].Value = txtDistrict.Text;
            //dataAdapter.InsertCommand.Parameters["@population"].Value = txtPopulation.Text;

            //try
            //{
            //    conn.Open();
            //    dataAdapter.InsertCommand.ExecuteNonQuery();

            //    dataSet.Clear();                                        // 이전 데이터 지우기
            //    dataAdapter.Fill(dataSet, "city");                      // DB -> DataSet
            //    dataGridView1.DataSource = dataSet.Tables["city"];      // dataGridView에 테이블 표시
            //    ClearTextBoxes();                                       // 텍스트 박스 내용 지우기
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

            #region MySqlDataAdapter.Update()를 이용한 처리
            DataRow newRow = dataSet.Tables["orders"].NewRow();
            newRow["memberId"] = txtId.Text;
            newRow["productNum"] = txtProductNum.Text;
            newRow["orderNum"] = txtOrderNum.Text;
            newRow["orderQuantity"] = txtOrderQuantity.Text;
            newRow["orderDate"] = txtOrderDate.Text;
            newRow["shippingAddress"] = txtAddress.Text;
            dataSet.Tables["orders"].Rows.Add(newRow);

            dataAdapter.InsertCommand.Parameters["@memberId"].Value = newRow["memberId"];
            dataAdapter.InsertCommand.Parameters["@productNum"].Value = newRow["productNum"];
            dataAdapter.InsertCommand.Parameters["@orderNum"].Value = newRow["orderNum"];
            dataAdapter.InsertCommand.Parameters["@orderQuantity"].Value = newRow["orderQuantity"];
            dataAdapter.InsertCommand.Parameters["@orderDate"].Value = newRow["orderDate"];
            dataAdapter.InsertCommand.Parameters["@shippingAddress"].Value = newRow["shippingAddress"];

            dataAdapter.Update(dataSet, "orders");

            dataSet.Clear();
            dataAdapter.Fill(dataSet, "orders");
            dataGridView1.DataSource = dataSet.Tables["orders"];
            #endregion
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTabName = tabControl1.SelectedTab.Text;
            //MessageBox.Show(SelectedTab);
        }

        private void btnDeleteCompany_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM company WHERE companyName=@companyName";
            adapterCompany.DeleteCommand = new MySqlCommand(sql, conn);
            adapterCompany.DeleteCommand.Parameters.AddWithValue("@companyName", dataGridView3.SelectedRows[0].Cells["companyName"].Value);

            try
            {
                conn.Open();
                DialogResult dr = MessageBox.Show("정말 삭제하시겠습니까?", "really?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                    adapterCompany.DeleteCommand.ExecuteNonQuery();
                else
                    return;
                dataSet.Clear();
                adapterCompany.Fill(dataSet, "orders");
                dataGridView3.DataSource = dataSet.Tables["orders"];
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql="";
            if (selectedTabName=="orders")
                sql = "DELETE FROM orders WHERE memberId=@memberId";
            else if(selectedTabName == "company")
                sql = "DELETE FROM company WHERE memberId=@memberId";

            dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@memberId", dataGridView1.SelectedRows[0].Cells["memberId"].Value);

            try
            {
                conn.Open();
                DialogResult dr = MessageBox.Show("정말 삭제하시겠습니까?", "really?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                    dataAdapter.DeleteCommand.ExecuteNonQuery();
                else
                    return;
                dataSet.Clear();
                dataAdapter.Fill(dataSet, "orders");
                dataGridView1.DataSource = dataSet.Tables["orders"];
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
    }
}
