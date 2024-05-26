namespace WindowsFormsApp1
{
    partial class Form2
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
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.AngleLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BirdPicture = new System.Windows.Forms.PictureBox();
            this.PigPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BirdPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PigPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpeedLabel.Location = new System.Drawing.Point(12, 9);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(261, 29);
            this.SpeedLabel.TabIndex = 0;
            this.SpeedLabel.Text = "Начальная скорость: ";
            // 
            // AngleLabel
            // 
            this.AngleLabel.AutoSize = true;
            this.AngleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AngleLabel.Location = new System.Drawing.Point(12, 49);
            this.AngleLabel.Name = "AngleLabel";
            this.AngleLabel.Size = new System.Drawing.Size(161, 29);
            this.AngleLabel.TabIndex = 1;
            this.AngleLabel.Text = "Угол броска:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BirdPicture
            // 
            this.BirdPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirdPicture.BackColor = System.Drawing.Color.Transparent;
            this.BirdPicture.Image = global::WindowsFormsApp1.Properties.Resources.redBird1;
            this.BirdPicture.Location = new System.Drawing.Point(0, 850);
            this.BirdPicture.Name = "BirdPicture";
            this.BirdPicture.Size = new System.Drawing.Size(100, 100);
            this.BirdPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BirdPicture.TabIndex = 2;
            this.BirdPicture.TabStop = false;
            // 
            // PigPicture
            // 
            this.PigPicture.BackColor = System.Drawing.Color.Transparent;
            this.PigPicture.Image = global::WindowsFormsApp1.Properties.Resources.pig;
            this.PigPicture.Location = new System.Drawing.Point(845, 271);
            this.PigPicture.Name = "PigPicture";
            this.PigPicture.Size = new System.Drawing.Size(244, 195);
            this.PigPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PigPicture.TabIndex = 3;
            this.PigPicture.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.angry_bird_background_3;
            this.ClientSize = new System.Drawing.Size(1478, 944);
            this.Controls.Add(this.PigPicture);
            this.Controls.Add(this.BirdPicture);
            this.Controls.Add(this.AngleLabel);
            this.Controls.Add(this.SpeedLabel);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BirdPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PigPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label AngleLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox BirdPicture;
        private System.Windows.Forms.PictureBox PigPicture;
    }
}