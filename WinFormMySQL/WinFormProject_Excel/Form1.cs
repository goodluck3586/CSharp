using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WinFormProject_Excel
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;
        int selectedRowIndex;
        string fsPath = "";         // 저장할 파일 경로 저장
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

            SetSearchComboBox();
        }

        #region ComboBox 세팅
        // **** 검색 조건 ComboBox에 CountryCode 목록 세팅 ****
        private void SetSearchComboBox()
        {
            string sql = "SELECT distinct countryCode FROM city";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                // CountryCode 목록 표시
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    cbCountryCode.Items.Add(reader.GetString("countryCode"));
                }
                reader.Close();

                // District 목록 표시
                sql = "SELECT distinct district FROM city";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    cbDistrict.Items.Add(reader.GetString("district"));
                }
                reader.Close();
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

        // 검색조건에서 특정 CountryCode를 선택하면 해당 국가의 District를 채움.
        private void cbCountryCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT distinct district FROM city WHERE countrycode=@countrycode";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@countrycode", cbCountryCode.Text);

            cbDistrict.Items.Clear();        // ComboBox 데이터 초기화

            try
            {
                // District 목록 표시
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    cbDistrict.Items.Add(reader.GetString("district"));
                }
                reader.Close();
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
        #endregion

        // **** SELECT 버튼 클릭 ****
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string queryStr;

            #region Select QueryString 만들기
            string[] conditions = new string[5];
            conditions[0] = (textBoxID.Text != "") ? "id=@id" : null;
            conditions[1] = (textBoxName.Text != "") ? "name=@name" : null;
            conditions[2] = (cbCountryCode.Text != "") ? "countrycode=@countrycode" : null;
            conditions[3] = (cbDistrict.Text != "") ? "district=@district" : null;
            string condition_population;
            if (textBoxMin.Text != "" && textBoxMax.Text != "")
            {
                condition_population = "population>=@min and population<=@max";
            }
            else if (textBoxMin.Text != "" || textBoxMax.Text != "")
            {
                if (textBoxMin.Text != "")
                    condition_population = "population>=@min";
                else
                    condition_population = "population <= @max";
            }
            else
            {
                condition_population = null;
            }
            conditions[4] = condition_population;

            if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null || conditions[4] != null)
            {
                queryStr = $"SELECT * FROM city WHERE ";
                bool firstCondition = true;
                for (int i = 0; i < conditions.Length; i++)
                {
                    if (conditions[i] != null)
                        if (firstCondition)
                        {
                            queryStr += conditions[i];
                            firstCondition = false;
                        }
                        else
                        {
                            queryStr += " and " + conditions[i];
                        }
                }
            }
            else
            {
                queryStr = "SELECT * FROM city";
            }
            #endregion

            #region SelectCommand 객체 생성 및 Parameters 설정
            dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@id", textBoxID.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@name", textBoxName.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@countryCode", cbCountryCode.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@district", cbDistrict.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@min", textBoxMin.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@max", textBoxMax.Text);
            #endregion

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

        // **** DataGridView에서 행을 선택하면 새창을 띄움 ****
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];

            // 새로운 폼에 선택된 row의 정보를 담아서 생성
            Form2 Dig = new Form2(
                selectedRowIndex,
                row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString()
                );

            Dig.Owner = this;               // 새로운 폼의 부모가 Form1 인스턴스임을 지정
            Dig.ShowDialog();               // 폼 띄우기(Modal)
            Dig.Dispose();
        }

        // **** Insert SQL 실행 ****
        public void InsertRow(string[] rowDatas)
        {
            string queryStr = "INSERT INTO city (name, countrycode, district, population) " +
                "VALUES(@name, @countrycode, @district, @population)";
            dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.InsertCommand.Parameters.Add("@name", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@countrycode", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@district", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@population", MySqlDbType.Int32);

            #region Parameter를 이용한 처리
            dataAdapter.InsertCommand.Parameters["@name"].Value = rowDatas[0];
            dataAdapter.InsertCommand.Parameters["@countrycode"].Value = rowDatas[1];
            dataAdapter.InsertCommand.Parameters["@district"].Value = rowDatas[2];
            dataAdapter.InsertCommand.Parameters["@population"].Value = rowDatas[3];

            try
            {
                conn.Open();
                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();                                        // 이전 데이터 지우기
                dataAdapter.Fill(dataSet, "city");                      // DB -> DataSet
                dataGridView1.DataSource = dataSet.Tables["city"];      // dataGridView에 테이블 표시                                     // 텍스트 박스 내용 지우기
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            #endregion
        }

        // **** Delete SQL 실행 ****
        internal void DeleteRow(string id)
        {
            string sql = "DELETE FROM city WHERE id=@id";
            dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                dataAdapter.DeleteCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "city");
                dataGridView1.DataSource = dataSet.Tables["city"];
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

        // **** Update SQL 실행 ****
        internal void UpdateRow(string[] rowDatas)
        {
            string sql = "UPDATE city SET name=@name, countrycode=@countrycode, district=@district, population=@population WHERE id=@id";
            dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@id", rowDatas[0]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@name", rowDatas[1]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@countrycode", rowDatas[2]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@district", rowDatas[3]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@population", rowDatas[4]);

            try
            {
                conn.Open();
                dataAdapter.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear();  // 이전 데이터 지우기
                dataAdapter.Fill(dataSet, "city");
                dataGridView1.DataSource = dataSet.Tables["city"];
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

        // **** Insert 버튼 클릭(새창 띄우기) ****
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form2 Dig = new Form2();
            Dig.Owner = this;               // 새로운 폼의 부모가 Form1 인스턴스임을 지정
            Dig.ShowDialog();               // 폼 띄우기(Modal)
            Dig.Dispose();
        }

        // 검색 조건 초기화 함수
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxName.Clear();
            cbCountryCode.Text = "";
            cbDistrict.Text = "";
            textBoxMin.Clear();
            textBoxMax.Clear();
        }

        // 저장 버튼 클릭(txt, excel)
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("저장할 파일 정보가 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (rbText.Checked == true)
            {
                saveFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fsPath = saveFileDialog1.FileName;  // SaveFileDialog에 지정한 파일경로를 전역 변수인 fsPath에 저장
                    TextFileSave();
                }
            }
            else
            {
                saveFileDialog1.Filter = "엑셀 파일(*.xlsx)|*.xlsx";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fsPath = saveFileDialog1.FileName;
                    ExcelFileSave();
                }
            }
        }

        // 텍스트 파일로 저장
        private void TextFileSave()
        {
            // SaveFileDialog에 지정한 파일경로에 Stream 생성
            using (StreamWriter sw = new StreamWriter(fsPath))
            {
                // Column Title 한번 출력
                foreach (DataColumn col in dataSet.Tables["city"].Columns)
                {
                    sw.Write($"{col.ColumnName}\t");
                }
                sw.WriteLine();

                // DataGridView에 기록된 모든 파일 정보를 Text파일에 출력
                foreach (DataRow row in dataSet.Tables["city"].Rows)
                {
                    string rowString = "";
                    foreach (var item in row.ItemArray)
                    {
                        rowString += item.ToString() + "\t";
                    }
                    sw.WriteLine(rowString);
                }
                sw.Close();
            }
        }

        // 엑셀 파일로 저장
        private void ExcelFileSave()
        {
            #region 1. 엑셀 사용에 필요한 객체 생성
            // 엑셀을 사용하기 위한 클래스 객체 생성
            Excel.Application eApp;     // 엑셀 프로그램 
            Excel.Workbook eWorkbook;   // 여러 WorkSheet 포함한 단위
            Excel.Worksheet eWorkSheet;

            string[,] data;     // 엑셀에 데이터를 저장하기 위한 2차원 배열

            eApp = new Excel.Application();         // 엑셀 프로그램 객체 생성
            eWorkbook = eApp.Workbooks.Add(true);   // 엑셀에 Workbook 추가, 초기화
            eWorkSheet = eWorkbook.Sheets[1] as Excel.Worksheet;    // WorkSheet 생성, Excel Sheet 배열은 1부터 시작한다.
            #endregion

            #region 2. 엑셀에 데이터를 저장할 2차원 데이터 배열(data[,]) 준비
            // 엑셀에 저장할 데이터 크기 지정
            int cnum = dataSet.Tables["city"].Columns.Count + 1;
            int rnum = dataSet.Tables["city"].Rows.Count + 1;
            data = new string[rnum+1, cnum+1];

            // 엑셀에 저장할 2차원 배열에 Column 이름 저장
            for (int i = 0; i < dataSet.Tables["city"].Columns.Count; i++)
            {
                data[0, i] = dataSet.Tables["city"].Columns[i].ColumnName;
            }

            // 엑셀에 저장할 2차원 배열에 데이터 저장
            for (int i = 0; i < dataSet.Tables["city"].Rows.Count; i++)                    // 리스트뷰의 행수만큼 반복
            {
                for (int j = 0; j < dataSet.Tables["city"].Columns.Count; j++)    // 한 행의 열수만큼 반복
                {
                    data[i + 1, j] = dataSet.Tables["city"].Rows[i].ItemArray[j].ToString();    // data 배열에 데이터 저장
                }
            }
            #endregion

            #region 3. 준비된 데이터를 엑셀에 저장
            //string EndStr = "F" + rnum.ToString();      // 8개의 파일을 선택한 경우 F9 => 마지막 데이터 저장셀 주소
            string EndStr = Convert.ToChar(cnum -2 + 65) + rnum.ToString();      // 8개의 파일을 선택한 경우 F9 => 마지막 데이터 저장셀 주소
            eWorkSheet.get_Range("A1:" + EndStr).Value = data;     // 데이터 기록

            eWorkbook.SaveAs(fsPath, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false,
                Excel.XlSaveAsAccessMode.xlShared, false, false, Type.Missing, Type.Missing, Type.Missing);
            eWorkbook.Close(false, Type.Missing, Type.Missing);
            eApp.Quit();
            #endregion
        }
    }
}