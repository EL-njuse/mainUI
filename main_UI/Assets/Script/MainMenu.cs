using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
public class MainMenu : MonoBehaviour
{
    string exePath = "C:\\Users\\chenhongyu\\Desktop\\mac";
    public void OnGUI(){
        Process.Start(exePath);
    }
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
        KillProcess("mac");
    }
}

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using System.Diagnostics;//需要引入命名空间
 
// public class OpenOtherExe : MonoBehaviour {
 
//     string exePath = "D:\\Test\\Debug\\TeacherMechine.exe";
//     // string str = Application.dataPath + "/Resources/MyFile/Debug/TeacherMechine.exe";
   
//     void OnGUI()
//     {
//         if (GUI.Button(new Rect(100, 100, 150, 50), "Start TeacherMechine"))
//         {
// //打开第三软件
//             Process.Start(exePath);
//         }
  
//         if (GUI.Button(new Rect(100, 200, 150, 50), "Stop TeacherMechine"))
//         {
//             KillProcess("TeacherMechine");//括号里面的是exe的文件名
//         }
//     }
 
//    //关闭第三方软件
 
   