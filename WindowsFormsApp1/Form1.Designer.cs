namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.VisualizteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxVelocity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.GetDataFromFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VisualizteButton
            // 
            this.VisualizteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VisualizteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisualizteButton.Location = new System.Drawing.Point(350, 658);
            this.VisualizteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VisualizteButton.Name = "VisualizteButton";
            this.VisualizteButton.Size = new System.Drawing.Size(710, 122);
            this.VisualizteButton.TabIndex = 0;
            this.VisualizteButton.Text = "Визуализировать!";
            this.VisualizteButton.UseVisualStyleBackColor = false;
            this.VisualizteButton.Click += new System.EventHandler(this.VisualizteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(340, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Визуализация полета by Юля Бабушкина";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxVelocity
            // 
            this.textBoxVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVelocity.Location = new System.Drawing.Point(348, 266);
            this.textBoxVelocity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxVelocity.Name = "textBoxVelocity";
            this.textBoxVelocity.Size = new System.Drawing.Size(708, 35);
            this.textBoxVelocity.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(344, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Укажите начальную скорость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(344, 357);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(453, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Укажите угол броска в градусах";
            // 
            // textBoxAngle
            // 
            this.textBoxAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAngle.Location = new System.Drawing.Point(348, 398);
            this.textBoxAngle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(708, 35);
            this.textBoxAngle.TabIndex = 5;
            // 
            // GetDataFromFileButton
            // 
            this.GetDataFromFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetDataFromFileButton.Location = new System.Drawing.Point(348, 555);
            this.GetDataFromFileButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GetDataFromFileButton.Name = "GetDataFromFileButton";
            this.GetDataFromFileButton.Size = new System.Drawing.Size(710, 74);
            this.GetDataFromFileButton.TabIndex = 6;
            this.GetDataFromFileButton.Text = "Ввести данные из файла";
            this.GetDataFromFileButton.UseVisualStyleBackColor = true;
            this.GetDataFromFileButton.Click += new System.EventHandler(this.GetDataFromFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1326, 863);
            this.Controls.Add(this.GetDataFromFileButton);
            this.Controls.Add(this.textBoxAngle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxVelocity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VisualizteButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VisualizteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxVelocity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAngle;
        private System.Windows.Forms.Button GetDataFromFileButton;
    }
}

