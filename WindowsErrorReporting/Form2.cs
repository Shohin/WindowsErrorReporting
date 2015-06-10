using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsErrorReporting
{
    public partial class Form2 : Form
    {
        ImageList appIcons;
        public Form2()
        {
            InitializeComponent();
            appIcons = new ImageList();
            appIcons.ImageSize = new Size(20, 20);
            appsLocationListView.SmallImageList = appIcons;
        }
        Icon getAppIcon(string path)
        {
            if (Path.IsPathRooted(path))
            {
                Icon result = Icon.ExtractAssociatedIcon(path);
                return result;
            }
            return null;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths";
            RegistryKey rkey = Registry.LocalMachine.OpenSubKey(uninstallKey);
            string[] subKeys = rkey.GetSubKeyNames();
            appsLocationListView.Items.Clear();
            foreach (string skName in subKeys)
            {
                RegistryKey sk = rkey.OpenSubKey(skName);
                try
                {
                    var appPath = sk.GetValue(null);
                    if (appPath != null)
                    {
                        if (Path.GetExtension(skName).ToLower().Equals(".exe"))
                        {
                            string exePath = appPath.ToString();
                            var appName = skName;
                            Icon icon = getAppIcon(exePath);
                            if (icon != null)
                            {
                                appIcons.Images.Add(icon);
                            }
                            ListViewItem item = new ListViewItem(new string[] { appName, exePath });
                            item.ImageIndex = appIcons.Images.Count - 1;
                            appsLocationListView.Items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
            }
        }

        private void appsLocationListView_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItems = appsLocationListView.SelectedItems;
            ListViewItem item = selectedItems[0];
            string fullPath = item.SubItems[1].Text;
            errorProcess(fullPath);
        }

        void errorProcess(string fullPath)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo(fullPath);
                info.ErrorDialog = false;
                info.RedirectStandardError = true;
                info.RedirectStandardOutput = true;
                info.CreateNoWindow = true;
                info.UseShellExecute = false;

                System.Diagnostics.Process p = System.Diagnostics.Process.Start(info);
                p.EnableRaisingEvents = true;
                p.Exited += p_Exited;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static void p_Exited(object sender, EventArgs e)
        {
            Process p = sender as Process;
            if (p != null)
            {
                string str = string.Format("{0} Cod bilan chiqildi", p.ExitCode);
                if (p.ExitCode >= 0)
                {
                    MessageBox.Show("Dastur ishonchli!");
                }
                else
                {
                    MessageBox.Show("Dastur ishonchsiz!");
                }
            }
            else
                MessageBox.Show("Chiqildi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int countApps = appsLocationListView.Items.Count;
            Random r = new Random();
            int errorCount = r.Next(countApps / 2, 2 * countApps);
            if (errorCount > countApps)
            {
                float k = calculateFac(errorCount) / (calculateFac(countApps) * calculateFac(errorCount - countApps));
                if (k > errorCount)
                {
                    MessageBox.Show("Tizim ishga yaroqsiz!");
                }
                else
                {
                    MessageBox.Show("Tizim ishga yaroqli!");
                }
            }
            else
            {
                MessageBox.Show("Tizim ishga yaroqli!");
            }
        }
        float calculateFac(int n)
        {
            float p = 1;
            for (int i = 1; i <= n; i++)
            {
                p *= i;
            }
            return p;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
