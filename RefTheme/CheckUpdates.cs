using MetroFramework;
using RefTheme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace EzUpdater
{
    public class CheckUpdates
    {
        public delegate DialogResult MesCallerUpdate(string message, string header, MessageBoxButtons buttons, MessageBoxIcon color);
        public delegate void NotifyCall(string Message, string Header);
        public static ProgressBar progressBar;  //change
        public static string PackageName { get; set; }
        public void updateschecker(string ProdVersion, string TagAppName, ProgressBar pb, inifiles.IniFile INI,string LinqDownloadArchive, MesCallerUpdate mesCaller)//Application.ProductVersion
        {
            PackageName = TagAppName;
            progressBar = pb;
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(@"http://fordroid.3dn.ru/version.xml");//LinqVersion
            var t = new Thread(() => checker(ProdVersion, TagAppName, INI, LinqDownloadArchive, mesCaller));
            t.Start();
            double versionRemote = Convert.ToDouble(doc1.GetElementsByTagName(TagAppName)[0].InnerText.Replace(".", "")),
                        thisVersion = Convert.ToDouble(ProdVersion.Replace(".", ""));
            if (thisVersion == versionRemote||thisVersion>versionRemote)
            {
                mesCaller(NotifyMessages.notifyLastestV, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void updateAutoChecker(string ProdVersion, string TagAppName, NotifyCall notifyCall)
        {
            PackageName = TagAppName;
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(@"http://fordroid.3dn.ru/version.xml");//LinqVersion
            double versionRemote = Convert.ToDouble(doc1.GetElementsByTagName(TagAppName)[0].InnerText.Replace(".", "")),
                        thisVersion = Convert.ToDouble(ProdVersion.Replace(".", ""));
            if (thisVersion < versionRemote)
            {
                notifyCall(NotifyMessages.newVerNot + doc1.GetElementsByTagName(TagAppName)[0].InnerText + ")",
                        NotifyMessages.notifyIcMessage);
            }
        }
        public void checker(string ProdVersion, string TagAppName, inifiles.IniFile INI, string LinqDownloadArchive, MesCallerUpdate mesCaller)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                XmlDocument docnew = new XmlDocument();
                doc.Load(@"http://fordroid.3dn.ru/version.xml"); //XML File с версией программы
                docnew.Load(@"http://fordroid.3dn.ru/news.xml"); //XML File с обнлвлениями
                string serverion = ProdVersion;//Application.ProductVersion.ToString();
                var updates = docnew.GetElementsByTagName(TagAppName)[0].InnerText;//.Replace("!!", "\n\t");
                double versionRemote = Convert.ToDouble(doc.GetElementsByTagName(TagAppName)[0].InnerText.Replace(".", "")), //TagName = Appname Любое название приложения
                        thisVersion = Convert.ToDouble(ProdVersion.Replace(".", ""));//Application.ProductVersion.Replace(".", "")); //ProductVersion текущая версия нашей программы
                if (thisVersion < versionRemote)
                {
                    progressBar.Invoke(new Action(() => { progressBar.Visible = true; progressBar.Location = new System.Drawing.Point(23, 266); }));
                    DialogResult dialogResult = mesCaller(NotifyMessages.newVerNot + doc.GetElementsByTagName(TagAppName)[0].InnerText + ")" + Environment.NewLine +
                         NotifyMessages.notifyMes2+ "\n\t"+ NotifyMessages.notifyMes3 +"\n\t" + updates, TagAppName + " v" + ProdVersion, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {
                        INI.Write("Last Version", "version", serverion);
                        var client = new WebClient();
                        client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(download_ProgressChanged);
                        client.DownloadFileCompleted += new AsyncCompletedEventHandler(download_Completed);
                        client.DownloadFileAsync(new Uri(@LinqDownloadArchive), TagAppName + ".zip");//@"http://fordroid.3dn.ru/Generator.zip"), "Generator.zip"); 

                    }
                    else if (dialogResult == DialogResult.Cancel)
                    {
                        progressBar.Invoke(new Action(() => { progressBar.Visible = false; }));
                        return;
                    }
                }
            }
            catch (Exception ex) {
                mesCaller(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static void download_ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            try
            {
                progressBar.Invoke(new Action(() => {
                    progressBar.Value = e.ProgressPercentage;
                }));
            }
            catch (Exception) { }
        }
        private static void download_Completed(object sender, AsyncCompletedEventArgs e)
        {
            Process.Start("updater.exe", PackageName);
            Process.GetCurrentProcess().Kill();
        }
    }
}
