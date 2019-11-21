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

namespace HanLightMarket
{
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=testdb;username=root;password=1111");
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM member",  connection);

            connection.Open();
            try
            {
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "member");
                dataGridView1.DataSource = dataSet.Tables["member"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
