using System;
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
            switch (e.KeyCode)
            {
                case Keys.Right:
                    if ( picSpaceShip.Location.X <=Width*0.75- picSpaceShip.Width  )
                        picSpaceShip.Left += 10; 
                    break;
                case Keys.Left:
                    if ( picSpaceShip.Location.X >= Width*0.40- picSpaceShip.Width)
                    
                        picSpaceShip.Left -= 10; 
                    break;
            }
        }
        
        private void frmGame_Load(object sender, EventArgs e)
        {
            picSpaceShip.Top = (Height - picSpaceShip.Height) - 130;
            
            LoadTiles();
        }

        //Llenamos la matriz con los bloques 
        private void LoadTiles()
        {
            int xAxis = 7;
            int yAxis = 3;

            int pbHeight = (int)(Height * 0.3) / yAxis;
            int pbWidth = Width / xAxis;

            cpb = new CustomPictureBox[yAxis, xAxis];
            
            for (int i = 0; i < yAxis; i++)
            {
                for (int j = 0; j < xAxis; j++)
                {
                    cpb[i, j] = new CustomPictureBox();

                    if (i == 0)
                        cpb[i, j].hits = 2;
                    else
                        cpb[i, j].hits = 1;

                    cpb[i, j].Height = pbHeight;
                    cpb[i, j].Width = pbWidth;

                    cpb[i, j].Left = j * pbWidth;
                    cpb[i, j].Top = i * pbHeight;
                    
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
            ball.Left = picSpaceShip.Left;
            
            Controls.Add(ball);
        }
    }
}