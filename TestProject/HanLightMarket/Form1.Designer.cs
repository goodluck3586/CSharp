namespace HanLightMarket
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.회원관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원목록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.제조업체관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상품관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주문관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.회원관리ToolStripMenuItem,
            this.제조업체관리ToolStripMenuItem,
            this.상품관리ToolStripMenuItem,
            this.주문관리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 회원관리ToolStripMenuItem
            // 
            this.회원관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.회원목록ToolStripMenuItem,
            this.회원등록ToolStripMenuItem,
            this.회원수정ToolStripMenuItem,
            this.회원삭제ToolStripMenuItem});
            this.회원관리ToolStripMenuItem.Name = "회원관리ToolStripMenuItem";
            this.회원관리ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.회원관리ToolStripMenuItem.Text = "회원 관리";
            // 
            // 회원목록ToolStripMenuItem
            // 
            this.회원목록ToolStripMenuItem.Name = "회원목록ToolStripMenuItem";
            this.회원목록ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.회원목록ToolStripMenuItem.Text = "회원 목록";
            this.회원목록ToolStripMenuItem.Click += new System.EventHandler(this.회원목록ToolStripMenuItem_Click);
            // 
            // 회원등록ToolStripMenuItem
            // 
            this.회원등록ToolStripMenuItem.Name = "회원등록ToolStripMenuItem";
            this.회원등록ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.회원등록ToolStripMenuItem.Text = "회원 등록";
            // 
            // 회원수정ToolStripMenuItem
            // 
            this.회원수정ToolStripMenuItem.Name = "회원수정ToolStripMenuItem";
            this.회원수정ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.회원수정ToolStripMenuItem.Text = "회원 수정";
            // 
            // 회원삭제ToolStripMenuItem
            // 
            this.회원삭제ToolStripMenuItem.Name = "회원삭제ToolStripMenuItem";
            this.회원삭제ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.회원삭제ToolStripMenuItem.Text = "회원 삭제";
            // 
            // 제조업체관리ToolStripMenuItem
            // 
            this.제조업체관리ToolStripMenuItem.Name = "제조업체관리ToolStripMenuItem";
            this.제조업체관리ToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.제조업체관리ToolStripMenuItem.Text = "제조업체 관리";
            // 
            // 상품관리ToolStripMenuItem
            // 
            this.상품관리ToolStripMenuItem.Name = "상품관리ToolStripMenuItem";
            this.상품관리ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.상품관리ToolStripMenuItem.Text = "상품 관리";
            // 
            // 주문관리ToolStripMenuItem
            // 
            this.주문관리ToolStripMenuItem.Name = "주문관리ToolStripMenuItem";
            this.주문관리ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.주문관리ToolStripMenuItem.Text = "주문 관리";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 698);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 회원관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원목록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 제조업체관리ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 회원등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상품관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주문관리ToolStripMenuItem;
    }
}

