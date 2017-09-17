namespace Diploma
{
    partial class TrajectoryForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadStateButton = new System.Windows.Forms.Button();
            this.SaveStateButton = new System.Windows.Forms.Button();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.ColorChangeButton = new System.Windows.Forms.Button();
            this.PauseModelingButton = new System.Windows.Forms.Button();
            this.TimeStepTextBox = new System.Windows.Forms.TextBox();
            this.PeriodTextBox = new System.Windows.Forms.TextBox();
            this.StopModelingButton = new System.Windows.Forms.Button();
            this.RadiusTextBox = new System.Windows.Forms.TextBox();
            this.StraightSpeedTextBox = new System.Windows.Forms.TextBox();
            this.CircularSpeedTextBox = new System.Windows.Forms.TextBox();
            this.StartTrajectoryButton = new System.Windows.Forms.Button();
            this.DrawPlane = new System.Windows.Forms.PictureBox();
            this.XValueTextBox = new System.Windows.Forms.TextBox();
            this.YValueTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NewPointButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DrawPlane)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(673, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Dt";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(669, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Період";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "A";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "U";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "V";
            // 
            // LoadStateButton
            // 
            this.LoadStateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadStateButton.Location = new System.Drawing.Point(673, 297);
            this.LoadStateButton.Name = "LoadStateButton";
            this.LoadStateButton.Size = new System.Drawing.Size(99, 23);
            this.LoadStateButton.TabIndex = 68;
            this.LoadStateButton.Text = "Завантажити";
            this.LoadStateButton.UseVisualStyleBackColor = true;
            this.LoadStateButton.Click += new System.EventHandler(this.LoadState_Click);
            // 
            // SaveStateButton
            // 
            this.SaveStateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveStateButton.Location = new System.Drawing.Point(568, 297);
            this.SaveStateButton.Name = "SaveStateButton";
            this.SaveStateButton.Size = new System.Drawing.Size(99, 23);
            this.SaveStateButton.TabIndex = 67;
            this.SaveStateButton.Text = "Зберегти";
            this.SaveStateButton.UseVisualStyleBackColor = true;
            this.SaveStateButton.Click += new System.EventHandler(this.SaveState_Click);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearAllButton.Location = new System.Drawing.Point(569, 268);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(203, 23);
            this.ClearAllButton.TabIndex = 66;
            this.ClearAllButton.Text = "Очистити все";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // ColorChangeButton
            // 
            this.ColorChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorChangeButton.Location = new System.Drawing.Point(672, 110);
            this.ColorChangeButton.Name = "ColorChangeButton";
            this.ColorChangeButton.Size = new System.Drawing.Size(100, 23);
            this.ColorChangeButton.TabIndex = 65;
            this.ColorChangeButton.Text = "Змінити колір";
            this.ColorChangeButton.UseVisualStyleBackColor = true;
            this.ColorChangeButton.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // PauseModelingButton
            // 
            this.PauseModelingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PauseModelingButton.Location = new System.Drawing.Point(672, 239);
            this.PauseModelingButton.Name = "PauseModelingButton";
            this.PauseModelingButton.Size = new System.Drawing.Size(100, 23);
            this.PauseModelingButton.TabIndex = 64;
            this.PauseModelingButton.Text = "Пауза";
            this.PauseModelingButton.UseVisualStyleBackColor = true;
            this.PauseModelingButton.Click += new System.EventHandler(this.Pause_Click);
            // 
            // TimeStepTextBox
            // 
            this.TimeStepTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeStepTextBox.Location = new System.Drawing.Point(673, 69);
            this.TimeStepTextBox.Name = "TimeStepTextBox";
            this.TimeStepTextBox.Size = new System.Drawing.Size(100, 21);
            this.TimeStepTextBox.TabIndex = 63;
            this.TimeStepTextBox.Text = "0.01";
            // 
            // PeriodTextBox
            // 
            this.PeriodTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PeriodTextBox.Location = new System.Drawing.Point(672, 30);
            this.PeriodTextBox.Name = "PeriodTextBox";
            this.PeriodTextBox.Size = new System.Drawing.Size(100, 21);
            this.PeriodTextBox.TabIndex = 62;
            this.PeriodTextBox.Text = "0.04";
            // 
            // StopModelingButton
            // 
            this.StopModelingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StopModelingButton.Location = new System.Drawing.Point(568, 239);
            this.StopModelingButton.Name = "StopModelingButton";
            this.StopModelingButton.Size = new System.Drawing.Size(100, 23);
            this.StopModelingButton.TabIndex = 61;
            this.StopModelingButton.Text = "Стоп";
            this.StopModelingButton.UseVisualStyleBackColor = true;
            this.StopModelingButton.Click += new System.EventHandler(this.Stop_Click);
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RadiusTextBox.Location = new System.Drawing.Point(567, 112);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(100, 21);
            this.RadiusTextBox.TabIndex = 60;
            this.RadiusTextBox.Text = "100";
            this.RadiusTextBox.TextChanged += new System.EventHandler(this.Radius_TextChanged);
            // 
            // StraightSpeedTextBox
            // 
            this.StraightSpeedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StraightSpeedTextBox.Location = new System.Drawing.Point(566, 70);
            this.StraightSpeedTextBox.Name = "StraightSpeedTextBox";
            this.StraightSpeedTextBox.Size = new System.Drawing.Size(100, 21);
            this.StraightSpeedTextBox.TabIndex = 59;
            this.StraightSpeedTextBox.Text = "70";
            this.StraightSpeedTextBox.TextChanged += new System.EventHandler(this.StraightSpeed_TextChanged);
            // 
            // CircularSpeedTextBox
            // 
            this.CircularSpeedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CircularSpeedTextBox.Location = new System.Drawing.Point(566, 30);
            this.CircularSpeedTextBox.Name = "CircularSpeedTextBox";
            this.CircularSpeedTextBox.Size = new System.Drawing.Size(100, 21);
            this.CircularSpeedTextBox.TabIndex = 58;
            this.CircularSpeedTextBox.Text = "150";
            this.CircularSpeedTextBox.TextChanged += new System.EventHandler(this.CircularSpeed_TextChanged);
            // 
            // StartTrajectoryButton
            // 
            this.StartTrajectoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartTrajectoryButton.Location = new System.Drawing.Point(568, 210);
            this.StartTrajectoryButton.Name = "StartTrajectoryButton";
            this.StartTrajectoryButton.Size = new System.Drawing.Size(204, 23);
            this.StartTrajectoryButton.TabIndex = 57;
            this.StartTrajectoryButton.Text = "Розпочати побудову траекторії";
            this.StartTrajectoryButton.UseVisualStyleBackColor = true;
            this.StartTrajectoryButton.Click += new System.EventHandler(this.Start_Click);
            // 
            // DrawPlane
            // 
            this.DrawPlane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawPlane.Location = new System.Drawing.Point(12, 12);
            this.DrawPlane.Name = "DrawPlane";
            this.DrawPlane.Size = new System.Drawing.Size(548, 338);
            this.DrawPlane.TabIndex = 56;
            this.DrawPlane.TabStop = false;
            this.DrawPlane.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPlane_Paint);
            this.DrawPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawPlane_MouseDown);
            this.DrawPlane.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawPlane_MouseMove);
            this.DrawPlane.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawPlane_MouseUp);
            // 
            // XValueTextBox
            // 
            this.XValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XValueTextBox.Location = new System.Drawing.Point(567, 156);
            this.XValueTextBox.Name = "XValueTextBox";
            this.XValueTextBox.Size = new System.Drawing.Size(100, 21);
            this.XValueTextBox.TabIndex = 74;
            // 
            // YValueTextBox
            // 
            this.YValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.YValueTextBox.Location = new System.Drawing.Point(672, 156);
            this.YValueTextBox.Name = "YValueTextBox";
            this.YValueTextBox.Size = new System.Drawing.Size(100, 21);
            this.YValueTextBox.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(567, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(672, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 77;
            this.label7.Text = "Y";
            // 
            // NewPointButton
            // 
            this.NewPointButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewPointButton.Location = new System.Drawing.Point(567, 180);
            this.NewPointButton.Name = "NewPointButton";
            this.NewPointButton.Size = new System.Drawing.Size(205, 23);
            this.NewPointButton.TabIndex = 78;
            this.NewPointButton.Text = "Додати нову точку";
            this.NewPointButton.UseVisualStyleBackColor = true;
            this.NewPointButton.Click += new System.EventHandler(this.NewPointButton_Click);
            // 
            // TrajectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.NewPointButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.YValueTextBox);
            this.Controls.Add(this.XValueTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadStateButton);
            this.Controls.Add(this.SaveStateButton);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.ColorChangeButton);
            this.Controls.Add(this.PauseModelingButton);
            this.Controls.Add(this.TimeStepTextBox);
            this.Controls.Add(this.PeriodTextBox);
            this.Controls.Add(this.StopModelingButton);
            this.Controls.Add(this.RadiusTextBox);
            this.Controls.Add(this.StraightSpeedTextBox);
            this.Controls.Add(this.CircularSpeedTextBox);
            this.Controls.Add(this.StartTrajectoryButton);
            this.Controls.Add(this.DrawPlane);
            this.Name = "TrajectoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Траекторія руху";
            this.SizeChanged += new System.EventHandler(this.AdvectionForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DrawPlane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadStateButton;
        private System.Windows.Forms.Button SaveStateButton;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.Button ColorChangeButton;
        private System.Windows.Forms.Button PauseModelingButton;
        private System.Windows.Forms.TextBox TimeStepTextBox;
        private System.Windows.Forms.TextBox PeriodTextBox;
        private System.Windows.Forms.Button StopModelingButton;
        private System.Windows.Forms.TextBox RadiusTextBox;
        private System.Windows.Forms.TextBox StraightSpeedTextBox;
        private System.Windows.Forms.TextBox CircularSpeedTextBox;
        private System.Windows.Forms.Button StartTrajectoryButton;
        private System.Windows.Forms.PictureBox DrawPlane;
        private System.Windows.Forms.TextBox XValueTextBox;
        private System.Windows.Forms.TextBox YValueTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button NewPointButton;
    }
}