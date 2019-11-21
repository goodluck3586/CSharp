using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console01_DataTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 단계: 테이블과 컬럼 만들기(DataTable과 DataColumn)
            DataTable table1 = new DataTable("table1");
            DataColumn Col1;

            Col1 = new DataColumn("Name", typeof(string));  // typeof => 시스템 타입 객체를 리턴해 준다. int => Int32
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

            table1.AcceptChanges();  // 변경된 부분이 바로 적용되도록함.(생략 가능)

            // 3 단계: 모든 데이터 출력(테이블에서 행을 하나씩 꺼내서 출력)
            Console.WriteLine("*** 테이블의 데이터 모두 출력 ***");
            foreach (DataRow printRow in table1.Rows)
            {
                string str;
                if (printRow["Male"].ToString() == "True")  // DataRow의 값은 모두 string
                    str = "남자";
                else
                    str = "여자";

                Console.WriteLine($"이름: {printRow["Name"]}, 나이: {printRow["Age"]}, 성별: {str}");
            }
            Console.WriteLine('\n');

            // 3 단계: 조건에 맞는 데이터만 출력
            Console.WriteLine("*** 나이가 30세 미만인 데이터 검색 ***");
            string filter = "Age<30";
            DataRow[] SelectedRow = table1.Select(filter);  // 조건을 만족하는 행들 반환
            if (SelectedRow.Length > 0)  // select된 데이터가 있다면
            {
                foreach (DataRow printRow in SelectedRow)
                {
                    string str;
                    if (printRow["Male"].ToString() == "True")  // DataRow의 값은 모두 string
                        str = "남자";
                    else
                        str = "여자";

                    Console.WriteLine($"이름: {printRow["Name"]}, 나이: {printRow["Age"]}, 성별: {str}");
                }
                Console.WriteLine('\n');
            }
        }
    }
}
