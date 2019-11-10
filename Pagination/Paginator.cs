using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Pagination
{
    public partial class Paginator : UserControl
    {
        public Paginator()
        {
            InitializeComponent();
        }

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

        private int TotalCount;
        private int NowPage;
        private static string CountSQL;
        private string translateRecordsPerPage;
        private int PerPage;
        private string LimitSQL;
        private DataGridView DGVName;


        DB db = new DB();

        #region 属性窗口元件
        private string[] recordsPerPage_Items = null;//每页显示条数数组
        private int defaultNowPage;//当前页
        private string sourceSQL;//原始SQL

        //用户控件在窗体中下方公有变量属性的分类
        [Category("分页控件"), Browsable(true), Description("下拉框赋值，只需填入每页显示条数，如每页显示3条，填“3”即可")]
        //公有变量会显示在用户控件的属性中
        public string[] RecordsPerPage_Items
        {
            get { return recordsPerPage_Items; }
            set { recordsPerPage_Items = value; }
        }

        [Category("分页控件"), Browsable(true), Description("程序运行时，默认页码")]
        public int DefaultNowPage
        {
            get
            {
                if (defaultNowPage <= 0)
                {
                    defaultNowPage = 1;
                    return defaultNowPage;
                }
                else
                {
                    return defaultNowPage;
                }
            }
            set { defaultNowPage = value; }
        }

        [Category("分页控件"), Browsable(false), Description("原始SQL，可通过set配置")]
        private string SourceSQL
        {
            get { return sourceSQL; }
            set { sourceSQL = value; }
        }
        #endregion

        private void Paginator_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(ps.NowPage.ToString());
            //txtbox_NowPage.TextAlign = HorizontalAlignment.Center;
            //cmbox_RecordsPerPage.SelectedIndex = 0;
        }

        public void Run(string SQLQuery, DataGridView dgv)
        {
            SourceSQL = SQLQuery;

            //将dgv存到变量，供其他功能调用
            DGVName = dgv;

            //将原始SQL转为获取数量SQL
            CountSQL = GetCountSQL(SQLQuery);

            //SQL返回总条数
            TotalCount = Convert.ToInt32(db.GetResult(CountSQL));

            //将属性中配置的当前页码放入当前页文本框
            txtbox_NowPage.Text = defaultNowPage.ToString();
            NowPage = Convert.ToInt32(txtbox_NowPage.Text);

            //分页_当前页文本框文字居中
            txtbox_NowPage.TextAlign = HorizontalAlignment.Center;

            //将属性中配置的每页显示条数存入下拉框Items
            if (recordsPerPage_Items.Length > 0)
            {
                cmbox_RecordsPerPage.Items.Clear();
                for (int i = 0; i < recordsPerPage_Items.Length; i++)
                {
                    translateRecordsPerPage = recordsPerPage_Items[i] + "条/页";
                    cmbox_RecordsPerPage.Items.Add(translateRecordsPerPage);
                }
                cmbox_RecordsPerPage.SelectedIndex = 0;
            }

            //分页_每页显示条数下拉框默认选第一个
            cmbox_RecordsPerPage.SelectedIndex = 0;

            //刷新共几条、共几页
            RefreshCountPage(cmbox_RecordsPerPage, lab_TotalRecords, lab_TotalPages);

            //将结果显示到dgv中
            GetDGV(dgv);
        }

        public void runtest()
        {
            if (recordsPerPage_Items.Length > 0)
            {
                cmbox_RecordsPerPage.Items.Clear();
                for (int i = 0; i < recordsPerPage_Items.Length; i++)
                {
                    translateRecordsPerPage = recordsPerPage_Items[i] + "条/页";
                    cmbox_RecordsPerPage.Items.Add(translateRecordsPerPage);
                }
                cmbox_RecordsPerPage.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 将传入的SQL，转为获取数量SQL
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string GetCountSQL(string str)
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
        private string[] SplitMulti(string str, string splitstr)
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
        private string LowUp(string str, string lowORup)
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

        /// <summary>
        /// 传入每页多少条下拉框名称、共几条label名称、共几页label名称，刷新共几条、共几页
        /// </summary>
        /// <param name="RecordsPerPage"></param>
        /// <param name="TotalRecords"></param>
        /// <param name="TotalPages"></param>
        private void RefreshCountPage(ComboBox RecordsPerPage, Label TotalRecords, Label TotalPages)
        {
            //显示共多少条数据
            int TotalCount = Convert.ToInt32(db.GetResult(CountSQL));
            TotalRecords.Text = "共" + TotalCount + "条";

            //获取下拉框每页显示条数
            int PerPage = GetCmboxRecordsPerPage(RecordsPerPage.SelectedIndex);

            //根据总条数、每页显示条数，显示共多少页
            TotalPages.Text = "共" + GetTotalPages(TotalCount, PerPage) + "页";
        }

        /// <summary>
        /// 传入每页条数下拉框的index，获取每页条数
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private int GetCmboxRecordsPerPage(int index)
        {
            int PerPage;
            if (recordsPerPage_Items.Length < 1)
            {
                PerPage = 7;
            }
            else
            {
                PerPage = Convert.ToInt32(recordsPerPage_Items[index]);
            }
            return PerPage;
        }

        /// <summary>
        /// 传入总条数、每页显示条数，返回一共多少页
        /// </summary>
        /// <param name="TotalCount"></param>
        /// <param name="RecordsPerPage"></param>
        /// <returns></returns>
        private int GetTotalPages(int TotalCount, int RecordsPerPage)
        {
            int TotalPages = 0;
            int quyu = TotalCount % RecordsPerPage;
            if (quyu == 0)
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
        /// 传入dg名称，根据每页显示多少条、当前页返回分页结果
        /// </summary>
        /// <param name="dg"></param>
        /// <returns></returns>
        private DataGridView GetDGV(DataGridView dg)
        {
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
        /// 将传入的SQL，改为取指定行SQL
        /// </summary>
        /// <param name="str"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private string GetLimitSQL(string str, int begin, int end)
        {
            string LimitSQL = null;
            if ((str != null) && (str != ""))
            {
                LimitSQL = str + " limit " + begin + "," + end;
            }
            return LimitSQL;
        }

        private void cmbox_RecordsPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            //每页多少条下拉框
            txtbox_NowPage.Text = defaultNowPage.ToString();
            NowPage = Convert.ToInt32(txtbox_NowPage.Text);
            RefreshCountPage(cmbox_RecordsPerPage, lab_TotalRecords, lab_TotalPages);
            GetDGV(DGVName);
        }
    }
}