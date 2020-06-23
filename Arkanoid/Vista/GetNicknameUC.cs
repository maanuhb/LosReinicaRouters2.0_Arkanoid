using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class GetNickname : UserControl
    {
        public delegate void Getnickname(string text);
        public Getnickname Get;
        public Player CurrentPlayer;
        
        
        public GetNickname()
        {
            InitializeComponent();
        }
        
        private void btnOk_Click_1(object sender, EventArgs e)
        {
            try
            {
                switch (txtNickname.Text)
                {
                    case string aux when aux.Length > 15:
                        throw new ExceedMaxCharException("No puede excederse de 15 caracteres");
                    case string aux when aux.Trim().Length == 0:
                        throw new EmptyNicknameException("Ingrese usuario porfavor");
                    default:
                        if(txtNickname.Text.Length != 0)
                            
                            CurrentPlayer = new Player(txtNickname.Text, 0);
                        Get?.Invoke(txtNickname.Text); 
                        Dispose();
                        break;
                }
            }
            catch(EmptyNicknameException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ExceedMaxCharException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOk_MouseHover_1(object sender, EventArgs e)
        {
            btnOk.BackColor = btnOk.BackColor == Color.MediumBlue ?
                Color.DarkCyan: Color.MediumBlue;
        }
        private void btnOk_MouseLeave_1(object sender, EventArgs e)
        {
            btnOk.BackColor = Color.MediumBlue;
        }
    }
}