using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBA
{
    public partial class Timer : Form
    {
        private int _ticks;
        

        public Timer()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            this.Text = _ticks.ToString();
            
            if(_ticks == 10)
            {
                this.Text = "Done";
                timer1.Stop();
            }
        }

        private void Timer_Load(object sender, EventArgs e)
        {

        }
    }
}
