using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class user : sample
    {
        public user()
        {
            InitializeComponent();
        }

        private void pizza_Click(object sender, EventArgs e)
        {
            this.Hide();
            pizza obj = new pizza();
            obj.ShowDialog();

        }

        private void user_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            burgerking bw = new burgerking();
            bw.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ginsoy gg = new ginsoy();
            gg.ShowDialog();
        }
    }
}
