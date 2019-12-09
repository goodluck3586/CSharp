namespace WinFormProject_Excel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDistrict = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCountryCode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbExcel = new System.Windows.Forms.RadioButton();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(689, 628);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsert.Location = new System.Drawing.Point(250, 111);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(101, 28);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.Location = new System.Drawing.Point(143, 111);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(101, 28);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMax);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxMin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbDistrict);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbCountryCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 96);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색 조건";
            // 
            // textBoxMax
            // 
            this.textBoxMax.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxMax.Location = new System.Drawing.Point(438, 59);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(100, 26);
            this.textBoxMax.TabIndex = 11;
            this.textBoxMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(417, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "~";
            // 
            // textBoxMin
            // 
            this.textBoxMin.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxMin.Location = new System.Drawing.Point(312, 59);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(100, 26);
            this.textBoxMin.TabIndex = 9;
            this.textBoxMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(215, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Population : ";
            // 
            // cbDistrict
            // 
            this.cbDistrict.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbDistrict.FormattingEnabled = true;
            this.cbDistrict.Location = new System.Drawing.Point(79, 59);
            this.cbDistrict.Name = "cbDistrict";
            this.cbDistrict.Size = new System.Drawing.Size(121, 24);
            this.cbDistrict.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(7, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "District : ";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxName.Location = new System.Drawing.Point(147, 23);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(147, 26);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(88, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name : ";
            // 
            // cbCountryCode
            // 
            this.cbCountryCode.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbCountryCode.FormattingEnabled = true;
            this.cbCountryCode.Location = new System.Drawing.Point(414, 23);
            this.cbCountryCode.Name = "cbCountryCode";
            this.cbCountryCode.Size = new System.Drawing.Size(121, 24);
            this.cbCountryCode.TabIndex = 3;
            this.cbCountryCode.SelectedIndexChanged += new System.EventHandler(this.cbCountryCode_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(300, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "CountryCode :  ";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxID.Location = new System.Drawing.Point(36, 23);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(43, 26);
            this.textBoxID.TabIndex = 1;
            this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :  ";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClear.Location = new System.Drawing.Point(361, 111);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 28);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.rbExcel);
            this.groupBox2.Controls.Add(this.rbText);
            this.groupBox2.Location = new System.Drawing.Point(600, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(105, 107);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "파일 저장";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(6, 66);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 32);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbExcel
            // 
            this.rbExcel.AutoSize = true;
            this.rbExcel.Location = new System.Drawing.Point(6, 46);
            this.rbExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbExcel.Name = "rbExcel";
            this.rbExcel.Size = new System.Drawing.Size(63, 16);
            this.rbExcel.TabIndex = 1;
            this.rbExcel.TabStop = true;
            this.rbExcel.Text = "EXCEL";
            this.rbExcel.UseVisualStyleBackColor = true;
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.Location = new System.Drawing.Point(6, 26);
            this.rbText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(47, 16);
            this.rbText.TabIndex = 0;
            this.rbText.TabStop = true;
            this.rbText.Text = "TXT";
            this.rbText.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 676);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbCountryCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDistrict;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbExcel;
        private System.Windows.Forms.RadioButton rbText;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

