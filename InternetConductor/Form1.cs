﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace InternetConductor
{
    public partial class InternetConductor : Form
    {
        List<int> numberOfTabs = new List<int>();
        


        public InternetConductor()
        {
            InitializeComponent();
            

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            CreateNewTab();
        }


        private void Web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {  
            tabControl1.SelectedTab.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= numberOfTabs.Count; i++)
            {
                if (toolStripTextBox1.Text != null)
                {
                    ((WebBrowser)tabControl1.SelectedTab.Controls[numberOfTabs[i + 1]]).Navigate(toolStripTextBox1.Text);
                }
                else
                {

                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {   
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoForward();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            CreateNewTab();
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("https://www.youtube.com/channel/UCVeLEDZfl7h5pdnDoCJfrTA?view_as=subscriber");
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count > 1)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
                tabControl1.SelectTab(tabControl1.TabPages.Count - 1);
                numberOfTabs.RemoveAt(numberOfTabs.Count - 1);
            }
            else
                Application.Exit();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void CreateNewTab()
        {
            WebBrowser web = new WebBrowser();
            web.Visible = true;
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.DocumentCompleted += Web_DocumentCompleted;
            tabControl1.TabPages.Add("Новая вкладка");
            tabControl1.SelectTab(numberOfTabs.Count);
            tabControl1.SelectedTab.Controls.Add(web);
            numberOfTabs.Add(+1);
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreateNewTab();
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(toolStripTextBox1.Text);
                toolStripTextBox1.Clear();
            }
        }

        private void goolgToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            CreateNewTab();
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("https://www.googl.com");
        }

        private void yandexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewTab();
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("https://www.yandex.ru");
        }

        private void mailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewTab();
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("https://www.mail.ru");
        }
    }
}