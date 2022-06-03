using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;//需要引入命名空间e

public class Openexe : MonoBehaviour {
    public Texture buttonTexture;
    string exePath = "C:\\Users\\chenhongyu\\Desktop\\mac\\恋爱篇.exe";
    // string str = Application.dataPath + "/Resources/MyFile/el_all/mac/恋爱篇";
    string str;
    void Start () {
    
    }
    void OnGUI()
    {
        GUIStyle fontStyle = new GUIStyle();  
        fontStyle.alignment=TextAnchor.MiddleCenter;
        fontStyle.fontSize=25;
        fontStyle.normal.textColor=Color.white;
        fontStyle.normal.background=(Texture2D)buttonTexture;
        if (GUI.Button(new Rect(880,1000,430,160), "第四篇",fontStyle))
        {
//打开第三软件
            // str = Application.dataPath + "/Resources/MyFile/el_all/mac/恋爱篇";
            Process.Start(exePath);
        }
    }  
   //关闭第三方软件
 
   void KillProcess(string processName)
    {
        Process[] processes = Process.GetProcesses();
        foreach (Process process in processes)
        {
            try
            {
                if (!process.HasExited)
                {
                    if (process.ProcessName == processName)
                    {
                        process.Kill();
                        UnityEngine.Debug.Log("已关闭进程");
                    }
                }
            }
            catch (System.InvalidOperationException ex)
            {
                UnityEngine.Debug.Log(ex);
            }
        }
    }
    /// <summary>
    /// 该程序关闭会自动结束自己打开的进程
    /// </summary>
    private void OnDisable()
    {
        KillProcess("恋爱篇");
    }
 
}