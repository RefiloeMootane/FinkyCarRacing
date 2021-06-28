using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinkyCarRacing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(5);
        }
        void moveline(int speed)
        {
            if (pictureBox1.Top >= 380)
            { pictureBox1.Top = 0; }
            else { pictureBox1.Top += speed; }

            if (pictureBox2.Top >= 380)
            { pictureBox2.Top = 0; }
            else { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 380)
            { pictureBox3.Top = 0; }
            else { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 380)
            { pictureBox4.Top = 0; }
            else { pictureBox4.Top += speed; }
        }
        int gamespeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (Car.Left > 0)
                    Car.Left += -gamespeed;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (Car.Right < 500)
                    Car.Left += gamespeed;
            }
            if (e.KeyCode == Keys.Up)
                if (gamespeed < 21)
                { gamespeed++; }
            if (e.KeyCode == Keys.Down)
                if (gamespeed > 0)
                { gamespeed++; }


        }
    }
}
