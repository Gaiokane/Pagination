using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pagination
{
    public partial class Paginator : UserControl
    {
        public Paginator()
        {
            InitializeComponent();
        }
        
        //每页条数下拉框 cmbox_RecordsPerPage
        private int txt_NowPage;

        public int NowPage { get => txt_NowPage; set => txt_NowPage = value; }

        //共77777条 lab_TotalRecords
        //每页条数下拉框 cmbox_RecordsPerPage
        //首页 linklab_FirstPage
        //上一页 linklab_PreviousPage
        //第 lab_Di
        //几 txtbox_NowPage
        //页 lab_Ye
        //下一页 linklab_NextPage
        //尾页 linklab_LastPage
        //共999页 lab_TotalPages

        private void Paginator_Load(object sender, EventArgs e)
        {
            MessageBox.Show(NowPage.ToString());
            txtbox_NowPage.TextAlign = HorizontalAlignment.Center;
            cmbox_RecordsPerPage.SelectedIndex = 0;
            txtbox_NowPage.Text = NowPage.ToString();
        }
    }
}
