using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// ProbeBll 的摘要说明
/// </summary>
public class ProbeBll
{
    public static DataTable select_Probeinfo(int deviceid)
    {
        string sql = "select * from probe_tb where deviceid=@deviceid";
        SqlParameter[] pars = { new SqlParameter("@deviceid", deviceid) };
        return DBhelp.select_AllParameter(sql, pars);
    }
}