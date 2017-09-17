namespace Diploma
{
    partial class AdvectionForm
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
            this.StartModelingButton = new System.Windows.Forms.Button();
            this.DrawPlane = new System.Windows.Forms.PictureBox();
            this.PointNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.SizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DrawPlane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointNumberUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(664, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Dt";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(660, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Період";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "A";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "U";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "V";
            // 
            // LoadStateButton
            // 
            this.LoadStateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadStateButton.Location = new System.Drawing.Point(665, 226);
            this.LoadStateButton.Name = "LoadStateButton";
            this.LoadStateButton.Size = new System.Drawing.Size(99, 23);
            this.LoadStateButton.TabIndex = 50;
            this.LoadStateButton.Text = "Завантажити";
            this.LoadStateButton.UseVisualStyleBackColor = true;
            this.LoadStateButton.Click += new System.EventHandler(this.LoadState_Click);
            // 
            // SaveStateButton
            // 
            this.SaveStateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveStateButton.Location = new System.Drawing.Point(560, 226);
            this.SaveStateButton.Name = "SaveStateButton";
            this.SaveStateButton.Size = new System.Drawing.Size(99, 23);
            this.SaveStateButton.TabIndex = 49;
            this.SaveStateButton.Text = "Зберегти";
            this.SaveStateButton.UseVisualStyleBackColor = true;
            this.SaveStateButton.Click += new System.EventHandler(this.SaveState_Click);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearAllButton.Location = new System.Drawing.Point(561, 197);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(203, 23);
            this.ClearAllButton.TabIndex = 47;
            this.ClearAllButton.Text = "Очистити все";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // ColorChangeButton
            // 
            this.ColorChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorChangeButton.Location = new System.Drawing.Point(663, 111);
            this.ColorChangeButton.Name = "ColorChangeButton";
            this.ColorChangeButton.Size = new System.Drawing.Size(100, 23);
            this.ColorChangeButton.TabIndex = 44;
            this.ColorChangeButton.Text = "Змінити колір";
            this.ColorChangeButton.UseVisualStyleBackColor = true;
            this.ColorChangeButton.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // PauseModelingButton
            // 
            this.PauseModelingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PauseModelingButton.Location = new System.Drawing.Point(666, 293);
            this.PauseModelingButton.Name = "PauseModelingButton";
            this.PauseModelingButton.Size = new System.Drawing.Size(100, 23);
            this.PauseModelingButton.TabIndex = 43;
            this.PauseModelingButton.Text = "Пауза";
            this.PauseModelingButton.UseVisualStyleBackColor = true;
            this.PauseModelingButton.Click += new System.EventHandler(this.Pause_Click);
            // 
            // TimeStepTextBox
            // 
            this.TimeStepTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeStepTextBox.Location = new System.Drawing.Point(664, 70);
            this.TimeStepTextBox.Name = "TimeStepTextBox";
            this.TimeStepTextBox.Size = new System.Drawing.Size(100, 21);
            this.TimeStepTextBox.TabIndex = 39;
            this.TimeStepTextBox.Text = "0.01";
            // 
            // PeriodTextBox
            // 
            this.PeriodTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PeriodTextBox.Location = new System.Drawing.Point(663, 31);
            this.PeriodTextBox.Name = "PeriodTextBox";
            this.PeriodTextBox.Size = new System.Drawing.Size(100, 21);
            this.PeriodTextBox.TabIndex = 38;
            this.PeriodTextBox.Text = "0.04";
            // 
            // StopModelingButton
            // 
            this.StopModelingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StopModelingButton.Location = new System.Drawing.Point(562, 293);
            this.StopModelingButton.Name = "StopModelingButton";
            this.StopModelingButton.Size = new System.Drawing.Size(100, 23);
            this.StopModelingButton.TabIndex = 37;
            this.StopModelingButton.Text = "Стоп";
            this.StopModelingButton.UseVisualStyleBackColor = true;
            this.StopModelingButton.Click += new System.EventHandler(this.Stop_Click);
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RadiusTextBox.Location = new System.Drawing.Point(558, 113);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(100, 21);
            this.RadiusTextBox.TabIndex = 36;
            this.RadiusTextBox.Text = "100";
            this.RadiusTextBox.TextChanged += new System.EventHandler(this.Radius_TextChanged);
            // 
            // StraightSpeedTextBox
            // 
            this.StraightSpeedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StraightSpeedTextBox.Location = new System.Drawing.Point(557, 71);
            this.StraightSpeedTextBox.Name = "StraightSpeedTextBox";
            this.StraightSpeedTextBox.Size = new System.Drawing.Size(100, 21);
            this.StraightSpeedTextBox.TabIndex = 35;
            this.StraightSpeedTextBox.Text = "70";
            this.StraightSpeedTextBox.TextChanged += new System.EventHandler(this.StraightSpeed_TextChanged);
            // 
            // CircularSpeedTextBox
            // 
            this.CircularSpeedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CircularSpeedTextBox.Location = new System.Drawing.Point(557, 31);
            this.CircularSpeedTextBox.Name = "CircularSpeedTextBox";
            this.CircularSpeedTextBox.Size = new System.Drawing.Size(100, 21);
            this.CircularSpeedTextBox.TabIndex = 34;
            this.CircularSpeedTextBox.Text = "150";
            this.CircularSpeedTextBox.TextChanged += new System.EventHandler(this.CircularSpeed_TextChanged);
            // 
            // StartModelingButton
            // 
            this.StartModelingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartModelingButton.Location = new System.Drawing.Point(562, 264);
            this.StartModelingButton.Name = "StartModelingButton";
            this.StartModelingButton.Size = new System.Drawing.Size(204, 23);
            this.StartModelingButton.TabIndex = 33;
            this.StartModelingButton.Text = "Старт";
            this.StartModelingButton.UseVisualStyleBackColor = true;
            this.StartModelingButton.Click += new System.EventHandler(this.Start_Click);
            // 
            // DrawPlane
            // 
            this.DrawPlane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawPlane.Location = new System.Drawing.Point(12, 11);
            this.DrawPlane.Name = "DrawPlane";
            this.DrawPlane.Size = new System.Drawing.Size(539, 302);
            this.DrawPlane.TabIndex = 32;
            this.DrawPlane.TabStop = false;
            this.DrawPlane.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPlane_Paint);
            this.DrawPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawPlane_MouseDown);
            this.DrawPlane.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawPlane_MouseMove);
            this.DrawPlane.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawPlane_MouseUp);
            // 
            // PointNumberUpDown
            // 
            this.PointNumberUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PointNumberUpDown.Location = new System.Drawing.Point(560, 165);
            this.PointNumberUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.PointNumberUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PointNumberUpDown.Name = "PointNumberUpDown";
            this.PointNumberUpDown.Size = new System.Drawing.Size(97, 21);
            this.PointNumberUpDown.TabIndex = 56;
            this.PointNumberUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SizeUpDown
            // 
            this.SizeUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SizeUpDown.Location = new System.Drawing.Point(668, 165);
            this.SizeUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.SizeUpDown.Name = "SizeUpDown";
            this.SizeUpDown.Size = new System.Drawing.Size(96, 21);
            this.SizeUpDown.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(559, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Кількість точок";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(668, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Розмір";
            // 
            // AdvectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 325);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SizeUpDown);
            this.Controls.Add(this.PointNumberUpDown);
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
            this.Controls.Add(this.StartModelingButton);
            this.Controls.Add(this.DrawPlane);
            this.Name = "AdvectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Адвекція рідини";
            this.SizeChanged += new System.EventHandler(this.AdvectionForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DrawPlane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointNumberUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeUpDown)).EndInit();
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
        private System.Windows.Forms.Button StartModelingButton;
        private System.Windows.Forms.PictureBox DrawPlane;
        private System.Windows.Forms.NumericUpDown PointNumberUpDown;
        private System.Windows.Forms.NumericUpDown SizeUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}