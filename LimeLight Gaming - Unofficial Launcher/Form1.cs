using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LimeLight_Gaming___Unofficial_Launcher
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();

            StyleManager = msmMain;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            msmMain.Style = (MetroFramework.MetroColorStyle)7;
            pictureBox3.ImageLocation = "https://limelightgaming.net/forums/images/banner/gt.php?url=aHR0cDovL2NhY2hlLnd3dy5nYW1ldHJhY2tlci5jb20vc2VydmVyX2luZm8vNTEuMjU0LjU3LjEzMzoyNzAzMC9iXzM1MF8yMF82OTIxMDhfMzgxMDA3X0ZGRkZGRl8wMDAwMDAucG5n";

            


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
            
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            server1panel.Hide();
            server2panel.Hide();
            server3panel.Show();
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
    }
}
