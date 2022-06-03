using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;//需要引入命名空间e
 
public class open2 : MonoBehaviour{
    string exePath2 = "C:\\Users\\chenhongyu\\Desktop\\el_all\\LarHotel_\\Version_2\\EL";
    // string str = Application.dataPath + "/Resources/MyFile/Debug/TeacherMechine.exe";
   
    void OnGUI()
    {
        if (GUI.Button(new Rect(880,700,430,160), ""))
        {
//打开第三软件
            Process.Start(exePath2);
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
        KillProcess("EL");
    }
 
}