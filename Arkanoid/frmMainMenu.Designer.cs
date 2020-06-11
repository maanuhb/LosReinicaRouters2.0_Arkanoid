using System.ComponentModel;

namespace Arkanoid
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.picArkanoidLetters = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnTopScore = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.picArkanoidLetters)).BeginInit();
            this.SuspendLayout();
            // 
            // picArkanoidLetters
            // 
            this.picArkanoidLetters.BackColor = System.Drawing.Color.Transparent;
            this.picArkanoidLetters.BackgroundImage = global::Arkanoid.Properties.Resources.Arkanoid_lettersblue;
            this.picArkanoidLetters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picArkanoidLetters.Location = new System.Drawing.Point(481, 48);
            this.picArkanoidLetters.Name = "picArkanoidLetters";
            this.picArkanoidLetters.Size = new System.Drawing.Size(328, 134);
            this.picArkanoidLetters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArkanoidLetters.TabIndex = 0;
            this.picArkanoidLetters.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.MediumBlue;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(481, 246);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(319, 82);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            this.btnPlay.MouseHover += new System.EventHandler(this.btnPlay_MouseHover);
            // 
            // btnTopScore
            // 
            this.btnTopScore.BackColor = System.Drawing.Color.MediumBlue;
            this.btnTopScore.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnTopScore.ForeColor = System.Drawing.Color.White;
            this.btnTopScore.Location = new System.Drawing.Point(481, 368);
            this.btnTopScore.Name = "btnTopScore";
            this.btnTopScore.Size = new System.Drawing.Size(319, 82);
            this.btnTopScore.TabIndex = 2;
            this.btnTopScore.Text = "Top Score";
            this.btnTopScore.UseVisualStyleBackColor = false;
            this.btnTopScore.Click += new System.EventHandler(this.btnTopScore_Click);
            this.btnTopScore.MouseLeave += new System.EventHandler(this.btnTopScore_MouseLeave);
            this.btnTopScore.MouseHover += new System.EventHandler(this.btnTopScore_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MediumBlue;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(481, 489);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(319, 82);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // frmMainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Arkanoid.Properties.Resources.MainMenuBackground;
            this.ClientSize = new System.Drawing.Size(1348, 634);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTopScore);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.picArkanoidLetters);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize) (this.picArkanoidLetters)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnTopScore;
        private System.Windows.Forms.PictureBox picArkanoidLetters;

        #endregion
    }
}