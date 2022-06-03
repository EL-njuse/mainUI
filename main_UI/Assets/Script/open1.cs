using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;//需要引入命名空间e
public class open1 : MonoBehaviour{
 
    string exePath = "C:\\Users\\chenhongyu\\Desktop\\mac";
    // string str = Application.dataPath + "/Resources/MyFile/Debug/TeacherMechine.exe";
   
    void OnGUI()
    {
        if (GUI.Button(new Rect(880,100,430,160), ""))
        {
//打开第三软件
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