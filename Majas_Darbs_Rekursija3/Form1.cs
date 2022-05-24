using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Majas_Darbs_Rekursija3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a = 5;
        double b = 2;
        double c = 3;
        





        public static double Y0(double textBox1, double x, double textBox2, double textBox3) { return textBox1*x*x+ textBox2*x+textBox3; }
        public static double Y1(double textBox1, double x, double textBox2, double textBox3) { return textBox1/x*x+textBox2/x+textBox3; }
        public static double Y2( double textBox1, double x, double textBox2, double textBox3) { return (textBox1*x+textBox2)/(textBox1*x+textBox3); }

        public delegate double DY(double textBox1, double x, double textBox2, double textBox3);

        public DY[] Y = new DY[3] { Y0, Y1, Y2 };

        private void DoTable(DY y)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("  x          y ");
            for (double x = -4; x < 4; x += 0.5)
            {
                richTextBox1.AppendText("  \n " + x + "\t" + (a * x * x + b * x + c));
            }

        }
        


        private void radioButton1_Click(object sender, EventArgs e)
        {

            richTextBox1.AppendText("  \n " + x + "\t" + (a * x * x + b * x + c));

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            for (double x = -4; x < 4; x += 0.5)
            {
                richTextBox1.AppendText("  \n " + x + "\t" + (a / x * x + b / x + c));
            }
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            for (double x = -4; x < 4; x += 0.5)
            {
                richTextBox1.AppendText("  \n " + x + "\t" + ((a * x + b) / (a * x + c)));
            }
        }

        void begin()
        {
             double Xn = double.Parse(textBox4.Text);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(((Button)sender).Tag);
            DoTable(Y[k]);
        }
    }
}
