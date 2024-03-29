﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Microsoft.Win32;
using Microsoft.Win32.TaskScheduler;

namespace RefTheme
{
    public class ThemeRef
    {
        public delegate DialogResult MesCaller(string message, string header, MessageBoxButtons buttons, MessageBoxIcon color);
        public OpenFileDialog openFileDialog = new OpenFileDialog
        {
            InitialDirectory = ConstantsAndVars.themePathDefault,
            Filter = ConstantsAndVars.filterForOFD,
            Title = NotifyMessages.titleOFD,
            FileName = "*.theme"
        };
        public string openFileThemeFinder()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ConstantsAndVars.themePaths = openFileDialog.FileName;
                return openFileDialog.FileName;
            }
            else return null;
        }

        public static bool IsTaskActive()
        {
            using (TaskService ts = new TaskService())
            {
                var taskA = ts.FindTask("Dark Theme Refresher", true)?.Definition;
                if (taskA == null)
                    return false;
                else if (taskA.Settings.Enabled == true)
                    return true;
                else if (taskA.Settings.Enabled == false)
                    return false;
                return false;
            }
        }

        public (bool, string, string) TaskActivate()
        {
            try
            {
                using (TaskService ts = new TaskService())
                {
                    var taskA = ts.FindTask("Dark Theme Refresher", true)?.Definition;
                    if (taskA == null)
                    {
                        TaskDefinition td = ts.NewTask();
                        td.RegistrationInfo.Description =
                            "Dark Theme Refresher. It's refreshing your dark theme after you logon. By IronShell";
                        td.Triggers.Add(new SessionStateChangeTrigger
                            {StateChange = TaskSessionStateChangeType.SessionUnlock});
                        td.Principal.LogonType = TaskLogonType.InteractiveToken;
                        td.Principal.RunLevel = TaskRunLevel.Highest;
                        td.Settings.MultipleInstances = TaskInstancesPolicy.IgnoreNew;
                        td.Settings.AllowHardTerminate = true;
                        td.Settings.Enabled = true;
                        td.Settings.IdleSettings.StopOnIdleEnd = true;
                        td.Settings.Hidden = false;
                        td.Actions.Add(new ExecAction(Application.ExecutablePath));
                        ts.RootFolder.RegisterTaskDefinition(@"Dark Theme Refresher", td);

                        return (true,"Success", NotifyMessages.notifyTastSuccess);
                    }
                    else if (taskA.Settings.Enabled == true)
                    {
                        taskA.Settings.Enabled = false;
                        ts.RootFolder.RegisterTaskDefinition(@"Dark Theme Refresher", taskA);
                        return (false, "Success", "Task has been disabled!");
                        
                    }
                    else if (taskA.Settings.Enabled == false)
                    {
                        taskA.Settings.Enabled = true;
                        ts.RootFolder.RegisterTaskDefinition(@"Dark Theme Refresher", taskA);
                        return (false, "Success", "Task has been enabled!");

                    }

                    //ts.NewTaskFromFile("C:\\Path\\To\\file.xml");
                }

                return (false,"Error",  "Not activated");
            }
            catch (UnauthorizedAccessException ex) //(Exception ex)
            {
                return (false, "Error", $"{NotifyMessages.exceptionAdminTask}\n {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, "Error", $"{ex.Message}");
            }
        }
        public void refreshTheme(MesCaller mesCaller)
        {
            try
            {
                Process.Start(ConstantsAndVars.themePaths);
            }
            catch (Exception ex)
            {
                mesCaller(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Thread.Sleep(ConstantsAndVars.DelayThemeUpdate * 1000);
            Registry.SetValue(ConstantsAndVars.registryThemeCommandPath, ConstantsAndVars.registryThemeCommands[0], 0);
            Registry.SetValue(ConstantsAndVars.registryThemeCommandPath, ConstantsAndVars.registryThemeCommands[1], 0);
            Thread.Sleep(ConstantsAndVars.DelaySettingClose * 1000);
            try
            {
                Thread.Sleep(700);
                var proc = System.Diagnostics.Process.GetProcessesByName("SystemSettings");
                foreach (Process procs in proc)
                    procs.Kill();
            }
            catch (Exception ex)
            {
                mesCaller(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void refThemeAuto(MesCaller mesCaller)
        {
            refreshTheme(mesCaller);
            Thread.Sleep(ConstantsAndVars.DelayProgramClose*1000);
            Application.Exit();
        }

    }
}
