using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_store
{
    public partial class Pharmacy1 : Form
    {
        public Pharmacy1()
        {
            InitializeComponent();
        }

        private void LoginBN_Click(object sender, EventArgs e)
        {
           string Username= UserNameTB.Text;
            if ( string.Equals(Username,"khetam",StringComparison.OrdinalIgnoreCase)
                && PasswordTB.Text == "1234")

            {

                do
                {
                    Thread.Sleep(500);
                    progressBar1.Value += 20;
                    ProgressLP.Text = (((float)progressBar1.Value / progressBar1.Maximum) * 100) + "%";
                    progressBar1.Refresh();
                    ProgressLP.Refresh();
                } while (progressBar1.Value < progressBar1.Maximum);



                    Form newform = new Pharmacy2();
                        newform.MdiParent = this;
                        newform.Show();

                        UserNameTB.Visible = false;
                        PasswordTB.Visible = false;
                        label1.Visible = false;
                        label2.Visible = false;
                        LoginBN.Visible = false;
                        progressBar1.Visible = false;
                        ProgressLP.Visible = false;
                    }
         
            else
            {
                MessageBox.Show("wrong password or username", "error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                notifyIcon1.BalloonTipTitle = "Error";
                notifyIcon1.BalloonTipText = "You cannot log into the system";
                notifyIcon1.ShowBalloonTip(1000);
            }
            
            
        }

        private void UserNameTB_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(UserNameTB.Text))
            {
                e.Cancel = true;
                UserNameTB.Focus();
                errorProvider1.SetError(UserNameTB, "Username is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(UserNameTB, "");
            }
        }

       
    }
}
