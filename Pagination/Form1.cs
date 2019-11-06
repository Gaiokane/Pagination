using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pagination
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DB db = new DB();
        paginator_setting ps = new paginator_setting();

        int NowPage;
        int TotalCount;
        int PerPage;
        string LimitSQL;

        //原始SQL
        static string SourceSQL = "SELECT id,xxx FROM info";

        //将原始SQL转为获取数量SQL
        static string CountSQL = GetCountSQL(SourceSQL);

        private void button1_Click(object sender, EventArgs e)
        {
            #region 此块=下面三行代码
            /*
            //显示共多少条数据
            TotalCount = Convert.ToInt32(db.GetResult(CountSQL));
            lab_TotalRecords.Text = "共" + TotalCount + "条";

            //获取下拉框每页显示条数
            PerPage = GetCmboxRecordsPerPage(cmbox_RecordsPerPage.SelectedIndex);

            //根据总条数、每页显示条数，显示共多少页
            lab_TotalPages.Text = "共" + GetTotalPages(TotalCount, PerPage) + "页";

            //        1       2        3
            //1       0,1     1,1      2,1
            //3       0,3     3,3      6,3
            //5       0,5     5,5      10,5
            //7       0,7     7,7      14,7
            //10      0,10    10,10    20,10
            //1行*1列-1列=,左边
            //1行：当前页
            //1列：每页显示条数
            */
            #endregion

            //默认第一页
            txtbox_NowPage.Text = "1";
            NowPage = Convert.ToInt32(txtbox_NowPage.Text);

            RefreshCountPage(cmbox_RecordsPerPage, lab_TotalRecords, lab_TotalPages);

            #region 此块=下行代码
            /*
            //根据每页显示多少条、当前页，拼接SQL
            LimitSQL = GetLimitSQL(SourceSQL, Convert.ToInt32(txtbox_NowPage.Text) * PerPage - PerPage, PerPage);
            //datagridview绑定数据
            dataGridView1.DataSource = db.GetDataSet(LimitSQL).Tables[0];
            */
            #endregion

            GetDGV(dataGridView1);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string Query = "select * from info where xxx = 'q'";
            label1.Text = db.GetRows(Query).ToString();
        }

        #region 注释
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

        //1条/页
        //3条/页
        //5条/页
        //7条/页
        //10条/页
        //20条/页
        //30条/页
        //999条/页
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            //分页_当前页文本框文字居中
            txtbox_NowPage.TextAlign = HorizontalAlignment.Center;

            //分页_每页显示条数下拉框默认选第一个
            cmbox_RecordsPerPage.SelectedIndex = 2;

            //分页_当前页文本框赋值
            //txtbox_NowPage.Text = 666.ToString();

            //显示共多少条数据
            //lab_TotalRecords.Text = "共" + db.GetResult(CountSQL) + "条";

            //返回sql执行统计行数的结果，耗时856ms
            //MessageBox.Show(db.GetResult(CountSQL).ToString());
            //将数据都存到内存统计行数，耗时996ms
            //MessageBox.Show(db.GetRows(SourceSQL).ToString());

            //dataGridView1.DataSource = db.GetDataSet(SourceSQL).Tables[0];
            
            TotalCount = Convert.ToInt32(db.GetResult(CountSQL));

            //默认第一页
            txtbox_NowPage.Text = "1";
            NowPage = Convert.ToInt32(txtbox_NowPage.Text);

            RefreshCountPage(cmbox_RecordsPerPage, lab_TotalRecords, lab_TotalPages);

            GetDGV(dataGridView1);
        }

        private void txtbox_NowPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                //当前页文本框回车
                if (e.KeyChar == 13)
                {
                    if (IsInt(txtbox_NowPage.Text) == true)
                    {
                        //一共多少页
                        if (Convert.ToInt32(txtbox_NowPage.Text) > GetTotalPages(TotalCount, PerPage) || Convert.ToInt32(txtbox_NowPage.Text) < 1)
                        {
                            txtbox_NowPage.Text = "1";
                            NowPage = Convert.ToInt32(txtbox_NowPage.Text);
                            #region 此块可直接调用Get DGV（已注释）
                            /*
                            //获取下拉框每页显示条数
                            PerPage = GetCmboxRecordsPerPage(cmbox_RecordsPerPage.SelectedIndex);
                            //根据每页显示多少条、当前页，拼接SQL
                            LimitSQL = GetLimitSQL(SourceSQL, Convert.ToInt32(txtbox_NowPage.Text) * PerPage - PerPage, PerPage);
                            //datagridview绑定数据
                            dataGridView1.DataSource = db.GetDataSet(LimitSQL).Tables[0];
                            */
                            #endregion
                            GetDGV(dataGridView1);
                        }
                        else
                        {
                            #region 此块可直接调用Get DGV（已注释）
                            /*
                            //获取下拉框每页显示条数
                            PerPage = GetCmboxRecordsPerPage(cmbox_RecordsPerPage.SelectedIndex);
                            //根据每页显示多少条、当前页，拼接SQL
                            LimitSQL = GetLimitSQL(SourceSQL, Convert.ToInt32(txtbox_NowPage.Text) * PerPage - PerPage, PerPage);
                            //datagridview绑定数据
                            dataGridView1.DataSource = db.GetDataSet(LimitSQL).Tables[0];
                            */
                            #endregion
                            NowPage = Convert.ToInt32(txtbox_NowPage.Text);
                            GetDGV(dataGridView1);
                        }
                    }
                    else
                    {
                        txtbox_NowPage.Text = "1";
                        NowPage = Convert.ToInt32(txtbox_NowPage.Text);
                        #region 此块可直接调用Get DGV（已注释）
                        /*
                        //获取下拉框每页显示条数
                        PerPage = GetCmboxRecordsPerPage(cmbox_RecordsPerPage.SelectedIndex);
                        //根据每页显示多少条、当前页，拼接SQL
                        LimitSQL = GetLimitSQL(SourceSQL, Convert.ToInt32(txtbox_NowPage.Text) * PerPage - PerPage, PerPage);
                        //datagridview绑定数据
                        dataGridView1.DataSource = db.GetDataSet(LimitSQL).Tables[0];
                        */
                        #endregion
                        GetDGV(dataGridView1);
                    }
                }
            }
        }

        private void txtbox_NowPage_KeyUp(object sender, KeyEventArgs e)
        {
            /*
            if (txtbox_NowPage.Text != "")
            {
                NowPage = Convert.ToInt32(txtbox_NowPage.Text);
            }
            */
        }

        private void cmbox_RecordsPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            //每页多少条下拉框
            txtbox_NowPage.Text = "1";
            NowPage = Convert.ToInt32(txtbox_NowPage.Text);
            RefreshCountPage(cmbox_RecordsPerPage, lab_TotalRecords, lab_TotalPages);
            GetDGV(dataGridView1);
        }

        private void linklab_FirstPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //跳到首页按钮
            txtbox_NowPage.Text = "1";
            NowPage = Convert.ToInt32(txtbox_NowPage.Text);
            GetDGV(dataGridView1);
        }

        private void linklab_LastPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //跳到尾页按钮
            txtbox_NowPage.Text = GetTotalPages(TotalCount, PerPage).ToString();
            NowPage = Convert.ToInt32(txtbox_NowPage.Text);
            GetDGV(dataGridView1);
        }

        private void linklab_PreviousPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //上一页按钮
            if (NowPage>1)
            {
                txtbox_NowPage.Text = (NowPage - 1).ToString();
                NowPage = NowPage - 1;
                GetDGV(dataGridView1);
            }
            else
            {
                txtbox_NowPage.Text = NowPage.ToString();
                MessageBox.Show("翻不到前面了😖");
            }
        }

        private void linklab_NextPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //下一页按钮

            //显示共多少条数据
            int TotalCount = Convert.ToInt32(db.GetResult(CountSQL));

            //获取下拉框每页显示条数
            int PerPage = GetCmboxRecordsPerPage(cmbox_RecordsPerPage.SelectedIndex);

            //MessageBox.Show(GetTotalPages(TotalCount, PerPage).ToString());

            if (NowPage < GetTotalPages(TotalCount, PerPage))
            {
                txtbox_NowPage.Text = (NowPage + 1).ToString();
                NowPage = NowPage + 1;
                GetDGV(dataGridView1);
            }
            else
            {
                txtbox_NowPage.Text = NowPage.ToString();
                MessageBox.Show("翻不到后面了😖");
            }
        }

        /// <summary>
        /// 传入每页多少条下拉框名称、共几条label每次、共几页label名称，刷新共几条、共几页
        /// </summary>
        /// <param name="RecordsPerPage"></param>
        /// <param name="TotalRecords"></param>
        /// <param name="TotalPages"></param>
        public static void RefreshCountPage(ComboBox RecordsPerPage, Label TotalRecords, Label TotalPages)
        {
            DB db = new DB();

            //显示共多少条数据
            int TotalCount = Convert.ToInt32(db.GetResult(CountSQL));
            TotalRecords.Text = "共" + TotalCount + "条";

            //获取下拉框每页显示条数
            int PerPage = GetCmboxRecordsPerPage(RecordsPerPage.SelectedIndex);

            //根据总条数、每页显示条数，显示共多少页
            TotalPages.Text = "共" + GetTotalPages(TotalCount, PerPage) + "页";
        }

        /// <summary>
        /// 传入dg名称，根据每页显示多少条、当前页返回分页结果
        /// </summary>
        /// <param name="dg"></param>
        /// <returns></returns>
        public DataGridView GetDGV(DataGridView dg)
        {
            DB db = new DB();
            try
            {
                //获取下拉框每页显示条数
                PerPage = GetCmboxRecordsPerPage(cmbox_RecordsPerPage.SelectedIndex);
                //根据每页显示多少条、当前页，拼接SQL
                LimitSQL = GetLimitSQL(SourceSQL, Convert.ToInt32(txtbox_NowPage.Text) * PerPage - PerPage, PerPage);
                //datagridview绑定数据
                dg.DataSource = db.GetDataSet(LimitSQL).Tables[0];
                return dg;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 判断是否为整型，返回true、false
        /// </summary>
        /// <param name="intstring"></param>
        /// <returns></returns>
        private bool IsInt(string intstring)
        {
            return Regex.IsMatch(intstring, @"[1-9]\d*$");
        }

        /// <summary>
        /// 传入总条数、每页显示条数，返回一共多少页
        /// </summary>
        /// <param name="TotalCount"></param>
        /// <param name="RecordsPerPage"></param>
        /// <returns></returns>
        public static int GetTotalPages(int TotalCount, int RecordsPerPage)
        {
            int TotalPages = 0;
            int quyu = TotalCount % RecordsPerPage;
            if (quyu==0)
            {
                TotalPages = TotalCount / RecordsPerPage;
            }
            else
            {
                TotalPages = TotalCount / RecordsPerPage + 1;
            }
            return TotalPages;
        }

        /// <summary>
        /// 传入每页条数下拉框的index，获取每页条数
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static int GetCmboxRecordsPerPage(int index)
        {
            int PerPage = 0;
            //1条/页
            if (index==0)
                PerPage = 1;
            //3条/页
            else if (index==1)
                PerPage = 3;
            //5条/页
            else if (index ==2)
                PerPage = 5;
            //7条/页
            else if (index ==3)
                PerPage = 7;
            //10条/页
            else if (index ==4)
                PerPage = 10;
            //20条/页
            else if (index ==5)
                PerPage = 20;
            //30条/页
            else if (index ==6)
                PerPage = 30;
            //999条/页
            else if (index ==7)
                PerPage = 999;
            return PerPage;
        }

        /// <summary>
        /// 将传入的SQL，改为取指定行SQL
        /// </summary>
        /// <param name="str"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static string GetLimitSQL(string str, int begin, int end)
        {
            string LimitSQL = null;
            if ((str != null) && (str != ""))
            {
                LimitSQL = str + " limit " + begin + "," + end;
            }
            return LimitSQL;
        }

        /// <summary>
        /// 将传入的SQL，转为获取数量SQL
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetCountSQL(string str)
        {
            string CountSQL = null;
            if ((str != null) && (str != ""))
            {
                CountSQL = "select count(*) from" + SplitMulti(LowUp(str, "low"), "from")[1];
            }
            return CountSQL;
        }

        /// <summary>
        /// 分割字符串
        /// </summary>
        /// <param name="str"></param>
        /// <param name="splitstr"></param>
        /// <returns></returns>
        public static string[] SplitMulti(string str, string splitstr)
        {
            string[] strArray = null;
            if ((str != null) && (str != ""))
            {
                strArray = new Regex(splitstr).Split(str);
            }
            return strArray;
        }

        /// <summary>
        /// 将字符串转换为大、小写
        /// </summary>
        /// <param name="str"></param>
        /// <param name="lowORup"></param>
        /// <returns></returns>
        public static string LowUp(string str, string lowORup)
        {
            string ResultStr = null;
            if ((str != null) && (str != ""))
            {
                if (lowORup == "low")
                {
                    ResultStr = str.ToLower();
                }
                else if (lowORup == "up")
                {
                    ResultStr = str.ToUpper();
                }
                else
                {
                    ResultStr = "error";
                }
            }
            return ResultStr;
        }
    }
}
