using System.Windows.Forms;

namespace Arkanoid
{
    public class CustomPictureBox : PictureBox
    {
        public int hits {get; set;}

        public CustomPictureBox() : base()
        {
        }
    }
}