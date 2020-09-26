using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTheme
{
    public class ConstantsAndVars
    {
        public static inifiles.IniFile ini = new inifiles.IniFile(settingPath() + "setting.ini");
        ThemeRef _refTheme = new ThemeRef();
        static Form1 _form1 = new Form1();
        public static string themePathDefault = @"C:\Windows\Resources\Themes\";
        public static readonly string[] settingCol = new string[] { "Delays", "Theme", "Path", "TaskCreated","ToggleAuto" };
        public static readonly string[] delaysSets = new string[] { "beforeApplyTheme", "themeUpdateDelay", "settingsClosing", "programClose" };
        public static int DelayBeforeStart { get; set; }
        public static int DelayThemeUpdate { get; set; }
        public static int DelaySettingClose { get; set; }
        public static int DelayProgramClose { get; set; }
        public static string themePaths { get; set; }
        public static readonly string registryThemeCommandPath = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
        public static readonly string[] registryThemeCommands = new string[] { "AppsUseLightTheme", "SystemUsesLightTheme" };
        public static readonly string filterForOFD = "Theme files|*.theme";
        public string themePath()
        {
            if (ini.KeyExists(settingCol[2], settingCol[1]))
            {
                themePaths = ini.ReadINI(settingCol[1], settingCol[2]);
                return themePaths;
            }
            else
            {
                themePaths = _refTheme.openFileThemeFinder();
                ini.Write(settingCol[1], settingCol[2], themePaths);
                return themePaths;
            }
        }
        public void SetterDelaysStart()
        {
            DelayBeforeStart = SetDelays(0);
            DelayThemeUpdate = SetDelays(1);
            DelaySettingClose = SetDelays(2);
            DelayProgramClose = SetDelays(3);
        }
        public int SetDelays(int delayId)
        {
            if (ini.KeyExists(delaysSets[delayId], settingCol[0]))
                return int.TryParse(ini.ReadINI(settingCol[0], delaysSets[delayId]), out var result) ? result : 4;

            return delayId == 3 ? 15 : 4;
            ////Convert.ToInt32(ini.ReadINI(settingCol[0], delaysSets[delayID]));
            //if (delayID == 3) return 15;
            //else return 4;
        }
        public static string settingPath()
        {
            string st = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\RefTheme\";
            if (!System.IO.Directory.Exists(st))
                System.IO.Directory.CreateDirectory(st);
            return st;
        }
        public static bool toggleAuto()
        {
            if (ini.KeyExists(settingCol[4], settingCol[0]))
                return bool.TryParse(ini.ReadINI(settingCol[0], settingCol[4]), out var result) ? result : false;
            else return false;
        }
    }
}
