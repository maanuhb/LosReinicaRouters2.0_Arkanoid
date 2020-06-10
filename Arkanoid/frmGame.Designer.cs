namespace Arkanoid
{
    partial class frmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.picSpaceShip = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.picSpaceShip)).BeginInit();
            this.SuspendLayout();
            // 
            // picSpaceShip
            // 
            this.picSpaceShip.BackColor = System.Drawing.Color.Transparent;
            this.picSpaceShip.BackgroundImage = global::Arkanoid.Properties.Resources.barra2loop;
            this.picSpaceShip.Location = new System.Drawing.Point(704, 417);
            this.picSpaceShip.Name = "picSpaceShip";
            this.picSpaceShip.Size = new System.Drawing.Size(117, 67);
            this.picSpaceShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpaceShip.TabIndex = 0;
            this.picSpaceShip.TabStop = false;
            // 
            // frmGame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Arkanoid.Properties.Resources.GameBackground;
            this.ClientSize = new System.Drawing.Size(1284, 634);
            this.Controls.Add(this.picSpaceShip);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize) (this.picSpaceShip)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox picSpaceShip;
    }
}