using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// DeviceModel 
/// 设备model
/// </summary>
public class DeviceModel
{
    private int deviceid;
    private int userid;
    private string devicecode;
    private string devicename;
    private string deviceaddre;
    private string devicetime;
    private int deviceonline;
    private string deviceinfo;

    private List<ProbeModel> plist;

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

    public int Userid
    {
        get
        {
            return userid;
        }

        set
        {
            userid = value;
        }
    }

    public string Devicecode
    {
        get
        {
            return devicecode;
        }

        set
        {
            devicecode = value;
        }
    }

    public string Devicename
    {
        get
        {
            return devicename;
        }

        set
        {
            devicename = value;
        }
    }

    public string Deviceaddre
    {
        get
        {
            return deviceaddre;
        }

        set
        {
            deviceaddre = value;
        }
    }

    public string Devicetime
    {
        get
        {
            return devicetime;
        }

        set
        {
            devicetime = value;
        }
    }

    public int Deviceonline
    {
        get
        {
            return deviceonline;
        }

        set
        {
            deviceonline = value;
        }
    }

    public string Deviceinfo
    {
        get
        {
            return deviceinfo;
        }

        set
        {
            deviceinfo = value;
        }
    }

    public List<ProbeModel> Plist
    {
        get
        {
            return plist;
        }

        set
        {
            plist = value;
        }
    }
}