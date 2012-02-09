using System;
using System.Collections.Generic;
using System.Text;
using DrawTools;

namespace CoolScreenShot
{
    static class Config
    {
        public static string AppIniFile = Environment.CurrentDirectory + "\\coolshot.ini";
        public static INIFile IniFile = new INIFile(AppIniFile);
        public static String KeyCode;
        public static bool ShiftKey;
        public static bool ControlKey;
        public static bool AltKey;
        public static bool WindowsKey;

        static Config(){
            ReadValues();
        }

        public static void ReadValues() {
            KeyCode = IniFile.Read("hotkey", "KeyCode", "A");
            ShiftKey = Config.BoolFromString((string)IniFile.Read("hotkey","Shift", "1"));
            ControlKey = BoolFromString((string)IniFile.Read("hotkey","Control", "1"));
            AltKey = BoolFromString((string)IniFile.Read("hotkey","Alt", "0"));
            WindowsKey = BoolFromString((string)IniFile.Read("hotkey","Windows", "0"));
        }

        public static void Save()
        {
            IniFile.Write("hotkey", "KeyCode", KeyCode.ToUpper());
            IniFile.Write("hotkey", "ShiftKey", BoolToString(ShiftKey));
            IniFile.Write("hotkey", "ControlKey", BoolToString(ControlKey));
            IniFile.Write("hotkey", "AltKey", BoolToString(AltKey));
            IniFile.Write("hotkey", "WindowsKey", BoolToString(WindowsKey));
        }

        public static string GetCurrentHotkeys() {
            string result = "";

            result = !ShiftKey ? result : result + "Shift+";
            result = !ControlKey ? result : result + "Ctrl+";
            result = !AltKey ? result : result + "Alt+";
            result = !WindowsKey ? result : result + "Windows+";

            result = result + KeyCode;

            return result;
        }

        #region Conversion helpers
        static string BoolToString(bool b)
        {
            if (b)
                return "1";
            else
                return "0";
        }

        static bool BoolFromString(string s)
        {
            if (s == null || s != "1")
                return false;
            else
                return true;
        }

        #endregion
    }
}
