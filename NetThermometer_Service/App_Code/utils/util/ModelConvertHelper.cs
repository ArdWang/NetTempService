﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Reflection;

/// <summary>
/// ModelConvertHelper
/// 将DataTable转为List<T>类型
/// </summary>
public class ModelConvertHelper<T> where T : new()  // 此处一定要加上new()
{

    public static List<T> ConvertToModel(DataTable dt)
    {
        List<T> ts = new List<T>();// 定义集合
        Type type = typeof(T); // 获得此模型的类型
        string tempName = "";
        foreach (DataRow dr in dt.Rows)
        {
            T t = new T();
            PropertyInfo[] propertys = t.GetType().GetProperties();// 获得此模型的公共属性
            foreach (PropertyInfo pi in propertys)
            {
                tempName = pi.Name;
                if (dt.Columns.Contains(tempName))
                {
                    if (!pi.CanWrite) continue;
                    object value = dr[tempName];
                    if (value != DBNull.Value)
                        pi.SetValue(t, value, null);
                }
            }
            ts.Add(t);
        }
        return ts;
    }
}