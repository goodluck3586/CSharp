namespace WinForm14_FileDialog
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtReadView = new System.Windows.Forms.TextBox();
            this.txtReadPath = new System.Windows.Forms.TextBox();
            this.btnReadAll = new System.Windows.Forms.Button();
            this.btnReadLine = new System.Windows.Forms.Button();
            this.btnReadPath = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtWriteView = new System.Windows.Forms.TextBox();
            this.txtWritePath = new System.Windows.Forms.TextBox();
            this.btnWriteAll = new System.Windows.Forms.Button();
            this.btnWriteLine = new System.Windows.Forms.Button();
            this.btnWritePath = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 426);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtReadView);
            this.tabPage1.Controls.Add(this.txtReadPath);
            this.tabPage1.Controls.Add(this.btnReadAll);
            this.tabPage1.Controls.Add(this.btnReadLine);
            this.tabPage1.Controls.Add(this.btnReadPath);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(648, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "파일 읽기";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtReadView
            // 
            this.txtReadView.Location = new System.Drawing.Point(6, 98);
            this.txtReadView.Multiline = true;
            this.txtReadView.Name = "txtReadView";
            this.txtReadView.Size = new System.Drawing.Size(636, 296);
            this.txtReadView.TabIndex = 4;
            // 
            // txtReadPath
            // 
            this.txtReadPath.Location = new System.Drawing.Point(6, 16);
            this.txtReadPath.Name = "txtReadPath";
            this.txtReadPath.Size = new System.Drawing.Size(517, 21);
            this.txtReadPath.TabIndex = 3;
            // 
            // btnReadAll
            // 
            this.btnReadAll.Location = new System.Drawing.Point(119, 43);
            this.btnReadAll.Name = "btnReadAll";
            this.btnReadAll.Size = new System.Drawing.Size(107, 29);
            this.btnReadAll.TabIndex = 2;
            this.btnReadAll.Text = "전체 읽기";
            this.btnReadAll.UseVisualStyleBackColor = true;
            this.btnReadAll.Click += new System.EventHandler(this.btnReadAll_Click);
            // 
            // btnReadLine
            // 
            this.btnReadLine.Location = new System.Drawing.Point(6, 43);
            this.btnReadLine.Name = "btnReadLine";
            this.btnReadLine.Size = new System.Drawing.Size(107, 29);
            this.btnReadLine.TabIndex = 1;
            this.btnReadLine.Text = "라인 읽기";
            this.btnReadLine.UseVisualStyleBackColor = true;
            this.btnReadLine.Click += new System.EventHandler(this.btnReadLine_Click);
            // 
            // btnReadPath
            // 
            this.btnReadPath.Location = new System.Drawing.Point(529, 11);
            this.btnReadPath.Name = "btnReadPath";
            this.btnReadPath.Size = new System.Drawing.Size(107, 29);
            this.btnReadPath.TabIndex = 0;
            this.btnReadPath.Text = "파일 선택";
            this.btnReadPath.UseVisualStyleBackColor = true;
            this.btnReadPath.Click += new System.EventHandler(this.btnReadPath_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtWriteView);
            this.tabPage2.Controls.Add(this.txtWritePath);
            this.tabPage2.Controls.Add(this.btnWriteAll);
            this.tabPage2.Controls.Add(this.btnWriteLine);
            this.tabPage2.Controls.Add(this.btnWritePath);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(648, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "파일 쓰기";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtWriteView
            // 
            this.txtWriteView.Location = new System.Drawing.Point(6, 96);
            this.txtWriteView.Multiline = true;
            this.txtWriteView.Name = "txtWriteView";
            this.txtWriteView.Size = new System.Drawing.Size(636, 296);
            this.txtWriteView.TabIndex = 9;
            // 
            // txtWritePath
            // 
            this.txtWritePath.Location = new System.Drawing.Point(6, 14);
            this.txtWritePath.Name = "txtWritePath";
            this.txtWritePath.Size = new System.Drawing.Size(517, 21);
            this.txtWritePath.TabIndex = 8;
            // 
            // btnWriteAll
            // 
            this.btnWriteAll.Location = new System.Drawing.Point(119, 41);
            this.btnWriteAll.Name = "btnWriteAll";
            this.btnWriteAll.Size = new System.Drawing.Size(107, 29);
            this.btnWriteAll.TabIndex = 7;
            this.btnWriteAll.Text = "전체 쓰기";
            this.btnWriteAll.UseVisualStyleBackColor = true;
            this.btnWriteAll.Click += new System.EventHandler(this.btnWriteAll_Click);
            // 
            // btnWriteLine
            // 
            this.btnWriteLine.Location = new System.Drawing.Point(6, 41);
            this.btnWriteLine.Name = "btnWriteLine";
            this.btnWriteLine.Size = new System.Drawing.Size(107, 29);
            this.btnWriteLine.TabIndex = 6;
            this.btnWriteLine.Text = "라인 쓰기";
            this.btnWriteLine.UseVisualStyleBackColor = true;
            this.btnWriteLine.Click += new System.EventHandler(this.btnWriteLine_Click);
            // 
            // btnWritePath
            // 
            this.btnWritePath.Location = new System.Drawing.Point(529, 9);
            this.btnWritePath.Name = "btnWritePath";
            this.btnWritePath.Size = new System.Drawing.Size(107, 29);
            this.btnWritePath.TabIndex = 5;
            this.btnWritePath.Text = "파일 선택";
            this.btnWritePath.UseVisualStyleBackColor = true;
            this.btnWritePath.Click += new System.EventHandler(this.btnWritePath_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtReadView;
        private System.Windows.Forms.TextBox txtReadPath;
        private System.Windows.Forms.Button btnReadAll;
        private System.Windows.Forms.Button btnReadLine;
        private System.Windows.Forms.Button btnReadPath;
        private System.Windows.Forms.TextBox txtWriteView;
        private System.Windows.Forms.TextBox txtWritePath;
        private System.Windows.Forms.Button btnWriteAll;
        private System.Windows.Forms.Button btnWriteLine;
        private System.Windows.Forms.Button btnWritePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

