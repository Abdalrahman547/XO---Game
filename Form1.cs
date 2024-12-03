using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using XO___Game.Properties;

namespace XO___Game
{
    public partial class GameScreen : Form
    {
        public GameScreen()
        {
            InitializeComponent();
        }

        enum enPlayer
        {
            Player1, Player2
        }

        enPlayer PlayerTurn = enPlayer.Player1;

        enum enWinner
        {
            Player1, player2, Draw, InProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;
        }

        stGameStatus GameStatus;

        public void EndGame()
        {
            lblTurn.Text = "Game Over";

            switch (GameStatus.Winner)
            {
                case enWinner.Player1:
                    lblWinner.Text = "Player 1";
                    break;

                case enWinner.player2:
                    lblWinner.Text = "Player 2";
                    break;

                default:
                    lblWinner.Text = "Draw";
                    break;
            }

            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            btn11.Enabled = false;
            btn12.Enabled = false;
            btn13.Enabled = false;
            btn21.Enabled = false;
            btn22.Enabled = false;
            btn23.Enabled = false;
            btn31.Enabled = false;
            btn32.Enabled = false;
            btn33.Enabled = false;
        }

        public bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if(btn1.Tag.ToString() != "?" &&
                btn1.Tag.ToString() == btn2.Tag.ToString() &&
                btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                if(btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    GameStatus.PlayCount = 0;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.player2;
                    GameStatus.GameOver = true;
                    GameStatus.PlayCount = 0;
                    EndGame();
                    return true;
                }
            }
            GameStatus.GameOver = false;
            return false;
        }

        public void CheckWinner()
        {
            if (CheckValues(btn11, btn12, btn13))
                return;

            if (CheckValues(btn21, btn22, btn23))
                return;

            if (CheckValues(btn31, btn32, btn33))
                return;

            if (CheckValues(btn11, btn21, btn31))
                return;

            if (CheckValues(btn12, btn22, btn32))
                return;

            if (CheckValues(btn13, btn23, btn33))
                return;

            if (CheckValues(btn11, btn22, btn33))
                return;

            if (CheckValues(btn13, btn22, btn31))
                return;
        }

        private void ChangeStatus(Button btn)
        {
            if(btn.Tag.ToString() == "?")
            {
                btn.BackgroundImage = null;

                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.Image = Resources.X;
                        PlayerTurn = enPlayer.Player2;
                        lblTurn.Text = "Player 2";
                        GameStatus.PlayCount++;
                        btn.Tag = "X";
                        CheckWinner();
                        break;

                    case enPlayer.Player2:
                        btn.Image = Resources.O;
                        PlayerTurn = enPlayer.Player1;
                        lblTurn.Text = "Player 1";
                        GameStatus.PlayCount++;
                        btn.Tag = "O";
                        CheckWinner();
                        break;

                }
            }
            else
            {
                MessageBox.Show("Wrong Choice", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (GameStatus.PlayCount == 9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }
        }

        private void ResetButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.BackColor = Color.Transparent;
            btn.Tag = "?";
            btn.Enabled = true;
        }

        private void ResetGame()
        {
            ResetButton(btn11);
            ResetButton(btn12);
            ResetButton(btn13);

            ResetButton(btn21);
            ResetButton(btn22);
            ResetButton(btn23);

            ResetButton(btn31);
            ResetButton(btn32);
            ResetButton(btn33);

            PlayerTurn = enPlayer.Player1;
            lblTurn.Text = "Player 1";
            lblWinner.Text = "In Progress";
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.InProgress;

        }

        private void btn_Click(object sender, EventArgs e)
        {
            ChangeStatus((Button)sender);
        }

        private void lblResetGame_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
