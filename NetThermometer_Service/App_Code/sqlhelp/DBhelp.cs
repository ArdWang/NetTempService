using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

/// <summary>
/// DBhelp 的摘要说明
/// </summary>
public class DBhelp
{
    //\sqlexpress
    public static SqlConnection conn()  //连接数据库字符串方法
    {
        string str = ConfigurationManager.ConnectionStrings["RIL_CON"].ToString();
        //con.ConnectionString = "server=.;database=stu;uid=sa;pwd=sa";
        //string str = @"Data Source=.\sqlexpress;Initial Catalog=Sy_DBOW;Integrated Security=True"; //定义一个字符串变量并把连接字段赋值给str
        SqlConnection con = new SqlConnection(str);  //重新new一个SqlConnection
        return con;  //返回con
    }


    /// <summary>
    /// 带参数的查询数据
    /// </summary>
    /// <param name="sql"></param>
    /// <param name="pars"></param>
    /// <returns>dt</returns>
    public static DataTable select_AllParameter(string sql, params SqlParameter[] pars)
    {
        DataTable dt = null;
        using (SqlConnection con = conn())
        {
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            sda.SelectCommand.CommandType = CommandType.Text;
            sda.SelectCommand.Parameters.AddRange(pars);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sda.SelectCommand);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }

    /// <summary>
    /// 带参数的增删查改
    /// </summary>
    /// <param name="sql"></param>
    /// <param name="pars"></param>
    /// <returns>irs</returns>
    public static int ExeCUD(string sql, params SqlParameter[] pars) //数据增加删除更新
    {
        int iRs = -1;
        using (SqlConnection con = conn())
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddRange(pars);
            con.Open();
            iRs = cmd.ExecuteNonQuery();
            con.Close();
        }
        return iRs;
    }

}