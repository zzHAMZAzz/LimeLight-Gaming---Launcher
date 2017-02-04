
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LimeLight_Gaming___Unofficial_Launcher
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        int XCounter = 0;

        public Main()
        {
            InitializeComponent();

            StyleManager = msmMain;

       //     AllocConsole();

            Scrollbar();
        }
       // *TO OPEN CONSOLE ON LAUNCH*

       // [DllImport("kernel32.dll", SetLastError = true)]
       // [return: MarshalAs(UnmanagedType.Bool)]
       // static extern bool AllocConsole();

        private void Form1_Load(object sender, EventArgs e)
        {
            msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            msmMain.Style = (MetroFramework.MetroColorStyle)7;
            string currentversion = Properties.Settings.Default.version;
            System.Net.WebClient wc = new System.Net.WebClient();
            byte[] raw = wc.DownloadData("http://pastebin.com/raw/PZg7Jwm7");
           
            string webData = Encoding.UTF8.GetString(raw);
            lblScroll.Text = "     " + webData;

            if (lblScroll.Text.Contains(currentversion))
            {

            }
            else
            {
                string updatemessage = "A New Update Is Available, Would You Like To Download It Now?";
                string updatecaption = "Update Available";
                MessageBoxButtons updatebuttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(updatemessage, updatecaption, updatebuttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Process.Start("https://mega.nz/#F!dY0GgZCT!qkkICH0GQdj4ibqs_lz2Wg");
                    Environment.Exit(0);

                }
                
                    
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        { 
            
        }

        private void metroTabPage5_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://limelightgaming.net/forums");
        }

        private void metroTabPage4_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            server1panel.Show();
            server2panel.Hide();
            server3panel.Hide();
            serverPanel4.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Process.Start("steam://connect/51.254.57.133:27030/");
        }

        private void metroPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            server2panel.Show();
            server1panel.Hide();
            server3panel.Hide();
            serverPanel4.Hide();

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            server1panel.Hide();
            server2panel.Hide();
            server3panel.Show();
            serverPanel4.Hide();
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Process.Start("steam://connect/51.254.57.133:27035/");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Process.Start("ts3server://51.254.57.133?port=9987");
        
        }

        private void metroLabel6_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://limelightgaming.net");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.newtonsoft.com/json");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://thielj.github.io/MetroFramework/");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://limelightgaming.net/forums/user-3506.html");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void server3panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblScroll.ForeColor = Color.Red;
            if (lblScroll.Location.X == 0)
            {
                XCounter = 0;
                lblScroll.Location = new Point(pnlScroll.Width - XCounter, lblScroll.Location.Y);
                XCounter++;
            }
            else
            {
                lblScroll.Location = new Point(pnlScroll.Width - XCounter, lblScroll.Location.Y);
                XCounter++;
            }
        }

        private void Scrollbar()
        {
            
            tmScroll.Start();
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            server1panel.Hide();
            server2panel.Hide();
            server3panel.Hide();
            serverPanel4.Show();
        }

        private void metroLabel14_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Process.Start("steam://connect/164.132.204.129:27016");
        }
    }
}
