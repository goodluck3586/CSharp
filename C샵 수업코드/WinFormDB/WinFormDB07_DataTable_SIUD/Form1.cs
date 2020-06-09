using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp7_DB02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable table1;
        private void Form1_Load(object sender, EventArgs e)
        {
            // 1 단계: 테이블과 컬럼 만들기(DataTable과 DataColumn)
            table1 = new DataTable("table1");
            DataColumn Col1 = new DataColumn("Name", typeof(string));  // typeof => 시스템 타입 객체를 리턴해 준다. int => Int32
            Col1.MaxLength = 10;
            Col1.AllowDBNull = false;

            table1.Columns.Add(Col1);
            Col1 = new DataColumn("Age", typeof(int));
            table1.Columns.Add(Col1);
            Col1 = new DataColumn("Male", typeof(bool));
            table1.Columns.Add(Col1);

            // 2 단계: 행 생성 및 데이터 입력(DataRow)
            DataRow row = table1.NewRow();
            row["Name"] = "아이유";
            row["Age"] = 26;
            row["Male"] = false;
            table1.Rows.Add(row);

            row = table1.NewRow();
            row["Name"] = "수지";
            row["Age"] = 26;
            row["Male"] = false;
            table1.Rows.Add(row);

            row = table1.NewRow();
            row["Name"] = "조승우";
            row["Age"] = 39;
            row["Male"] = true;
            table1.Rows.Add(row);

            dataGridView1.DataSource = table1;
            dataGridView1.MultiSelect = false;  // 한 행만 선택
        }

        // 행(Row) 입력
        private void btnInput_Click(object sender, EventArgs e)
        {
            // 행(Row) 추가
            DataRow row = table1.NewRow();

            row["Name"] = textBoxName.Text;
            row["Age"] = int.Parse(textBoxAge.Text);  // 저장은 string이지만 Col1 = new DataColumn("Age", typeof(int));으로 넣어야 한다.
            if (rbMale.Checked)
                row["Male"] = true;
            else
                row["Male"] = false;

            table1.Rows.Add(row);

            table1.AcceptChanges();  // 입력된 데이터 반영
        }

        // 행(Row) 삭제
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // [삭제방법 1]
            //var Rows = dataGridView1.SelectedRows;  // 선택된 Row Collection 가져오기
            //int selectedRowIndex = Rows[0].Index;  // 전체에서의 상대적 위치 index 가져오기
            //DataRow Row = table1.Rows[selectedRowIndex];  // DateTable에서 선택된 Row 참조 가져오기
            //Row.Delete();

            // [삭제 방법 2]
            var row = dataGridView1.SelectedRows[0];    // 선택된 Row 가져오기
            dataGridView1.Rows.Remove(row);             // 선택된 Row 삭제

            table1.AcceptChanges();  // 삭제된 데이터 반영
        }

        // 행(Row) 수정
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var Rows = dataGridView1.SelectedRows;  // 선택된 Row Collection 가져오기
            int selectedRowIndex = Rows[0].Index;  // 전체에서의 상대적 위치 index 가져오기
            DataRow Row = table1.Rows[selectedRowIndex];  // DateTable에서 선택된 Row 참조 가져오기
            Row["Name"] = textBoxName.Text;
            Row["Age"] = int.Parse(textBoxAge.Text);
            if (rbMale.Checked)
                Row["Male"] = true;
            else
                Row["Male"] = false;
        }
    }
}
