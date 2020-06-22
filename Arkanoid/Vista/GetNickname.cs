using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class GetNickname : UserControl
    {
        public delegate void Getnickname(string text);
        public Getnickname get;
        public Player currentPlayer;
        
        
        public GetNickname()
        {
            InitializeComponent();
        }
        private void btnOk_Click_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            try
            {
                switch (txtNickname.Text)
                {
                    case string aux when aux.Length > 15:
                        throw new ExceedMaxCharException("No puede excederse de 15 caracteres");
                    case string aux when aux.Trim().Length == 0:
                        throw new EmptyNicknameException("Ingrese usuario porfavor");
                    default:
                        get?.Invoke(txtNickname.Text);
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
=======
            if(txtNickname.Text.Length != 0)
                currentPlayer = new Player(txtNickname.Text, 0);
                get?.Invoke(txtNickname.Text);
            Dispose();
>>>>>>> dae896fc3cecc6a0ff78983b4483a89ae8481fb8
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