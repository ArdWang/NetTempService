using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


/// <summary>
/// UserBll 
/// 用户的业务类
/// </summary>
public class UserBll
{
    /// <summary>
    /// 登录Bll
    /// </summary>
    /// <param name="sql"></param>
    /// <param name="serach"></param>
    /// <returns>DBhelp.select_AllParameter(sql, pars)</returns>
    public static DataTable select_LoginUser(string username,string password)
    {
        string sql = "select * from user_tb where username=@username and password=@password";
        SqlParameter[] pars = { new SqlParameter("@username", username), new SqlParameter("@password", password) };
        return DBhelp.select_AllParameter(sql, pars);
    }
}