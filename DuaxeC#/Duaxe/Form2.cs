using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duaxe
{
    public partial class Form2 : Form
    {
        public int diemso;
        public Form2()
        {
            InitializeComponent();
            over.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tocdo(5);
            lose();
            diemdatduoc();
        }
        Random newrock = new Random();
        void tocdo(int speed)
        {

            if (lephai.Top > 360) lephai.Top = 0;
            else lephai.Top += speed;
            if (lephai2.Top > 300) lephai2.Top = 0;
            else lephai2.Top += speed;
            if (bien1.Top > 360) bien1.Top = 0;
            else bien1.Top += speed;
            if (bien2.Top > 360) bien2.Top = 0;
            else bien2.Top += speed;
            if (bien3.Top > 360) bien3.Top = 0;
            else bien3.Top += speed;
            if (letrai.Top > 360) letrai.Top = 0;
            else letrai.Top += speed;
            if (letrai2.Top > 300) letrai2.Top = 0;
            else letrai2.Top += speed;
            if (rock1.Top > 290)
            {
                //diemchoi++;
                rock1.Left = newrock.Next(0, 150); // xuat hien xe o khoang ( do ramdom) vt trai
                rock1.Top = newrock.Next(0, 100);// xuat hien xe o khoang ( do ramdom) vt tren
                rock1.Top = 0;

            }
            else rock1.Top += speed;

            if (rock2.Top > 290)
            {
                //diemchoi++;
                rock2.Left = newrock.Next(0, 150); // xuat hien xe o khoang ( do ramdom) vt trai
                rock2.Top = newrock.Next(0, 100);// xuat hien xe o khoang ( do ramdom) vt tren
                rock2.Top = 0;

            }
            else rock2.Top += speed;

            if (rock3.Top > 290)
            {
                //diemchoi++;
                rock3.Left = newrock.Next(0, 150); // xuat hien xe o khoang ( do ramdom) vt trai
                rock3.Top = newrock.Next(0, 100);// xuat hien xe o khoang ( do ramdom) vt tren
                rock3.Top = 0;

            }
            else rock3.Top += speed;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        int speeds = 4;
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Mycar.Left > 55) Mycar.Left -= 4;
            if (e.KeyCode == Keys.Right && Mycar.Left < 255) Mycar.Left += 4;
            if (e.KeyCode == Keys.Down && speeds > 4) speeds--;
            if (e.KeyCode == Keys.Up && speeds < 50) speeds++;
        }
        int diemchoi = 0;
        void diemdatduoc()
        {
            diemchoi++;
            label1.Text = "Score:" + diemchoi.ToString() + " Km";


            //    private void lephai2_Click(object sender, EventArgs e)
            //{

            //}
        }
        void lose()
        {
            if (Mycar.Bounds.IntersectsWith(rock1.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true; // dieu kien de khi 2 pic cham nhau Pause- xuat hien Text Box
                Form3 fr = new Form3(diemchoi.ToString());
                this.Hide();
                fr.ShowDialog();
                this.Show();
            }
            else
            {

                if (Mycar.Bounds.IntersectsWith(rock2.Bounds))
                {
                    timer1.Enabled = false;
                    over.Visible = true;
                    Form3 fr = new Form3(diemchoi.ToString());
                    this.Hide();
                    fr.ShowDialog();
                    this.Show();
                }
                else
                {
                    if (Mycar.Bounds.IntersectsWith(rock3.Bounds))
                    {
                        timer1.Enabled = false;
                        over.Visible = true;
                        Form3 fr = new Form3(diemchoi.ToString());
                        this.Hide();
                        fr.ShowDialog();
                        this.Show();
                    }
                }

            }
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        void exitgame()
        {
            if (MessageBox.Show("Do you exit?", "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            exitgame();
        }

        //private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form2 NewForm = new Form2();
        //    NewForm.Show();
        //    this.Dispose(false);
        //}

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 NewForm = new Form2();
            NewForm.Show();
            this.Dispose(false);
        }

        private void quitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            exitgame();
        }
        
    }
}
