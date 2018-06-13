using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// ProbeManager 的摘要说明
/// </summary>
public class ProbeManager : ProbeDao
{
    public List<ProbeModel> getProbeList(int deviceid)
    {
        try
        {
            List<ProbeModel> list = new List<ProbeModel>();
            list = ModelConvertHelper<ProbeModel>.ConvertToModel(ProbeBll.select_Probeinfo(deviceid));
            return list;
        }
        catch {
            return null;
        }
    }
}