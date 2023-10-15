using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Start_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bStart_Click(object sender, EventArgs e)
        {
            label1.Hide();
            bStart.Hide();
            bOptions.Hide();
            bExit.Hide();
        }

        private void bStart_MouseHover(object sender, EventArgs e)
        {
            bStart.BackColor = Color.Yellow;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Учеба\Программирование\Start menu\zvuk11.wav");
            sound.Play();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bStart_MouseLeave(object sender, EventArgs e)
        {
            bStart.BackColor = Color.White;
        }


        private void bExit_MouseHover(object sender, EventArgs e)
        {
            bExit.BackColor = Color.Yellow;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Учеба\Программирование\Start menu\zvuk11.wav");
            sound.Play();


        }
        private void bOptions_MouseHover(object sender, EventArgs e)
        {
            bOptions.BackColor = Color.Yellow;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Учеба\Программирование\Start menu\zvuk11.wav");
            sound.Play();
        }

        private void bOptions_MouseLeave(object sender, EventArgs e)
        {
            bOptions.BackColor = Color.White;
        }

        private void bExit_MouseLeave(object sender, EventArgs e)
        {
            bExit.BackColor = Color.White;
        }

        private void bOptions_Click(object sender, EventArgs e)
        {
            option_page option = new option_page();
            option.ShowDialog();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
 }
