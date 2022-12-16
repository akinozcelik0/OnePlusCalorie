using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace OnePlusCalorie.UI.Forms
{
    public partial class IdleForm : Form
    {
        public IdleForm()
        {
            InitializeComponent();
        }

        private void IdleForm_Load(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString("T");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //System.Timers.Timer timer = new System.Timers.Timer();
            //timer.Interval = 1000;
            //timer.Elapsed += Timer_Elapsed;
            timer1.Start();

        }

        //private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        //{
        //    Invoke(new MethodInvoker(delegate ()
        //    {
        //        lblSaat.Text = DateTime.Now.ToString("T");
        //    }
        //    ));
        //}
    }
}
