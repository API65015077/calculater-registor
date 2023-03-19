using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculate_resistor
{
    
    public partial class Form1 : Form
    {
        private Color[] band1andband2 = { Color.Black, Color.Brown, Color.Red, Color.Orange,
                                          Color.Yellow, Color.Green, Color.Blue, Color.Violet,
                                          Color.Gray, Color.White };
        private Color[] bandd3 = { Color.Black, Color.Brown, Color.Red, Color.Orange,
                                          Color.Yellow, Color.Green, Color.Blue, Color.Violet,
                                          Color.Gray, Color.White, Color.Gold , Color.Silver };
        private Color[] bandd4 = {  Color.Brown, Color.Red, Color.Orange,
                                          Color.Yellow, Color.Green, Color.Blue, Color.Violet,
                                          Color.Gray, Color.Gold , Color.Silver };

        private int[] digit = { 0,1,2,3,4,5,6,7,8,9 };
        private double[] multiplier = { 1,10,100,1000,10000,100000,1000000,10000000,100000000,1000000000,0.1,0.01 };
        private double[] perror = { 0.01, 0.02, 0.03, 0.04, 0.005, 0.0025, 0.001, 0.005, 0.05, 0.1 };
        private void Updatedata()
        {
            if (comboBox1.SelectedIndex >= 0 && comboBox2.SelectedIndex >= 0 && 
                comboBox3.SelectedIndex >= 0 && comboBox4.SelectedIndex >= 0  )
            {
                double value = 0;
                value = (digit[comboBox1.SelectedIndex] * 10 ) + digit[comboBox2.SelectedIndex];
                value *= multiplier[comboBox3.SelectedIndex];
                double min = value - (value * perror[comboBox4.SelectedIndex]);
                double max = value + (value * perror[comboBox4.SelectedIndex]);
                double kilo = value / 1000;
                double mega = value / 1000000;
                double errorP = (perror[comboBox4.SelectedIndex] *100);

                textBox1.Text = value.ToString("N2");
                textBox2.Text = max.ToString("N2");
                textBox3.Text = min.ToString("N2");
                textBox4.Text = kilo.ToString("N2");
                textBox5.Text = mega.ToString("N2");
                textBox6.Text = errorP.ToString("N2");


            }
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            band1.BackColor = band1andband2[comboBox1.SelectedIndex];
            Updatedata();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            band2.BackColor = band1andband2[comboBox2.SelectedIndex];
            Updatedata();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            band3.BackColor = bandd3[comboBox3.SelectedIndex];
            Updatedata();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            band4.BackColor = bandd4[comboBox4.SelectedIndex];
            Updatedata();
        }
    }
}
