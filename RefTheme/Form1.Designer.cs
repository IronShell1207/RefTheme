namespace RefTheme
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.buttonAccept = new MetroFramework.Controls.MetroButton();
            this.textBoxPath = new MetroFramework.Controls.MetroTextBox();
            this.buttonOpen = new MetroFramework.Controls.MetroButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.numUD2 = new System.Windows.Forms.NumericUpDown();
            this.numUD3 = new System.Windows.Forms.NumericUpDown();
            this.labelDelays = new MetroFramework.Controls.MetroLabel();
            this.labelDelay2 = new MetroFramework.Controls.MetroLabel();
            this.labelDelay3 = new MetroFramework.Controls.MetroLabel();
            this.labelSec2 = new MetroFramework.Controls.MetroLabel();
            this.labelSec3 = new MetroFramework.Controls.MetroLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьНастройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.labelSec1 = new MetroFramework.Controls.MetroLabel();
            this.labelSec4 = new MetroFramework.Controls.MetroLabel();
            this.numUD1 = new System.Windows.Forms.NumericUpDown();
            this.labelDelay1 = new MetroFramework.Controls.MetroLabel();
            this.numUD4 = new System.Windows.Forms.NumericUpDown();
            this.labelDelay4 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.buttonTaskCreate = new MetroFramework.Controls.MetroButton();
            this.buttonCheckUpdate = new MetroFramework.Controls.MetroButton();
            this.labelVersion = new MetroFramework.Controls.MetroLabel();
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.toggleAuto = new MetroFramework.Controls.MetroToggle();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD3)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD4)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // buttonAccept
            // 
            this.buttonAccept.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            resources.ApplyResources(this.buttonAccept, "buttonAccept");
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.buttonAccept.UseSelectable = true;
            this.buttonAccept.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // textBoxPath
            // 
            // 
            // 
            // 
            this.textBoxPath.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.textBoxPath.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.textBoxPath.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.textBoxPath.CustomButton.Name = "";
            this.textBoxPath.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.textBoxPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxPath.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.textBoxPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxPath.CustomButton.UseSelectable = true;
            this.textBoxPath.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.textBoxPath.Lines = new string[0];
            resources.ApplyResources(this.textBoxPath, "textBoxPath");
            this.textBoxPath.MaxLength = 32767;
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.PasswordChar = '\0';
            this.textBoxPath.PromptText = "Theme path";
            this.textBoxPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxPath.SelectedText = "";
            this.textBoxPath.SelectionLength = 0;
            this.textBoxPath.SelectionStart = 0;
            this.textBoxPath.ShortcutsEnabled = true;
            this.textBoxPath.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textBoxPath.UseSelectable = true;
            this.textBoxPath.WaterMark = "Theme path";
            this.textBoxPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // buttonOpen
            // 
            this.buttonOpen.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            resources.ApplyResources(this.buttonOpen, "buttonOpen");
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.buttonOpen.UseSelectable = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // numUD2
            // 
            this.numUD2.BackColor = System.Drawing.Color.Black;
            this.numUD2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.numUD2, "numUD2");
            this.numUD2.ForeColor = System.Drawing.Color.Gainsboro;
            this.numUD2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUD2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUD2.Name = "numUD2";
            this.numUD2.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numUD2.ValueChanged += new System.EventHandler(this.numUD2_ValueChanged);
            // 
            // numUD3
            // 
            this.numUD3.BackColor = System.Drawing.Color.Black;
            this.numUD3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.numUD3, "numUD3");
            this.numUD3.ForeColor = System.Drawing.Color.Gainsboro;
            this.numUD3.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUD3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD3.Name = "numUD3";
            this.numUD3.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numUD3.ValueChanged += new System.EventHandler(this.numUD3_ValueChanged);
            // 
            // labelDelays
            // 
            resources.ApplyResources(this.labelDelays, "labelDelays");
            this.labelDelays.Name = "labelDelays";
            this.labelDelays.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // labelDelay2
            // 
            resources.ApplyResources(this.labelDelay2, "labelDelay2");
            this.labelDelay2.Name = "labelDelay2";
            this.labelDelay2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // labelDelay3
            // 
            resources.ApplyResources(this.labelDelay3, "labelDelay3");
            this.labelDelay3.Name = "labelDelay3";
            this.labelDelay3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // labelSec2
            // 
            resources.ApplyResources(this.labelSec2, "labelSec2");
            this.labelSec2.Name = "labelSec2";
            this.labelSec2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // labelSec3
            // 
            resources.ApplyResources(this.labelSec3, "labelSec3");
            this.labelSec3.Name = "labelSec3";
            this.labelSec3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьНастройкиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // изменитьНастройкиToolStripMenuItem
            // 
            this.изменитьНастройкиToolStripMenuItem.Name = "изменитьНастройкиToolStripMenuItem";
            resources.ApplyResources(this.изменитьНастройкиToolStripMenuItem, "изменитьНастройкиToolStripMenuItem");
            this.изменитьНастройкиToolStripMenuItem.Click += new System.EventHandler(this.ИзменитьНастройкиToolStripMenuItem_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.labelSec1);
            this.metroPanel1.Controls.Add(this.labelSec4);
            this.metroPanel1.Controls.Add(this.labelSec3);
            this.metroPanel1.Controls.Add(this.numUD2);
            this.metroPanel1.Controls.Add(this.numUD1);
            this.metroPanel1.Controls.Add(this.labelDelay1);
            this.metroPanel1.Controls.Add(this.labelSec2);
            this.metroPanel1.Controls.Add(this.numUD4);
            this.metroPanel1.Controls.Add(this.labelDelay4);
            this.metroPanel1.Controls.Add(this.numUD3);
            this.metroPanel1.Controls.Add(this.labelDelay3);
            this.metroPanel1.Controls.Add(this.labelDelay2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.metroPanel1, "metroPanel1");
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // labelSec1
            // 
            resources.ApplyResources(this.labelSec1, "labelSec1");
            this.labelSec1.Name = "labelSec1";
            this.labelSec1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // labelSec4
            // 
            resources.ApplyResources(this.labelSec4, "labelSec4");
            this.labelSec4.Name = "labelSec4";
            this.labelSec4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // numUD1
            // 
            this.numUD1.BackColor = System.Drawing.Color.Black;
            this.numUD1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.numUD1, "numUD1");
            this.numUD1.ForeColor = System.Drawing.Color.Gainsboro;
            this.numUD1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUD1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD1.Name = "numUD1";
            this.numUD1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numUD1.ValueChanged += new System.EventHandler(this.numUD1_ValueChanged);
            // 
            // labelDelay1
            // 
            resources.ApplyResources(this.labelDelay1, "labelDelay1");
            this.labelDelay1.Name = "labelDelay1";
            this.labelDelay1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // numUD4
            // 
            this.numUD4.BackColor = System.Drawing.Color.Black;
            this.numUD4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.numUD4, "numUD4");
            this.numUD4.ForeColor = System.Drawing.Color.Gainsboro;
            this.numUD4.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUD4.Name = "numUD4";
            this.numUD4.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numUD4.ValueChanged += new System.EventHandler(this.numUD4_ValueChanged);
            // 
            // labelDelay4
            // 
            resources.ApplyResources(this.labelDelay4, "labelDelay4");
            this.labelDelay4.Name = "labelDelay4";
            this.labelDelay4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton1
            // 
            resources.ApplyResources(this.metroButton1, "metroButton1");
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // metroButton2
            // 
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            resources.ApplyResources(this.metroButton2, "metroButton2");
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // buttonTaskCreate
            // 
            this.buttonTaskCreate.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            resources.ApplyResources(this.buttonTaskCreate, "buttonTaskCreate");
            this.buttonTaskCreate.Name = "buttonTaskCreate";
            this.buttonTaskCreate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.buttonTaskCreate.UseSelectable = true;
            this.buttonTaskCreate.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // buttonCheckUpdate
            // 
            this.buttonCheckUpdate.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            resources.ApplyResources(this.buttonCheckUpdate, "buttonCheckUpdate");
            this.buttonCheckUpdate.Name = "buttonCheckUpdate";
            this.buttonCheckUpdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.buttonCheckUpdate.UseSelectable = true;
            this.buttonCheckUpdate.Click += new System.EventHandler(this.buttonCheckUpdates_Click);
            // 
            // labelVersion
            // 
            resources.ApplyResources(this.labelVersion, "labelVersion");
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // progressBar
            // 
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            this.progressBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // toggleAuto
            // 
            resources.ApplyResources(this.toggleAuto, "toggleAuto");
            this.toggleAuto.DisplayStatus = false;
            this.toggleAuto.Name = "toggleAuto";
            this.toggleAuto.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toggleAuto.UseSelectable = true;
            this.toggleAuto.CheckedChanged += new System.EventHandler(this.ToggleAuto_CheckedChanged);
            this.toggleAuto.MouseHover += new System.EventHandler(this.toggleAuto_MouseHover);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.toggleAuto);
            this.Controls.Add(this.buttonCheckUpdate);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.buttonTaskCreate);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.labelDelays);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Loads);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD3)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton buttonAccept;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTextBox textBoxPath;
        private MetroFramework.Controls.MetroButton buttonOpen;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroLabel labelDelay2;
        private MetroFramework.Controls.MetroLabel labelDelays;
        private MetroFramework.Controls.MetroLabel labelDelay3;
        private MetroFramework.Controls.MetroLabel labelSec3;
        private MetroFramework.Controls.MetroLabel labelSec2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem изменитьНастройкиToolStripMenuItem;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel labelSec1;
        private MetroFramework.Controls.MetroLabel labelDelay1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton buttonTaskCreate;
        private MetroFramework.Controls.MetroLabel labelSec4;
        private MetroFramework.Controls.MetroLabel labelDelay4;
        public System.Windows.Forms.NumericUpDown numUD3;
        public System.Windows.Forms.NumericUpDown numUD2;
        public System.Windows.Forms.NumericUpDown numUD1;
        public System.Windows.Forms.NumericUpDown numUD4;
        private MetroFramework.Controls.MetroButton buttonCheckUpdate;
        private MetroFramework.Controls.MetroLabel labelVersion;
        private MetroFramework.Controls.MetroProgressBar progressBar;
        private MetroFramework.Controls.MetroToggle toggleAuto;
    }
}

