using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;

namespace CoolScreenShot
{
    class UtilHelps
    {
        public static  String AppName = "coolshot";

           /// 开机启动项  
        /// </summary>  
        /// <param name="Started">是否启动</param>  
        /// <param name="name">启动值的名称</param>  
        /// <param name="path">启动程序的路径</param>  
        private static void RunWhenStart(bool Started, string name, string path)
        {
            RegistryKey HKLM = Registry.LocalMachine;
            RegistryKey Run = HKLM.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
            if (Started == true)
            {
                try
                {
                    Run.SetValue(name, path);
                    HKLM.Close();
                }
                catch//没有权限会异常 
                {}
            }
            else
            {
                try
                {
                    Run.DeleteValue(name);
                    HKLM.Close();
                }
                catch//没有权限会异常 
                {}
            }
        }

        public static bool IsFirstRunApp() {
            RegistryKey ms_run = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            Object path = ms_run.GetValue(AppName);

            return path == null;
        }

        public static bool HasAddToStart() {
            RegistryKey ms_run = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            Object path = ms_run.GetValue(AppName);

            return path != null && path.ToString() == Application.ExecutablePath.ToString();
        }

        public static void AddWhenStart() {
            //添加启动
            RegistryKey ms_run = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            ms_run.SetValue("coolshot", Application.ExecutablePath.ToString());
        }

        public static void RemoveWhenStart() {
            //删除启动（设为控，注册表项还在）
            RegistryKey ms_run = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            ms_run.SetValue("coolshot", "");
        }
    }
}
