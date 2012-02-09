using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using DrawTools.Properties;

namespace DrawTools
{
    public static class DrawSettings
    {
        public static Color LastUsedColor = Color.FromArgb(255,255,0,0);
        public static int LastUsedPenWidth = 1;
        public static int LastUsedTextSize = 8;
        public static int Quality = 80;


        public static Color DefaultColor = Color.FromArgb(255, 255, 0, 0);
        public static int DefaultPenWidth = 1;
        public static int DefaultTextSize = 8;

        static DrawSettings() { 
            Settings settings = Properties.Settings.Default;
            DrawSettings.LastUsedColor = settings.color;
            DrawSettings.LastUsedPenWidth = settings.penWidth;
            DrawSettings.LastUsedTextSize = settings.textSize;

            DrawSettings.DefaultColor = settings.color;
            DrawSettings.DefaultPenWidth = settings.penWidth;
            DrawSettings.DefaultTextSize = settings.textSize;
        }

        public static void Save() {
            Settings settings = Properties.Settings.Default;
            settings.color = DrawSettings.LastUsedColor;
            settings.penWidth = DrawSettings.LastUsedPenWidth;
            settings.textSize = DrawSettings.LastUsedTextSize;

            settings.Save();
        }
    }
}
