using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
            instructionsUC1.Visible = false;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            FrmGame playGame = new FrmGame();
            playGame.Show();
            Hide();
        }
        private void btnPlay_MouseHover(object sender, EventArgs e)
        {
            btnPlay.BackColor = btnPlay.BackColor == Color.MediumBlue ?
                Color.DarkCyan: Color.MediumBlue;
        }
        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            btnPlay.BackColor = Color.MediumBlue;
        }
        private void btnTopScore_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(instructionsUC1);
            TOP10 ft = new TOP10
            {
                CloseAction = () =>
                {
                    Show();
                }
            };

            ft.Show();
            Hide();
        }
        private void btnTopScore_MouseHover(object sender, EventArgs e)
        {
            btnTopScore.BackColor = btnTopScore.BackColor == Color.MediumBlue ?
                Color.MediumOrchid: Color.MediumBlue;
        }
        private void btnTopScore_MouseLeave(object sender, EventArgs e)
        {
            btnTopScore.BackColor = Color.MediumBlue;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas salir ?", "Arkanoid Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.BackColor = btnExit.BackColor == Color.MediumBlue ?
                Color.MediumPurple: Color.MediumBlue;
        }
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.MediumBlue;
        }
        private void btnInstructions_MouseHover(object sender, EventArgs e)
        {
            instructionsUC1.Visible = true;
        }
        private void btnInstructions_MouseLeave(object sender, EventArgs e)
        {
            instructionsUC1.Visible = false;
        }
    }
}