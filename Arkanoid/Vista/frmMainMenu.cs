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
        // Al presionar este botón, se mostrará el juego.
        private void btnPlay_Click(object sender, EventArgs e)
        {
            FrmGame playGame = new FrmGame();
            playGame.Show();
            Hide();
        }
        //Esta funcion sirve para redibujar el fondo, para que no se tenga ningun error visual.
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000; // WS_EX_COMPOSITED       
                return handleParam;
            }
        } 
        //las funciones hover de los botones, son cuando el mouse pase sobre encima del botón, este cambie el color.
        private void btnPlay_MouseHover(object sender, EventArgs e)
        {
            btnPlay.BackColor = btnPlay.BackColor == Color.MediumBlue ?
                Color.DarkCyan: Color.MediumBlue;
        }
        //Las funciones leave, sirve cuando el mouse se quita del botón, este retome su color original.
        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            btnPlay.BackColor = Color.MediumBlue;
        }
        // Al presionar este botón, llevara al apartado del top 10.
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
        // Al presionar este botón, saltará un mensaje de advertencia por si se desea cerrar la aplicación.
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
        //la funcion hover del botón de instrucciones, sirve para mostrar las instrucciones del juego.
        private void btnInstructions_MouseHover(object sender, EventArgs e)
        {
            instructionsUC1.Visible = true;
        }
        // La funcione leave del botón de instrucciones, sirve para ocultar las instrucciones del juego.
        private void btnInstructions_MouseLeave(object sender, EventArgs e)
        {
            instructionsUC1.Visible = false;
        }

        private void FrmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}