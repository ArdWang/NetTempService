using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// DeviceDao 设接口
/// </summary>
public interface DeviceDao
{
    /// <summary>
    /// 获取设备信息
    /// </summary>
    /// <param name="userid"></param>
    /// <returns></returns>
    List<DeviceModel> getDeviceList(int userid);
}