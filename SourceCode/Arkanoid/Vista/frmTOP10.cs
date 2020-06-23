using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class TOP10 : Form
    {
        //Delegates para poder controlar el show y hide del top
        public delegate void OnCloseWindows();
        public OnCloseWindows CloseAction;
        private Label[,] players;
        public TOP10()
        {
            InitializeComponent();
        }
        //Cambiar ventanas actuales por medio del delegate
        private void TOP10_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseAction?.Invoke();
        }
        private void TOP10_Load(object sender, EventArgs e)
        {
            LoadPlayers();
        }

        #region loadPlayersFunction
        private void LoadPlayers()
        {
            var PlayerList = PlayerController.ObtainTopPlayers();
            players = new Label[10,2];
            
            int sampleTop = label1.Bottom + 50, sampleLeft = 45;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    players[i,j] = new Label();
                    players[i,j].BackColor = Color.Transparent;
                    players[i,j].ForeColor = Color.White;

                    if (j == 0)
                    {
                        players[i, j].Text = PlayerList[i].Nickname;
                        players[i, j].Left = sampleLeft;
                    }
                    else
                    {
                        players[i, j].Text = PlayerList[i].Score.ToString();
                        players[i, j].Left = Width / 2 + sampleLeft;
                    }

                    players[i, j].Top = sampleTop + 43* i;
                    players[i,j].Height += 4;
                    players[i,j].Width += 25;
                    
                    players[i,j].Font = new Font("Microsoft Yahei", 16F);
                    players[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    
                    Controls.Add(players[i,j]);
                }
            }
        }
        #endregion
        
        #region menuButton
        //  Al presionar este botón, el usuario regresará al menú principal.
        private void btnMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu Menu = new FrmMainMenu();
                Menu.Show();
                Hide();
        }
        private void btnMenu_MouseHover(object sender, EventArgs e)
        {
            btnMenu.BackColor = btnMenu.BackColor == Color.MediumBlue ?
                Color.DarkCyan: Color.MediumBlue;
        }
        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {
            btnMenu.BackColor = Color.MediumBlue;
        }
        #endregion
    }
}