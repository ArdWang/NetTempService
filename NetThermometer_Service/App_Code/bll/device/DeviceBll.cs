using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// DeviceBll 的摘要说明
/// </summary>
public class DeviceBll
{
    /// <summary>
    /// 获取设备信息
    /// </summary>
    /// <param name="userid"></param>
    /// <returns></returns>
    public static DataTable select_Deviceinfo(int userid) {
        string sql = "select * from device_tb where userid = @userid";
        SqlParameter[] pars = { new SqlParameter("@userid", userid) };
        
        return DBhelp.select_AllParameter(sql, pars);
    }
}