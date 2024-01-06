using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner
{
    public partial class PreCheck : Form
    {
        public PreCheck()
        {
            InitializeComponent();
        }

        public bool MotorTest_Result { get; private set; }

        public void Motor_CheckedChanged(object sender, EventArgs e)
        {
            Motor.CheckState = CheckState.Checked;
        }
    }
}
