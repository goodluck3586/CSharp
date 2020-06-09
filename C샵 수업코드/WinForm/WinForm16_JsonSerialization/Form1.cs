using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ex08_Json
{
    public partial class Form1 : Form
    {
        List<Student> studentList = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        // 직렬화 버튼 클릭
        private void btnSerialize_Click(object sender, EventArgs e)
        {
            // 1. 직렬화할 Student 객체 생성
            var student = new Student()
            {
                StudentNo = txtStudentNo.Text,
                Name = txtStudentName.Text,
                Age = int.Parse(txtStudentAge.Text)
            };

            // 2. 직렬화 
            txtJson.Text = JsonConvert.SerializeObject(student);
        }

        // 역직렬화 버튼 클릭
        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            // 1. Json 스트링
            var student = JsonConvert.DeserializeObject<Student>(txtJson.Text);

            // 2. textBox에 객체들의 속성값 표시
            txtStudentNo.Text = student.StudentNo;
            txtStudentName.Text = student.Name;
            txtStudentAge.Text = student.Age.ToString();
        }
    }

    class Student
    {
        public string StudentNo { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
