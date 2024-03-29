﻿using MathNet.Numerics;
using System.Windows.Forms.DataVisualization.Charting;

namespace DictionaryQuestionApp.Forms.AnalysisForm
{
    partial class AnalysisForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            ChartArea chartArea1 = new ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label2 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            button1 = new Button();
            chart = new Chart();
            label27 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(251, 248, 241);
            label2.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(424, 528);
            label2.Name = "label2";
            label2.Size = new Size(254, 17);
            label2.TabIndex = 1;
            label2.Text = "Коефіцієнт рангової кореляції Спірмена";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(12, 317);
            label14.Name = "label14";
            label14.Size = new Size(135, 17);
            label14.TabIndex = 15;
            label14.Text = "Коефіцієнт Спірмена";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(12, 302);
            label15.Name = "label15";
            label15.Size = new Size(104, 17);
            label15.TabIndex = 14;
            label15.Text = "Медіана Кемеді";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(12, 269);
            label16.Name = "label16";
            label16.Size = new Size(71, 17);
            label16.TabIndex = 13;
            label16.Text = "Питання 3";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(12, 417);
            label17.Name = "label17";
            label17.Size = new Size(135, 17);
            label17.TabIndex = 18;
            label17.Text = "Коефіцієнт Спірмена";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(12, 402);
            label18.Name = "label18";
            label18.Size = new Size(104, 17);
            label18.TabIndex = 17;
            label18.Text = "Медіана Кемеді";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(12, 369);
            label19.Name = "label19";
            label19.Size = new Size(71, 17);
            label19.TabIndex = 16;
            label19.Text = "Питання 4";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(12, 140);
            label20.Name = "label20";
            label20.Size = new Size(135, 17);
            label20.TabIndex = 21;
            label20.Text = "Коефіцієнт Спірмена";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(12, 125);
            label21.Name = "label21";
            label21.Size = new Size(104, 17);
            label21.TabIndex = 20;
            label21.Text = "Медіана Кемеді";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(12, 92);
            label22.Name = "label22";
            label22.Size = new Size(71, 17);
            label22.TabIndex = 19;
            label22.Text = "Питання 1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 233);
            label5.Name = "label5";
            label5.Size = new Size(135, 17);
            label5.TabIndex = 27;
            label5.Text = "Коефіцієнт Спірмена";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 218);
            label6.Name = "label6";
            label6.Size = new Size(104, 17);
            label6.TabIndex = 26;
            label6.Text = "Медіана Кемеді";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 185);
            label7.Name = "label7";
            label7.Size = new Size(71, 17);
            label7.TabIndex = 25;
            label7.Text = "Питання 2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 508);
            label8.Name = "label8";
            label8.Size = new Size(135, 17);
            label8.TabIndex = 24;
            label8.Text = "Коефіцієнт Спірмена";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(12, 493);
            label9.Name = "label9";
            label9.Size = new Size(104, 17);
            label9.TabIndex = 23;
            label9.Text = "Медіана Кемеді";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(12, 460);
            label10.Name = "label10";
            label10.Size = new Size(71, 17);
            label10.TabIndex = 22;
            label10.Text = "Питання 5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(153, 125);
            label1.Name = "label1";
            label1.Size = new Size(28, 17);
            label1.TabIndex = 28;
            label1.Text = "null";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(153, 140);
            label3.Name = "label3";
            label3.Size = new Size(28, 17);
            label3.TabIndex = 29;
            label3.Text = "null";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(153, 233);
            label4.Name = "label4";
            label4.Size = new Size(28, 17);
            label4.TabIndex = 31;
            label4.Text = "null";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(153, 218);
            label11.Name = "label11";
            label11.Size = new Size(28, 17);
            label11.TabIndex = 30;
            label11.Text = "null";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(153, 317);
            label12.Name = "label12";
            label12.Size = new Size(28, 17);
            label12.TabIndex = 33;
            label12.Text = "null";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(153, 302);
            label13.Name = "label13";
            label13.Size = new Size(28, 17);
            label13.TabIndex = 32;
            label13.Text = "null";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(153, 417);
            label23.Name = "label23";
            label23.Size = new Size(28, 17);
            label23.TabIndex = 35;
            label23.Text = "null";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(153, 402);
            label24.Name = "label24";
            label24.Size = new Size(28, 17);
            label24.TabIndex = 34;
            label24.Text = "null";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(153, 508);
            label25.Name = "label25";
            label25.Size = new Size(28, 17);
            label25.TabIndex = 37;
            label25.Text = "null";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(153, 493);
            label26.Name = "label26";
            label26.Size = new Size(28, 17);
            label26.TabIndex = 36;
            label26.Text = "null";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(236, 205, 180);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(210, 574);
            button1.Name = "button1";
            button1.Size = new Size(379, 30);
            button1.TabIndex = 38;
            button1.Text = "Закрити";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // chart
            // 
            chartArea1.AxisY.Interval = 0.1D;
            chartArea1.AxisY.Maximum = 1D;
            chartArea1.AxisY.Minimum = -1D;
            chartArea1.Name = "RankingDifferences";
            chart.ChartAreas.Add(chartArea1);
            chart.Location = new Point(228, 92);
            chart.Name = "chart";
            series1.BorderWidth = 2;
            series1.ChartArea = "RankingDifferences";
            series1.ChartType = SeriesChartType.Line;
            series1.Color = Color.Blue;
            series1.Name = "Series1";
            chart.Series.Add(series1);
            chart.Size = new Size(602, 433);
            chart.TabIndex = 0;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(291, 34);
            label27.Name = "label27";
            label27.Size = new Size(221, 32);
            label27.TabIndex = 39;
            label27.Text = "Результати аналізу";
            // 
            // AnalysisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 248, 241);
            ClientSize = new Size(870, 626);
            Controls.Add(label27);
            Controls.Add(chart);
            Controls.Add(button1);
            Controls.Add(label25);
            Controls.Add(label26);
            Controls.Add(label23);
            Controls.Add(label24);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label4);
            Controls.Add(label11);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label2);
            Name = "AnalysisForm";
            Text = "AnalysisForm";
            Load += AnalysisForm_Load;
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Button button1;
        private Chart chart;
        private Label label27;
    }
}