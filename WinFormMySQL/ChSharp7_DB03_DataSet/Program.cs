using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChSharp7_DB03_DataSet
{
    class Program
    {
        static MySqlConnection conn;
        static MySqlDataAdapter dataAdapter;
        static DataSet dataSet;

        static void Main(string[] args)
        {
            string connectionString = "Server=127.0.0.1;port=3306;username=root;password=1111";
            conn = new MySqlConnection(connectionString);
            dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = new MySqlCommand("SELECT * FROM world.city where countrycode='KOR'", conn);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "city");
            //dataSet.Tables[0].Columns[0].AutoIncrement = true;

            AddRow();

            // dataSet의 데이터 출력
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                //Console.WriteLine($"{row["name"]}");
                // Console.WriteLine(row[1]); 
                string data = null;
                foreach (var item in row.ItemArray)
                {
                    data += $"{item}\t";
                }
                Console.WriteLine(data);
            }
        }

        static void AddRow()
        {
            for (int i = 0; i < 10; i++)
            {
                DataRow row = dataSet.Tables[0].NewRow();
                row["id"] = i;
                row["name"] = "아이유";
                row["countrycode"] = "KOR";
                row["district"] = "아이유구";
                row["population"] = i * 1000000;
                dataSet.Tables[0].Rows.Add(row);
            }
        }
    }
}
