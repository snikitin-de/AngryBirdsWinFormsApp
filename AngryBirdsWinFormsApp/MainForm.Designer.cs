namespace AngryBirdsWinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            birdPictureBox = new PictureBox();
            renderPictureBox = new PictureBox();
            pigPictureBox = new PictureBox();
            scoreLabel = new Label();
            cube1PictureBox = new PictureBox();
            cube2PictureBox = new PictureBox();
            cube6PictureBox = new PictureBox();
            cube5PictureBox = new PictureBox();
            cube4PictureBox = new PictureBox();
            cube3PictureBox = new PictureBox();
            beam1PictureBox = new PictureBox();
            beam2PictureBox = new PictureBox();
            beam3PictureBox = new PictureBox();
            slingPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)birdPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)renderPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pigPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cube1PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cube2PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cube6PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cube5PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cube4PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cube3PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)beam1PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)beam2PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)beam3PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slingPictureBox).BeginInit();
            SuspendLayout();
            // 
            // birdPictureBox
            // 
            birdPictureBox.Image = Properties.Resources.redBird;
            birdPictureBox.Location = new Point(47, 351);
            birdPictureBox.Name = "birdPictureBox";
            birdPictureBox.Size = new Size(46, 46);
            birdPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            birdPictureBox.TabIndex = 2;
            birdPictureBox.TabStop = false;
            // 
            // renderPictureBox
            // 
            renderPictureBox.Dock = DockStyle.Fill;
            renderPictureBox.Image = Properties.Resources.background;
            renderPictureBox.Location = new Point(0, 0);
            renderPictureBox.Name = "renderPictureBox";
            renderPictureBox.Size = new Size(1203, 598);
            renderPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            renderPictureBox.TabIndex = 0;
            renderPictureBox.TabStop = false;
            renderPictureBox.Paint += renderPictureBox_Paint;
            renderPictureBox.MouseDown += renderPictureBox_MouseDown;
            // 
            // pigPictureBox
            // 
            pigPictureBox.Image = Properties.Resources.pig;
            pigPictureBox.Location = new Point(838, 257);
            pigPictureBox.Name = "pigPictureBox";
            pigPictureBox.Size = new Size(78, 76);
            pigPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pigPictureBox.TabIndex = 3;
            pigPictureBox.TabStop = false;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Arial Narrow", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            scoreLabel.ForeColor = Color.LimeGreen;
            scoreLabel.Location = new Point(12, 9);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(131, 43);
            scoreLabel.TabIndex = 4;
            scoreLabel.Text = "Score: 0\r\n";
            // 
            // cube1PictureBox
            // 
            cube1PictureBox.Image = Properties.Resources.cube;
            cube1PictureBox.Location = new Point(569, 351);
            cube1PictureBox.Name = "cube1PictureBox";
            cube1PictureBox.Size = new Size(84, 83);
            cube1PictureBox.TabIndex = 5;
            cube1PictureBox.TabStop = false;
            // 
            // cube2PictureBox
            // 
            cube2PictureBox.Image = Properties.Resources.cube;
            cube2PictureBox.Location = new Point(569, 433);
            cube2PictureBox.Name = "cube2PictureBox";
            cube2PictureBox.Size = new Size(84, 83);
            cube2PictureBox.TabIndex = 6;
            cube2PictureBox.TabStop = false;
            // 
            // cube6PictureBox
            // 
            cube6PictureBox.Image = Properties.Resources.cube;
            cube6PictureBox.Location = new Point(1097, 433);
            cube6PictureBox.Name = "cube6PictureBox";
            cube6PictureBox.Size = new Size(84, 83);
            cube6PictureBox.TabIndex = 8;
            cube6PictureBox.TabStop = false;
            // 
            // cube5PictureBox
            // 
            cube5PictureBox.Image = Properties.Resources.cube;
            cube5PictureBox.Location = new Point(1097, 351);
            cube5PictureBox.Name = "cube5PictureBox";
            cube5PictureBox.Size = new Size(84, 83);
            cube5PictureBox.TabIndex = 7;
            cube5PictureBox.TabStop = false;
            // 
            // cube4PictureBox
            // 
            cube4PictureBox.Image = Properties.Resources.cube;
            cube4PictureBox.Location = new Point(835, 433);
            cube4PictureBox.Name = "cube4PictureBox";
            cube4PictureBox.Size = new Size(84, 83);
            cube4PictureBox.TabIndex = 10;
            cube4PictureBox.TabStop = false;
            // 
            // cube3PictureBox
            // 
            cube3PictureBox.Image = Properties.Resources.cube;
            cube3PictureBox.Location = new Point(835, 351);
            cube3PictureBox.Name = "cube3PictureBox";
            cube3PictureBox.Size = new Size(84, 83);
            cube3PictureBox.TabIndex = 9;
            cube3PictureBox.TabStop = false;
            // 
            // beam1PictureBox
            // 
            beam1PictureBox.Image = Properties.Resources.beam;
            beam1PictureBox.Location = new Point(569, 334);
            beam1PictureBox.Name = "beam1PictureBox";
            beam1PictureBox.Size = new Size(206, 19);
            beam1PictureBox.TabIndex = 11;
            beam1PictureBox.TabStop = false;
            // 
            // beam2PictureBox
            // 
            beam2PictureBox.Image = Properties.Resources.beam;
            beam2PictureBox.Location = new Point(773, 334);
            beam2PictureBox.Name = "beam2PictureBox";
            beam2PictureBox.Size = new Size(206, 19);
            beam2PictureBox.TabIndex = 12;
            beam2PictureBox.TabStop = false;
            // 
            // beam3PictureBox
            // 
            beam3PictureBox.Image = Properties.Resources.beam;
            beam3PictureBox.Location = new Point(975, 334);
            beam3PictureBox.Name = "beam3PictureBox";
            beam3PictureBox.Size = new Size(206, 19);
            beam3PictureBox.TabIndex = 13;
            beam3PictureBox.TabStop = false;
            // 
            // slingPictureBox
            // 
            slingPictureBox.Image = Properties.Resources.sling;
            slingPictureBox.Location = new Point(141, 298);
            slingPictureBox.Name = "slingPictureBox";
            slingPictureBox.Size = new Size(78, 218);
            slingPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            slingPictureBox.TabIndex = 14;
            slingPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 598);
            Controls.Add(pigPictureBox);
            Controls.Add(birdPictureBox);
            Controls.Add(beam3PictureBox);
            Controls.Add(beam2PictureBox);
            Controls.Add(beam1PictureBox);
            Controls.Add(cube4PictureBox);
            Controls.Add(cube3PictureBox);
            Controls.Add(cube6PictureBox);
            Controls.Add(cube5PictureBox);
            Controls.Add(cube2PictureBox);
            Controls.Add(cube1PictureBox);
            Controls.Add(slingPictureBox);
            Controls.Add(scoreLabel);
            Controls.Add(renderPictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Angry Birds";
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)birdPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)renderPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pigPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cube1PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cube2PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cube6PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cube5PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cube4PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cube3PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)beam1PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)beam2PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)beam3PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)slingPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox birdPictureBox;
        private PictureBox renderPictureBox;
        private PictureBox pigPictureBox;
        private Label scoreLabel;
        private PictureBox cube1PictureBox;
        private PictureBox cube2PictureBox;
        private PictureBox cube6PictureBox;
        private PictureBox cube5PictureBox;
        private PictureBox cube4PictureBox;
        private PictureBox cube3PictureBox;
        private PictureBox beam1PictureBox;
        private PictureBox beam2PictureBox;
        private PictureBox beam3PictureBox;
        private PictureBox slingPictureBox;
    }
}