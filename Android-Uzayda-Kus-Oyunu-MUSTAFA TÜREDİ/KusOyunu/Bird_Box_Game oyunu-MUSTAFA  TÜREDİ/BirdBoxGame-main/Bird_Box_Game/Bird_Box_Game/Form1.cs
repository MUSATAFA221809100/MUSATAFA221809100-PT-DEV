using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Bird_Box_Game
{
    public partial class Form1 : Form
    {
        int score=0;
        Random r = new Random();
        int bird1X,bird1Y;
        int bird2X=700, bird2Y;
        int bird3X, bird3Y;
        int bird4X=700, bird4Y;
        int superman1X=-200, superman1Y;
        int superman2X=1000, superman2Y;
        int mermi = 20;

        SoundPlayer silah = new SoundPlayer();

        

        int fly = 15;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            

            help_pnl.Visible = false;
            help_pnl.Enabled = false;
            game_pnl.Visible = false;
            game_pnl.Enabled = false;

            silah.SoundLocation = @"C:\Users\Haydar\source\repos\Bird_Box_Game\Bird_Box_Game\shotgun-firing-4-6746.wav";
            bird1Y = r.Next(5, 200);
            bird2Y = r.Next(200, 400);
            bird3Y = r.Next(400, 600);
            bird4Y = r.Next(600, 700);
            superman1Y = r.Next(5, 350);
            superman2Y = r.Next(355, 700);


        }

        

        private void help_btn_Click(object sender, EventArgs e)
        {
            help_pnl.Visible = true;
            help_pnl.Enabled = true;
            help_pnl.Width = 1000;
            help_pnl.Height = 600;
            help_pnl.Location = new Point(5, 5);
            game_pnl.Visible = false;
            game_pnl.Enabled = false;
        }

        

        private void geri_btn_Click(object sender, EventArgs e)
        {
            help_pnl.Visible = false;
            help_pnl.Enabled = false;
            game_pnl.Visible = false;
            game_pnl.Enabled = false;
            
        }

        

        private void basla_btn_Click_1(object sender, EventArgs e)
        {
            game_pnl.Enabled = true;
            game_pnl.Visible = true;
            game_pnl.Dock = DockStyle.Fill;
            
            help_pnl.Visible = false;
            help_pnl.Enabled = false;
            timer1.Enabled = true;
            timer1.Interval = 50;
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            bird1X += fly;
            bird2X += -fly;
            bird3X += fly;
            bird4X += -fly;
            superman1X += 20;
            superman2X += -20;

            bird_1.Location = new Point(bird1X, bird1Y);
            bird_2.Location = new Point(bird2X, bird2Y);
            bird_3.Location = new Point(bird3X, bird3Y);
            bird_4.Location = new Point(bird4X, bird4Y);
            false_bird.Location = new Point(superman1X, superman1Y);
            false_bird_2.Location = new Point(superman2X, superman2Y);

            if (bird1X>1250)
            {
                bird1X = r.Next(-250, -50);
                bird1Y = r.Next(5, 200);
            }
            if (bird2X < -150)
            {
                bird2X = r.Next(1200, 1400);
                bird2Y = r.Next(200, 400);
                
            }
            if (bird3X > 1250)
            {
                bird3X = r.Next(-250, -50);
                bird3Y = r.Next(400, 600);
            }
            if (bird4X < -150)
            {
                bird4X = r.Next(1200, 1400);
                bird4Y = r.Next(500, 500);
            }

            if (superman1X > 1300)
            {
                superman1X = r.Next(-250,-50);
                superman1Y = r.Next(5, 350);
            }
            if (superman2X < -50)
            {
                superman2X = r.Next(1200, 1400);
                superman2Y = r.Next(355, 500);
            }



        }

        

       

        private void bird_2_Click(object sender, EventArgs e)
        {
            score++;
            mermi--;
            mermi_lbl_2.Text = Convert.ToString(mermi);
            bird2X = r.Next(1200, 1500);
            bird2Y = r.Next(200, 300);
            silah.Play();
            if (mermi == 0)
            {
                game_pnl.Enabled = false;
                return_pnl.Enabled = true;
                return_pnl.Visible = true;

                return_pnl.Dock = DockStyle.Fill;
                score_lbl_2.Text = Convert.ToString(score);
            }
        }

        

        

        private void bird_4_Click(object sender, EventArgs e)
        {
            score++;
            mermi--;
            mermi_lbl_2.Text = Convert.ToString(mermi);
            bird4X = r.Next(1200, 1500);
            bird4Y = r.Next(500, 550);
            silah.Play();
            if (mermi == 0)
            {
                timer1.Enabled = false;
                game_pnl.Enabled = false;
                game_pnl.Visible = false;
                return_pnl.Enabled = true;
                return_pnl.Visible = true;

                return_pnl.Dock = DockStyle.Fill;
                score_lbl_2.Text = Convert.ToString(score);
            }
        }

        

        private void bird_3_Click(object sender, EventArgs e)
        {
            score++;
            mermi--;
            mermi_lbl_2.Text = Convert.ToString(mermi);
            bird3X = r.Next(-250, -150);
            bird3Y = r.Next(400, 500);
            silah.Play();
            if (mermi == 0)
            {
                timer1.Enabled = false;
                game_pnl.Enabled = false;
                game_pnl.Visible = false;
                return_pnl.Enabled = true;
                return_pnl.Visible = true;

                return_pnl.Dock = DockStyle.Fill;
                score_lbl_2.Text = Convert.ToString(score);
            }
        }
        private void bird_1_Click_1(object sender, EventArgs e)
        {
            score++;
            mermi--;
            mermi_lbl_2.Text = Convert.ToString(mermi);
            bird1X = r.Next(-250, -150);
            bird1Y = r.Next(20, 200);
            silah.Play();

            if (mermi==0)
            {
                timer1.Enabled = false;
                game_pnl.Enabled = false;
                game_pnl.Visible = false;
                return_pnl.Enabled = true;
                return_pnl.Visible = true;
                return_pnl.Dock = DockStyle.Fill;
                score_lbl_2.Text = Convert.ToString(score);
            }
        }
        private void false_bird_Click(object sender, EventArgs e)
        {
            return_pnl.Enabled = true;
            timer1.Enabled = false;
            game_pnl.Enabled = false;
            game_pnl.Visible = false;
            return_pnl.Visible = true;

            return_pnl.Dock = DockStyle.Fill;
            score_lbl_2.Text = Convert.ToString(score);
            silah.Play();
        }
        private void false_bird_2_Click(object sender, EventArgs e)
        {

            return_pnl.Enabled = true;
            timer1.Enabled = false;
            game_pnl.Enabled = false;
            game_pnl.Visible = false;
            return_pnl.Visible = true;

            return_pnl.Dock = DockStyle.Fill;
            score_lbl_2.Text = Convert.ToString(score);
            silah.Play();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            game_pnl.Enabled = false;
            timer1.Enabled = false;
            return_pnl.Visible = true;
            game_pnl.Visible = false;
            return_pnl.Enabled = true;

        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            game_pnl.Enabled = true;
            game_pnl.Dock = DockStyle.Fill;
            game_pnl.Visible = true;
            return_pnl.Enabled = false;
            mermi_lbl_2.Text = "20";
            score = 0;
            mermi = 20;

            bird2X = 1000;
            bird4X = 1000;
            bird1X = r.Next(-350, -150);
            bird3X = r.Next(-350, -150);
            superman1X = -200;
            superman2X = 1000;
            bird1Y = r.Next(5, 200);
            bird2Y = r.Next(200, 400);
            bird3Y = r.Next(400, 600);
            bird4Y = r.Next(600, 700);
            superman1Y = r.Next(5, 350);
            superman2Y = r.Next(355, 700);

        }
    }
}
