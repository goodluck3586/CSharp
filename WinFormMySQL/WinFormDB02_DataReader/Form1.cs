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

namespace WinFormDB02_DataReader
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
            // 1. DB 연결 설정
            string connectionString = "server=localhost;port=3306;username=root;database=world;password=1111";
            conn = new MySqlConnection(connectionString);

            try
            {
                // 2. DB 열기
                conn.Open();

                // 3. SELECT 쿼리 실행 : 실행할 쿼리와 함께 MySqlCommand 객체 생성 
                string sql = "SELECT distinct continent FROM country";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                // 4. 쿼리 결과 가져오기 : ExecuteReader()로 MySqlReader객체 생성: MySqlReader 객체에는 MySqlCommand객체에서 실행된 쿼리 결과가 포함되어 있다.
                MySqlDataReader reader = cmd.ExecuteReader();

                // 5. 데이터 활용 : 
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    cbContinents.Items.Add(reader.GetString("Continent"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbContinents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = $"SELECT Name FROM country WHERE continent='{cbContinents.SelectedItem.ToString()}'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataReader reader = cmd.ExecuteReader();
            cbCountries.Items.Clear();
            while (reader.Read())  // 다음 레코드가 있으면 true
            {
                cbCountries.Items.Add(reader.GetString("Name"));
            }
            reader.Close();
        }
    }
}
