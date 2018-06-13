using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

/// <summary>
/// NormalUtil 
/// 普通的帮助类
/// </summary>
public class NormalUtil
{
    /// <summary>
    /// 将list转为数组
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <returns>小写输出json数据</returns>
    public static string Obj2Json<T>(T data)
    {
        try
        {
            System.Runtime.Serialization.Json.DataContractJsonSerializer serializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(data.GetType());
            using (MemoryStream ms = new MemoryStream())
            {
                serializer.WriteObject(ms, data);
                //变为小写输出
                return Encoding.UTF8.GetString(ms.ToArray()).ToLower();
            }
        }
        catch
        {
            return null;
        }
    }
}