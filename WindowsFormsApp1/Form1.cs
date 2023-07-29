using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool checker;
        public Form1()
        {
            InitializeComponent();
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            checker = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "")
            {
                if (checker==false) {
                    btn1.Text = "O";
                    checker=true;
                }
                else if (checker == true){
                    btn1.Text = "X";
                    checker=false;
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "")
            {
                if (checker == false)
                {
                    btn2.Text = "O";
                    checker = true;
                }
                else if (checker == true)
                {
                    btn2.Text = "X";
                    checker = false;
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text == "")
            {
                if (checker == false)
                {
                    btn3.Text = "O";
                    checker = true;
                }
                else if (checker == true)
                {
                    btn3.Text = "X";
                    checker = false;
                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Text == "")
            {
                if (checker == false)
                {
                    btn4.Text = "O";
                    checker = true;
                }
                else if (checker == true)
                {
                    btn4.Text = "X";
                    checker = false;
                }
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.Text == "")
            {
                if (checker == false)
                {
                    btn5.Text = "O";
                    checker = true;
                }
                else if (checker == true)
                {
                    btn5.Text = "X";
                    checker = false;
                }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.Text == "")
            {
                if (checker == false)
                {
                    btn6.Text = "O";
                    checker = true;
                }
                else if (checker == true)
                {
                    btn6.Text = "X";
                    checker = false;
                }
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.Text == "")
            {
                if (checker == false)
                {
                    btn7.Text = "O";
                    checker = true;
                }
                else if (checker == true)
                {
                    btn7.Text = "X";
                    checker = false;
                }
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.Text == "")
            {
                if (checker == false)
                {
                    btn8.Text = "O";
                    checker = true;
                }
                else if (checker == true)
                {
                    btn8.Text = "X";
                    checker = false;
                }
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.Text == "")
            {
                if (checker == false)
                {
                    btn9.Text = "O";
                    checker = true;
                }
                else if (checker == true)
                {
                    btn9.Text = "X";
                    checker = false;
                }
            }
        }
    }
}
 