using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalNotification
{
    public partial class Form1 : Form
    {
        string DateTimes;
        int notifycount = 0;

        public Form1()
        {
            InitializeComponent();
            NotifyItem Notifycation = new NotifyItem();
            Notifycation.Notify();
            DateTimes = "23:00";
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void セットToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentalSettingForm Rental = new RentalSettingForm();
            Rental.Show();
        }

        private void 返却予定物ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmationForm Confirm = new ConfirmationForm();
            Confirm.AllReadXML();
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;

            Application.Exit();
        }

        private void NotifRightClickMenu_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            RentalSettingForm Rental = new RentalSettingForm();
            Rental.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            string pickTime = DateTime.Now.ToShortTimeString();

            if (notifycount == 0)
            {
                if (pickTime == DateTimes)
                {
                    NotifyItem Notifycation = new NotifyItem();
                    Notifycation.Notify();
                    notifycount = 1;
                }
            }
            if (pickTime != DateTimes)
            {
                notifycount = 0;
            }

            
        }
    }
}
