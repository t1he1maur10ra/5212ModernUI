using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernUi
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        
        public Home()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float fCpu = pCPU.NextValue();
            float fRam = pRAM.NextValue();
            cpbCPU.Value = (int)fCpu;
            cpbRAM.Value = (int)fRam;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

    }
}
