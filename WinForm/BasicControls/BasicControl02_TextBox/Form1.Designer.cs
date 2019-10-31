namespace BasicControl02_TextBox
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox.Location = new System.Drawing.Point(26, 28);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(191, 35);
            this.textBox.TabIndex = 0;
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdit_KeyPress);
            // 
            // btnInput
            // 
            this.btnInput.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInput.Location = new System.Drawing.Point(238, 28);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(117, 31);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "입력";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelResult.Location = new System.Drawing.Point(33, 105);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(82, 24);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "결과 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 187);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.textBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "문자 입출력";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Label labelResult;
    }
}

