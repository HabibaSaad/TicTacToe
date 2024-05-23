using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class twoplayer : Form
    {
        int score_x = 0, score_o = 0;
        bool check;
        void enabel_false()
        {
            button2.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
        }
        void enabel_true()
        {
            button2.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
        }
        void score()
        {
            //x hori
            if(button2.Text == "X" && button4.Text == "X" && button5.Text == "X")
            {
                button2.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                score_x++;
                label2.Text = score_x.ToString();
                enabel_false(); 
                MessageBox.Show("The WINNER is Player X","Tic Tac Toe",MessageBoxButtons.OK);

            }
            else if (button6.Text == "X" && button7.Text == "X" && button8.Text == "X")
            {
                button8.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                score_x++;
                label2.Text = score_x.ToString();
                enabel_false();
                MessageBox.Show("The WINNER is Player X", "Tic Tac Toe", MessageBoxButtons.OK);
            }
            else if (button11.Text == "X" && button9.Text == "X" && button10.Text == "X")
            {
                button11.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                button10.BackColor = Color.Green;
                score_x++;
                label2.Text = score_x.ToString();
                enabel_false();
                MessageBox.Show("The WINNER is Player X", "Tic Tac Toe", MessageBoxButtons.OK);
            } 
            //x vert
            else if (button2.Text == "X" && button8.Text == "X" && button11.Text == "X")
            {
                button2.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                button11.BackColor = Color.Green;
                score_x++;
                label2.Text = score_x.ToString();
                enabel_false();
                MessageBox.Show("The WINNER is Player X", "Tic Tac Toe", MessageBoxButtons.OK);
            }
            else if (button4.Text == "X" && button7.Text == "X" && button10.Text == "X")
            {
                button4.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                button10.BackColor = Color.Green;
                score_x++;
                label2.Text = score_x.ToString();
                enabel_false();
                MessageBox.Show("The WINNER is Player X", "Tic Tac Toe", MessageBoxButtons.OK);
            }
           
            else if (button9.Text == "X" && button6.Text == "X" && button5.Text == "X")
            {
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                score_x++;
                label2.Text = score_x.ToString();
                enabel_false();
                MessageBox.Show("The WINNER is Player X", "Tic Tac Toe", MessageBoxButtons.OK);
            }//x diag
            else if (button2.Text == "X" && button9.Text == "X" && button7.Text == "X")
            {
                button9.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                score_x++;
                label2.Text = score_x.ToString();
                enabel_false();
                MessageBox.Show("The WINNER is Player X", "Tic Tac Toe", MessageBoxButtons.OK);
            }
            else if (button5.Text == "X" && button7.Text == "X" && button11.Text == "X")
            {
                button7.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button11.BackColor = Color.Green;
                score_x++;
                label2.Text = score_x.ToString();
                enabel_false();
                MessageBox.Show("The WINNER is Player X", "Tic Tac Toe", MessageBoxButtons.OK);
            }
            //o hori
            else if (button2.Text == "O" && button4.Text == "O" && button5.Text == "O")
            {
                button2.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                score_o++;
                label4.Text = score_o.ToString();
                enabel_false();
                MessageBox.Show("The WINNER is Player O", "Tic Tac Toe", MessageBoxButtons.OK);
            }
            else if (button8.Text == "O" && button6.Text == "O" && button7.Text == "O")
            {
                button8.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                score_o++;
                label4.Text = score_o.ToString();
                enabel_false();
                MessageBox.Show("The WINNER is Player O", "Tic Tac Toe", MessageBoxButtons.OK);
            }
            else if (button11.Text == "O" && button9.Text == "O" && button10.Text == "O")
            {
                button11.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                button10.BackColor = Color.Green;
                score_o++;
                label4.Text = score_o.ToString();
                enabel_false();
                MessageBox.Show("The WINNER is Player O", "Tic Tac Toe", MessageBoxButtons.OK);
            }
            //o vert
            else if (button2.Text == "O" && button8.Text == "O" && button11.Text == "O")
            {
                button2.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                button11.BackColor = Color.Green;
                score_o++;
                label4.Text = score_o.ToString();
                enabel_false();
                MessageBox.Show("The WINNER is Player O", "Tic Tac Toe", MessageBoxButtons.OK);
            }
            else if (button4.Text == "O" && button7.Text == "O" && button10.Text == "O")
            {
                button4.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                button10.BackColor = Color.Green;
                score_o++;
                label4.Text = score_o.ToString();
                enabel_false();
                MessageBox.Show("The WINNER is Player O", "Tic Tac Toe", MessageBoxButtons.OK);
            }

            else if (button9.Text == "O" && button6.Text == "O" && button5.Text == "O")
            {
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                score_o++;
                label4.Text = score_o.ToString();
                enabel_false();
                MessageBox.Show("The WINNER is Player O", "Tic Tac Toe", MessageBoxButtons.OK);
            }
            //o diag
            else if (button2.Text == "O" && button9.Text == "O" && button7.Text == "O")
            {
                button9.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                score_o++;
                label4.Text = score_o.ToString();
                enabel_false();
                MessageBox.Show("The WINNER is Player O", "Tic Tac Toe", MessageBoxButtons.OK);
            }
            else if (button5.Text == "O" && button7.Text == "O" && button11.Text == "O")
            {
                button7.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button11.BackColor = Color.Green;
                score_o++;
                label4.Text = score_o.ToString();
                enabel_false();
                MessageBox.Show("The WINNER is Player O", "Tic Tac Toe", MessageBoxButtons.OK);
            }
        }
        public twoplayer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                button2.Text = "X";
                check= true;    
            }
            else
            {
                button2.Text = "O";
                check= false;
            }
            score();
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enabel_true();
            button2.BackColor = Color.FromArgb(131, 111, 255);
            button4.BackColor = Color.FromArgb(131, 111, 255);
            button5.BackColor = Color.FromArgb(131, 111, 255);
            button6.BackColor = Color.FromArgb(131, 111, 255);
            button7.BackColor = Color.FromArgb(131, 111, 255);
            button8.BackColor = Color.FromArgb(131, 111, 255);
            button9.BackColor = Color.FromArgb(131, 111, 255);
            button10.BackColor = Color.FromArgb(131, 111, 255);
            button11.BackColor = Color.FromArgb(131, 111, 255);
            button2.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
        }

        private void twoplayer_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (check == false)
            {
                button4.Text = "X";
                check = true;
            }
            else
            {
                button4.Text = "O";
                check = false;
            }
            score();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (check == false)
            {
                button5.Text = "X";
                check = true;
            }
            else
            {
                button5.Text = "O";
                check = false;
            }
            score();
            button5.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (check == false)
            {
                button8.Text = "X";
                check = true;
            }
            else
            {
                button8.Text = "O";
                check = false;
            }
            score();
            button8.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (check == false)
            {
                button7.Text = "X";
                check = true;
            }
            else
            {
                button7.Text = "O";
                check = false;
            }
            score();
            button7.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (check == false)
            {
                button6.Text = "X";
                check = true;
            }
            else
            {
                button6.Text = "O";
                check = false;
            }
            score();
            button6.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (check == false)
            {
                button11.Text = "X";
                check = true;
            }
            else
            {
                button11.Text = "O";
                check = false;
            }
            score();
            button11.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (check == false)
            {
                button10.Text = "X";
                check = true;
            }
            else
            {
                button10.Text = "O";
                check = false;
            }
            score();
            button10.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (check == false)
            {
                button9.Text = "X";
                check = true;
            }
            else
            {
                button9.Text = "O";
                check = false;
            }
            score();
            button9.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            enabel_true();
            button2.BackColor = Color.FromArgb(131, 111, 255);
            button4.BackColor = Color.FromArgb(131, 111, 255);
            button5.BackColor = Color.FromArgb(131, 111, 255);
            button6.BackColor = Color.FromArgb(131, 111, 255);
            button7.BackColor = Color.FromArgb(131, 111, 255);
            button8.BackColor = Color.FromArgb(131, 111, 255);
            button9.BackColor = Color.FromArgb(131, 111, 255);
            button10.BackColor = Color.FromArgb(131, 111, 255);
            button11.BackColor = Color.FromArgb(131, 111, 255);
            button2.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            label4.Text = "0";
            label2.Text = "0";  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainpage page = new mainpage(); 
            page.Show();
            this.Hide();
        }
    }
}
