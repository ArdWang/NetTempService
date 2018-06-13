using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// ProbeDao 的摘要说明
/// </summary>
public interface ProbeDao
{
    List<ProbeModel> getProbeList(int deviceid);
}