namespace Diploma
{
    partial class PoincareForm
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
            this.TimeStepTextBox = new System.Windows.Forms.TextBox();
            this.PeriodTextBox = new System.Windows.Forms.TextBox();
            this.RadiusTextBox = new System.Windows.Forms.TextBox();
            this.StraightSpeedTextBox = new System.Windows.Forms.TextBox();
            this.CircularSpeedTextBox = new System.Windows.Forms.TextBox();
            this.BuildPoincareButton = new System.Windows.Forms.Button();
            this.DrawPlane = new System.Windows.Forms.PictureBox();
            this.WorkingTimeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PoincareBuildBar = new System.Windows.Forms.ProgressBar();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.NewPointButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.YValueTextBox = new System.Windows.Forms.TextBox();
            this.XValueTextBox = new System.Windows.Forms.TextBox();
            this.ClearPoincareButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DrawPlane)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(673, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Dt";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(669, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Період";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "A";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "U";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "V";
            // 
            // LoadStateButton
            // 
            this.LoadStateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadStateButton.Location = new System.Drawing.Point(672, 296);
            this.LoadStateButton.Name = "LoadStateButton";
            this.LoadStateButton.Size = new System.Drawing.Size(99, 23);
            this.LoadStateButton.TabIndex = 69;
            this.LoadStateButton.Text = "Завантажити";
            this.LoadStateButton.UseVisualStyleBackColor = true;
            this.LoadStateButton.Click += new System.EventHandler(this.LoadState_Click);
            // 
            // SaveStateButton
            // 
            this.SaveStateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveStateButton.Location = new System.Drawing.Point(568, 296);
            this.SaveStateButton.Name = "SaveStateButton";
            this.SaveStateButton.Size = new System.Drawing.Size(98, 23);
            this.SaveStateButton.TabIndex = 68;
            this.SaveStateButton.Text = "Зберегти";
            this.SaveStateButton.UseVisualStyleBackColor = true;
            this.SaveStateButton.Click += new System.EventHandler(this.SaveState_Click);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearAllButton.Location = new System.Drawing.Point(568, 267);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(98, 23);
            this.ClearAllButton.TabIndex = 67;
            this.ClearAllButton.Text = "Очистити все";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // ColorChangeButton
            // 
            this.ColorChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorChangeButton.Location = new System.Drawing.Point(569, 238);
            this.ColorChangeButton.Name = "ColorChangeButton";
            this.ColorChangeButton.Size = new System.Drawing.Size(202, 23);
            this.ColorChangeButton.TabIndex = 66;
            this.ColorChangeButton.Text = "Змінити колір";
            this.ColorChangeButton.UseVisualStyleBackColor = true;
            this.ColorChangeButton.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // TimeStepTextBox
            // 
            this.TimeStepTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeStepTextBox.Location = new System.Drawing.Point(673, 62);
            this.TimeStepTextBox.Name = "TimeStepTextBox";
            this.TimeStepTextBox.Size = new System.Drawing.Size(100, 21);
            this.TimeStepTextBox.TabIndex = 64;
            this.TimeStepTextBox.Text = "0.01";
            // 
            // PeriodTextBox
            // 
            this.PeriodTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PeriodTextBox.Location = new System.Drawing.Point(672, 23);
            this.PeriodTextBox.Name = "PeriodTextBox";
            this.PeriodTextBox.Size = new System.Drawing.Size(100, 21);
            this.PeriodTextBox.TabIndex = 63;
            this.PeriodTextBox.Text = "0.04";
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RadiusTextBox.Location = new System.Drawing.Point(567, 105);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(100, 21);
            this.RadiusTextBox.TabIndex = 61;
            this.RadiusTextBox.Text = "100";
            this.RadiusTextBox.TextChanged += new System.EventHandler(this.Radius_TextChanged);
            // 
            // StraightSpeedTextBox
            // 
            this.StraightSpeedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StraightSpeedTextBox.Location = new System.Drawing.Point(566, 63);
            this.StraightSpeedTextBox.Name = "StraightSpeedTextBox";
            this.StraightSpeedTextBox.Size = new System.Drawing.Size(100, 21);
            this.StraightSpeedTextBox.TabIndex = 60;
            this.StraightSpeedTextBox.Text = "70";
            this.StraightSpeedTextBox.TextChanged += new System.EventHandler(this.StraightSpeed_TextChanged);
            // 
            // CircularSpeedTextBox
            // 
            this.CircularSpeedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CircularSpeedTextBox.Location = new System.Drawing.Point(566, 23);
            this.CircularSpeedTextBox.Name = "CircularSpeedTextBox";
            this.CircularSpeedTextBox.Size = new System.Drawing.Size(100, 21);
            this.CircularSpeedTextBox.TabIndex = 59;
            this.CircularSpeedTextBox.Text = "150";
            this.CircularSpeedTextBox.TextChanged += new System.EventHandler(this.CircularSpeed_TextChanged);
            // 
            // BuildPoincareButton
            // 
            this.BuildPoincareButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuildPoincareButton.Location = new System.Drawing.Point(567, 209);
            this.BuildPoincareButton.Name = "BuildPoincareButton";
            this.BuildPoincareButton.Size = new System.Drawing.Size(204, 23);
            this.BuildPoincareButton.TabIndex = 58;
            this.BuildPoincareButton.Text = "Побудувати перетин Пуанкаре";
            this.BuildPoincareButton.UseVisualStyleBackColor = true;
            this.BuildPoincareButton.Click += new System.EventHandler(this.BuildPoincareButton_Click);
            // 
            // DrawPlane
            // 
            this.DrawPlane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawPlane.Location = new System.Drawing.Point(8, 7);
            this.DrawPlane.Name = "DrawPlane";
            this.DrawPlane.Size = new System.Drawing.Size(552, 295);
            this.DrawPlane.TabIndex = 57;
            this.DrawPlane.TabStop = false;
            this.DrawPlane.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPlane_Paint);
            this.DrawPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawPlane_MouseDown);
            this.DrawPlane.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawPlane_MouseMove);
            this.DrawPlane.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawPlane_MouseUp);
            // 
            // WorkingTimeTextBox
            // 
            this.WorkingTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkingTimeTextBox.Location = new System.Drawing.Point(672, 105);
            this.WorkingTimeTextBox.Name = "WorkingTimeTextBox";
            this.WorkingTimeTextBox.Size = new System.Drawing.Size(99, 21);
            this.WorkingTimeTextBox.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(673, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Час виконання";
            // 
            // PoincareBuildBar
            // 
            this.PoincareBuildBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PoincareBuildBar.Location = new System.Drawing.Point(8, 327);
            this.PoincareBuildBar.Name = "PoincareBuildBar";
            this.PoincareBuildBar.Size = new System.Drawing.Size(763, 23);
            this.PoincareBuildBar.TabIndex = 77;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(11, 311);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(0, 13);
            this.ProgressLabel.TabIndex = 78;
            // 
            // NewPointButton
            // 
            this.NewPointButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewPointButton.Location = new System.Drawing.Point(567, 178);
            this.NewPointButton.Name = "NewPointButton";
            this.NewPointButton.Size = new System.Drawing.Size(205, 23);
            this.NewPointButton.TabIndex = 83;
            this.NewPointButton.Text = "Додати нову точку";
            this.NewPointButton.UseVisualStyleBackColor = true;
            this.NewPointButton.Click += new System.EventHandler(this.NewPointButton_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(672, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 82;
            this.label7.Text = "Y";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(567, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 81;
            this.label8.Text = "X";
            // 
            // YValueTextBox
            // 
            this.YValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.YValueTextBox.Location = new System.Drawing.Point(672, 154);
            this.YValueTextBox.Name = "YValueTextBox";
            this.YValueTextBox.Size = new System.Drawing.Size(100, 21);
            this.YValueTextBox.TabIndex = 80;
            // 
            // XValueTextBox
            // 
            this.XValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XValueTextBox.Location = new System.Drawing.Point(567, 154);
            this.XValueTextBox.Name = "XValueTextBox";
            this.XValueTextBox.Size = new System.Drawing.Size(100, 21);
            this.XValueTextBox.TabIndex = 79;
            // 
            // ClearPoincareButton
            // 
            this.ClearPoincareButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearPoincareButton.Location = new System.Drawing.Point(672, 267);
            this.ClearPoincareButton.Name = "ClearPoincareButton";
            this.ClearPoincareButton.Size = new System.Drawing.Size(98, 23);
            this.ClearPoincareButton.TabIndex = 84;
            this.ClearPoincareButton.Text = "Зняти перетин";
            this.ClearPoincareButton.UseVisualStyleBackColor = true;
            this.ClearPoincareButton.Click += new System.EventHandler(this.ClearPoincareButton_Click);
            // 
            // PoincareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.ClearPoincareButton);
            this.Controls.Add(this.NewPointButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.YValueTextBox);
            this.Controls.Add(this.XValueTextBox);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.PoincareBuildBar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.WorkingTimeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadStateButton);
            this.Controls.Add(this.SaveStateButton);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.ColorChangeButton);
            this.Controls.Add(this.TimeStepTextBox);
            this.Controls.Add(this.PeriodTextBox);
            this.Controls.Add(this.RadiusTextBox);
            this.Controls.Add(this.StraightSpeedTextBox);
            this.Controls.Add(this.CircularSpeedTextBox);
            this.Controls.Add(this.BuildPoincareButton);
            this.Controls.Add(this.DrawPlane);
            this.Name = "PoincareForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перетин Пуанкаре";
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
        private System.Windows.Forms.TextBox TimeStepTextBox;
        private System.Windows.Forms.TextBox PeriodTextBox;
        private System.Windows.Forms.TextBox RadiusTextBox;
        private System.Windows.Forms.TextBox StraightSpeedTextBox;
        private System.Windows.Forms.TextBox CircularSpeedTextBox;
        private System.Windows.Forms.Button BuildPoincareButton;
        private System.Windows.Forms.PictureBox DrawPlane;
        private System.Windows.Forms.TextBox WorkingTimeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar PoincareBuildBar;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.Button NewPointButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox YValueTextBox;
        private System.Windows.Forms.TextBox XValueTextBox;
        private System.Windows.Forms.Button ClearPoincareButton;
    }
}