namespace LennyTool_2
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitC_main = new System.Windows.Forms.SplitContainer();
            this.splitC_mainbtns = new System.Windows.Forms.SplitContainer();
            this.btn_settings = new System.Windows.Forms.Button();
            this.splitC_update = new System.Windows.Forms.SplitContainer();
            this.btn_update = new System.Windows.Forms.Button();
            this.prgBar_update = new System.Windows.Forms.ProgressBar();
            this.splitC_lenny = new System.Windows.Forms.SplitContainer();
            this.tbl_pageControl = new System.Windows.Forms.TableLayoutPanel();
            this.splitC_pageNumber = new System.Windows.Forms.SplitContainer();
            this.pageNumber = new System.Windows.Forms.TextBox();
            this.totalPageNumber = new System.Windows.Forms.TextBox();
            this.btn_pageNext = new System.Windows.Forms.Button();
            this.btn_pagePrev = new System.Windows.Forms.Button();
            this.flow_lennyPage = new System.Windows.Forms.FlowLayoutPanel();
            this.splitC_settings = new System.Windows.Forms.SplitContainer();
            this.splitC_settingsbtns = new System.Windows.Forms.SplitContainer();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_revert = new System.Windows.Forms.Button();
            this.ntfyIcn_lennyTool = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitC_main)).BeginInit();
            this.splitC_main.Panel1.SuspendLayout();
            this.splitC_main.Panel2.SuspendLayout();
            this.splitC_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitC_mainbtns)).BeginInit();
            this.splitC_mainbtns.Panel1.SuspendLayout();
            this.splitC_mainbtns.Panel2.SuspendLayout();
            this.splitC_mainbtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitC_update)).BeginInit();
            this.splitC_update.Panel1.SuspendLayout();
            this.splitC_update.Panel2.SuspendLayout();
            this.splitC_update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitC_lenny)).BeginInit();
            this.splitC_lenny.Panel1.SuspendLayout();
            this.splitC_lenny.Panel2.SuspendLayout();
            this.splitC_lenny.SuspendLayout();
            this.tbl_pageControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitC_pageNumber)).BeginInit();
            this.splitC_pageNumber.Panel1.SuspendLayout();
            this.splitC_pageNumber.Panel2.SuspendLayout();
            this.splitC_pageNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitC_settings)).BeginInit();
            this.splitC_settings.Panel1.SuspendLayout();
            this.splitC_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitC_settingsbtns)).BeginInit();
            this.splitC_settingsbtns.Panel1.SuspendLayout();
            this.splitC_settingsbtns.Panel2.SuspendLayout();
            this.splitC_settingsbtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitC_main
            // 
            this.splitC_main.IsSplitterFixed = true;
            this.splitC_main.Location = new System.Drawing.Point(12, 21);
            this.splitC_main.Name = "splitC_main";
            this.splitC_main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitC_main.Panel1
            // 
            this.splitC_main.Panel1.Controls.Add(this.splitC_mainbtns);
            // 
            // splitC_main.Panel2
            // 
            this.splitC_main.Panel2.Controls.Add(this.splitC_lenny);
            this.splitC_main.Size = new System.Drawing.Size(358, 389);
            this.splitC_main.SplitterDistance = 199;
            this.splitC_main.TabIndex = 0;
            // 
            // splitC_mainbtns
            // 
            this.splitC_mainbtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitC_mainbtns.IsSplitterFixed = true;
            this.splitC_mainbtns.Location = new System.Drawing.Point(0, 0);
            this.splitC_mainbtns.Name = "splitC_mainbtns";
            // 
            // splitC_mainbtns.Panel1
            // 
            this.splitC_mainbtns.Panel1.Controls.Add(this.btn_settings);
            // 
            // splitC_mainbtns.Panel2
            // 
            this.splitC_mainbtns.Panel2.Controls.Add(this.splitC_update);
            this.splitC_mainbtns.Size = new System.Drawing.Size(358, 199);
            this.splitC_mainbtns.SplitterDistance = 179;
            this.splitC_mainbtns.TabIndex = 0;
            // 
            // btn_settings
            // 
            this.btn_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_settings.Location = new System.Drawing.Point(0, 0);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(179, 199);
            this.btn_settings.TabIndex = 0;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.bt_settings_Click);
            // 
            // splitC_update
            // 
            this.splitC_update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitC_update.IsSplitterFixed = true;
            this.splitC_update.Location = new System.Drawing.Point(0, 0);
            this.splitC_update.Name = "splitC_update";
            this.splitC_update.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitC_update.Panel1
            // 
            this.splitC_update.Panel1.Controls.Add(this.btn_update);
            this.splitC_update.Panel1MinSize = 0;
            // 
            // splitC_update.Panel2
            // 
            this.splitC_update.Panel2.Controls.Add(this.prgBar_update);
            this.splitC_update.Panel2MinSize = 0;
            this.splitC_update.Size = new System.Drawing.Size(175, 199);
            this.splitC_update.SplitterDistance = 73;
            this.splitC_update.TabIndex = 0;
            // 
            // btn_update
            // 
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_update.Location = new System.Drawing.Point(0, 0);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(175, 73);
            this.btn_update.TabIndex = 0;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // prgBar_update
            // 
            this.prgBar_update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prgBar_update.Location = new System.Drawing.Point(0, 0);
            this.prgBar_update.Name = "prgBar_update";
            this.prgBar_update.Size = new System.Drawing.Size(175, 122);
            this.prgBar_update.TabIndex = 0;
            // 
            // splitC_lenny
            // 
            this.splitC_lenny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitC_lenny.IsSplitterFixed = true;
            this.splitC_lenny.Location = new System.Drawing.Point(0, 0);
            this.splitC_lenny.Name = "splitC_lenny";
            this.splitC_lenny.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitC_lenny.Panel1
            // 
            this.splitC_lenny.Panel1.Controls.Add(this.tbl_pageControl);
            // 
            // splitC_lenny.Panel2
            // 
            this.splitC_lenny.Panel2.Controls.Add(this.flow_lennyPage);
            this.splitC_lenny.Size = new System.Drawing.Size(358, 186);
            this.splitC_lenny.SplitterDistance = 123;
            this.splitC_lenny.TabIndex = 0;
            // 
            // tbl_pageControl
            // 
            this.tbl_pageControl.ColumnCount = 3;
            this.tbl_pageControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tbl_pageControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tbl_pageControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tbl_pageControl.Controls.Add(this.splitC_pageNumber, 1, 0);
            this.tbl_pageControl.Controls.Add(this.btn_pageNext, 2, 0);
            this.tbl_pageControl.Controls.Add(this.btn_pagePrev, 0, 0);
            this.tbl_pageControl.Location = new System.Drawing.Point(3, 3);
            this.tbl_pageControl.Name = "tbl_pageControl";
            this.tbl_pageControl.RowCount = 1;
            this.tbl_pageControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_pageControl.Size = new System.Drawing.Size(342, 103);
            this.tbl_pageControl.TabIndex = 0;
            // 
            // splitC_pageNumber
            // 
            this.splitC_pageNumber.IsSplitterFixed = true;
            this.splitC_pageNumber.Location = new System.Drawing.Point(122, 3);
            this.splitC_pageNumber.Name = "splitC_pageNumber";
            // 
            // splitC_pageNumber.Panel1
            // 
            this.splitC_pageNumber.Panel1.Controls.Add(this.pageNumber);
            // 
            // splitC_pageNumber.Panel2
            // 
            this.splitC_pageNumber.Panel2.Controls.Add(this.totalPageNumber);
            this.splitC_pageNumber.Size = new System.Drawing.Size(78, 77);
            this.splitC_pageNumber.SplitterDistance = 34;
            this.splitC_pageNumber.TabIndex = 2;
            // 
            // pageNumber
            // 
            this.pageNumber.Location = new System.Drawing.Point(13, 17);
            this.pageNumber.Name = "pageNumber";
            this.pageNumber.Size = new System.Drawing.Size(41, 20);
            this.pageNumber.TabIndex = 2;
            this.pageNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pageNumber_KeyDown);
            this.pageNumber.Leave += new System.EventHandler(this.pageNumber_Leave);
            // 
            // totalPageNumber
            // 
            this.totalPageNumber.Enabled = false;
            this.totalPageNumber.Location = new System.Drawing.Point(20, 44);
            this.totalPageNumber.Name = "totalPageNumber";
            this.totalPageNumber.Size = new System.Drawing.Size(44, 20);
            this.totalPageNumber.TabIndex = 0;
            // 
            // btn_pageNext
            // 
            this.btn_pageNext.Location = new System.Drawing.Point(224, 3);
            this.btn_pageNext.Name = "btn_pageNext";
            this.btn_pageNext.Size = new System.Drawing.Size(75, 23);
            this.btn_pageNext.TabIndex = 1;
            this.btn_pageNext.Text = "Next";
            this.btn_pageNext.UseVisualStyleBackColor = true;
            this.btn_pageNext.Click += new System.EventHandler(this.btn_pageNext_Click);
            // 
            // btn_pagePrev
            // 
            this.btn_pagePrev.Location = new System.Drawing.Point(3, 3);
            this.btn_pagePrev.Name = "btn_pagePrev";
            this.btn_pagePrev.Size = new System.Drawing.Size(75, 23);
            this.btn_pagePrev.TabIndex = 0;
            this.btn_pagePrev.Text = "Previous";
            this.btn_pagePrev.UseVisualStyleBackColor = true;
            this.btn_pagePrev.Click += new System.EventHandler(this.btn_pagePrev_Click);
            // 
            // flow_lennyPage
            // 
            this.flow_lennyPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_lennyPage.Location = new System.Drawing.Point(0, 0);
            this.flow_lennyPage.Name = "flow_lennyPage";
            this.flow_lennyPage.Size = new System.Drawing.Size(358, 59);
            this.flow_lennyPage.TabIndex = 1;
            this.flow_lennyPage.SizeChanged += new System.EventHandler(this.flow_lennyPage_SizeChanged);
            // 
            // splitC_settings
            // 
            this.splitC_settings.Location = new System.Drawing.Point(505, 344);
            this.splitC_settings.Name = "splitC_settings";
            this.splitC_settings.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitC_settings.Panel1
            // 
            this.splitC_settings.Panel1.Controls.Add(this.splitC_settingsbtns);
            this.splitC_settings.Size = new System.Drawing.Size(196, 216);
            this.splitC_settings.SplitterDistance = 54;
            this.splitC_settings.TabIndex = 1;
            // 
            // splitC_settingsbtns
            // 
            this.splitC_settingsbtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitC_settingsbtns.Location = new System.Drawing.Point(0, 0);
            this.splitC_settingsbtns.Name = "splitC_settingsbtns";
            // 
            // splitC_settingsbtns.Panel1
            // 
            this.splitC_settingsbtns.Panel1.Controls.Add(this.btn_save);
            // 
            // splitC_settingsbtns.Panel2
            // 
            this.splitC_settingsbtns.Panel2.Controls.Add(this.btn_revert);
            this.splitC_settingsbtns.Size = new System.Drawing.Size(196, 54);
            this.splitC_settingsbtns.SplitterDistance = 91;
            this.splitC_settingsbtns.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_save.Location = new System.Drawing.Point(0, 0);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(91, 54);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save and return";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_revert
            // 
            this.btn_revert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_revert.Location = new System.Drawing.Point(0, 0);
            this.btn_revert.Name = "btn_revert";
            this.btn_revert.Size = new System.Drawing.Size(101, 54);
            this.btn_revert.TabIndex = 0;
            this.btn_revert.Text = "Revert changes";
            this.btn_revert.UseVisualStyleBackColor = true;
            // 
            // ntfyIcn_lennyTool
            // 
            this.ntfyIcn_lennyTool.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfyIcn_lennyTool.Icon")));
            this.ntfyIcn_lennyTool.Text = "LennyTool 2";
            this.ntfyIcn_lennyTool.Click += new System.EventHandler(this.ntfyIcn_lennyTool_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 572);
            this.Controls.Add(this.splitC_settings);
            this.Controls.Add(this.splitC_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1600, 1300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Main";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LennyTool 2";
            this.Load += new System.EventHandler(this.Main_Load);
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.splitC_main.Panel1.ResumeLayout(false);
            this.splitC_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitC_main)).EndInit();
            this.splitC_main.ResumeLayout(false);
            this.splitC_mainbtns.Panel1.ResumeLayout(false);
            this.splitC_mainbtns.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitC_mainbtns)).EndInit();
            this.splitC_mainbtns.ResumeLayout(false);
            this.splitC_update.Panel1.ResumeLayout(false);
            this.splitC_update.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitC_update)).EndInit();
            this.splitC_update.ResumeLayout(false);
            this.splitC_lenny.Panel1.ResumeLayout(false);
            this.splitC_lenny.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitC_lenny)).EndInit();
            this.splitC_lenny.ResumeLayout(false);
            this.tbl_pageControl.ResumeLayout(false);
            this.splitC_pageNumber.Panel1.ResumeLayout(false);
            this.splitC_pageNumber.Panel1.PerformLayout();
            this.splitC_pageNumber.Panel2.ResumeLayout(false);
            this.splitC_pageNumber.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitC_pageNumber)).EndInit();
            this.splitC_pageNumber.ResumeLayout(false);
            this.splitC_settings.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitC_settings)).EndInit();
            this.splitC_settings.ResumeLayout(false);
            this.splitC_settingsbtns.Panel1.ResumeLayout(false);
            this.splitC_settingsbtns.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitC_settingsbtns)).EndInit();
            this.splitC_settingsbtns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitC_main;
        private System.Windows.Forms.SplitContainer splitC_mainbtns;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.SplitContainer splitC_settings;
        private System.Windows.Forms.SplitContainer splitC_settingsbtns;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_revert;
        private System.Windows.Forms.SplitContainer splitC_update;
        private System.Windows.Forms.ProgressBar prgBar_update;
        private System.Windows.Forms.SplitContainer splitC_lenny;
        private System.Windows.Forms.TableLayoutPanel tbl_pageControl;
        private System.Windows.Forms.SplitContainer splitC_pageNumber;
        private System.Windows.Forms.TextBox pageNumber;
        private System.Windows.Forms.Button btn_pagePrev;
        private System.Windows.Forms.Button btn_pageNext;
        private System.Windows.Forms.TextBox totalPageNumber;
        private System.Windows.Forms.NotifyIcon ntfyIcn_lennyTool;
        private System.Windows.Forms.FlowLayoutPanel flow_lennyPage;
    }
}

