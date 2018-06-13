using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// DeviceManager 的摘要说明
/// </summary>
public class DeviceManager : DeviceDao
{
    public List<DeviceModel> getDeviceList(int userid)
    {
       try
        {
            List<DeviceModel> list = new List<DeviceModel>();
            list = ModelConvertHelper<DeviceModel>.ConvertToModel(DeviceBll.select_Deviceinfo(userid));
            return list;
       }
       catch {
          return null;
       }
    }
}