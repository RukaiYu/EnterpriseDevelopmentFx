using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace NkjSoft.Tools.DBUtility
{
    /// <summary>
    /// ���ݿ���������
    /// <para>
    ///     ���÷�ʽ ��  
    ///   SqlHelper.ExecuteNonQuery("select * from ���ݿ���� ;",CommandType.Text,����,�������Ϊnull);
    /// </para>
    /// </summary>
    public sealed class SqlHelper
    {
        /// <summary>
        /// ��ȡ���ݿ������ַ���
        /// </summary>
        public static string ConnectionString = null;//System.Configuration.ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;

        /// <summary>
        /// 
        /// </summary>
        private static SqlConnection commonConn = null;

        public static bool IsOpen
        {
            get
            {
                if (commonConn == null)
                    commonConn = new SqlConnection(ConnectionString);
                Open();
                return commonConn.State == ConnectionState.Open;
            }
        }

        private static void Open()
        {
            commonConn.Open();
        }



        /// <summary>
        /// ���ص�����Ĳ�ѯ.
        /// </summary>
        /// <param name="sqlExpressionOrSp_Name">sql�����ߴ洢��������</param>
        /// <param name="cmdType">�������ͣ�SQL��䣬���ߴ洢����</param>
        /// <param name="parames">�������ϣ��ɿ�</param>
        /// <returns>������ѯ�����</returns>
        public static DataTable ToDataTable(string sqlExpressionOrSp_Name, CommandType cmdType, params System.Data.SqlClient.SqlParameter[] parames)
        {
            DataTable result = null;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlExpressionOrSp_Name, conn))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    cmd.CommandType = cmdType;

                    if (parames != null && parames.Length != 0)
                        cmd.Parameters.AddRange(parames);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        result = new DataTable();

                        result.Load(reader);
                    }
                }

            }
            return result;
        }



        /// <summary>
        /// ִ�в�ѯ�����ز�ѯ��Ӱ�������.
        /// </summary>
        /// <param name="sqlExpressionOrSp_Name">sql�����ߴ洢��������</param>
        /// <param name="cmdType">�������ͣ�SQL��䣬���ߴ洢����</param>
        /// <param name="parames">�������ϣ��ɿ�</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sqlExpressionOrSp_Name, CommandType cmdType, params System.Data.SqlClient.SqlParameter[] parames)
        {
            int result = -1;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlExpressionOrSp_Name, conn))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    cmd.CommandType = cmdType;

                    if (parames != null && parames.Length != 0)
                        cmd.Parameters.AddRange(parames);
                    //SqlParameter d = new SqlParameter("@ReturnValue", "");
                    //d.Direction = ParameterDirection.ReturnValue;
                    //cmd.Parameters.Add(d);
                    result = cmd.ExecuteNonQuery();
                }

            }
            return result;
        }


        /// <summary>
        /// ִ�в�ѯ�������Զ�������ֵ��
        /// </summary>
        /// <param name="sqlExpressionOrSp_Name">sql�����ߴ洢��������</param>
        /// <param name="cmdType">�������ͣ�SQL��䣬���ߴ洢����</param>
        ///<param name="identity"></param>
        /// <param name="parames">�������ϣ��ɿ�</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sqlExpressionOrSp_Name, CommandType cmdType, out int identity, params System.Data.SqlClient.SqlParameter[] parames)
        {
            int result = -1;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlExpressionOrSp_Name, conn))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    cmd.CommandType = cmdType;

                    if (parames != null && parames.Length != 0)
                        cmd.Parameters.AddRange(parames);
                    SqlParameter d = new SqlParameter("@ReturnValue", "");
                    d.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(d);
                    result = cmd.ExecuteNonQuery();

                    identity = d.Value == null ? -1 : Convert.ToInt32(d.Value.ToString());
                }

            }
            return result;
        }


        /// <summary>
        /// ִ�в�ѯ�����ص���ֵ��ǿ���ͽ��.
        /// </summary>
        /// <typeparam name="TResult">����ֵ����</typeparam>
        /// <param name="sqlExpressionOrSp_Name">sql�����ߴ洢��������</param>
        /// <param name="cmdType">�������ͣ�SQL��䣬���ߴ洢����</param>
        /// <param name="parames">�������ϣ��ɿ�</param>
        /// <returns>����ֵ</returns>
        public static object ExecuteScalar(string sqlExpressionOrSp_Name, CommandType cmdType, params System.Data.SqlClient.SqlParameter[] parames)
        {
            object result = null;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlExpressionOrSp_Name, conn))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    cmd.CommandType = cmdType;

                    if (parames != null && parames.Length != 0)
                        cmd.Parameters.AddRange(parames);
                    result = cmd.ExecuteScalar();
                }
            }
            return result;
        }


        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] Parameters)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                if (Parameters != null && Parameters.Length != 0)
                    cmd.Parameters.AddRange(Parameters);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }
        private static SqlConnectionStringBuilder builder;
        /// <summary>
        /// ���ص�ǰ�����ַ������ӵ������ݿ�����֡�
        /// </summary>
        /// <param name="dbName">Name of the db.</param>
        /// <returns></returns>
        public static string BuildConnectionString(string dbName)
        {
            builder = new SqlConnectionStringBuilder(ConnectionString);

            builder.InitialCatalog = dbName;
            return builder.ToString();
        }
    }
}
