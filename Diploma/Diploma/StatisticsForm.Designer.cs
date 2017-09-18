using ZedGraph;
namespace Diploma
{
    partial class StatisticsForm
    {
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadStateButton = new System.Windows.Forms.Button();
            this.SaveStateButton = new System.Windows.Forms.Button();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.PauseModelingButton = new System.Windows.Forms.Button();
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
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.CalculationTimeTextBox = new System.Windows.Forms.TextBox();
            this.CalculationPeriodTextBox = new System.Windows.Forms.TextBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.CalculationLabel = new System.Windows.Forms.Label();
            this.CellNumberTextBox = new System.Windows.Forms.TextBox();
            this.CellNumberLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.DrawPlane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointNumberUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeUpDown)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(823, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Період";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(826, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "A";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(721, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "U";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(720, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "V";
            // 
            // LoadStateButton
            // 
            this.LoadStateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadStateButton.Location = new System.Drawing.Point(828, 294);
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
            this.SaveStateButton.Location = new System.Drawing.Point(723, 294);
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
            this.ClearAllButton.Location = new System.Drawing.Point(724, 265);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(203, 23);
            this.ClearAllButton.TabIndex = 47;
            this.ClearAllButton.Text = "Очистити все";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // PauseModelingButton
            // 
            this.PauseModelingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PauseModelingButton.Location = new System.Drawing.Point(828, 461);
            this.PauseModelingButton.Name = "PauseModelingButton";
            this.PauseModelingButton.Size = new System.Drawing.Size(100, 23);
            this.PauseModelingButton.TabIndex = 43;
            this.PauseModelingButton.Text = "Пауза";
            this.PauseModelingButton.UseVisualStyleBackColor = true;
            this.PauseModelingButton.Click += new System.EventHandler(this.Pause_Click);
            // 
            // PeriodTextBox
            // 
            this.PeriodTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PeriodTextBox.Location = new System.Drawing.Point(826, 28);
            this.PeriodTextBox.Name = "PeriodTextBox";
            this.PeriodTextBox.Size = new System.Drawing.Size(100, 21);
            this.PeriodTextBox.TabIndex = 38;
            this.PeriodTextBox.Text = "0.04";
            // 
            // StopModelingButton
            // 
            this.StopModelingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StopModelingButton.Location = new System.Drawing.Point(724, 461);
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
            this.RadiusTextBox.Location = new System.Drawing.Point(826, 68);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(100, 21);
            this.RadiusTextBox.TabIndex = 36;
            this.RadiusTextBox.Text = "100";
            this.RadiusTextBox.TextChanged += new System.EventHandler(this.Radius_TextChanged);
            // 
            // StraightSpeedTextBox
            // 
            this.StraightSpeedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StraightSpeedTextBox.Location = new System.Drawing.Point(720, 68);
            this.StraightSpeedTextBox.Name = "StraightSpeedTextBox";
            this.StraightSpeedTextBox.Size = new System.Drawing.Size(100, 21);
            this.StraightSpeedTextBox.TabIndex = 35;
            this.StraightSpeedTextBox.Text = "70";
            this.StraightSpeedTextBox.TextChanged += new System.EventHandler(this.StraightSpeed_TextChanged);
            // 
            // CircularSpeedTextBox
            // 
            this.CircularSpeedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CircularSpeedTextBox.Location = new System.Drawing.Point(720, 28);
            this.CircularSpeedTextBox.Name = "CircularSpeedTextBox";
            this.CircularSpeedTextBox.Size = new System.Drawing.Size(100, 21);
            this.CircularSpeedTextBox.TabIndex = 34;
            this.CircularSpeedTextBox.Text = "150";
            this.CircularSpeedTextBox.TextChanged += new System.EventHandler(this.CircularSpeed_TextChanged);
            // 
            // StartModelingButton
            // 
            this.StartModelingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartModelingButton.Location = new System.Drawing.Point(724, 432);
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
            this.DrawPlane.Size = new System.Drawing.Size(681, 434);
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
            this.PointNumberUpDown.Location = new System.Drawing.Point(724, 238);
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
            this.SizeUpDown.Location = new System.Drawing.Point(832, 238);
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
            this.label6.Location = new System.Drawing.Point(723, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Кількість точок";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(832, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Розмір";
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
            this.zedGraph.Size = new System.Drawing.Size(681, 434);
            this.zedGraph.TabIndex = 1;
            // 
            // CalculationTimeTextBox
            // 
            this.CalculationTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculationTimeTextBox.Location = new System.Drawing.Point(720, 108);
            this.CalculationTimeTextBox.Name = "CalculationTimeTextBox";
            this.CalculationTimeTextBox.Size = new System.Drawing.Size(99, 21);
            this.CalculationTimeTextBox.TabIndex = 60;
            this.CalculationTimeTextBox.Text = "400";
            // 
            // CalculationPeriodTextBox
            // 
            this.CalculationPeriodTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculationPeriodTextBox.Location = new System.Drawing.Point(826, 108);
            this.CalculationPeriodTextBox.Name = "CalculationPeriodTextBox";
            this.CalculationPeriodTextBox.Size = new System.Drawing.Size(100, 21);
            this.CalculationPeriodTextBox.TabIndex = 61;
            this.CalculationPeriodTextBox.Text = "1";
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(719, 92);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(82, 13);
            this.TimeLabel.TabIndex = 62;
            this.TimeLabel.Text = "Час виконання";
            // 
            // CalculationLabel
            // 
            this.CalculationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculationLabel.AutoSize = true;
            this.CalculationLabel.Location = new System.Drawing.Point(826, 92);
            this.CalculationLabel.Name = "CalculationLabel";
            this.CalculationLabel.Size = new System.Drawing.Size(75, 13);
            this.CalculationLabel.TabIndex = 63;
            this.CalculationLabel.Text = "Період заміру";
            // 
            // CellNumberTextBox
            // 
            this.CellNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CellNumberTextBox.Location = new System.Drawing.Point(720, 152);
            this.CellNumberTextBox.Name = "CellNumberTextBox";
            this.CellNumberTextBox.Size = new System.Drawing.Size(204, 21);
            this.CellNumberTextBox.TabIndex = 64;
            this.CellNumberTextBox.Text = "11";
            this.CellNumberTextBox.TextChanged += new System.EventHandler(this.CellNumberTextBox_TextChanged);
            // 
            // CellNumberLabel
            // 
            this.CellNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CellNumberLabel.AutoSize = true;
            this.CellNumberLabel.Location = new System.Drawing.Point(721, 133);
            this.CellNumberLabel.Name = "CellNumberLabel";
            this.CellNumberLabel.Size = new System.Drawing.Size(88, 13);
            this.CellNumberLabel.TabIndex = 65;
            this.CellNumberLabel.Text = "Ширина комірок";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(701, 472);
            this.tabControl1.TabIndex = 66;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DrawPlane);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(693, 446);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Адвекція";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.zedGraph);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(693, 446);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Графік";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 497);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CellNumberLabel);
            this.Controls.Add(this.CellNumberTextBox);
            this.Controls.Add(this.CalculationLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.CalculationPeriodTextBox);
            this.Controls.Add(this.CalculationTimeTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SizeUpDown);
            this.Controls.Add(this.PointNumberUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadStateButton);
            this.Controls.Add(this.SaveStateButton);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.PauseModelingButton);
            this.Controls.Add(this.PeriodTextBox);
            this.Controls.Add(this.StopModelingButton);
            this.Controls.Add(this.RadiusTextBox);
            this.Controls.Add(this.StraightSpeedTextBox);
            this.Controls.Add(this.CircularSpeedTextBox);
            this.Controls.Add(this.StartModelingButton);
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистичні дані";
            this.SizeChanged += new System.EventHandler(this.AdvectionForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DrawPlane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointNumberUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeUpDown)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadStateButton;
        private System.Windows.Forms.Button SaveStateButton;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.Button PauseModelingButton;
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
        private ZedGraphControl zedGraph;
        private System.Windows.Forms.TextBox CalculationTimeTextBox;
        private System.Windows.Forms.TextBox CalculationPeriodTextBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label CalculationLabel;
        private System.Windows.Forms.TextBox CellNumberTextBox;
        private System.Windows.Forms.Label CellNumberLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}