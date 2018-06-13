using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// UserDao
/// 用户接口
/// </summary>
public interface UserDao
{
   /// <summary>
   /// 获取当前的用户信息
   /// </summary>
   /// <param name="username"></param>
   /// <param name="password"></param>
   /// <returns>list</returns>
   List<UserModel> getLoginUser(String username, String password);
}