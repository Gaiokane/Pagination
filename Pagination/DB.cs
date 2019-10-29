using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Pagination
{
    class DB
    {
        public MySqlConnection Mysqlconn()
        {
            
            string sqlconn = "Host=127.0.0.1;Database=pagination;Username=qk;Password=11111;sslmode=none";
            MySqlConnection conn = new MySqlConnection(sqlconn);
            return conn;
        }

        //Mysqlcom
        //CommInt
        //MysqlComm
        //MysqlDs
        //没有Comm

        /// <summary>
        /// 传入SQL，返回查询结果记录条数
        /// </summary>
        /// <param name="Query"></param>
        /// <returns></returns>
        public int GetRows(string Query)
        {
            MySqlConnection conn = Mysqlconn();
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand(Query, conn);
                MySqlDataAdapter mysqldataadapter = new MySqlDataAdapter();
                mysqldataadapter.SelectCommand = comm;
                DataSet ds = new DataSet();
                int n = mysqldataadapter.Fill(ds);
                return n;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 传入SQL，返回该命令所影响行数，其他类型语句（建表）、回滚，返回值为-1
        /// </summary>
        /// <param name="Query"></param>
        /// <returns></returns>
        public int GetAffectRows(string Query)
        {
            MySqlConnection sqlconn = Mysqlconn();
            sqlconn.Open();
            try
            {
                MySqlCommand comm = new MySqlCommand(Query, sqlconn);

                int result = comm.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlconn.Close();
            }
        }

        /// <summary>
        /// 传入SQL，返回查询结果中第一行第一列的值
        /// </summary>
        /// <param name="Query"></param>
        /// <returns></returns>
        public object GetResult(string Query)
        {
            MySqlConnection sqlconn = Mysqlconn();
            sqlconn.Open();
            try
            {
                MySqlCommand sqlcommd = new MySqlCommand(Query, sqlconn);
                object result = sqlcommd.ExecuteScalar();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlconn.Close();
            }
        }

        /// <summary>
        /// 传入SQL，返回DataSet
        /// </summary>
        /// <param name="Query"></param>
        /// <returns></returns>
        public DataSet GetDataSet(string Query)
        {
            DataSet ds = new DataSet();
            MySqlConnection sqlconn = Mysqlconn();
            try
            {
                sqlconn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(Query, sqlconn);
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlconn.Close();
            }
        }
    }
}
