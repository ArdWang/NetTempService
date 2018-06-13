using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

/// <summary>
/// DeviceCommon 的摘要说明
/// </summary>
public class DeviceCommon
{
    public static string getDeviceInfoCommon(int userid)
    {
        //http://localhost:59519/Service/rilservlet.ashx?action=getDevice&userid=1
        DeviceManager device = new DeviceManager();
        string data = "";
        string json = "";
        JavaScriptSerializer js = new JavaScriptSerializer();

        List<DeviceModel> lstoutinfo = new List<DeviceModel>();
        DeviceModel outinfo = null;

        using (SqlConnection con = DBhelp.conn())
        {
            con.Open();
            string sql = "select* from device_tb where userid = @userid";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue(@"userid", userid);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
              
                outinfo = new DeviceModel();
                outinfo.Deviceid = int.Parse(dr["deviceid"].ToString());
                outinfo.Userid = int.Parse(dr["userid"].ToString());
                outinfo.Devicecode = dr["devicecode"].ToString();
                outinfo.Devicename = dr["devicename"].ToString();
                outinfo.Deviceaddre = dr["deviceaddre"].ToString();
                outinfo.Devicetime = dr["devicetime"].ToString();
                outinfo.Deviceonline = int.Parse(dr["deviceonline"].ToString());
                outinfo.Deviceinfo = dr["deviceinfo"].ToString();
                lstoutinfo.Add(outinfo);

            }
            dr.Close();
            con.Close();

        }

        using (SqlConnection con = DBhelp.conn())
        {
            
            con.Open();
            for (int i = 0; i < lstoutinfo.Count; i++)
            {

                lstoutinfo[i].Plist = new List<ProbeModel>();

                outinfo.Plist = new List<ProbeModel>();

                ProbeModel pb = null;
                string sql = "select * from probe_tb where deviceid='" + lstoutinfo[i].Deviceid + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {       
                    pb = new ProbeModel();
                    pb.Probename = dr["probename"].ToString();
                    pb.Probeid = int.Parse(dr["probeid"].ToString());
                    pb.Deviceid = int.Parse(dr["deviceid"].ToString());
                    pb.Probetemp = dr["probetemp"].ToString();
                    lstoutinfo[i].Plist.Add(pb);
                }
                dr.Close();
            }
            con.Close();
        }

        data = js.Serialize(lstoutinfo);

        if (data!= null && data != "")
        {
            json = "{" + "\"code\"" + ":" + 200 + "," + "\"message\"" + ":" + "\"success\"" + "," + "\"device\"" + ":" + data + "}";
        }
        else {
            json = "{" + "\"code\"" + ":" + 0 + "," + "\"message\"" + ":" + "\"error\"" + "}";
        }

        return json;

    }


}