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
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.instructionsUC1 = new Arkanoid.InstructionsUC();
            this.btnInstructions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.picArkanoidLetters)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picArkanoidLetters
            // 
            this.picArkanoidLetters.BackColor = System.Drawing.Color.Transparent;
            this.picArkanoidLetters.BackgroundImage = global::Arkanoid.Properties.Resources.Arkanoid_lettersblue;
            this.picArkanoidLetters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picArkanoidLetters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picArkanoidLetters.Location = new System.Drawing.Point(387, 3);
            this.picArkanoidLetters.Name = "picArkanoidLetters";
            this.picArkanoidLetters.Size = new System.Drawing.Size(478, 78);
            this.picArkanoidLetters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArkanoidLetters.TabIndex = 0;
            this.picArkanoidLetters.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlay.BackColor = System.Drawing.Color.MediumBlue;
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(387, 171);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(478, 78);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            this.btnPlay.MouseHover += new System.EventHandler(this.btnPlay_MouseHover);
            // 
            // btnTopScore
            // 
            this.btnTopScore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTopScore.BackColor = System.Drawing.Color.MediumBlue;
            this.btnTopScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTopScore.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnTopScore.ForeColor = System.Drawing.Color.White;
            this.btnTopScore.Location = new System.Drawing.Point(387, 339);
            this.btnTopScore.Name = "btnTopScore";
            this.btnTopScore.Size = new System.Drawing.Size(478, 78);
            this.btnTopScore.TabIndex = 2;
            this.btnTopScore.Text = "Top Score";
            this.btnTopScore.UseVisualStyleBackColor = false;
            this.btnTopScore.Click += new System.EventHandler(this.btnTopScore_Click);
            this.btnTopScore.MouseLeave += new System.EventHandler(this.btnTopScore_MouseLeave);
            this.btnTopScore.MouseHover += new System.EventHandler(this.btnTopScore_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.BackColor = System.Drawing.Color.MediumBlue;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(387, 507);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(478, 78);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1154, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Instructions";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackgroundImage = global::Arkanoid.Properties.Resources.MainMenuBackground;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.04171F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.46924F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.489051F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 388F));
            this.tableLayoutPanel1.Controls.Add(this.picArkanoidLetters, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPlay, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnTopScore, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.instructionsUC1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInstructions, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1348, 634);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // instructionsUC1
            // 
            this.instructionsUC1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.instructionsUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instructionsUC1.Location = new System.Drawing.Point(2, 3);
            this.instructionsUC1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.instructionsUC1.Name = "instructionsUC1";
            this.tableLayoutPanel1.SetRowSpan(this.instructionsUC1, 8);
            this.instructionsUC1.Size = new System.Drawing.Size(380, 628);
            this.instructionsUC1.TabIndex = 4;
            // 
            // btnInstructions
            // 
            this.btnInstructions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInstructions.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInstructions.Image = ((System.Drawing.Image) (resources.GetObject("btnInstructions.Image")));
            this.btnInstructions.Location = new System.Drawing.Point(871, 171);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(85, 78);
            this.btnInstructions.TabIndex = 5;
            this.btnInstructions.UseVisualStyleBackColor = false;
            this.btnInstructions.MouseLeave += new System.EventHandler(this.btnInstructions_MouseLeave);
            this.btnInstructions.MouseHover += new System.EventHandler(this.btnInstructions_MouseHover);
            // 
            // frmMainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1348, 634);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize) (this.picArkanoidLetters)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnTopScore;
        private System.Windows.Forms.Button button1;
        private Arkanoid.InstructionsUC instructionsUC1;
        private System.Windows.Forms.PictureBox picArkanoidLetters;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}