using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
           
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ImageLocation = @"C:\Users\Naveed Ahmed\Downloads\hd.jpg";
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 150;
            if (panel1.Width > 800) 
            {
                timerStop();
                Form2 frm2 = new Form2();
                this.Hide();
                frm2.ShowDialog();
            }
        }
        public void timerStop() 
        {
            timer1.Stop();  
        }
    }
}
