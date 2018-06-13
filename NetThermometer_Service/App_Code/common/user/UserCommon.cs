using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

/// <summary>
/// UserCommon
/// 用户登录验证
/// 
/// </summary>
public class UserCommon
{
    /// <summary>
    /// 生成输出的json数据
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    public static string getLoginUserCommon(string username, string password) {
        UserManager user = new UserManager();
        string json = "";
        string data = NormalUtil.Obj2Json<List<UserModel>>(user.getLoginUser(username, password));
        if (data != null && !data.Equals(""))
        {
            json = "{" + "\"code\"" + ":" + 200 + "," + "\"message\"" +":"+ "\"success\"" + "," + "\"user\"" + ":" + data + "}";
            return json;
        }
        else {
            json = "{" + "\"code\"" + ":" + 0 + "," + "\"message\"" +":"+ "\"error\"" + "}";
            return json;
        }
        
    }

 


    
}