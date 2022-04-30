using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IWshRuntimeLibrary;

namespace RefTheme
{
    class ShortcutMaker
    {
        public static void Create()
        {

            WshShell shell = new WshShell();

            //путь к ярлыку
            string shortcutPath = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + @"\RefTheme.lnk";

            //создаем объект ярлыка
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);

            //задаем свойства для ярлыка
            //описание ярлыка в всплывающей подсказке
            shortcut.Description = "Dark theme auto refresher";
            shortcut.IconLocation = @"D:\UserStuff\CSProjects2020\Actual\RefTheme\RefTheme\cb6uu-dv8du.ico";
            //горячая клавиша
            //путь к самой программе
            shortcut.TargetPath = System.Reflection.Assembly.GetExecutingAssembly().Location;

            //Создаем ярлык
            shortcut.Save();
        }
    }
}
