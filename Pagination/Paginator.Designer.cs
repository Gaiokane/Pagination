namespace Pagination
{
    partial class Paginator
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_TotalRecords = new System.Windows.Forms.Label();
            this.cmbox_RecordsPerPage = new System.Windows.Forms.ComboBox();
            this.linklab_FirstPage = new System.Windows.Forms.LinkLabel();
            this.linklab_PreviousPage = new System.Windows.Forms.LinkLabel();
            this.lab_Di = new System.Windows.Forms.Label();
            this.txtbox_NowPage = new System.Windows.Forms.TextBox();
            this.lab_Ye = new System.Windows.Forms.Label();
            this.linklab_NextPage = new System.Windows.Forms.LinkLabel();
            this.linklab_LastPage = new System.Windows.Forms.LinkLabel();
            this.lab_TotalPages = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_TotalRecords
            // 
            this.lab_TotalRecords.AutoSize = true;
            this.lab_TotalRecords.Location = new System.Drawing.Point(17, 6);
            this.lab_TotalRecords.Name = "lab_TotalRecords";
            this.lab_TotalRecords.Size = new System.Drawing.Size(59, 12);
            this.lab_TotalRecords.TabIndex = 0;
            this.lab_TotalRecords.Text = "共77777条";
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
            this.cmbox_RecordsPerPage.Location = new System.Drawing.Point(94, 3);
            this.cmbox_RecordsPerPage.Name = "cmbox_RecordsPerPage";
            this.cmbox_RecordsPerPage.Size = new System.Drawing.Size(77, 20);
            this.cmbox_RecordsPerPage.TabIndex = 1;
            this.cmbox_RecordsPerPage.SelectedIndexChanged += new System.EventHandler(this.cmbox_RecordsPerPage_SelectedIndexChanged);
            // 
            // linklab_FirstPage
            // 
            this.linklab_FirstPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linklab_FirstPage.AutoSize = true;
            this.linklab_FirstPage.Location = new System.Drawing.Point(177, 6);
            this.linklab_FirstPage.Name = "linklab_FirstPage";
            this.linklab_FirstPage.Size = new System.Drawing.Size(17, 12);
            this.linklab_FirstPage.TabIndex = 2;
            this.linklab_FirstPage.TabStop = true;
            this.linklab_FirstPage.Text = "<<";
            // 
            // linklab_PreviousPage
            // 
            this.linklab_PreviousPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linklab_PreviousPage.AutoSize = true;
            this.linklab_PreviousPage.Location = new System.Drawing.Point(200, 6);
            this.linklab_PreviousPage.Name = "linklab_PreviousPage";
            this.linklab_PreviousPage.Size = new System.Drawing.Size(11, 12);
            this.linklab_PreviousPage.TabIndex = 3;
            this.linklab_PreviousPage.TabStop = true;
            this.linklab_PreviousPage.Text = "<";
            // 
            // lab_Di
            // 
            this.lab_Di.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_Di.AutoSize = true;
            this.lab_Di.Location = new System.Drawing.Point(217, 6);
            this.lab_Di.Name = "lab_Di";
            this.lab_Di.Size = new System.Drawing.Size(17, 12);
            this.lab_Di.TabIndex = 4;
            this.lab_Di.Text = "第";
            // 
            // txtbox_NowPage
            // 
            this.txtbox_NowPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_NowPage.Location = new System.Drawing.Point(240, 3);
            this.txtbox_NowPage.Name = "txtbox_NowPage";
            this.txtbox_NowPage.Size = new System.Drawing.Size(37, 21);
            this.txtbox_NowPage.TabIndex = 5;
            this.txtbox_NowPage.Text = "1";
            // 
            // lab_Ye
            // 
            this.lab_Ye.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_Ye.AutoSize = true;
            this.lab_Ye.Location = new System.Drawing.Point(283, 6);
            this.lab_Ye.Name = "lab_Ye";
            this.lab_Ye.Size = new System.Drawing.Size(17, 12);
            this.lab_Ye.TabIndex = 6;
            this.lab_Ye.Text = "页";
            // 
            // linklab_NextPage
            // 
            this.linklab_NextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linklab_NextPage.AutoSize = true;
            this.linklab_NextPage.Location = new System.Drawing.Point(306, 6);
            this.linklab_NextPage.Name = "linklab_NextPage";
            this.linklab_NextPage.Size = new System.Drawing.Size(11, 12);
            this.linklab_NextPage.TabIndex = 7;
            this.linklab_NextPage.TabStop = true;
            this.linklab_NextPage.Text = ">";
            // 
            // linklab_LastPage
            // 
            this.linklab_LastPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linklab_LastPage.AutoSize = true;
            this.linklab_LastPage.Location = new System.Drawing.Point(323, 6);
            this.linklab_LastPage.Name = "linklab_LastPage";
            this.linklab_LastPage.Size = new System.Drawing.Size(17, 12);
            this.linklab_LastPage.TabIndex = 8;
            this.linklab_LastPage.TabStop = true;
            this.linklab_LastPage.Text = ">>";
            // 
            // lab_TotalPages
            // 
            this.lab_TotalPages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_TotalPages.AutoSize = true;
            this.lab_TotalPages.Location = new System.Drawing.Point(346, 6);
            this.lab_TotalPages.Name = "lab_TotalPages";
            this.lab_TotalPages.Size = new System.Drawing.Size(47, 12);
            this.lab_TotalPages.TabIndex = 9;
            this.lab_TotalPages.Text = "共777页";
            // 
            // Paginator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lab_TotalPages);
            this.Controls.Add(this.linklab_LastPage);
            this.Controls.Add(this.linklab_NextPage);
            this.Controls.Add(this.lab_Ye);
            this.Controls.Add(this.txtbox_NowPage);
            this.Controls.Add(this.lab_Di);
            this.Controls.Add(this.linklab_PreviousPage);
            this.Controls.Add(this.linklab_FirstPage);
            this.Controls.Add(this.cmbox_RecordsPerPage);
            this.Controls.Add(this.lab_TotalRecords);
            this.Name = "Paginator";
            this.Size = new System.Drawing.Size(396, 27);
            this.Load += new System.EventHandler(this.Paginator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_TotalRecords;
        private System.Windows.Forms.ComboBox cmbox_RecordsPerPage;
        private System.Windows.Forms.LinkLabel linklab_FirstPage;
        private System.Windows.Forms.LinkLabel linklab_PreviousPage;
        private System.Windows.Forms.Label lab_Di;
        private System.Windows.Forms.TextBox txtbox_NowPage;
        private System.Windows.Forms.Label lab_Ye;
        private System.Windows.Forms.LinkLabel linklab_NextPage;
        private System.Windows.Forms.LinkLabel linklab_LastPage;
        private System.Windows.Forms.Label lab_TotalPages;
    }
}
