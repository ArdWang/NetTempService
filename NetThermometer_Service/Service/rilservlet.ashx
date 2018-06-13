<%@ WebHandler Language="C#" Class="rilservlet" %>

using System;
using System.Web;


public class rilservlet : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html;charset=utf-8";
        string json = "";
        if (HttpContext.Current.Request.RequestType.Equals("POST"))
        {
            json = getRilPost(context);
            context.Response.Write(json);
        }
        else {
            json = getRilGet(context);
            context.Response.Write(json);
        }

    }

    /// <summary>
    /// 用户post请求
    /// </summary>
    /// <param name="context"></param>
    /// <returns>json</returns>
    private string getRilPost(HttpContext context) {
        string action = context.Request.Form["action"].ToString();
        string json = "";
        if (action == "getLogin") {
            string username = context.Request.Form["username"].ToString();
            string password = context.Request.Form["password"].ToString();
            json = UserCommon.getLoginUserCommon(username, password);
            return json;
        }
        else if (action=="getDevice") {
            string uid = context.Request.Form["userid"].ToString();
            int userid = int.Parse(uid);
            json = DeviceCommon.getDeviceInfoCommon(userid);
            return json;

        }
        return json;
    }



    /// <summary>
    /// 用户为Get请求的时候
    /// </summary>
    /// <param name="context"></param>
    /// <returns>json</returns>
    private string getRilGet(HttpContext context) {
        string action = context.Request.QueryString["action"];
        string json = "";
        if (action=="getLogin") {
            string username = context.Request.QueryString["username"];
            string password = context.Request.QueryString["password"];
            json = UserCommon.getLoginUserCommon(username, password);
            return json;
        }
        else if (action=="getDevice") {
            string uid = context.Request.QueryString["userid"];
            int userid = int.Parse(uid);
            json = DeviceCommon.getDeviceInfoCommon(userid);
            return json;

        }


        return json;
    }



    public bool IsReusable {
        get {
            return false;
        }
    }

}