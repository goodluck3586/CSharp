using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex09_Delegate
{
    public partial class Form1 : Form
    {
        delegate bool FilterHandler(Student s);

        List<Student> studentList = new List<Student>();
        Dictionary<string, Student> studentMap = new Dictionary<string, Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentList.Add(new Student { StudentNo = "S0001", Name = "아이유", Age = 28 });
            studentList.Add(new Student { StudentNo = "S0002", Name = "구천성", Age = 24 });
            studentList.Add(new Student { StudentNo = "S0003", Name = "배수지", Age = 28 });
            studentList.Add(new Student { StudentNo = "S0004", Name = "조승우", Age = 38 });
            studentList.Add(new Student { StudentNo = "S0005", Name = "조진웅", Age = 43 });

            foreach (var item in studentList)
            {
                studentMap.Add(item.StudentNo, item);
                comboBox1.Items.Add(item.StudentNo);
            }


            dataGridView1.DataSource = studentList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var student = studentMap[comboBox1.SelectedItem.ToString()];
            MessageBox.Show($"{student.Name}\n{student.Age}");

            studentList = new List<Student>() { student };
            //dataGridView1.DataSource = studentList;

            dataGridView1.DataSource = SearchByName();
        }

        // 이름 검색 버튼 클릭
        private void btnSearchName_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = SearchByName();
            //dataGridView1.DataSource = Search((Student s) => { return s.Name.IndexOf(txtSearchText.Text) >= 0; });
            //dataGridView1.DataSource = Search((s) => { return s.Name.IndexOf(txtSearchText.Text) >= 0; });
            //dataGridView1.DataSource = Search(s => s.Name.IndexOf(txtSearchText.Text) >= 0);
            dataGridView1.DataSource = studentList.Where(s => s.Name.IndexOf(txtSearchText.Text) >= 0).ToList();    // IEnumerable을 List로 변환
            // => 위의 .Where의 원형 : public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
        }

        // 나이 검색 버튼 클릭
        private void btnSearchAge_Click(object sender, EventArgs e)
        {
            // dataGridView1.DataSource = SearchByAge();
            dataGridView1.DataSource = Search(s => s.Age >= int.Parse(txtSearchText.Text));
        }

        // 검색된 Student.Name List 반환
        /*private List<Student> SearchByName()
        {
            var list = new List<Student>();

            foreach (var s in studentList)
            {
                int index;
                // txtSearchText의 문자열이 s.Name에 포함되는가?
                if ((index=s.Name.IndexOf(txtSearchText.Text)) >= 0)
                {
                    list.Add(s);
                }
            }
            return list;
        }*/

        private List<Student> SearchByName()
        {
            var list = new List<Student>();

            foreach (var s in studentList)
            {
                int index;
                // txtSearchText의 문자열이 s.Name에 포함되는가?
                if ((index = s.Name.IndexOf(txtSearchText.Text)) >= 0)
                {
                    list.Add(s);
                }
            }
            return list;
        }

        // 검색된 Student.Age List 반환
        private List<Student> SearchByAge()
        {
            var list = new List<Student>();

            if(int.TryParse(txtSearchText.Text, out _))
            {
                foreach (var s in studentList)
                {
                    // txtSearchText의 나이 보다 나이가 많은가?
                    if (s.Age>=int.Parse(txtSearchText.Text))
                    {
                        list.Add(s);
                    }
                }
            }
            else
            {
                MessageBox.Show("잘못된 나이 입력입니다.");
            }
            return list;
        }

        // 검색된 Student.Age List 반환
        private List<Student> Search(Func<Student, bool> filter)  //FilterHandler filter
        {
            var list = new List<Student>();

            foreach (var s in studentList)
            {
                if (filter(s))
                {
                    list.Add(s);
                }
            }

            return list;
        }
    }

    class Student
    {
        public string StudentNo { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
