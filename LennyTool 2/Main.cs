using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace LennyTool_2
{
    public partial class Main : Form
    {
        private int lennyPerPage = 5;
        private int lennyCount;
        private int currentPage = 0;
        private int totalPageCount = 0;

        private string[] lennyStrings;
        private Button[] lennyButtons;
        private TextBox[] lennyBoxes;
        private SplitContainer[,] lennySplitters;

        private string ldbFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\LennyTool\\";

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            setLayout();

            ntfyIcn_lennyTool.Visible = false;
            this.ShowInTaskbar = true;

            totalPageNumber.TextAlign = HorizontalAlignment.Left;
            totalPageNumber.Text = "of --";
            totalPageNumber.Font = new Font(this.Font, FontStyle.Bold);
            pageNumber.TextAlign = HorizontalAlignment.Right;
            pageNumber.Text = "--";
            pageNumber.Font = new Font(this.Font, FontStyle.Bold);

            operateFile('r', 'l');
        }

// Managing on-screen stuff

        private void setLayout()
        {
            this.MaximumSize = new System.Drawing.Size(600, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Size = new System.Drawing.Size(300, 300);

            splitC_mainbtns.Parent = splitC_main.Panel1;

            splitC_update.Parent = splitC_mainbtns.Panel2;
            splitC_update.Dock = DockStyle.Fill;
            splitC_update.Panel1Collapsed = false;
            splitC_update.Panel2Collapsed = true;

            prgBar_update.Parent = splitC_update.Panel2;
            prgBar_update.Dock = DockStyle.Fill;
            prgBar_update.Value = 0;

            btn_update.Parent = splitC_update.Panel1;
            btn_update.Dock = DockStyle.Fill;

            btn_settings.Parent = splitC_mainbtns.Panel1;
            btn_settings.Dock = DockStyle.Fill;
            btn_settings.Enabled = false; // Will be deactivated in the future, after i add actual settings

            btn_save.Parent = splitC_settingsbtns.Panel1;
            btn_revert.Parent = splitC_settingsbtns.Panel2;

            splitC_lenny.Parent = splitC_main.Panel2;
            splitC_lenny.Dock = DockStyle.Fill;
            splitC_lenny.SplitterDistance = 20;

            tbl_pageControl.Parent = splitC_lenny.Panel1;
            tbl_pageControl.Dock = DockStyle.Fill;

            btn_pagePrev.Dock = DockStyle.Fill;
            btn_pageNext.Dock = DockStyle.Fill;

            splitC_pageNumber.Dock = DockStyle.Fill;

            pageNumber.Dock = DockStyle.Fill;
            totalPageNumber.Dock = DockStyle.Fill;

            splitC_settings.Dock = DockStyle.None;
            splitC_settings.Enabled = false;
            splitC_settings.Visible = false;
            splitC_main.Dock = DockStyle.Fill;
            scaleSplitC(splitC_mainbtns);
            scaleSplitC(splitC_pageNumber);
            splitC_main.SplitterDistance = 35;
            splitC_main.Visible = true;
            splitC_main.Enabled = true;
        }

        private void generateButtons(char nr)
        {
            if( nr == 'n')
            {
                // new generation of the buttons
                totalPageCount = (int)Math.Ceiling(((double)lennyCount / (double)lennyPerPage));
                totalPageNumber.Text = "of " + totalPageCount.ToString();
                pageNumber.Text = "1";
                currentPage = 1;
                lennyButtons = new Button[lennyPerPage];
                lennyBoxes = new TextBox[lennyPerPage];
                lennySplitters = new SplitContainer[2, lennyPerPage];
                for (int cnt = 0; cnt < lennyPerPage; cnt++)
                {
                    lennySplitters[0, cnt] = new SplitContainer();
                    lennySplitters[0, cnt].Parent = flow_lennyPage;
                    lennySplitters[0, cnt].Width = flow_lennyPage.Width - 5;
                    lennySplitters[0, cnt].SplitterDistance = (int)(flow_lennyPage.Width * 0.68f);
                    lennySplitters[0, cnt].Height = 30;
                    lennySplitters[0, cnt].IsSplitterFixed = true;

                    lennyButtons[cnt] = new Button();
                    lennyButtons[cnt].Click += lennyButton_Clicked;
                    lennyButtons[cnt].Text = "Copy Lenny";
                    lennyButtons[cnt].Font = new Font(lennyButtons[cnt].Font, FontStyle.Bold);
                    lennyButtons[cnt].Parent = lennySplitters[0, cnt].Panel2;
                    lennyButtons[cnt].Dock = DockStyle.Top;
                    lennyButtons[cnt].Height = 30;
                    lennyButtons[cnt].MinimumSize = new Size(cnt, cnt);

                    lennyBoxes[cnt] = new TextBox();
                    lennyBoxes[cnt].Font = new Font("Lucida Sans Unicode", lennyBoxes[cnt].Font.Size);
                    lennyBoxes[cnt].Text = lennyStrings[cnt];
                    lennyBoxes[cnt].Parent = lennySplitters[0, cnt].Panel1;
                    lennyBoxes[cnt].Dock = DockStyle.Top;
                }
            } else
            {
                // reloading of the texts
                for(int cnt = 0; cnt < lennyPerPage; cnt++)
                {
                    if( (currentPage-1) * lennyPerPage + cnt < lennyCount)
                    {
                        lennyBoxes[cnt].Enabled = true;
                        lennyButtons[cnt].Enabled = true;
                        lennyBoxes[cnt].Text = lennyStrings[(currentPage - 1) * lennyPerPage + cnt];
                    } else
                    {
                        lennyBoxes[cnt].Enabled = false;
                        lennyButtons[cnt].Enabled = false;
                        lennyBoxes[cnt].Text = "";
                    }
                    
                }
            }
            return;
        }
        
// File reading, writing

        private void updateFile()
        {
            splitC_update.Panel1Collapsed = true;
            splitC_update.Panel2Collapsed = false;
            try
            {
                WebClient wbcl = new WebClient();
                wbcl.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCompleted);
                wbcl.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadStatusChanged);
                wbcl.DownloadFileAsync(new Uri("https://od.lk/d/NzVfMzc0MzA3MF8/LDB.txt"), @ldbFilePath+"LDBFile.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                splitC_update.Panel1Collapsed = false;
                splitC_update.Panel2Collapsed = true;
                prgBar_update.Value = 0;
            }
            return;
        }

        private void operateFile( char rw, char setLen)
        {
            if( setLen == 'l')
            {
                bool success = false;
                // for now lenny files can only be read
                try
                {
                    lennyStrings = File.ReadAllLines(ldbFilePath + "LDBFile.txt", Encoding.UTF8);
                    lennyCount = lennyStrings.GetLength(0);
                    success = true;
                }
                catch (DirectoryNotFoundException)
                {
                    Directory.CreateDirectory(ldbFilePath);
                    MessageBox.Show("No Lenny-Database found, most recent one will be downloaded.");
                    updateFile();
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("No Lenny-Database found, most recent one will be downloaded.");
                    updateFile();
                }
                if(success)
                {
                    if (lennyButtons == null)
                    {
                        generateButtons('n');
                    } else
                    {
                        generateButtons('r');
                    }
                }
                return;
            } else
            {
                if( rw == 'r')
                {
                    
                }
            }
            return;
        }

// Size scaling functions

        private void scaleSplitC( SplitContainer sc)
        {
            if (sc.Width < 0)
            {
                sc.Width = 100;
            }
            if (sc.Width % 2 == 0)
            {
                sc.SplitterWidth = 4;
                sc.SplitterDistance = (sc.Width - 4) / 2;
            }
            else
            {
                sc.SplitterWidth = 3;
                sc.SplitterDistance = (sc.Width - 3) / 2;
            }
            return;
        }

// Menu switching

        private void switchMenus( SplitContainer sc1, SplitContainer sc2)
        {
            sc1.Enabled = false;
            sc1.Visible = false;
            sc1.Dock = DockStyle.None;
            sc2.Dock = DockStyle.Fill;
            sc2.Enabled = true;
            sc2.Visible = true;
            return;
        }

// Events

        private void lennyButton_Clicked(object sender, EventArgs e)
        {
            Button lb = (Button)sender;
            Clipboard.SetText(lennyBoxes[lb.MinimumSize.Height].Text);
        }

        private void bt_settings_Click(object sender, EventArgs e)
        {
            switchMenus(splitC_main, splitC_settings);
            scaleSplitC(splitC_settingsbtns);
            splitC_settings.SplitterDistance = 35;
            return;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            switchMenus(splitC_settings, splitC_main);
            scaleSplitC(splitC_mainbtns);
            splitC_main.SplitterDistance = 35;
            return;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            updateFile();
            return;
        }

        private void DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if ( e.Error == null)
            {
                MessageBox.Show("Most recent Lenny-Database downloaded.");
                splitC_update.Panel1Collapsed = false;
                splitC_update.Panel2Collapsed = true;
                prgBar_update.Value = 0;
                operateFile('r', 'l');
            }
            else
            {
                MessageBox.Show("Download of the Lenny-Database failed:\n" + e.Error.ToString());
                splitC_update.Panel1Collapsed = false;
                splitC_update.Panel2Collapsed = true;
                prgBar_update.Value = 0;
            }
            return;
        }

        private void DownloadStatusChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            prgBar_update.Value = e.ProgressPercentage;
            return;
        }

        private void ntfyIcn_lennyTool_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                ntfyIcn_lennyTool.Visible = false;
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            }
            return;
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                ntfyIcn_lennyTool.Visible = true;
                this.ShowInTaskbar = false;
            }
            return;
        }

        private void flow_lennyPage_SizeChanged(object sender, EventArgs e)
        {
            if( lennySplitters != null && this.WindowState == FormWindowState.Normal)
            {
                for (int cnt = 0; cnt < lennyPerPage; cnt++)
                {
                    lennySplitters[0, cnt].Width = flow_lennyPage.Width - 5;
                    lennySplitters[0, cnt].SplitterDistance = (int)(flow_lennyPage.Width * 0.68f);
                }
            }
            return;
        }

        private void btn_pagePrev_Click(object sender, EventArgs e)
        {
            if( currentPage != 0)
            {
                if(currentPage > 1)
                {
                    currentPage--;
                    pageNumber.Text = currentPage.ToString();
                    generateButtons('r');
                }
            }
            return;
        }

        private void btn_pageNext_Click(object sender, EventArgs e)
        {
            if (currentPage != 0)
            {
                if (currentPage < totalPageCount)
                {
                    currentPage++;
                    pageNumber.Text = currentPage.ToString();
                    generateButtons('r');
                }
            }
            return;
        }

        private void pageNumber_Leave(object sender, EventArgs e)
        {
            pageNumber.Text = currentPage.ToString();
            return;
        }

        private void pageNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                int num;
                if (int.TryParse(pageNumber.Text, out num))
                {
                    if (num <= totalPageCount && num > 0)
                    {
                        currentPage = num;
                        generateButtons('r');
                    }
                    else
                    {
                        MessageBox.Show("Invalid page number.\nPlease enter a number between 1 and " + totalPageCount.ToString() + ".");
                        pageNumber.Text = currentPage.ToString();
                    }
                }
            }
            return;
        }

    }
}
