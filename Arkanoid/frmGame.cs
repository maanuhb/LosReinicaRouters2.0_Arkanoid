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
        }
    }
}