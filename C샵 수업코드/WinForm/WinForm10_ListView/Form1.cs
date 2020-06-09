using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm07_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var people = GetPeopleList();  // 리스트뷰에 넣을 List<Person> 가져오기

            listViewPeople.Items.Clear();  // clear the list view

            foreach (var person in people)
            {
                var row = new string[] { person.Id.ToString(), person.Name, person.MajorWork };
                var newListViewItem = new ListViewItem(row);
                newListViewItem.Tag = person;

                listViewPeople.Items.Add(newListViewItem);
            }
        }

        // ListView에 표시할 데이터를 반환하는 메소드
        private List<Person> GetPeopleList()
        {
            var list = new List<Person>();
            list.Add(new Person() { Id = Person.idNum, Name = "아이유", MajorWork = "나의 아저씨" });
            list.Add(new Person() { Id = Person.idNum, Name = "아이유2", MajorWork = "나의 아저씨2" });
            list.Add(new Person() { Id = Person.idNum, Name = "아이유3", MajorWork = "나의 아저씨3" });

            return list;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TextCheck())
            {
                Person person = new Person() { Id = Person.idNum, Name = this.textBoxName.Text, MajorWork = this.textBoxMajorWork.Text };
                var row = new string[] { person.Id.ToString(), person.Name, person.MajorWork };
                var newListViewItem = new ListViewItem(row);
                newListViewItem.Tag = person;

                this.listViewPeople.Items.Add(newListViewItem);

                this.textBoxName.Text = "";
                this.textBoxMajorWork.Text = "";
            }
        }

        private bool TextCheck()
        {
            if (this.textBoxName.Text != "" && this.textBoxMajorWork.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("빈칸을 채워주세요", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void listViewPeople_Click(object sender, EventArgs e)
        {
            Person selectedItem = listViewPeople.SelectedItems[0].Tag as Person;  // 중단점 설정 후 디버깅 해보기

            if (selectedItem != null)
                MessageBox.Show(selectedItem.ToString(), "선택한 아이템", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
