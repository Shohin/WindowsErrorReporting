using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsErrorReporting
{
    public partial class Form1 : Form
    {
        //ImageList appIcons;
        public Form1()
        {
            InitializeComponent();
            /*appIcons = new ImageList();
            appIcons.ImageSize = new Size(20, 20);
            appsListView.View = View.SmallIcon;
            appsListView.SmallImageList = appIcons;*/
        }

        private string getExeFilePathApp(string installedLocation)
        {
            string exeFilePath = null;
            if (Directory.Exists(installedLocation))
            {
                string [] exeFiles = Directory.GetFiles(installedLocation, "*.exe");
                foreach (string file in exeFiles)
                {
                    string filePath = Path.Combine(installedLocation, file);
                    exeFilePath = filePath;
                    break;
                    
                }
                //List<string> dirs = new List<string>(Directory.EnumerateFiles(installedLocation, "*.exe"));
                /*if (exeFilePath == null)
                {
                    string[] dirs = Directory.GetDirectories(installedLocation);
                    foreach (string directory in dirs)
                    {
                        foreach (string file in Directory.GetFiles(installedLocation, "*.exe"))
                        {
                            string filePath = Path.Combine(installedLocation, file);
                            exeFilePath = filePath;
                        }
                        return exeFilePath;
                    }
                }*/
                return exeFilePath;
            }
            else
            {
                return exeFilePath;
            }
        }


        private void getListButton_Click(object sender, EventArgs e)
        {
            appsListView.Items.Clear();
            string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            RegistryKey rkey = Registry.LocalMachine.OpenSubKey(uninstallKey);
            string [] subKeys = rkey.GetSubKeyNames();
            foreach (string skName in subKeys)
            {
                RegistryKey sk = rkey.OpenSubKey(skName);
                try
                {
                    var displayName = sk.GetValue("DisplayName");
                    var publisher = sk.GetValue("Publisher");
                    var installedOn = sk.GetValue("InstallDate");
                    var size = sk.GetValue("EstimatedSize");
                    var version = sk.GetValue("DisplayVersion");
                    var installLocarion = sk.GetValue("InstallLocation");

                    string fullSizeInf = "";
                    string installedOnStr = "";

                    if (publisher == null)
                    {
                        publisher = "";
                    }
                    if (installedOn != null)
                    {
                        installedOnStr = installedOn.ToString();
                        installedOnStr = installedOnStr.Substring(0, 4) + " - " + installedOnStr.Substring(4, 2) + " - " + installedOnStr.Substring(6, 2);
                        //DateTime dt = DateTime.Parse(installedOnStr);
                        //installedOnStr = string.Format("{dd-MM-YYYY", dt);
                    }
                    if (size != null)
                    {
                        double parseSize = Convert.ToDouble(size);//Double.Parse(size);
                        if (parseSize > 1048576)
                        {
                            parseSize /= 1048576;
                            fullSizeInf = string.Format("{0:0.##} GB", parseSize);
                        }
                        else if (parseSize < 1048576 && parseSize > 1024)
                        {
                            parseSize /= 1024;
                            fullSizeInf = string.Format("{0:0.##} MB", parseSize); ;
                        }
                        else
                        {
                            fullSizeInf = parseSize + " KB";
                        }
                    }
                    if (version == null)
                    {
                        version = "";
                    }
                    if (installLocarion == null)
                    {
                        installLocarion = "";
                    }
                    /*else
                    {
                        Icon icon = getAppIcon(installLocarion.ToString());
                        if (icon != null)
                        {
                            appIcons.Images.Add(icon);
                            pictureBox1.Image = Bitmap.FromHicon(new Icon(icon, new Size(48, 48)).Handle);
                        }
                    }*/
                    
                    ListViewItem item;
                    if (displayName != null)
                    {
                        item = new ListViewItem(new string[] { displayName.ToString(), publisher.ToString(), 
                            installedOnStr, fullSizeInf, version.ToString(), installLocarion.ToString() });
                        //item.ImageIndex = appIcons.Images.Count - 1;
                        appsListView.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            countSoftLabel.Text = "O`rnatilgan Dasturlar (" + appsListView.Items.Count.ToString() + ")";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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
                MessageBox.Show(str);
            }
            else
                MessageBox.Show("Chiqildi");
        }

        private void appsListView_DoubleClick(object sender, EventArgs e)
        {
            /*ListView.SelectedListViewItemCollection selectedItems = appsListView.SelectedItems;
            ListViewItem item = selectedItems[0];
            string appPath = item.SubItems[5].Text;
            string fullPath = getExeFilePathApp(appPath);
            errorProcess(fullPath);*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
