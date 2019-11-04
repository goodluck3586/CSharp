namespace WinForm09_ShowProcess
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMemory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKill = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslProcess = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCPU = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslMemory = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chPID,
            this.chTime,
            this.chMemory});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(386, 340);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "프로세스 이름";
            this.chName.Width = 110;
            // 
            // chPID
            // 
            this.chPID.Text = "PID";
            this.chPID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chTime
            // 
            this.chTime.Text = "Time";
            this.chTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chTime.Width = 90;
            // 
            // chMemory
            // 
            this.chMemory.Text = "메모리 사용";
            this.chMemory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chMemory.Width = 100;
            // 
            // btnKill
            // 
            this.btnKill.Location = new System.Drawing.Point(283, 358);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(115, 35);
            this.btnKill.TabIndex = 1;
            this.btnKill.Text = "프로세스 끝내기";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslProcess,
            this.tsslCPU,
            this.tsslMemory});
            this.statusStrip1.Location = new System.Drawing.Point(0, 415);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(411, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslProcess
            // 
            this.tsslProcess.Name = "tsslProcess";
            this.tsslProcess.Size = new System.Drawing.Size(85, 17);
            this.tsslProcess.Text = "프로세스 : 0개";
            // 
            // tsslCPU
            // 
            this.tsslCPU.Name = "tsslCPU";
            this.tsslCPU.Size = new System.Drawing.Size(86, 17);
            this.tsslCPU.Text = "CPU 사용 : 0%";
            // 
            // tsslMemory
            // 
            this.tsslMemory.Name = "tsslMemory";
            this.tsslMemory.Size = new System.Drawing.Size(99, 17);
            this.tsslMemory.Text = "실제 메모리 : 0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 437);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "프로세스 보기";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chPID;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chMemory;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslProcess;
        private System.Windows.Forms.ToolStripStatusLabel tsslCPU;
        private System.Windows.Forms.ToolStripStatusLabel tsslMemory;
    }
}

