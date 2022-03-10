using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tempo_de_atraso
{
    public partial class splashScreen : Form
    {


        private int ticks;

        public splashScreen()
        {
            InitializeComponent();
            timer1.Start();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            ticks++;
            if(ticks == 2)
            {

                this.Visible = false;
                Principal pc = new Principal();
                pc.ShowDialog();
                timer1.Stop();
            }

        }
    }
}
