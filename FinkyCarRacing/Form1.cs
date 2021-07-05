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
            over.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(5);
            enemy(5);
            gameover();
            




        }
        Random r = new Random();
        int x, y;
        void enemy(int speed)
        {
            if (enemy1.Top >= 380)
            {
                x = r.Next(0, 200);
                enemy1.Location = new Point(x, 0);
            }
            else { enemy1.Top += speed; }

            if (enemy2.Top >= 380)
            {
                x = r.Next(0, 400);
                enemy2.Location = new Point(x, 0);
            }
            else { enemy2.Top += speed; }


            if (enemy3.Top >= 380)
            {
                x = r.Next(200, 350);
                enemy3.Location = new Point(x, 0);
            }
            else { enemy3.Top += speed; }


        }


        void gameover()
        {
            if(Car.Bounds.IntersectsWith(enemy1.Bounds))
            {
              timer1.Enabled=false;
                over.Visible = true;
            }
            if (Car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (Car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }

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
                    Car.Left += -8;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (Car.Right < 380)
                    Car.Left += 8;
            }
            if (e.KeyCode == Keys.Up)
                if (gamespeed < 21)
                { gamespeed++; }
            if (e.KeyCode == Keys.Down)
                if (gamespeed > 0)
                { gamespeed++; }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enemy1_Click(object sender, EventArgs e)
        {

        }

        private void Over_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
    }
}
