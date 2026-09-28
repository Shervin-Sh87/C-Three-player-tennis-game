using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isup  = true, isright = true;
        Random rnd = new Random();
        int m = 50;
        int s = 50;
        int b = 50;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
            int n = rnd.Next(2,2);
            if (n == 0)
            {
                isup = true;
            }
            else { isup = false; }

            s = 50;
            m = 50;
            b = 50;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isup == true)
            {
                label2.Top -= 5;
            }
            else { label2.Top += 5; }
            if (isright == true)
            {
                label2.Left += 5;
            }
            else { label2.Left -= 5; }
            if (label2.Top < 0)
            {
                isup = false;
            }
            if (label2.Top + label2.Height > this.Height-30)
            {
                s--;
                label2.Left = 419;
                label2.Top = 215;
                if (s == 0)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("سبز باخت", "BOOM", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            if (label2.Left < 0)
            {
                b--;
                label2.Left = 419;
                label2.Top = 215;
                if (b == 0)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("بنفش باخت", "BOOM", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            if (label2.Left + label2.Height > this.Width-20)
            {
                m--;
                label2.Left = 419;
                label2.Top = 215;
                if (m == 0)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("قرمز باخت" , "BOOM",MessageBoxButtons.OK,MessageBoxIcon.Stop );
                }
            }
            if (label1.Bounds.IntersectsWith(label2.Bounds))
            {
                isright = false;
            }
            if (label5.Bounds.IntersectsWith(label2.Bounds))
            {
                isup = true;
            }
            if (label3.Bounds.IntersectsWith(label2.Bounds))
            {
                isright = true;
            }
            label7.Text = m.ToString();
            label8.Text = s.ToString();
            label6.Text = b.ToString();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Text = m.ToString();
            label6.Text = b.ToString();
            label8.Text = s.ToString();            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad9)
            {
                label1.Top -= 10; 

            }
            if (e.KeyCode == Keys.NumPad3)
        	{
                label1.Top += 10;
	        }
            if (e.KeyCode == Keys.M)
            {
                label5.Left += 30;
            }
            if (e.KeyCode == Keys.N)
            {
                label5.Left -= 30;
            }
            if (e.KeyCode == Keys.Q)
            {
                label3.Top -= 10;

            }
            if (e.KeyCode == Keys.Z)
            {
                label3.Top += 10;
            }
        }
    }
}
