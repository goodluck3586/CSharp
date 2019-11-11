namespace WinFormDB01
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDBClose = new System.Windows.Forms.Button();
            this.btnDBOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(49, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "연결 상태";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDBClose
            // 
            this.btnDBClose.Location = new System.Drawing.Point(57, 192);
            this.btnDBClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDBClose.Name = "btnDBClose";
            this.btnDBClose.Size = new System.Drawing.Size(170, 52);
            this.btnDBClose.TabIndex = 1;
            this.btnDBClose.Text = "Close Connection";
            this.btnDBClose.UseVisualStyleBackColor = true;
            this.btnDBClose.Click += new System.EventHandler(this.btnDBClose_Click);
            // 
            // btnDBOpen
            // 
            this.btnDBOpen.Location = new System.Drawing.Point(274, 192);
            this.btnDBOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDBOpen.Name = "btnDBOpen";
            this.btnDBOpen.Size = new System.Drawing.Size(170, 52);
            this.btnDBOpen.TabIndex = 2;
            this.btnDBOpen.Text = "Open Connection";
            this.btnDBOpen.UseVisualStyleBackColor = true;
            this.btnDBOpen.Click += new System.EventHandler(this.btnDBOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 279);
            this.Controls.Add(this.btnDBOpen);
            this.Controls.Add(this.btnDBClose);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDBClose;
        private System.Windows.Forms.Button btnDBOpen;
    }
}

