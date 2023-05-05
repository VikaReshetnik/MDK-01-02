using Racist_simulator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Калькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            man.BorderStyle = BorderStyle.FixedSingle; ;
            man.BackColor = Color.Gainsboro;
        }
        private void qqq(object sender, EventArgs e)
        {
            woman.BorderStyle = BorderStyle.None;
            man.BorderStyle = BorderStyle.FixedSingle;
            man.BackColor = Color.Gainsboro;
            woman.BackColor = Color.WhiteSmoke;
        }

        private void qq(object sender, EventArgs e)
        {
            man.BorderStyle = BorderStyle.None;
            woman.BorderStyle = BorderStyle.FixedSingle;
            man.BackColor = Color.WhiteSmoke;
            woman.BackColor = Color.Gainsboro;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Weights = Convert.ToDouble(weight.Text);
            double Heights = Convert.ToDouble(height.Text);
            Heights = Heights / 100;
            double BMI = Math.Round(Weights / (Heights * Heights),1);
            if (man.BackColor == Color.Gainsboro)
            {
                picture.Image = Properties.Resources.male_icon;
            }
            else
                picture.Image = Properties.Resources.female_icon;
            if (BMI < 18.5)
            {
                trackBar1.Value = 10;
                BMItext.Text = "Недовес";

            }
            else if (BMI <= 24.9)
            {
                trackBar1.Value = 15;
                BMItext.Text = "Здоровый";

            }
            else if (BMI <= 29.9)
            {
                trackBar1.Value = 25;
                BMItext.Text = "Избыточный вес";

            }
            else if (BMI >= 30)
            {
                trackBar1.Value = 35;
                BMItext.Text = "Ожирение";

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Race = new Map();
            Race.Show();

        }
    }
}
