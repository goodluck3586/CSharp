using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* 694p 예제 */
namespace WinForm07_Textbook01
{
    public partial class Form1 : Form
    {
        Random random = new Random(37);

        public Form1()
        {
            InitializeComponent();

            lvDummy.Columns.Add("Name");
            lvDummy.Columns.Add("Depth");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families;  // 운영체제에 설치되어 있는 폰트 목록 검색
            foreach (var font in Fonts)
            {
                cboFont.Items.Add(font.Name);
            }
        }

        void ChangeFont()
        {
            if (cboFont.SelectedIndex < 0)  // 콤보박스에서 선택한 폰트가 없으면 메서드 종료
                return;

            FontStyle style = FontStyle.Regular;  // FontStyle 객체 초기화, public enum class FontStyle

            if (chkBold.Checked)  // "굵게" 체크 박스가 선택된 상태이면 Bold 논리합 수행
                style |= FontStyle.Bold;

            if (chkItalic.Checked)
                style |= FontStyle.Italic;

            // txtSampleText의 폰트를 위에서 만든 style로 수정
            txtSampleText.Font = new Font((string)cboFont.SelectedItem, 20, style);
        }

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void tbDummy_Scroll(object sender, EventArgs e)
        {
            pgDummy.Value = tbDummy.Value;  // trackBar의 위치에 따라 progressBar의 모양 변경
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modal Form";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.Red;
            frm.ShowDialog();  // Modal 창을 띄운다.
        }

        private void btnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modaless Form";
            frm.Width = 300;
            frm.Height = 300;
            frm.BackColor = Color.Green;
            frm.Show();  // Modaless 창을 띄운다.
        }

        private void btnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSampleText.Text, "MessageBox Test", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        void TreeToList()
        {
            lvDummy.Items.Clear();
            foreach ( TreeNode node in tvDummy.Nodes)
            {
                TreeToList(node);
            }
        }

        // TreeView의 각 노드를 ListView에 표시한다.
        private void TreeToList(TreeNode Node)
        {
            lvDummy.Items.Add(new ListViewItem(new string[] { Node.Text, Node.FullPath.Count(f => f == '\\').ToString() }));

            foreach (TreeNode node in Node.Nodes)
            {
                TreeToList(node);
            }
        }

        private void btnAddRoot_Click(object sender, EventArgs e)
        {
            tvDummy.Nodes.Add(random.Next().ToString());
            TreeToList();
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            if (tvDummy.SelectedNode == null)
            {
                MessageBox.Show("선택된 노트가 없습니다.", "TreeView Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            tvDummy.SelectedNode.Expand();  // 트리 노드 확장
            TreeToList();
        }
    }
}
