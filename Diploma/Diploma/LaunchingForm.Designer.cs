namespace Diploma
{
    partial class LaunchingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaunchingForm));
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.AdvectionDrawPicture = new System.Windows.Forms.PictureBox();
            this.PuankareDrawPicture = new System.Windows.Forms.PictureBox();
            this.TrajectoryDrawPicture = new System.Windows.Forms.PictureBox();
            this.AdvectionWindowCallButton = new System.Windows.Forms.Button();
            this.PuankareWindowCallButton = new System.Windows.Forms.Button();
            this.TrajectoryWindowCallButton = new System.Windows.Forms.Button();
            this.StatisticsWindowCallButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdvectionDrawPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuankareDrawPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrajectoryDrawPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderLabel.Location = new System.Drawing.Point(115, 45);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(564, 52);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Моделювання процесів переносу скалярних полів \r\n                в півколі з рухом" +
    "ими границями";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorLabel.Location = new System.Drawing.Point(191, 109);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(416, 23);
            this.AuthorLabel.TabIndex = 1;
            this.AuthorLabel.Text = "Автор: Макарчук Олександр Володимирович";
            // 
            // AdvectionDrawPicture
            // 
            this.AdvectionDrawPicture.Image = ((System.Drawing.Image)(resources.GetObject("AdvectionDrawPicture.Image")));
            this.AdvectionDrawPicture.Location = new System.Drawing.Point(557, 150);
            this.AdvectionDrawPicture.Name = "AdvectionDrawPicture";
            this.AdvectionDrawPicture.Size = new System.Drawing.Size(176, 127);
            this.AdvectionDrawPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AdvectionDrawPicture.TabIndex = 2;
            this.AdvectionDrawPicture.TabStop = false;
            // 
            // PuankareDrawPicture
            // 
            this.PuankareDrawPicture.Image = ((System.Drawing.Image)(resources.GetObject("PuankareDrawPicture.Image")));
            this.PuankareDrawPicture.Location = new System.Drawing.Point(308, 150);
            this.PuankareDrawPicture.Name = "PuankareDrawPicture";
            this.PuankareDrawPicture.Size = new System.Drawing.Size(176, 127);
            this.PuankareDrawPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PuankareDrawPicture.TabIndex = 3;
            this.PuankareDrawPicture.TabStop = false;
            // 
            // TrajectoryDrawPicture
            // 
            this.TrajectoryDrawPicture.Image = ((System.Drawing.Image)(resources.GetObject("TrajectoryDrawPicture.Image")));
            this.TrajectoryDrawPicture.Location = new System.Drawing.Point(61, 150);
            this.TrajectoryDrawPicture.Name = "TrajectoryDrawPicture";
            this.TrajectoryDrawPicture.Size = new System.Drawing.Size(176, 127);
            this.TrajectoryDrawPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TrajectoryDrawPicture.TabIndex = 4;
            this.TrajectoryDrawPicture.TabStop = false;
            // 
            // AdvectionWindowCallButton
            // 
            this.AdvectionWindowCallButton.Location = new System.Drawing.Point(557, 302);
            this.AdvectionWindowCallButton.Name = "AdvectionWindowCallButton";
            this.AdvectionWindowCallButton.Size = new System.Drawing.Size(176, 44);
            this.AdvectionWindowCallButton.TabIndex = 5;
            this.AdvectionWindowCallButton.Text = "Адвекція рідини";
            this.AdvectionWindowCallButton.UseVisualStyleBackColor = true;
            this.AdvectionWindowCallButton.Click += new System.EventHandler(this.AdvectionWindowCallButton_Click);
            // 
            // PuankareWindowCallButton
            // 
            this.PuankareWindowCallButton.Location = new System.Drawing.Point(308, 302);
            this.PuankareWindowCallButton.Name = "PuankareWindowCallButton";
            this.PuankareWindowCallButton.Size = new System.Drawing.Size(176, 44);
            this.PuankareWindowCallButton.TabIndex = 6;
            this.PuankareWindowCallButton.Text = "Переріз Пуанкаре";
            this.PuankareWindowCallButton.UseVisualStyleBackColor = true;
            this.PuankareWindowCallButton.Click += new System.EventHandler(this.PuankareWindowCallButton_Click);
            // 
            // TrajectoryWindowCallButton
            // 
            this.TrajectoryWindowCallButton.Location = new System.Drawing.Point(61, 302);
            this.TrajectoryWindowCallButton.Name = "TrajectoryWindowCallButton";
            this.TrajectoryWindowCallButton.Size = new System.Drawing.Size(176, 44);
            this.TrajectoryWindowCallButton.TabIndex = 7;
            this.TrajectoryWindowCallButton.Text = "Траекторія руху рідини";
            this.TrajectoryWindowCallButton.UseVisualStyleBackColor = true;
            this.TrajectoryWindowCallButton.Click += new System.EventHandler(this.TrajectoryWindowCallButton_Click);
            // 
            // StatisticsWindowCallButton
            // 
            this.StatisticsWindowCallButton.Location = new System.Drawing.Point(768, 302);
            this.StatisticsWindowCallButton.Name = "StatisticsWindowCallButton";
            this.StatisticsWindowCallButton.Size = new System.Drawing.Size(176, 44);
            this.StatisticsWindowCallButton.TabIndex = 8;
            this.StatisticsWindowCallButton.Text = "Статистика";
            this.StatisticsWindowCallButton.UseVisualStyleBackColor = true;
            this.StatisticsWindowCallButton.Click += new System.EventHandler(this.StatisticsWindowCallButton_Click);
            // 
            // LaunchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(973, 362);
            this.Controls.Add(this.StatisticsWindowCallButton);
            this.Controls.Add(this.TrajectoryWindowCallButton);
            this.Controls.Add(this.PuankareWindowCallButton);
            this.Controls.Add(this.AdvectionWindowCallButton);
            this.Controls.Add(this.TrajectoryDrawPicture);
            this.Controls.Add(this.PuankareDrawPicture);
            this.Controls.Add(this.AdvectionDrawPicture);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "LaunchingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Моделювання процесів переносу скалярних полів в півколі з рухомими границями";
            ((System.ComponentModel.ISupportInitialize)(this.AdvectionDrawPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuankareDrawPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrajectoryDrawPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.PictureBox AdvectionDrawPicture;
        private System.Windows.Forms.PictureBox PuankareDrawPicture;
        private System.Windows.Forms.PictureBox TrajectoryDrawPicture;
        private System.Windows.Forms.Button AdvectionWindowCallButton;
        private System.Windows.Forms.Button PuankareWindowCallButton;
        private System.Windows.Forms.Button TrajectoryWindowCallButton;
        private System.Windows.Forms.Button StatisticsWindowCallButton;
    }
}