using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Nickname : Form
    {
        public delegate string GetNickname(string text);
         public GetNickname gn;
        
        public Nickname()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtNickname.Text.Length != 0)
                gn?.Invoke(txtNickname.Text);
        }
    }
}