namespace Pagination
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.paginator1 = new Pagination.Paginator();
            this.lab_TotalPages = new System.Windows.Forms.Label();
            this.linklab_LastPage = new System.Windows.Forms.LinkLabel();
            this.linklab_NextPage = new System.Windows.Forms.LinkLabel();
            this.lab_Ye = new System.Windows.Forms.Label();
            this.txtbox_NowPage = new System.Windows.Forms.TextBox();
            this.lab_Di = new System.Windows.Forms.Label();
            this.linklab_PreviousPage = new System.Windows.Forms.LinkLabel();
            this.linklab_FirstPage = new System.Windows.Forms.LinkLabel();
            this.cmbox_RecordsPerPage = new System.Windows.Forms.ComboBox();
            this.lab_TotalRecords = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(770, 338);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // paginator1
            // 
            this.paginator1.Location = new System.Drawing.Point(388, 12);
            this.paginator1.Name = "paginator1";
            this.paginator1.Size = new System.Drawing.Size(400, 27);
            this.paginator1.TabIndex = 3;
            // 
            // lab_TotalPages
            // 
            this.lab_TotalPages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_TotalPages.AutoSize = true;
            this.lab_TotalPages.Location = new System.Drawing.Point(359, 23);
            this.lab_TotalPages.Name = "lab_TotalPages";
            this.lab_TotalPages.Size = new System.Drawing.Size(47, 12);
            this.lab_TotalPages.TabIndex = 19;
            this.lab_TotalPages.Text = "共999页";
            // 
            // linklab_LastPage
            // 
            this.linklab_LastPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linklab_LastPage.AutoSize = true;
            this.linklab_LastPage.Location = new System.Drawing.Point(336, 23);
            this.linklab_LastPage.Name = "linklab_LastPage";
            this.linklab_LastPage.Size = new System.Drawing.Size(17, 12);
            this.linklab_LastPage.TabIndex = 18;
            this.linklab_LastPage.TabStop = true;
            this.linklab_LastPage.Text = ">>";
            // 
            // linklab_NextPage
            // 
            this.linklab_NextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linklab_NextPage.AutoSize = true;
            this.linklab_NextPage.Location = new System.Drawing.Point(319, 23);
            this.linklab_NextPage.Name = "linklab_NextPage";
            this.linklab_NextPage.Size = new System.Drawing.Size(11, 12);
            this.linklab_NextPage.TabIndex = 17;
            this.linklab_NextPage.TabStop = true;
            this.linklab_NextPage.Text = ">";
            // 
            // lab_Ye
            // 
            this.lab_Ye.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_Ye.AutoSize = true;
            this.lab_Ye.Location = new System.Drawing.Point(296, 23);
            this.lab_Ye.Name = "lab_Ye";
            this.lab_Ye.Size = new System.Drawing.Size(17, 12);
            this.lab_Ye.TabIndex = 16;
            this.lab_Ye.Text = "页";
            // 
            // txtbox_NowPage
            // 
            this.txtbox_NowPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_NowPage.Location = new System.Drawing.Point(253, 20);
            this.txtbox_NowPage.Name = "txtbox_NowPage";
            this.txtbox_NowPage.Size = new System.Drawing.Size(37, 21);
            this.txtbox_NowPage.TabIndex = 15;
            this.txtbox_NowPage.Text = "1";
            // 
            // lab_Di
            // 
            this.lab_Di.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_Di.AutoSize = true;
            this.lab_Di.Location = new System.Drawing.Point(230, 23);
            this.lab_Di.Name = "lab_Di";
            this.lab_Di.Size = new System.Drawing.Size(17, 12);
            this.lab_Di.TabIndex = 14;
            this.lab_Di.Text = "第";
            // 
            // linklab_PreviousPage
            // 
            this.linklab_PreviousPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linklab_PreviousPage.AutoSize = true;
            this.linklab_PreviousPage.Location = new System.Drawing.Point(213, 23);
            this.linklab_PreviousPage.Name = "linklab_PreviousPage";
            this.linklab_PreviousPage.Size = new System.Drawing.Size(11, 12);
            this.linklab_PreviousPage.TabIndex = 13;
            this.linklab_PreviousPage.TabStop = true;
            this.linklab_PreviousPage.Text = "<";
            // 
            // linklab_FirstPage
            // 
            this.linklab_FirstPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linklab_FirstPage.AutoSize = true;
            this.linklab_FirstPage.Location = new System.Drawing.Point(190, 23);
            this.linklab_FirstPage.Name = "linklab_FirstPage";
            this.linklab_FirstPage.Size = new System.Drawing.Size(17, 12);
            this.linklab_FirstPage.TabIndex = 12;
            this.linklab_FirstPage.TabStop = true;
            this.linklab_FirstPage.Text = "<<";
            // 
            // cmbox_RecordsPerPage
            // 
            this.cmbox_RecordsPerPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbox_RecordsPerPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_RecordsPerPage.FormattingEnabled = true;
            this.cmbox_RecordsPerPage.Items.AddRange(new object[] {
            "1条/页",
            "3条/页",
            "5条/页",
            "7条/页",
            "10条/页",
            "20条/页",
            "30条/页",
            "999条/页"});
            this.cmbox_RecordsPerPage.Location = new System.Drawing.Point(107, 20);
            this.cmbox_RecordsPerPage.Name = "cmbox_RecordsPerPage";
            this.cmbox_RecordsPerPage.Size = new System.Drawing.Size(77, 20);
            this.cmbox_RecordsPerPage.TabIndex = 11;
            // 
            // lab_TotalRecords
            // 
            this.lab_TotalRecords.AutoSize = true;
            this.lab_TotalRecords.Location = new System.Drawing.Point(30, 23);
            this.lab_TotalRecords.Name = "lab_TotalRecords";
            this.lab_TotalRecords.Size = new System.Drawing.Size(59, 12);
            this.lab_TotalRecords.TabIndex = 10;
            this.lab_TotalRecords.Text = "共77777条";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbox_RecordsPerPage);
            this.groupBox1.Controls.Add(this.lab_TotalPages);
            this.groupBox1.Controls.Add(this.lab_TotalRecords);
            this.groupBox1.Controls.Add(this.linklab_LastPage);
            this.groupBox1.Controls.Add(this.linklab_FirstPage);
            this.groupBox1.Controls.Add(this.linklab_NextPage);
            this.groupBox1.Controls.Add(this.linklab_PreviousPage);
            this.groupBox1.Controls.Add(this.lab_Ye);
            this.groupBox1.Controls.Add(this.lab_Di);
            this.groupBox1.Controls.Add(this.txtbox_NowPage);
            this.groupBox1.Location = new System.Drawing.Point(12, 385);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 53);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.paginator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private Paginator paginator1;
        private System.Windows.Forms.Label lab_TotalPages;
        private System.Windows.Forms.LinkLabel linklab_LastPage;
        private System.Windows.Forms.LinkLabel linklab_NextPage;
        private System.Windows.Forms.Label lab_Ye;
        private System.Windows.Forms.TextBox txtbox_NowPage;
        private System.Windows.Forms.Label lab_Di;
        private System.Windows.Forms.LinkLabel linklab_PreviousPage;
        private System.Windows.Forms.LinkLabel linklab_FirstPage;
        private System.Windows.Forms.ComboBox cmbox_RecordsPerPage;
        private System.Windows.Forms.Label lab_TotalRecords;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

