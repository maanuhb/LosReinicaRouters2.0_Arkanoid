using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class GetNickname : UserControl
    {
        public delegate void Getnickname(string text);
        public Getnickname get;
        
        public GetNickname()
        {
            InitializeComponent();
        }
        private void btnOk_Click_1(object sender, EventArgs e)
        {
            if(txtNickname.Text.Length != 0)
                get?.Invoke(txtNickname.Text);
            Dispose();
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