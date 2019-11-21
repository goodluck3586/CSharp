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
        int selectedRowIndex;

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

        // *** Select ***
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

        // *** Insert ***
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string queryStr = "INSERT INTO city (name, countrycode, district, population) " +
                "VALUES(@name, @countrycode, @district, @population)";

            dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.InsertCommand.Parameters.Add("@name", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@countrycode", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@district", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@population", MySqlDbType.Int32);

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
            DataRow newRow = dataSet.Tables["city"].NewRow();
            newRow["name"] = txtName.Text;
            newRow["countrycode"] = txtCountryCode.Text;
            newRow["district"] = txtDistrict.Text;
            newRow["population"] = txtPopulation.Text;
            dataSet.Tables["city"].Rows.Add(newRow);

            dataAdapter.InsertCommand.Parameters["@name"].Value = newRow["name"];
            dataAdapter.InsertCommand.Parameters["@countrycode"].Value = newRow["countrycode"];
            dataAdapter.InsertCommand.Parameters["@district"].Value = newRow["district"];
            dataAdapter.InsertCommand.Parameters["@population"].Value = newRow["population"];

            dataAdapter.Update(dataSet, "city");

            dataSet.Clear();
            dataAdapter.Fill(dataSet, "city");
            dataGridView1.DataSource = dataSet.Tables["city"];
            #endregion
        }

        // *** Update ***
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
            // Update를 호출하기 전에 명령을 명시적으로 설정해야 한다. 
            string sql = "UPDATE city SET district=@district WHERE countrycode=@countrycode";
            dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@id", dataGridView1.SelectedRows[0].Cells["id"].Value);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@name", txtName.Text);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@countrycode", txtCountryCode.Text);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@district", txtDistrict.Text);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@population", txtPopulation.Text);

            //int id = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
            //string filter = "id=" + id;
            //DataRow[] findRows = dataSet.Tables["city"].Select(filter);
            //findRows[0]["id"] = id;
            //findRows[0]["name"] = txtName.Text;
            //findRows[0]["countrycode"] = txtCountryCode.Text;
            //findRows[0]["district"] = txtDistrict.Text;
            //findRows[0]["population"] = txtPopulation.Text;

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
            //dataSet.Clear();
            //dataAdapter.Fill(dataSet, "city");
            //dataGridView1.DataSource = dataSet.Tables["city"];
            #endregion
        }

        // *** Delete ***
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

        private void btnTextBoxClear_Click(object sender, EventArgs e)
        {
            //ClearTextBoxes();
            Form form = new Form();
            PictureBox picture = new PictureBox();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.ClientSize = new Size(300, 100);
            form.Controls.AddRange(new Control[] { label, picture, textBox, buttonOk, buttonCancel });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            form.Text = "title";
            label.Text = "";
            textBox.Text = "";
            buttonOk.Text = "확인";
            buttonCancel.Text = "취소";

            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            picture.SetBounds(10, 10, 50, 50);
            label.SetBounds(65, 17, 100, 20);
            textBox.SetBounds(65, 40, 220, 20);
            buttonOk.SetBounds(135, 70, 70, 20);
            buttonCancel.SetBounds(215, 70, 70, 20);

            DialogResult dialogResult = form.ShowDialog();

        }

        // *** TextBox 지우기 ***
        private void ClearTextBoxes()
        {
            txtId.Clear();
            txtName.Clear();
            txtCountryCode.Clear();
            txtDistrict.Clear();
            txtPopulation.Clear();
        }

        // *** DataGridView에서 특정 셀을 선택하면, 해당 Row의 내용이 텍스트박스에 표시되도록하는 메소드 ***
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtCountryCode.Text = row.Cells[2].Value.ToString();
            txtDistrict.Text = row.Cells[3].Value.ToString();
            txtPopulation.Text = row.Cells[4].Value.ToString();
        }
    }
}
