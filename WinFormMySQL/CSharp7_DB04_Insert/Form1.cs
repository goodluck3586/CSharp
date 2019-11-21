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

namespace CSharp7_DB04_Insert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;

        private void Form1_Load(object sender, EventArgs e)
        {
            dataAdapter = new MySqlDataAdapter();
            dataSet = new DataSet();

            conn = new MySqlConnection("server=localhost;port=3306;database=world;uid=root;pwd=1111");

            try
            {
                conn.Open();
                /* Create the SelectCommand. */
                string queryStr = "SELECT * FROM city WHERE countryCode=@countryCode";  // SelectCommand.Parameters 사용
                dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
                dataAdapter.SelectCommand.Parameters.Add("@countryCode", MySqlDbType.VarChar, 3);  // 매개변수 추가(형식 지정)  // SelectCommand.Parameters 사용
                dataAdapter.SelectCommand.Parameters["@countryCode"].Value = "KOR";  // 매개변수에 값 저장  // SelectCommand.Parameters 사용  
                
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, "City") == 0)
                    MessageBox.Show("찾는 데이터가 없습니다.");
                else
                    dataGridView1.DataSource = dataSet.Tables["City"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // SQL문 정의
            string queryStr = "INSERT INTO city (name, countrycode, district, population) VALUES(@name, @countrycode, @district, @population)";

            // InsertCommand.Parameter 객체 생성
            dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);

            // InsertCommand.Parameter 추가
            dataAdapter.InsertCommand.Parameters.Add("@name", MySqlDbType.VarChar, 35);
            dataAdapter.InsertCommand.Parameters.Add("@countrycode", MySqlDbType.VarChar, 3);
            dataAdapter.InsertCommand.Parameters.Add("@district", MySqlDbType.VarChar, 20);
            dataAdapter.InsertCommand.Parameters.Add("@population", MySqlDbType.Int32, 11);

            // InsertCommand.Parameter에 값 저장
            dataAdapter.InsertCommand.Parameters["@name"].Value = textBoxName.Text;
            dataAdapter.InsertCommand.Parameters["@countrycode"].Value = textBoxCountryCode.Text;
            dataAdapter.InsertCommand.Parameters["@district"].Value = textBoxDistrict.Text;
            dataAdapter.InsertCommand.Parameters["@population"].Value = int.Parse(textBoxPopulation.Text);

            dataAdapter.InsertCommand.ExecuteNonQuery();

            dataSet.Clear();  // 이전 데이터 지우기
            dataAdapter.Fill(dataSet, "city");
            dataGridView1.DataSource = dataSet.Tables["city"];
        }

        private void btnInsertDataSet_Click(object sender, EventArgs e)
        {
            DataRow newRow = dataSet.Tables["city"].NewRow();
            newRow["Name"] = textBoxName.Text;
            newRow["countryCode"] = textBoxCountryCode.Text;
            newRow["district"] = textBoxDistrict.Text;
            newRow["population"] = int.Parse(textBoxPopulation.Text);
            dataSet.Tables["city"].Rows.Add(newRow);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dataAdapter.Update(dataSet, "city");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // SQL문 정의
            string queryStr = "DELETE FROM city WHERE id=@id";

            #region 동적 쿼리를 이용하는 방법
            //dataAdapter.DeleteCommand = new MySqlCommand(queryStr, conn);
            //dataAdapter.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int32, 11, "id");
            //dataAdapter.DeleteCommand.Parameters["@id"].Value = (int)dataGridView1.CurrentRow.Cells["id"].Value;
            //dataAdapter.DeleteCommand.ExecuteNonQuery();

            //dataSet.Clear();
            //dataAdapter.Fill(dataSet, "city");
            //dataGridView1.DataSource = dataSet.Tables["city"];
            #endregion

            #region Update()를 이용하는 방법
            int id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
            dataAdapter.DeleteCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int32, 11, "id");

            string FilterStr = "id=" + id;
            DataRow[] FindRow = dataSet.Tables["city"].Select(FilterStr);
            FindRow[0].Delete();

            dataAdapter.Update(dataSet, "city");
            dataSet.Clear();
            dataAdapter.Fill(dataSet, "city");
            dataGridView1.DataSource = dataSet.Tables["city"];
            #endregion
        }
    }
}
