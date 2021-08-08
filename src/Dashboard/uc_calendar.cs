using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_and_Maintenance_Management_System.src.Dashboard
{
    public partial class uc_calendar : UserControl
    {
        private MainDashboard inst;
        private string uname;

        public void setUname(string uname)
        {
            this.uname = uname;
        }
        public uc_calendar()
        {
            InitializeComponent();
            lbl_date.Text= DateTime.Now.ToString("dd/MMM/yyyy");
            //lblGreetings.Text += uname + '!';
            System.Timers.Timer delay = new System.Timers.Timer();
            delay.Interval = 1000;
            delay.Elapsed += setTime;
            delay.Start();
            this.BackColor = Color.FromArgb(231, 245, 254);
        }
        public void setDashboardInstance(MainDashboard inst)
        {
            this.inst = inst;
        }
        private void setTime(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    lbl_time.Text = DateTime.Now.ToString("T");
                }));
            }
            catch(System.InvalidOperationException ex)
            {
                TextWriter.writeContent("logs.txt", ex.ToString());
            }
        }

        private void uc_calendar_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblNotif2_Click(object sender, EventArgs e)
        {
            inst.clickedDashboardLabel("label-2");
        }

        private void lblNotif1_Click(object sender, EventArgs e)
        {
            inst.clickedDashboardLabel("label-1");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            inst.clickedDashboardLabel("label-3");
        }
    }
}
