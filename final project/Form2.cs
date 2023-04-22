using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;


namespace final_project
{
    public partial class sign_in_page : Form
    {
        public sign_in_page()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            si_panel.Visible = false;
            panel1.Location = new System.Drawing.Point(0, 57);
            si_panel.Location = new System.Drawing.Point(503, 57);
            emailtext.Text = "";
            ei.Visible = false;
            emailtext.BackColor = Color.WhiteSmoke;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            si_panel.Visible = true;
            panel1.Location = new System.Drawing.Point(503, 57);
            si_panel.Location = new System.Drawing.Point(0, 57);
            txtf.Text = "";
            txtl.Text = "";
            txtmail.Text = "";
            txtmobile.Text = "";
            txtpass.Text = "";
            ccountry.SelectedItem  = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            home frm = new home();
            frm.ShowDialog();
            this.Close();
        }

        private void con_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
        @"Data Source=C:\Users\Student\Documents\Visual Studio 2010\Projects\final project\final project\signup.accdb";
            if ( emailtext.Text != string.Empty || passtext.Text != string.Empty)
            {
                conn.Open();
                String my_querry = "select * from Table1 where Email='" + emailtext.Text + "' and password='" + passtext.Text + "'";
                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    MessageBox.Show("Login Successful");
                    this.Hide();
                    home form = new home();
                    form.ShowDialog();
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label21_Click(object sender, EventArgs e)
        {

        System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
        conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
    @"Data Source=C:\Users\Student\Documents\Visual Studio 2010\Projects\final project\final project\signup.accdb";

     try
       {
           conn.Open();
           String firstname = txtf.Text.ToString();                 
           String lastname = txtl.Text.ToString();
           String email = txtmail.Text.ToString();
           String mobile = txtmobile.Text.ToString();
           String ppassword = txtpass.Text.ToString();
           String country = ccountry.SelectedItem.ToString();
           String my_querry = "INSERT INTO Table1(Fname,Lname,Email,country,phone,[password])VALUES('" + firstname + "','" + lastname + "','" + email + "','" + country + "','" + mobile + "','" + ppassword + "')";

            OleDbCommand cmd = new OleDbCommand(my_querry, conn);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Data saved successfuly...!");
            panel1.Visible = false;
            si_panel.Visible = true;
            panel1.Location = new System.Drawing.Point(503, 57);
            si_panel.Location = new System.Drawing.Point(0, 57);
            txtf.Text = "";
            txtl.Text = "";
            txtmail.Text = "";
            txtmobile.Text = "";
            txtpass.Text = "";
            ccountry.SelectedItem = "";
          }
         catch (Exception ex)
         {
             MessageBox.Show("Failed due to"+ex.Message);
         }
         finally
         {
             conn.Close();
         }
        }

        private void rectangleShape9_Click(object sender, EventArgs e)
        {
            String s = Convert.ToString(emailtext);

            if (s.Contains("@gmail.com") == false)
            {
                ei.Visible = true;
                emailtext.BackColor = Color.FromArgb(255, 192, 192);
            }
        }
        ProcessStartInfo fbook = new ProcessStartInfo("https://www.facebook.com/login.php?skip_api_login=1&api_key=401696723281463&kid_directed_site=0&app_id=401696723281463&signed_next=1&next=https%3A%2F%2Fwww.facebook.com%2Fv10.0%2Fdialog%2Foauth%3Fclient_id%3D401696723281463%26redirect_uri%3Dhttps%253A%252F%252Fidentity.doordash.com%252Fauth%252Ffacebook%252FsignupStart%26response_type%3Dcode%26scope%3Demail%26state%3D1d85322c-862a-4028-87d4-a243b74d73f4%26ret%3Dlogin%26fbapp_pres%3D0%26logger_id%3D69b51c39-346c-473c-bc6f-3d021fa31755%26tp%3Dunspecified&cancel_url=https%3A%2F%2Fidentity.doordash.com%2Fauth%2Ffacebook%2FsignupStart%3Ferror%3Daccess_denied%26error_code%3D200%26error_description%3DPermissions%2Berror%26error_reason%3Duser_denied%26state%3D1d85322c-862a-4028-87d4-a243b74d73f4%23_%3D_&display=page&locale=en_GB&pl_dbl=0");
        ProcessStartInfo google = new ProcessStartInfo("https://accounts.google.com/o/oauth2/v2/auth/identifier?client_id=17899670534-2ivu55vr2ic42rembj2kbj0s61p6fsvj.apps.googleusercontent.com&redirect_uri=https%3A%2F%2Fidentity.doordash.com%2Fauth%2Fgoogle%2FsignupStart&response_type=code&scope=openid%20email%20profile&access_type=offline&state=08efb4c1-2db5-4d72-8ac3-77b3136ea998&service=lso&o2v=2&flowName=GeneralOAuthFlow");
        ProcessStartInfo apple = new ProcessStartInfo("https://appleid.apple.com/auth/authorize?client_id=com.doordash.AppleSignInDoordashConsumerProduction&redirect_uri=https%3A%2F%2Fidentity.doordash.com%2Fauth%2Fapple%2FsignupStart&response_type=code&response_mode=form_post&scope=name%20email&state=6de530a8-0608-4077-b18e-20a1915efc54");
        ProcessStartInfo ppolicy = new ProcessStartInfo("https://www.doordash.com/privacy?_ga=2.266171339.555242196.1668832160-660734334.1662437176");
        ProcessStartInfo tc = new ProcessStartInfo("https://www.doordash.com/terms?_ga=2.266171339.555242196.1668832160-660734334.1662437176");
        private void rectangleShape5_Click(object sender, EventArgs e)
        {
            Process.Start(google);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Process.Start(google);
        }
       
        private void rectangleShape6_Click(object sender, EventArgs e)
        {
            Process.Start(fbook);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Process.Start(fbook);
        }
       

        private void rectangleShape7_Click(object sender, EventArgs e)
        {
            Process.Start(apple);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Process.Start(apple);
        }

        private void rectangleShape13_Click(object sender, EventArgs e)
        {
            Process.Start(google);
        }

        private void rectangleShape12_Click(object sender, EventArgs e)
        {
            Process.Start(fbook);
        }

        private void rectangleShape11_Click(object sender, EventArgs e)
        {
            Process.Start(apple);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(ppolicy);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(tc);
        }

        private void rectangleShape5_MouseEnter(object sender, EventArgs e)
        {
            rectangleShape5.BorderColor = Color.DodgerBlue;
        }

        private void rectangleShape5_MouseLeave(object sender, EventArgs e)
        {
            rectangleShape5.BorderColor = Color.Snow;
        }

        private void rectangleShape6_MouseEnter(object sender, EventArgs e)
        {
            rectangleShape6.BorderColor = Color.MidnightBlue;
        }

        private void rectangleShape6_MouseLeave(object sender, EventArgs e)
        {
            rectangleShape6.BorderColor = Color.Snow;
        }

        private void rectangleShape7_MouseEnter(object sender, EventArgs e)
        {
            rectangleShape7.BorderColor = Color.Black;
        }

        private void rectangleShape7_MouseLeave(object sender, EventArgs e)
        {
            rectangleShape7.BorderColor = Color.Snow;
        }

        private void rectangleShape9_MouseEnter(object sender, EventArgs e)
        {
            rectangleShape9.BorderColor = Color.Red;
        }

        private void rectangleShape9_MouseLeave(object sender, EventArgs e)
        {
            rectangleShape9.BorderColor = Color.Snow;
        }       
    }
}
