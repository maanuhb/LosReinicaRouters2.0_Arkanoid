using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            frmGame PlayGame = new frmGame();
            PlayGame.Show();
            
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
            
            if ( MessageBox.Show("estas seguro que deseas salir?", "Salida", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Close();
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

        

       
    }
}