namespace InternetConductor
{
    partial class InternetConductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InternetConductor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Back = new System.Windows.Forms.ToolStripButton();
            this.Refresh = new System.Windows.Forms.ToolStripButton();
            this.GoForward = new System.Windows.Forms.ToolStripButton();
            this.MyChannel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Search = new System.Windows.Forms.ToolStripButton();
            this.AddNewTab = new System.Windows.Forms.ToolStripButton();
            this.DeleteTab = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.goolgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yandexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Back,
            this.Refresh,
            this.GoForward,
            this.MyChannel,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripSeparator2,
            this.Search,
            this.AddNewTab,
            this.DeleteTab,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1177, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Back
            // 
            this.Back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(23, 22);
            this.Back.Text = "toolStripButton1";
            this.Back.ToolTipText = "Назад";
            this.Back.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Refresh
            // 
            this.Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Refresh.Image = ((System.Drawing.Image)(resources.GetObject("Refresh.Image")));
            this.Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(23, 22);
            this.Refresh.Text = "toolStripButton2";
            this.Refresh.ToolTipText = "Обновить";
            this.Refresh.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // GoForward
            // 
            this.GoForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GoForward.Image = ((System.Drawing.Image)(resources.GetObject("GoForward.Image")));
            this.GoForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoForward.Name = "GoForward";
            this.GoForward.Size = new System.Drawing.Size(23, 22);
            this.GoForward.Text = "toolStripButton3";
            this.GoForward.ToolTipText = "Вперед";
            this.GoForward.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // MyChannel
            // 
            this.MyChannel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MyChannel.Image = ((System.Drawing.Image)(resources.GetObject("MyChannel.Image")));
            this.MyChannel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MyChannel.Name = "MyChannel";
            this.MyChannel.Size = new System.Drawing.Size(23, 22);
            this.MyChannel.Text = "toolStripButton4";
            this.MyChannel.ToolTipText = "Подпишись на мой канал!";
            this.MyChannel.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(900, 25);
            this.toolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Search
            // 
            this.Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Search.Image = ((System.Drawing.Image)(resources.GetObject("Search.Image")));
            this.Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(23, 22);
            this.Search.Text = "toolStripButton5";
            this.Search.ToolTipText = "Поиск";
            this.Search.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // AddNewTab
            // 
            this.AddNewTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddNewTab.Image = ((System.Drawing.Image)(resources.GetObject("AddNewTab.Image")));
            this.AddNewTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddNewTab.Name = "AddNewTab";
            this.AddNewTab.Size = new System.Drawing.Size(23, 22);
            this.AddNewTab.Text = "toolStripButton6";
            this.AddNewTab.ToolTipText = "Добавить вкладку";
            this.AddNewTab.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // DeleteTab
            // 
            this.DeleteTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteTab.Image = ((System.Drawing.Image)(resources.GetObject("DeleteTab.Image")));
            this.DeleteTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteTab.Name = "DeleteTab";
            this.DeleteTab.Size = new System.Drawing.Size(23, 22);
            this.DeleteTab.Text = "toolStripButton7";
            this.DeleteTab.ToolTipText = "Удалить вкладку";
            this.DeleteTab.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goolgToolStripMenuItem,
            this.yandexToolStripMenuItem,
            this.mailToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(91, 22);
            this.toolStripSplitButton1.Text = "Поисковики";
            // 
            // goolgToolStripMenuItem
            // 
            this.goolgToolStripMenuItem.Name = "goolgToolStripMenuItem";
            this.goolgToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.goolgToolStripMenuItem.Text = "Goolg";
            this.goolgToolStripMenuItem.Click += new System.EventHandler(this.goolgToolStripMenuItem_Click);
            // 
            // yandexToolStripMenuItem
            // 
            this.yandexToolStripMenuItem.Name = "yandexToolStripMenuItem";
            this.yandexToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.yandexToolStripMenuItem.Text = "Yandex";
            this.yandexToolStripMenuItem.Click += new System.EventHandler(this.yandexToolStripMenuItem_Click);
            // 
            // mailToolStripMenuItem
            // 
            this.mailToolStripMenuItem.Name = "mailToolStripMenuItem";
            this.mailToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.mailToolStripMenuItem.Text = "Mail";
            this.mailToolStripMenuItem.Click += new System.EventHandler(this.mailToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1210, 676);
            this.tabControl1.TabIndex = 1;
            // 
            // InternetConductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 701);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InternetConductor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Internet Conductor";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Back;
        private System.Windows.Forms.ToolStripButton Refresh;
        private System.Windows.Forms.ToolStripButton GoForward;
        private System.Windows.Forms.ToolStripButton MyChannel;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton Search;
        private System.Windows.Forms.ToolStripButton AddNewTab;
        private System.Windows.Forms.ToolStripButton DeleteTab;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem goolgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yandexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailToolStripMenuItem;
    }
}

