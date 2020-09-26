using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using inifiles;
using System.IO;
using MetroFramework;
using System.Threading;
using static RefTheme.ThemeRef;

namespace RefTheme
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        ConstantsAndVars constantsAndVars = new ConstantsAndVars();
        EzUpdater.CheckUpdates checkUpdates = new EzUpdater.CheckUpdates();
        ThemeRef themeRef = new ThemeRef();
        public Form1()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroThemeStyle.Dark;
        }
        public DialogResult MessageBoxCaller(string message, string header, MessageBoxButtons buttons, MessageBoxIcon color)
        {
            return MetroMessageBox.Show(this, message, header, buttons, color);
        }
        private void Form1_Loads(object sender, EventArgs e)
        {
            textBoxPath.Text = constantsAndVars.themePath();
            constantsAndVars.SetterDelaysStart();
            toggleAuto.Checked = bool.TryParse(ConstantsAndVars.ini.ReadINI(ConstantsAndVars.settingCol[0], ConstantsAndVars.settingCol[4]), out var result) ? result : false;
            numUD1.Value = ConstantsAndVars.DelayBeforeStart;
            изменитьНастройкиToolStripMenuItem.Text = NotifyMessages.notifyIconToolText;
            numUD2.Value = ConstantsAndVars.DelayThemeUpdate;
            numUD3.Value = ConstantsAndVars.DelaySettingClose;
            labelVersion.Text = NotifyMessages.versionS + " " + Application.ProductVersion;
            numUD4.Value = ConstantsAndVars.DelayProgramClose;
            if (toggleAuto.Checked)
            {

                if (ConstantsAndVars.themePaths != null)
                {
                    this.WindowState = FormWindowState.Minimized;
                    notifyIcon1.Visible = true;
                    MesCaller mesCaller = MessageBoxCaller;
                    var proc = new Thread(() => { themeRef.refThemeAuto(mesCaller); });
                    proc.IsBackground = true;
                    proc.Start();
                }
            }
            var proc1 = new Thread(() => { AutoUpdateChecher(); });
            proc1.Start();
        }
        //
        private void MetroButton1_Click(object sender, EventArgs e)
        {
            MesCaller mesCaller = MessageBoxCaller;
            var proc = new Thread(() => { themeRef.refreshTheme(mesCaller); });
            proc.Start();
            // proc.Join();
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            string st = themeRef.openFileThemeFinder();
            if (st != null)
            {
                ConstantsAndVars.themePaths = st;
                textBoxPath.Text = st;
                ConstantsAndVars.ini.Write(ConstantsAndVars.settingCol[1], ConstantsAndVars.settingCol[2], st);
            }
        }
        private void ИзменитьНастройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = false;
            }
        }
        private void metroButton3_Click(object sender, EventArgs e)
        {
            // MesCaller mesCaller = MessageBoxCaller;
            DialogResult diYes = DialogResult.Yes;
            string message = NotifyMessages.notifyTaskCreating;
            if (ConstantsAndVars.ini.KeyExists(ConstantsAndVars.settingCol[3], ConstantsAndVars.settingCol[0]))
                message = NotifyMessages.notifyTastAlready;
            if (diYes == MessageBoxCaller(message, "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DialogResult abortDR = DialogResult.Abort;
                ConstantsAndVars.ini.Write(ConstantsAndVars.settingCol[0], ConstantsAndVars.settingCol[3], "true");
                var proc = new Thread(() =>          {
                    if (abortDR != themeRef.TaskActivate(MessageBoxCaller))
                        toggleAuto.Checked = true;   });               
                proc.Start();
                
            }
        }
        private void metroButton1_Click_1(object sender, EventArgs e)
        {

            //MesCaller mesCaller = MessageBoxCaller;
            themeRef.TaskActivate(MessageBoxCaller);
            //MessageBox.Show(ConstantsAndVars.themePathDefault);
        }
        #region numUD
        private void numUD1_ValueChanged(object sender, EventArgs e)
        {
            ConstantsAndVars.ini.Write(ConstantsAndVars.settingCol[0], ConstantsAndVars.delaysSets[0], numUD1.Value.ToString());
            ConstantsAndVars.DelayBeforeStart = (int)numUD1.Value;
        }
        private void numUD2_ValueChanged(object sender, EventArgs e)
        {
            ConstantsAndVars.ini.Write(ConstantsAndVars.settingCol[0], ConstantsAndVars.delaysSets[1], numUD2.Value.ToString());
            ConstantsAndVars.DelayThemeUpdate = (int)numUD2.Value;
        }
        private void numUD3_ValueChanged(object sender, EventArgs e)
        {
            ConstantsAndVars.ini.Write(ConstantsAndVars.settingCol[0], ConstantsAndVars.delaysSets[2], numUD3.Value.ToString());
            ConstantsAndVars.DelaySettingClose = (int)numUD3.Value;
        }
        private void numUD4_ValueChanged(object sender, EventArgs e)
        {
            ConstantsAndVars.ini.Write(ConstantsAndVars.settingCol[0], ConstantsAndVars.delaysSets[3], numUD4.Value.ToString());
            ConstantsAndVars.DelayProgramClose = (int)numUD4.Value;
        }


        #endregion

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            notifyIcon1.Visible = true;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void buttonCheckUpdates_Click(object sender, EventArgs e)
        {
            EzUpdater.CheckUpdates.MesCallerUpdate mesCallerUpdate = MessageBoxCaller;
            // MessageBoxCaller(Application.ProductVersion, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            checkUpdates.updateschecker(Application.ProductVersion, Application.ProductName, progressBar, ConstantsAndVars.ini, @"https://fordroid.3dn.ru/RefTheme.zip", mesCallerUpdate);
        }
        public void NotifyMessageCaller(string Message, string Header)
        {
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(3000, Message, Header, ToolTipIcon.Info);

        }
        private void ToggleAuto_CheckedChanged(object sender, EventArgs e)
        {//if (toggleAuto.Checked)
            ConstantsAndVars.ini.Write(ConstantsAndVars.settingCol[0], ConstantsAndVars.settingCol[4], toggleAuto.Checked ? "true" : "false");
            //  else ConstantsAndVars.ini.Write(ConstantsAndVars.settingCol[0], ConstantsAndVars.settingCol[4], "false");
        }

        private void toggleAuto_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(toggleAuto, NotifyMessages.tooltipToggle);
        }
        private void AutoUpdateChecher()
        {
            Thread.Sleep(3000);
            EzUpdater.CheckUpdates.NotifyCall cals = NotifyMessageCaller;
            checkUpdates.updateAutoChecker(Application.ProductVersion, Application.ProductName, cals);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           // var pr = Process.GetProcessesByName("RefTheme");
           //  pr[0].Kill();
        }
    }
}
