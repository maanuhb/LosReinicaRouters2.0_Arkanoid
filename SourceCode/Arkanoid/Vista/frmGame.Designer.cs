using System.ComponentModel;

namespace Arkanoid
{
    partial class FrmGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            this.picSpaceShip = new System.Windows.Forms.PictureBox();
            this.tmrSpeed = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.heart1 = new System.Windows.Forms.Label();
            this.heart2 = new System.Windows.Forms.Label();
            this.heart3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.picSpaceShip)).BeginInit();
            this.SuspendLayout();
            // 
            // picSpaceShip
            // 
            this.picSpaceShip.BackColor = System.Drawing.Color.Transparent;
            this.picSpaceShip.BackgroundImage = global::Arkanoid.Properties.Resources.barra2loop;
            this.picSpaceShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSpaceShip.Location = new System.Drawing.Point(599, 426);
            this.picSpaceShip.Name = "picSpaceShip";
            this.picSpaceShip.Size = new System.Drawing.Size(109, 55);
            this.picSpaceShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpaceShip.TabIndex = 0;
            this.picSpaceShip.TabStop = false;
            // 
            // tmrSpeed
            // 
            this.tmrSpeed.Tick += new System.EventHandler(this.tmrSpeed_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "VIDAS: ";
            // 
            // heart1
            // 
            this.heart1.BackColor = System.Drawing.Color.Transparent;
            this.heart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.heart1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.heart1.Image = ((System.Drawing.Image) (resources.GetObject("heart1.Image")));
            this.heart1.Location = new System.Drawing.Point(95, 9);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(45, 46);
            this.heart1.TabIndex = 2;
            // 
            // heart2
            // 
            this.heart2.BackColor = System.Drawing.Color.Transparent;
            this.heart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.heart2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.heart2.Image = ((System.Drawing.Image) (resources.GetObject("heart2.Image")));
            this.heart2.Location = new System.Drawing.Point(146, 9);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(45, 46);
            this.heart2.TabIndex = 3;
            // 
            // heart3
            // 
            this.heart3.BackColor = System.Drawing.Color.Transparent;
            this.heart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.heart3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.heart3.Image = ((System.Drawing.Image) (resources.GetObject("heart3.Image")));
            this.heart3.Location = new System.Drawing.Point(197, 9);
            this.heart3.Name = "heart3";
            this.heart3.Size = new System.Drawing.Size(45, 46);
            this.heart3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(1042, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "PUNTAJE: ";
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScore.Location = new System.Drawing.Point(1176, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(86, 44);
            this.lblScore.TabIndex = 6;
            // 
            // FrmGame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Arkanoid.Properties.Resources.GameBackground;
            this.ClientSize = new System.Drawing.Size(1284, 634);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.heart3);
            this.Controls.Add(this.heart2);
            this.Controls.Add(this.heart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picSpaceShip);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arkanoid Game ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGame_FormClosing);
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize) (this.picSpaceShip)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label heart1;
        private System.Windows.Forms.Label heart2;
        private System.Windows.Forms.Label heart3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox picSpaceShip;
        private System.Windows.Forms.Timer tmrSpeed;

        #endregion
    }
}