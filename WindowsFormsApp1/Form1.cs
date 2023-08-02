using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool checker;
        int x, o;
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
        private void score_update()
        {
            x=int.Parse(lblx.Text);
            o = int.Parse(lblo.Text);
            
            if(( (btn1.Text=="x") && (btn2.Text == "x") && (btn3.Text == "x")) || ((btn4.Text == "x") && (btn5.Text == "x") && (btn6.Text == "x"))  || ((btn7.Text == "x") && (btn8.Text == "x") && (btn9.Text == "x")))
           {
                x++;
                lblx.Text = x.ToString();
                //("Winner is X ");
                btn_enable_false();
            }
            else if( ((btn1.Text == "x") && (btn4.Text == "x") && (btn7.Text == "x"))
                    || ((btn2.Text == "x") && (btn5.Text == "x") && (btn8.Text == "x"))
                    || ((btn3.Text == "x") && (btn6.Text == "x") && (btn9.Text == "x")))
           {
                x++;
                lblx.Text = x.ToString();
                btn_enable_false();
            }

            else if (((btn1.Text == "x") && (btn5.Text == "x") && (btn9.Text == "x"))
                    || ((btn3.Text == "x") && (btn5.Text == "x") && (btn7.Text == "x")))
                    
           {
                x++;
                lblx.Text = x.ToString();
                btn_enable_false();
            }
            else if (((btn1.Text == "o") && (btn2.Text == "o") && (btn3.Text == "o")) || ((btn4.Text == "o") && (btn5.Text == "o") && (btn6.Text == "o")) || ((btn7.Text == "o") && (btn8.Text == "o") && (btn9.Text == "o")))
            {
                o++;
                lblo.Text = o.ToString();
                //("Winner is X ");
                btn_enable_false();
            }
            else if (((btn1.Text == "o") && (btn4.Text == "o") && (btn7.Text == "o"))
                    || ((btn2.Text == "o") && (btn5.Text == "o") && (btn8.Text == "o"))
                    || ((btn3.Text == "o") && (btn6.Text == "o") && (btn9.Text == "o")))
            {
                o++;
                lblo.Text = o.ToString();
                btn_enable_false();
            }

            else if (((btn1.Text == "o") && (btn5.Text == "o") && (btn9.Text == "o"))
                    || ((btn3.Text == "o") && (btn5.Text == "o") && (btn7.Text == "o")))

            {
                o++;
                lblo.Text = o.ToString();
                btn_enable_false();
            }

        }
        private void btn_enable_false()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "")
            {
                if (checker==false) {
                    btn1.Text = "o";
                    checker=true;
                    score_update();

                }
                else if (checker == true){
                    btn1.Text = "x";
                    checker=false;
                    score_update();
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "")
            {
                if (checker == false)
                {
                    btn2.Text = "o";
                    checker = true;
                    score_update();
                }
                else if (checker == true)
                {
                    btn2.Text = "x";
                    checker = false;
                    score_update();
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text == "")
            {
                if (checker == false)
                {
                    btn3.Text = "o";
                    checker = true;
                    score_update();
                }
                else if (checker == true)
                {
                    btn3.Text = "x";
                    checker = false;
                    score_update();
                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Text == "")
            {
                if (checker == false)
                {
                    btn4.Text = "o";
                    checker = true;
                    score_update();
                }
                else if (checker == true)
                {
                    btn4.Text = "x";
                    checker = false;
                    score_update();
                }
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.Text == "")
            {
                if (checker == false)
                {
                    btn5.Text = "o";
                    checker = true;
                    score_update();
                }
                else if (checker == true)
                {
                    btn5.Text = "x";
                    checker = false;
                    score_update();
                }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.Text == "")
            {
                if (checker == false)
                {
                    btn6.Text = "o";
                    checker = true;
                    score_update();
                }
                else if (checker == true)
                {
                    btn6.Text = "x";
                    checker = false;
                    score_update();
                }
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.Text == "")
            {
                if (checker == false)
                {
                    btn7.Text = "o";
                    checker = true;
                    score_update();
                }
                else if (checker == true)
                {
                    btn7.Text = "x";
                    checker = false;
                    score_update();
                }
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.Text == "")
            {
                if (checker == false)
                {
                    btn8.Text = "o";
                    checker = true;
                    score_update();
                }
                else if (checker == true)
                {
                    btn8.Text = "x";
                    checker = false;
                    score_update();
                }
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.Text == "")
            {
                if (checker == false)
                {
                    btn9.Text = "o";
                    checker = true;
                    score_update();
                }
                else if (checker == true)
                {
                    btn9.Text = "x";
                    checker = false;
                    score_update();
                }
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
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
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }
    }
}