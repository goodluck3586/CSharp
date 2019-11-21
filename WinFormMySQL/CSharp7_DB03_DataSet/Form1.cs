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

namespace CSharp7_DB03_DataSet
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
            conn = new MySqlConnection("server=localhost;port=3306;database=world;uid=root;pwd=1111");
            dataAdapter = new MySqlDataAdapter();
            dataSet = new DataSet();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Create the SelectCommand. */
            conn.Open();
            string queryStr = "SELECT * FROM city WHERE countryCode=@countryCode";  // SelectCommand.Parameters 사용

            dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.SelectCommand.Parameters.Add("@countryCode", MySqlDbType.VarChar, 3);  // 매개변수 추가(형식 지정)  // SelectCommand.Parameters 사용
            dataAdapter.SelectCommand.Parameters["@countryCode"].Value = textBox1.Text;  // 매개변수에 값 저장  // SelectCommand.Parameters 사용
            dataSet.Clear();

            if (dataAdapter.Fill(dataSet, "City") == 0)
                MessageBox.Show("찾는 데이터가 없습니다.");
            else
                dataGridView1.DataSource = dataSet.Tables["City"];
            conn.Close();
        }
    }
}
