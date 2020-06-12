using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class frmGame : Form
    {
        private CustomPictureBox[,] cpb;
        private PictureBox ball;
        private bool[,] ArrayExist;
        

        public frmGame()
        {
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Normal;
            KeyDown += new KeyEventHandler(frmGame_KeyDown);
            int x = (int) (Width * 0.50);
            int y = (int) (Height * 0.20);
            picSpaceShip.Location = new Point(x,y);
        }

        //Movimiento de la plataforma con teclado
        private void frmGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                GameData.gamestarted = true;
            }
            if (!GameData.gamestarted)
            {
                switch (e.KeyCode)
                {
                    case Keys.Right:
                        if (picSpaceShip.Location.X <= Width * 0.75 - picSpaceShip.Width)
                            picSpaceShip.Left += 10;
                        ball.Left = picSpaceShip.Left + (picSpaceShip.Width / 2) - (ball.Width / 2);
                        break;
                    case Keys.Left:
                        if (picSpaceShip.Location.X >= Width * 0.40 - picSpaceShip.Width)
                            picSpaceShip.Left -= 10;
                        ball.Left = picSpaceShip.Left + (picSpaceShip.Width / 2) - (ball.Width / 2);
                        break;
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.Right:
                        if (picSpaceShip.Location.X <= Width * 0.75 - picSpaceShip.Width)
                            picSpaceShip.Left += 10;
                        break;
                    case Keys.Left:
                        if (picSpaceShip.Location.X >= Width * 0.40 - picSpaceShip.Width)

                            picSpaceShip.Left -= 10;
                        break;
                }
            }
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            picSpaceShip.Top = (Height - picSpaceShip.Height) - 130;
            LoadBall();
            LoadTiles();
            tmrSpeed.Start();
        }

        //Llenamos la matriz con los bloques 
        private void LoadTiles()
        {
            int xAxis = 6;
            int yAxis = 4;
            //aqui reducimos el tamaño de los bloques para que pueda encajar en el espacio asignado del juego
            int pbHeight = (int)(Height * 0.3) / yAxis;
            int pbWidth = (int)(Width/2.15) / xAxis;

            cpb = new CustomPictureBox[yAxis, xAxis];
            
            for (int i = 0; i < yAxis; i++)
            {
                for (int j = 0; j < xAxis; j++)
                {
                    cpb[i, j] = new CustomPictureBox();

                    if (i == 0)
                        cpb[i, j].hits = 3;
                    else if (i == 6)
                        cpb[i, j].hits = 2;
                    else
                        cpb[i, j].hits = 1;

                    cpb[i, j].Height = pbHeight;
                    cpb[i, j].Width = pbWidth;
                    //Aqui lo que hicimos fue que le cambiamos las coordenadas de aparicion de los bloques, para que 
                    //encajara con el espacio asignado del juego
                    cpb[i, j].Left = (int) (Width * 0.30)+j * pbWidth;
                    cpb[i, j].Top = (int)(Height*0.22)+i * pbHeight;
                    cpb[i, j].BackgroundImage = Image.FromFile("../../Resources/_" + (i + 0) + ".png");
                    cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    cpb[i,j].BackColor = Color.Transparent;
                    
                    cpb[i, j].Tag = "tileTag";
                    
                    Controls.Add(cpb[i,j]);
                }
            }
        }
        private void LoadBall()
        {
            ball = new PictureBox();
            ball.Width = ball.Height = 20;
            ball.BackgroundImage = Image.FromFile("../../Resources/pelota.png");
            ball.BackgroundImageLayout = ImageLayout.Stretch;
            ball.BackColor = Color.Transparent;

            ball.Top = picSpaceShip.Top - ball.Height;
            ball.Left = picSpaceShip.Left + (picSpaceShip.Width / 2) - (ball.Width / 2);
            
            Controls.Add(ball);
        }

        private void tmrSpeed_Tick(object sender, EventArgs e)
        {
            if (!GameData.gamestarted)
                return;
            ball.Left += GameData.dirX;
            ball.Top += GameData.dirY;
            bounceball();
        }

        private void bounceball()
        {
            if (ball.Bottom > (int)(Height*0.9) + ball.Height)
            {
                /*
                GameData.dirX = 0;
                GameData.dirY = 0;
                
                if ( MessageBox.Show("Perdiste we", "Re manco pibe", MessageBoxButtons.OK, 
                    MessageBoxIcon.Question)==DialogResult.OK)
                {
                    Close();
                    frmMainMenu Prueba = new frmMainMenu();
                    Prueba.Show();
                }*/
                Application.Exit();
            }

            if (ball.Left < Width * 0.30 || ball.Right > Width * 0.75)
            {
                GameData.dirX = -GameData.dirX;
                return;
            }

            if (ball.Top< Height-Height*0.77)
            {
                GameData.dirY= -GameData.dirY;
                return;
            }

            if (ball.Bounds.IntersectsWith(picSpaceShip.Bounds))
                GameData.dirY = -GameData.dirY;

            for (int i = 3; i >= 0; i--)
            {
                for (int j = 0; j < 6; j++)
                {
                    /*var control = ArrayExist.OfType<bool>().Contains(true);
                    if( ArrayExist[i, j] ) {
                        GameData.dirY= - GameData.dirY;

                        ArrayExist[i, j] = false;
                    }*/
                   
                    if (cpb[i,j]!= null && ball.Bounds.IntersectsWith(cpb[i, j].Bounds))
                    {
                        cpb[i, j].hits--;
                        if (cpb[i, j].hits == 0)
                        {
                            Controls.Remove(cpb[i,j]);
                            cpb[i, j] = null;
                        }

                        GameData.dirY = -GameData.dirY;
                        return;
                    }
                }
            }
        }
    }
}