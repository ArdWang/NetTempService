using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// ProbeModel 的摘要说明
/// </summary>
public class ProbeModel
{
    private int probeid;
    private int deviceid;
    private string probename;
    private string probetemp;

    public int Probeid
    {
        get
        {
            return probeid;
        }

        set
        {
            probeid = value;
        }
    }

    public int Deviceid
    {
        get
        {
            return deviceid;
        }

        set
        {
            deviceid = value;
        }
    }

    public string Probename
    {
        get
        {
            return probename;
        }

        set
        {
            probename = value;
        }
    }

    public string Probetemp
    {
        get
        {
            return probetemp;
        }

        set
        {
            probetemp = value;
        }
    }
}