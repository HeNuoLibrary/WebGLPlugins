using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

//原文链接：https://blog.csdn.net/xunideshijie/article/details/123795652

public class GetURLValue : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern string StringReturnValueFunction();

    public static string UrlMsg = string.Empty;

    void Start()
    {
        UrlMsg = "";
        try
        {
            UrlMsg = StringReturnValueFunction();
        }
        catch (System.Exception e)
        {
            UrlMsg = "[catch debug]" + e.Message;
        }
    }
}
