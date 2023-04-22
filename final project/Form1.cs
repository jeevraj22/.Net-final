using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace final_project
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            this.Hide();
            sign_in_page frm = new sign_in_page();
            frm.ShowDialog();
            this.Close();
        }

        ProcessStartInfo near = new ProcessStartInfo("https://www.doordash.com/restaurants-near-me/");
        private void label9_Click(object sender, EventArgs e)
        {
            Process.Start(near);
        }
        private void rectangleShape3_Click(object sender, EventArgs e)
        {    
            Process.Start(near);
        }
        //
        private void label8_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://app.adjust.com/p58jfw?adgroup=&campaign=app_install_mobile_web_interstitial_NEW_FM1_ONLY_V5&creative=%2F&dd_device_id=dx_d34f4174f4674d51b26e2ba5c1ca8db6&dd_login_id&dd_session_id=sx_21a9715cb5824c8aa4e69f119e1167f1&deep_link=doordash%3A%2F%2F&landing_page=%2F&referrer=");
            Process.Start(sInfo);
        }

        private void rectangleShape1_MouseEnter(object sender, EventArgs e)
        {
            rectangleShape1.BorderColor = Color.Blue;
        }

        private void rectangleShape1_MouseLeave(object sender, EventArgs e)
        {
            rectangleShape1.BorderColor = Color.WhiteSmoke;
        }

        private void rectangleShape2_MouseEnter(object sender, EventArgs e)
        {
            rectangleShape2.BorderColor = Color.Red;       
        }

        private void rectangleShape2_MouseLeave(object sender, EventArgs e)
        {
            rectangleShape2.BorderColor = Color.WhiteSmoke;           
        }

        private void rectangleShape3_MouseEnter(object sender, EventArgs e)
        {
            rectangleShape3.BorderColor = Color.Red;
        }

        private void rectangleShape3_MouseLeave(object sender, EventArgs e)
        {
            rectangleShape3.BorderColor = Color.WhiteSmoke;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://dasher.doordash.com/en-us?utm_source=dx_signup_text_cx_home");
            Process.Start(sInfo);
        }

        private void label17_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sup = new ProcessStartInfo("https://get.doordash.com/en-us");
            Process.Start(sup);
        }

        private void label18_Click(object sender, EventArgs e)
        {
            ProcessStartInfo gapp = new ProcessStartInfo("https://apps.apple.com/app/id719972451?mt=8&pt=9654801&ct=Mobile+Splash+Page+%28New+-+08%2F3%2F17%29");
            Process.Start(gapp);
        }      
    }
}
