namespace WinForm07_Textbook01
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.txtSampleText = new System.Windows.Forms.TextBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDummy = new System.Windows.Forms.TrackBar();
            this.pgDummy = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnModal = new System.Windows.Forms.Button();
            this.btnModaless = new System.Windows.Forms.Button();
            this.btnMsgBox = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tvDummy = new System.Windows.Forms.TreeView();
            this.lvDummy = new System.Windows.Forms.ListView();
            this.btnAddRoot = new System.Windows.Forms.Button();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDummy)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkItalic);
            this.groupBox1.Controls.Add(this.cboFont);
            this.groupBox1.Controls.Add(this.chkBold);
            this.groupBox1.Controls.Add(this.txtSampleText);
            this.groupBox1.Controls.Add(this.lblFont);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ComboBox, CheckBox, TextBox";
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(15, 32);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(41, 12);
            this.lblFont.TabIndex = 0;
            this.lblFont.Text = "Font : ";
            // 
            // txtSampleText
            // 
            this.txtSampleText.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSampleText.Location = new System.Drawing.Point(17, 55);
            this.txtSampleText.Name = "txtSampleText";
            this.txtSampleText.Size = new System.Drawing.Size(330, 39);
            this.txtSampleText.TabIndex = 1;
            this.txtSampleText.Text = "Hello, C#";
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkBold.Location = new System.Drawing.Point(193, 31);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(50, 16);
            this.chkBold.TabIndex = 2;
            this.chkBold.Text = "굵게";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // cboFont
            // 
            this.cboFont.FormattingEnabled = true;
            this.cboFont.Location = new System.Drawing.Point(53, 29);
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(121, 20);
            this.cboFont.TabIndex = 3;
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.cboFont_SelectedIndexChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkItalic.Location = new System.Drawing.Point(261, 31);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(60, 16);
            this.chkItalic.TabIndex = 4;
            this.chkItalic.Text = "이텔릭";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pgDummy);
            this.groupBox2.Controls.Add(this.tbDummy);
            this.groupBox2.Location = new System.Drawing.Point(12, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TrackBar, ProgressBar";
            // 
            // tbDummy
            // 
            this.tbDummy.Location = new System.Drawing.Point(17, 20);
            this.tbDummy.Maximum = 20;
            this.tbDummy.Name = "tbDummy";
            this.tbDummy.Size = new System.Drawing.Size(330, 45);
            this.tbDummy.TabIndex = 0;
            this.tbDummy.Scroll += new System.EventHandler(this.tbDummy_Scroll);
            // 
            // pgDummy
            // 
            this.pgDummy.Location = new System.Drawing.Point(17, 71);
            this.pgDummy.Maximum = 20;
            this.pgDummy.Name = "pgDummy";
            this.pgDummy.Size = new System.Drawing.Size(330, 22);
            this.pgDummy.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMsgBox);
            this.groupBox3.Controls.Add(this.btnModaless);
            this.groupBox3.Controls.Add(this.btnModal);
            this.groupBox3.Location = new System.Drawing.Point(12, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 67);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modal & Modaless";
            // 
            // btnModal
            // 
            this.btnModal.Location = new System.Drawing.Point(6, 29);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(89, 23);
            this.btnModal.TabIndex = 0;
            this.btnModal.Text = "Modal";
            this.btnModal.UseVisualStyleBackColor = true;
            this.btnModal.Click += new System.EventHandler(this.btnModal_Click);
            // 
            // btnModaless
            // 
            this.btnModaless.Location = new System.Drawing.Point(115, 29);
            this.btnModaless.Name = "btnModaless";
            this.btnModaless.Size = new System.Drawing.Size(89, 23);
            this.btnModaless.TabIndex = 1;
            this.btnModaless.Text = "Modaless";
            this.btnModaless.UseVisualStyleBackColor = true;
            this.btnModaless.Click += new System.EventHandler(this.btnModaless_Click);
            // 
            // btnMsgBox
            // 
            this.btnMsgBox.Location = new System.Drawing.Point(223, 29);
            this.btnMsgBox.Name = "btnMsgBox";
            this.btnMsgBox.Size = new System.Drawing.Size(137, 23);
            this.btnMsgBox.TabIndex = 2;
            this.btnMsgBox.Text = "MessageBox";
            this.btnMsgBox.UseVisualStyleBackColor = true;
            this.btnMsgBox.Click += new System.EventHandler(this.btnMsgBox_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddChild);
            this.groupBox4.Controls.Add(this.btnAddRoot);
            this.groupBox4.Controls.Add(this.lvDummy);
            this.groupBox4.Controls.Add(this.tvDummy);
            this.groupBox4.Location = new System.Drawing.Point(12, 384);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(366, 191);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TreeView & ListView";
            // 
            // tvDummy
            // 
            this.tvDummy.Location = new System.Drawing.Point(6, 20);
            this.tvDummy.Name = "tvDummy";
            this.tvDummy.Size = new System.Drawing.Size(170, 100);
            this.tvDummy.TabIndex = 0;
            // 
            // lvDummy
            // 
            this.lvDummy.HideSelection = false;
            this.lvDummy.Location = new System.Drawing.Point(190, 20);
            this.lvDummy.Name = "lvDummy";
            this.lvDummy.Size = new System.Drawing.Size(170, 100);
            this.lvDummy.TabIndex = 1;
            this.lvDummy.UseCompatibleStateImageBehavior = false;
            this.lvDummy.View = System.Windows.Forms.View.Details;
            // 
            // btnAddRoot
            // 
            this.btnAddRoot.Location = new System.Drawing.Point(6, 138);
            this.btnAddRoot.Name = "btnAddRoot";
            this.btnAddRoot.Size = new System.Drawing.Size(75, 23);
            this.btnAddRoot.TabIndex = 2;
            this.btnAddRoot.Text = "루트 추가";
            this.btnAddRoot.UseVisualStyleBackColor = true;
            this.btnAddRoot.Click += new System.EventHandler(this.btnAddRoot_Click);
            // 
            // btnAddChild
            // 
            this.btnAddChild.Location = new System.Drawing.Point(99, 138);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(75, 23);
            this.btnAddChild.TabIndex = 3;
            this.btnAddChild.Text = "자식 추가";
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 731);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDummy)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.ComboBox cboFont;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.TextBox txtSampleText;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar pgDummy;
        private System.Windows.Forms.TrackBar tbDummy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMsgBox;
        private System.Windows.Forms.Button btnModaless;
        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.Button btnAddRoot;
        private System.Windows.Forms.ListView lvDummy;
        private System.Windows.Forms.TreeView tvDummy;
    }
}

