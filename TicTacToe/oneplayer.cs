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
    public partial class oneplayer : Form
    {
        public enum Player
        {
            X, O
        }
        bool win = false;
        Player currentPlayer; 
        List<Button> buttons; 
        Random rand = new Random(); 
        int playerWins = 0; 
        int computerWins = 0; 
        public oneplayer()
        {
           InitializeComponent();
           loadbuttons();
        }

        private void loadbuttons()
        {
            buttons = new List<Button> { button11, button2, button10, button4, button5, button6, button7, button9, button8 };
        }
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
            AImove.Stop();
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
    
        private void Check()
        {
            //x hori
            if (button2.Text == "X" && button4.Text == "X" && button5.Text == "X")
            {
                button2.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                AImove.Stop(); 
                playerWins++; 
                label2.Text = playerWins.ToString();
                win = true;
                enabel_false();
                MessageBox.Show("Player Wins", "Tic Tac Toe", MessageBoxButtons.OK);

            }
            else if (button6.Text == "X" && button7.Text == "X" && button8.Text == "X")
            {
                button8.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                AImove.Stop();
                playerWins++;
                label2.Text = playerWins.ToString();
                win = true;
                enabel_false();
                MessageBox.Show("Player Wins", "Tic Tac Toe", MessageBoxButtons.OK);
            }
            else if (button11.Text == "X" && button9.Text == "X" && button10.Text == "X")
            {
                button11.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                button10.BackColor = Color.Green;
                AImove.Stop();
                playerWins++;
                label2.Text = playerWins.ToString();
                enabel_false();
                win = true;
                MessageBox.Show("Player Wins", "Tic Tac Toe", MessageBoxButtons.OK);
            }
            //x vert
            else if (button2.Text == "X" && button8.Text == "X" && button11.Text == "X")
            {
                button2.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                button11.BackColor = Color.Green;
                AImove.Stop();
                playerWins++;
                label2.Text = playerWins.ToString();
                enabel_false();
                win = true;
                MessageBox.Show("Player Wins", "Tic Tac Toe", MessageBoxButtons.OK);
            }
            else if (button4.Text == "X" && button7.Text == "X" && button10.Text == "X")
            {
                button4.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                button10.BackColor = Color.Green;
                AImove.Stop();
                playerWins++;
                label2.Text = playerWins.ToString();
                enabel_false();
                win = true;
                MessageBox.Show("Player Wins", "Tic Tac Toe", MessageBoxButtons.OK);
            }

            else if (button9.Text == "X" && button6.Text == "X" && button5.Text == "X")
            {
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                AImove.Stop();
                playerWins++;
                label2.Text = playerWins.ToString();
                enabel_false();
                win = true;
                MessageBox.Show("Player Wins", "Tic Tac Toe", MessageBoxButtons.OK);
            }//x diag
            else if (button2.Text == "X" && button9.Text == "X" && button7.Text == "X")
            {
                button9.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                AImove.Stop();
                playerWins++;
                label2.Text = playerWins.ToString();
                enabel_false();
                win = true;
                MessageBox.Show("Player Wins", "Tic Tac Toe", MessageBoxButtons.OK);
            }
            else if (button5.Text == "X" && button7.Text == "X" && button11.Text == "X")
            {
                button7.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button11.BackColor = Color.Green;
                AImove.Stop();
                playerWins++;
                label2.Text = playerWins.ToString();
                enabel_false();
                win = true;
                MessageBox.Show("Player Wins", "Tic Tac Toe", MessageBoxButtons.OK);
            }
            //o hori
            else if (button2.Text == "O" && button4.Text == "O" && button5.Text == "O")
            {
                button2.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                AImove.Stop();
                computerWins++;
                label4.Text = computerWins.ToString();
                enabel_false();
                win = true;
                MessageBox.Show("computer Wins", "Tic Tac Toe", MessageBoxButtons.OK);
            }
            else if (button8.Text == "O" && button6.Text == "O" && button7.Text == "O")
            {
                button8.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                AImove.Stop();
                computerWins++;
                label4.Text = computerWins.ToString();
                enabel_false();
                win = true;
                MessageBox.Show("computer Wins", "Tic Tac Toe", MessageBoxButtons.OK);
            }
            else if (button11.Text == "O" && button9.Text == "O" && button10.Text == "O")
            {
                button11.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                button10.BackColor = Color.Green;
                AImove.Stop();
                computerWins++;
                label4.Text = computerWins.ToString();
                enabel_false();
                win = true;
                MessageBox.Show("computer Wins", "Tic Tac Toe", MessageBoxButtons.OK);
            }
            //o vert
            else if (button2.Text == "O" && button8.Text == "O" && button11.Text == "O")
            {
                button2.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                button11.BackColor = Color.Green;
                AImove.Stop();
                computerWins++;
                label4.Text = computerWins.ToString();
                enabel_false();
                win = true;
                MessageBox.Show("computer Wins", "Tic Tac Toe", MessageBoxButtons.OK);
            }
            else if (button4.Text == "O" && button7.Text == "O" && button10.Text == "O")
            {
                button4.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                button10.BackColor = Color.Green;
                AImove.Stop();
                computerWins++;
                label4.Text = computerWins.ToString();
                enabel_false();
                win = true;
                MessageBox.Show("computer Wins", "Tic Tac Toe", MessageBoxButtons.OK);
            }

            else if (button9.Text == "O" && button6.Text == "O" && button5.Text == "O")
            {
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                AImove.Stop();
                computerWins++;
                label4.Text = computerWins.ToString();
                enabel_false();
                win = true;
                MessageBox.Show("computer Wins", "Tic Tac Toe", MessageBoxButtons.OK);
            }
            //o diag
            else if (button2.Text == "O" && button9.Text == "O" && button7.Text == "O")
            {
                button9.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                AImove.Stop();
                computerWins++;
                label4.Text = computerWins.ToString();
                enabel_false();
                win = true;
                MessageBox.Show("computer Wins", "Tic Tac Toe", MessageBoxButtons.OK);
            }
            else if (button5.Text == "O" && button7.Text == "O" && button11.Text == "O")
            {
                button7.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button11.BackColor = Color.Green;
                AImove.Stop();
                computerWins++;
                label4.Text = computerWins.ToString();
                enabel_false();
                win = true;
                MessageBox.Show("computer Wins", "Tic Tac Toe", MessageBoxButtons.OK);
            }
        }
        private void oneplayer_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            enabel_true();
            loadbuttons();
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
            win=false;
            AImove.Start();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            enabel_true();
            loadbuttons();
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
            playerWins = 0;
            computerWins = 0;
            label2.Text = "0";
            label4.Text = "0";
            win=false;
            AImove.Start();
        }

        private void cpumove(object sender, EventArgs e)
        {
            if (buttons.Count > 0 && win!=true)
            {
                int index = rand.Next(buttons.Count); 
                buttons[index].Enabled = false;
                currentPlayer = Player.O; 
                buttons[index].Text = currentPlayer.ToString(); 
                buttons.RemoveAt(index); 
                Check(); 
                AImove.Stop(); 
            }
        }

        private void playerclkbtn(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            buttons.Remove(button);
            Check();
            AImove.Start();


        }
        private void button3_Click(object sender, EventArgs e)
        {
        mainpage page = new mainpage();
        page.Show();
        this.Hide();

        }
    }
}
