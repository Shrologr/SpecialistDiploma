namespace Diploma
{
    partial class LiapunovForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.LiapunovTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.XValueTextBox = new System.Windows.Forms.TextBox();
            this.YValueTextBox = new System.Windows.Forms.TextBox();
            this.NewPointButton = new System.Windows.Forms.Button();
            this.XLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DrawPlane)).BeginInit();
            this.LiapunovTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.DrawPlane.Location = new System.Drawing.Point(6, 6);
            this.DrawPlane.Name = "DrawPlane";
            this.DrawPlane.Size = new System.Drawing.Size(520, 263);
            this.DrawPlane.TabIndex = 32;
            this.DrawPlane.TabStop = false;
            this.DrawPlane.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPlane_Paint);
            this.DrawPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawPlane_MouseDown);
            this.DrawPlane.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawPlane_MouseMove);
            this.DrawPlane.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawPlane_MouseUp);
            // 
            // LiapunovTabControl
            // 
            this.LiapunovTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LiapunovTabControl.Controls.Add(this.tabPage1);
            this.LiapunovTabControl.Controls.Add(this.tabPage2);
            this.LiapunovTabControl.Location = new System.Drawing.Point(12, 12);
            this.LiapunovTabControl.Name = "LiapunovTabControl";
            this.LiapunovTabControl.SelectedIndex = 0;
            this.LiapunovTabControl.Size = new System.Drawing.Size(540, 301);
            this.LiapunovTabControl.TabIndex = 60;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DrawPlane);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(532, 275);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Маркери";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.zedGraph);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(532, 275);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Графік";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // zedGraph
            // 
            this.zedGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraph.Location = new System.Drawing.Point(6, 6);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(520, 263);
            this.zedGraph.TabIndex = 0;
            // 
            // XValueTextBox
            // 
            this.XValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XValueTextBox.Location = new System.Drawing.Point(557, 160);
            this.XValueTextBox.Name = "XValueTextBox";
            this.XValueTextBox.Size = new System.Drawing.Size(100, 21);
            this.XValueTextBox.TabIndex = 61;
            this.XValueTextBox.Text = "0";
            // 
            // YValueTextBox
            // 
            this.YValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.YValueTextBox.Location = new System.Drawing.Point(663, 159);
            this.YValueTextBox.Name = "YValueTextBox";
            this.YValueTextBox.Size = new System.Drawing.Size(100, 21);
            this.YValueTextBox.TabIndex = 62;
            this.YValueTextBox.Text = "0";
            // 
            // NewPointButton
            // 
            this.NewPointButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewPointButton.Location = new System.Drawing.Point(557, 188);
            this.NewPointButton.Name = "NewPointButton";
            this.NewPointButton.Size = new System.Drawing.Size(206, 23);
            this.NewPointButton.TabIndex = 63;
            this.NewPointButton.Text = "Змінити координати";
            this.NewPointButton.UseVisualStyleBackColor = true;
            this.NewPointButton.Click += new System.EventHandler(this.NewPointButton_Click);
            // 
            // XLabel
            // 
            this.XLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(557, 144);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(13, 13);
            this.XLabel.TabIndex = 64;
            this.XLabel.Text = "X";
            // 
            // YLabel
            // 
            this.YLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(663, 144);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(13, 13);
            this.YLabel.TabIndex = 65;
            this.YLabel.Text = "Y";
            // 
            // LiapunovForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 325);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.NewPointButton);
            this.Controls.Add(this.YValueTextBox);
            this.Controls.Add(this.XValueTextBox);
            this.Controls.Add(this.LiapunovTabControl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorChangeButton);
            this.Controls.Add(this.PauseModelingButton);
            this.Controls.Add(this.TimeStepTextBox);
            this.Controls.Add(this.PeriodTextBox);
            this.Controls.Add(this.StopModelingButton);
            this.Controls.Add(this.RadiusTextBox);
            this.Controls.Add(this.StraightSpeedTextBox);
            this.Controls.Add(this.CircularSpeedTextBox);
            this.Controls.Add(this.StartModelingButton);
            this.Name = "LiapunovForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Найбільший показник Ляпунова";
            this.SizeChanged += new System.EventHandler(this.AdvectionForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DrawPlane)).EndInit();
            this.LiapunovTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TabControl LiapunovTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.TextBox XValueTextBox;
        private System.Windows.Forms.TextBox YValueTextBox;
        private System.Windows.Forms.Button NewPointButton;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label YLabel;
    }
}