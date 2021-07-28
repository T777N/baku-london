using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TIME : Form
    {
        static int count=0;
        Timer Timer = new Timer();
        public TIME()
        {
            InitializeComponent();

            if (count == 0)
            {

                Timer.Tick += Timer_Tick_B;
                Timer.Interval = 1000;
                Timer.Start();

            }
            else if (count == 1)
            {
                Timer.Tick += Timer_Tick_L;
                Timer.Interval = 1000;
                Timer.Start();

            }
            

        }
        private void Timer_Tick_B(object sender, EventArgs e)
        {
            count = 0;

            timeLbl.Text = DateTime.Now.ToLongTimeString();

        }

        private void Timer_Tick_L(object sender, EventArgs e)
        {
            count = 1;

            //DateTime dateValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour-3, DateTime.Now.Minute, DateTime.Now.Second);
            
            timeLbl.Text = DateTime.Now.AddHours(-3).ToLongTimeString();


        }

        private void BakuBtn_Click(object sender, EventArgs e)
        {
            this.BackgroundImage =Properties.Resources.baku_image;
          
            timeLbl.Text = DateTime.Now.ToLongTimeString();     
        }

        

        private void LondonBtn_Click(object sender, EventArgs e)
        {
           

            this.BackgroundImage = Properties.Resources.london_image;
                      
            
            timeLbl.Text = DateTime.Now.AddHours(-3).ToLongDateString();
            

        }
    }
}
