namespace Practice_testDB_OrderTable
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrderQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrderNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.labelDBConnStatus = new System.Windows.Forms.Label();
            this.btnTextBoxClear = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCompany = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPageOrder = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDeleteCompany = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPageOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtOrderDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtOrderQuantity);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtOrderNum);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtProductNum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 216);
            this.panel1.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(125, 177);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(213, 25);
            this.txtAddress.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(125, 146);
            this.txtOrderDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(213, 25);
            this.txtOrderDate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Order Date";
            // 
            // txtOrderQuantity
            // 
            this.txtOrderQuantity.Location = new System.Drawing.Point(125, 114);
            this.txtOrderQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderQuantity.Name = "txtOrderQuantity";
            this.txtOrderQuantity.Size = new System.Drawing.Size(213, 25);
            this.txtOrderQuantity.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "OrderQuantity";
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Location = new System.Drawing.Point(125, 84);
            this.txtOrderNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(213, 25);
            this.txtOrderNum.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "OrderNum";
            // 
            // txtProductNum
            // 
            this.txtProductNum.Location = new System.Drawing.Point(125, 53);
            this.txtProductNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductNum.Name = "txtProductNum";
            this.txtProductNum.Size = new System.Drawing.Size(213, 25);
            this.txtProductNum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Num";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(125, 22);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(213, 25);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member ID";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(392, 58);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(214, 32);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(392, 98);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(214, 32);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(392, 142);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(214, 32);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(392, 188);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(214, 32);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // labelDBConnStatus
            // 
            this.labelDBConnStatus.Location = new System.Drawing.Point(389, 24);
            this.labelDBConnStatus.Name = "labelDBConnStatus";
            this.labelDBConnStatus.Size = new System.Drawing.Size(217, 22);
            this.labelDBConnStatus.TabIndex = 5;
            this.labelDBConnStatus.Text = "DB 연결 상태";
            this.labelDBConnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTextBoxClear
            // 
            this.btnTextBoxClear.Location = new System.Drawing.Point(392, 232);
            this.btnTextBoxClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTextBoxClear.Name = "btnTextBoxClear";
            this.btnTextBoxClear.Size = new System.Drawing.Size(214, 32);
            this.btnTextBoxClear.TabIndex = 6;
            this.btnTextBoxClear.Text = "텍스트 박스 내용 지우기";
            this.btnTextBoxClear.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCompany);
            this.tabControl1.Controls.Add(this.tabPageProduct);
            this.tabControl1.Controls.Add(this.tabPageOrder);
            this.tabControl1.Location = new System.Drawing.Point(11, 281);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(616, 715);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageCompany
            // 
            this.tabPageCompany.Controls.Add(this.dataGridView3);
            this.tabPageCompany.Location = new System.Drawing.Point(4, 25);
            this.tabPageCompany.Name = "tabPageCompany";
            this.tabPageCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompany.Size = new System.Drawing.Size(608, 686);
            this.tabPageCompany.TabIndex = 0;
            this.tabPageCompany.Text = "company";
            this.tabPageCompany.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(602, 680);
            this.dataGridView3.TabIndex = 0;
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.Controls.Add(this.dataGridView2);
            this.tabPageProduct.Location = new System.Drawing.Point(4, 25);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduct.Size = new System.Drawing.Size(608, 686);
            this.tabPageProduct.TabIndex = 1;
            this.tabPageProduct.Text = "product";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(602, 680);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPageOrder
            // 
            this.tabPageOrder.Controls.Add(this.dataGridView1);
            this.tabPageOrder.Location = new System.Drawing.Point(4, 25);
            this.tabPageOrder.Name = "tabPageOrder";
            this.tabPageOrder.Size = new System.Drawing.Size(608, 686);
            this.tabPageOrder.TabIndex = 2;
            this.tabPageOrder.Text = "orders";
            this.tabPageOrder.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(608, 686);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnDeleteCompany
            // 
            this.btnDeleteCompany.Location = new System.Drawing.Point(392, 268);
            this.btnDeleteCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteCompany.Name = "btnDeleteCompany";
            this.btnDeleteCompany.Size = new System.Drawing.Size(214, 32);
            this.btnDeleteCompany.TabIndex = 10;
            this.btnDeleteCompany.Text = "Delete Company";
            this.btnDeleteCompany.UseVisualStyleBackColor = true;
            this.btnDeleteCompany.Click += new System.EventHandler(this.btnDeleteCompany_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 1008);
            this.Controls.Add(this.btnDeleteCompany);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnTextBoxClear);
            this.Controls.Add(this.labelDBConnStatus);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageCompany.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPageProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPageOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrderQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrderNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label labelDBConnStatus;
        private System.Windows.Forms.Button btnTextBoxClear;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCompany;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPageOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeleteCompany;
    }
}

