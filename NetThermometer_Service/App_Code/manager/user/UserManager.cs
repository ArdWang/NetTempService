using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// UserManager 
/// 实现接口
/// </summary>
public class UserManager:UserDao
{
    /// <summary>
    /// 实现UserDao
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    public List<UserModel> getLoginUser(String username, String password) {
        try
        {
            List<UserModel> list = new List<UserModel>();
            list = ModelConvertHelper<UserModel>.ConvertToModel(UserBll.select_LoginUser(username, password));
            return list;
        }
        catch {
            return null;
        }
    }

   
}