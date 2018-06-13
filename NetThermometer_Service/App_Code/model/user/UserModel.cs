using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// User 的摘要说明
/// </summary>
public class UserModel
{
    private int userid;
    private string username;
    private string password;
    private int age;
    private string sex;
    private string phone;
    private string email;
    private string hoby;
    private string note;

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

    public string Username
    {
        get
        {
            return username;
        }

        set
        {
            username = value;
        }
    }

    public string Password
    {
        get
        {
            return password;
        }

        set
        {
            password = value;
        }
    }

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            age = value;
        }
    }

    public string Sex
    {
        get
        {
            return sex;
        }

        set
        {
            sex = value;
        }
    }

    public string Phone
    {
        get
        {
            return phone;
        }

        set
        {
            phone = value;
        }
    }

    public string Email
    {
        get
        {
            return email;
        }

        set
        {
            email = value;
        }
    }

    public string Hoby
    {
        get
        {
            return hoby;
        }

        set
        {
            hoby = value;
        }
    }

    public string Note
    {
        get
        {
            return note;
        }

        set
        {
            note = value;
        }
    }
}