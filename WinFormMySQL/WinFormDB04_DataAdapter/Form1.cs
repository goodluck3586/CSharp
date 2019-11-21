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

namespace WinFormDB04_DataAdapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        MySqlDataAdapter adapter;
        DataTable table = new DataTable();
        int position = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=localhost;port=3306;username=root;database=world;password=1111");

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    labelDBConnStatus.Text = "연결 성공";
                    labelDBConnStatus.ForeColor = Color.Green;
                }

                adapter = new MySqlDataAdapter("SELECT * FROM city", conn);
                adapter.Fill(table);
                ShowData(position);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        /* 화면의 TextBox에 선택된 데이터를 출력하는 메소드 */
        private void ShowData(int index)
        {
            txtId.Text = table.Rows[index][0].ToString();
            txtName.Text = table.Rows[index][1].ToString();
            txtCountryCode.Text = table.Rows[index][2].ToString();
            txtDistrict.Text = table.Rows[index][3].ToString();
            txtPopulation.Text = table.Rows[index][4].ToString();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            position = 0;
            ShowData(position);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            position++;
            if (position < table.Rows.Count)
                ShowData(position);
            else
            {
                MessageBox.Show("데이터 없음.");
                position = table.Rows.Count - 1;
            }   
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            position--;
            if (position >= 0)
                ShowData(position);
            else
            {
                MessageBox.Show("데이터 없음.");
                position = 0;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            position = table.Rows.Count - 1;
            ShowData(position);
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
