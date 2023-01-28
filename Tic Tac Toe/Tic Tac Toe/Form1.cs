using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        string Player = "X";
        int Draw = 0;
        int count = 60;

        private void button_Click(object sender, EventArgs e)
        {
            int t = 60 - Convert.ToInt16(lbTime.Text);
            Button btn = (Button)sender;
            btn.Enabled = false;
            btn.BackColor = Color.Orange;

            if (Player == "X") 
            {
                btn.Text = Player;
                Player = "O";
                lbName.Text = "O";
            }
            else
            {
                btn.Text = Player;
                Player = "X";
                lbName.Text = "X";
            }

            if ((btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X" && btn.Text != "") ||
               (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X" && btn.Text != "") ||
               (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X" && btn.Text != "") ||
               (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X" && btn.Text != "") ||
               (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X" && btn.Text != "") ||
               (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X" && btn.Text != "") ||
               (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X" && btn.Text != "") ||
               (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X" && btn.Text != ""))
            {
                clock.Stop();
                btnPause.Enabled = false;
                btnStart.Enabled = false;
                tableLayoutPanel1.Enabled = false;
                MessageBox.Show("Player X Win.\n\nTime : " + t + "s");
            }
            else if ((btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O" && btn.Text != "") ||
                    (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O" && btn.Text != "") ||
                    (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O" && btn.Text != "") ||
                    (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O" && btn.Text != "") ||
                    (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O" && btn.Text != "") ||
                    (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O" && btn.Text != "") ||
                    (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O" && btn.Text != "") ||
                    (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O" && btn.Text != "")) 
            {
                clock.Stop();
                btnPause.Enabled = false;
                btnStart.Enabled = false;
                tableLayoutPanel1.Enabled = false;
                MessageBox.Show("Player O Win.\n\nTime : " + t + "s");
            }
            else if(Draw == 8)
            {
                clock.Stop();
                btnPause.Enabled = false;
                btnStart.Enabled = false;
                tableLayoutPanel1.Enabled = false;
                MessageBox.Show("Draw !!!.\n\nTime : " + t + "s");
            }
            Draw++;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Player = "X";
            Draw = 0;
            count = 60;
            lbTime.Text = "60";
            clock.Stop();
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btn1.Enabled = true; btn1.Text = ""; btn1.BackColor = Color.White;
            btn2.Enabled = true; btn2.Text = ""; btn2.BackColor = Color.White;
            btn3.Enabled = true; btn3.Text = ""; btn3.BackColor = Color.White;
            btn4.Enabled = true; btn4.Text = ""; btn4.BackColor = Color.White;
            btn5.Enabled = true; btn5.Text = ""; btn5.BackColor = Color.White;
            btn6.Enabled = true; btn6.Text = ""; btn6.BackColor = Color.White;
            btn7.Enabled = true; btn7.Text = ""; btn7.BackColor = Color.White;
            btn8.Enabled = true; btn8.Text = ""; btn8.BackColor = Color.White;
            btn9.Enabled = true; btn9.Text = ""; btn9.BackColor = Color.White;
            tableLayoutPanel1.Enabled = false;
        }

        private void time_Tick(object sender, EventArgs e)
        {
            count--;
            lbTime.Text = count.ToString();
            if (count == 0) 
            {
                clock.Stop();
                MessageBox.Show("Time out !!!");
                btnPause.Enabled = false;
                tableLayoutPanel1.Enabled = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = true;
            clock.Start();
            tableLayoutPanel1.Enabled = true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            clock.Stop();
            tableLayoutPanel1.Enabled = false;
            DialogResult dlr = MessageBox.Show("Restart game ?", "Game stop !!!", MessageBoxButtons.OK);
            if (dlr == DialogResult.OK) 
            {
                clock.Start();
                tableLayoutPanel1.Enabled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            btnPause.Enabled = false;
            tableLayoutPanel1.Enabled = false;
        }
    }
}
