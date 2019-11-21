using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace CSharp7_DB01
{
    public partial class Form1 : Form
    {
        FileInfo fileInfo = null;   // 파일 정보 가져오기
        string fsPath = "";         // 저장할 파일 경로 저장

        public Form1()
        {
            InitializeComponent();
        }

        // 선택한 파일들의 속성 정보를 나타내는 작업 수행
        private void btnPath_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)  // 파일 열기 대화상자 오픈
            {
                int serialNum = 0;
                foreach (string fileName in openFileDialog1.FileNames)  // 대화상자에서 선택한 모든 파일 이름(전체경로와 파일이름)을 가져옴
                {
                    serialNum++;
                    fileInfo = new FileInfo(fileName);  // 선택한 파일경로로 파일정보 객체 생성
                    // ListView에 선택된 파일 정보 추가
                    lvFile.Items.Add(new ListViewItem(new string[]
                    {
                        serialNum.ToString(),
                        fileInfo.Name,
                        fileInfo.LastWriteTime.ToString(),
                        fileInfo.Extension.Split('.')[1],
                        GetFileSize(fileInfo.Length),
                        fileInfo.FullName
                    }));
                }
            }
        }

        private string GetFileSize(long byteCount)
        {
            return "fileSize";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lvFile.Items.Count == 0)
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

        private void ExcelFileSave()
        {
            #region 엑셀 사용에 필요한 객체 생성
            // 엑셀을 사용하기 위한 클래스 객체 생성
            Excel.Application eApp;     // 엑셀 프로그램 
            Excel.Workbook eWorkbook;   // 여러 WorkSheet 포함한 단위
            Excel.Worksheet eWorkSheet;

            string[,] data;     // 엑셀에 데이터를 저장하기 위한 2차원 배열

            eApp = new Excel.Application();         // 엑셀 프로그램 객체 생성
            eWorkbook = eApp.Workbooks.Add(true);   // 엑셀에 Workbook 추가, 초기화
            eWorkSheet = eWorkbook.Sheets[1] as Excel.Worksheet;    // WorkSheet 생성, Excel Sheet 배열은 1부터 시작한다.
            #endregion

            #region 엑셀에 데이터를 저장할 2차원 데이터 배열(data[,]) 준비
            // 엑셀에 저장할 데이터 크기 지정
            int rnum = lvFile.Items.Count + 1;
            int cnum = lvFile.Items[0].SubItems.Count + 1;
            data = new string[rnum, cnum];

            // 엑셀에 저장할 2차원 배열에 Column 이름 저장
            data[0, 0] = "연번";
            data[0, 1] = "이름";
            data[0, 2] = "수정한 날짜";
            data[0, 3] = "유형";
            data[0, 4] = "크기";
            data[0, 5] = "경로";

            // 엑셀에 저장할 2차원 배열에 데이터 저장
            for (int i = 0; i < lvFile.Items.Count; i++)                    // 리스트뷰의 행수만큼 반복
            {
                for (int j = 0; j < lvFile.Items[i].SubItems.Count; j++)    // 한 행의 열수만큼 반복
                {
                    data[i + 1, j] = lvFile.Items[i].SubItems[j].Text;      // data 배열에 데이터 저장
                }
            }
            #endregion

            #region 준비된 데이터를 엑셀에 저장, 종료
            string EndStr = "F" + rnum.ToString();      // 8개의 파일은 선택한 경우 F9 => 마지막 데이터 저장셀 주소
            eWorkSheet.get_Range("A1:" + EndStr).Value = data;     // A1:F9까지의 범위에 데이터 기록

            eWorkbook.SaveAs(fsPath, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false, 
                Excel.XlSaveAsAccessMode.xlShared, false, false, Type.Missing, Type.Missing, Type.Missing);
            eWorkbook.Close(false, Type.Missing, Type.Missing);
            eApp.Quit();
            #endregion
        }

        private void TextFileSave()
        {
            // SaveFileDialog에 지정한 파일경로에 Stream 생성
            using (StreamWriter sw = new StreamWriter(fsPath))
            {
                sw.WriteLine($"이름\t수정한 날짜\t유형\t크기\t경로\t");  // Column Title 한번 출력

                // ListView에 기록된 모든 파일 정보를 Text파일에 출력
                for (int i = 0; i < lvFile.Items.Count; i++)  // row만큼 반복
                {
                    string FInfoStr = "";
                    for (int j = 0; j < lvFile.Items[i].SubItems.Count; j++)  // column만큼 반복
                    {
                        FInfoStr += lvFile.Items[i].SubItems[j].Text + "\t";
                    }
                    sw.WriteLine(FInfoStr);
                }
                sw.Close();
            }
        }
    }
}
