using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racist_simulator
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            button1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label1.Text = "checkpoint 2";
            label3.Text = "Новодевичей монастырь";
            label5.Visible = true;
            label6.Visible=true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            pictureBox14.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
            pictureBox15.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            button1.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            button1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label1.Text = "checkpoint 1";
            label3.Text = "МЦК Лужники";
            label5.Visible = true;
            pictureBox14.Visible = true;
            label6.Visible = true;
            pictureBox15.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            button1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label1.Text = "checkpoint 3";
            label3.Text = "Метро Киевская";
            label5.Visible = false;
            label5.Visible = true;
            pictureBox14.Visible = true;
            label6.Visible = true;
            pictureBox15.Visible = true;
            label7.Visible= true;
            pictureBox16.Visible= true;  
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            button1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label1.Text = "checkpoint 4";
            label3.Text = "МИД";
            label5.Visible = true;
            pictureBox14.Visible = true;
            label6.Visible = true;
            pictureBox15.Visible = true;
            label7.Visible = true;
            pictureBox16.Visible = true;
            label9.Visible = true;
            pictureBox18.Visible = true;
            //label9.Location = new Point(42; 211);
            //pictureBox18.Location = new Point(10; 207);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            button1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label1.Text = "checpoint 5";
            label3.Text = "Парк Горького";
            label5.Visible = true;
            pictureBox14.Visible = true;
            label6.Visible = true;
            pictureBox15.Visible = true;
            label7.Visible = true;
            pictureBox16.Visible = true;
            label8.Visible= true;
            pictureBox17.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            button1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label1.Text = "checkpoint 6";
            label3.Text = "Здание РАН";
            label5.Visible = true;
            pictureBox14.Visible = true;
            label6.Visible = true;
            pictureBox15.Visible = true;
            label7.Visible = true;
            pictureBox16.Visible = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            button1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label1.Text = "checkpoint 7";
            label3.Text = "Метро Воробевы горы";
            label5.Visible = true;
            pictureBox14.Visible = true;
            label6.Visible = true;
            pictureBox15.Visible = true;
            label7.Visible = true;
            pictureBox16.Visible = true;
            label8.Visible = true;
            pictureBox17.Visible = true;
            label9.Visible = true;
            pictureBox18.Visible = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            button1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label1.Text = "checkpoint 8";
            label3.Text = "Стадион Лужники";
            label5.Visible = true;
            pictureBox14.Visible = true;
            label6.Visible = true;
            pictureBox15.Visible = true;
            label7.Visible = true;
            pictureBox16.Visible = true;
            label8.Visible = true;
            pictureBox17.Visible = true;
            label9.Visible = true;
            pictureBox18.Visible = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            button1_Click(sender,e);
            button1.Visible = true;
            label1.Visible = true;
            label3.Visible = true;
            label1.Text = "Начало гонки";
            label3.Text = "Самба, полный марафон";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            button1.Visible = true;
            label1.Visible = true;
            label3.Visible = true;
            label1.Text = "Начало гонки";
            label3.Text = "Джонго, половина марафона";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            button1.Visible = true;
            label1.Visible = true;
            label3.Visible = true;
            label1.Text = "Начало гонки";
            label3.Text = "Капоэйра, весёлый забег на 5 километров";
        }
    }
}
