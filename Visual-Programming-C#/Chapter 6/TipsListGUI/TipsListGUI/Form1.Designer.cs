namespace TipsListGUI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.day1TextBox = new System.Windows.Forms.TextBox();
            this.day2TextBox = new System.Windows.Forms.TextBox();
            this.day3TextBox = new System.Windows.Forms.TextBox();
            this.day4TextBox = new System.Windows.Forms.TextBox();
            this.day5TextBox = new System.Windows.Forms.TextBox();
            this.day6TextBox = new System.Windows.Forms.TextBox();
            this.day7TextBox = new System.Windows.Forms.TextBox();
            this.dif1DisplayLabel = new System.Windows.Forms.Label();
            this.dif2DisplayLabel = new System.Windows.Forms.Label();
            this.dif3DisplayLabel = new System.Windows.Forms.Label();
            this.dif4DisplayLabel = new System.Windows.Forms.Label();
            this.dif5DisplayLabel = new System.Windows.Forms.Label();
            this.dif6DisplayLabel = new System.Windows.Forms.Label();
            this.dif7DisplayLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalDisplayLabel = new System.Windows.Forms.Label();
            this.avgDisplayLabel = new System.Windows.Forms.Label();
            this.processButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(50, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Day 1 Tips";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(50, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Day 4 Tips";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(50, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Day 7 Tips";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(50, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Day 6 Tips";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(50, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Day 5 Tips";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(50, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Day 3 Tips";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(50, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Day 2 Tips";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // day1TextBox
            // 
            this.day1TextBox.Location = new System.Drawing.Point(126, 49);
            this.day1TextBox.Name = "day1TextBox";
            this.day1TextBox.Size = new System.Drawing.Size(100, 23);
            this.day1TextBox.TabIndex = 0;
            this.day1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day1TextBox.TextChanged += new System.EventHandler(this.day1TextBox_TextChanged);
            // 
            // day2TextBox
            // 
            this.day2TextBox.Location = new System.Drawing.Point(126, 80);
            this.day2TextBox.Name = "day2TextBox";
            this.day2TextBox.Size = new System.Drawing.Size(100, 23);
            this.day2TextBox.TabIndex = 1;
            this.day2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day2TextBox.TextChanged += new System.EventHandler(this.day2TextBox_TextChanged);
            // 
            // day3TextBox
            // 
            this.day3TextBox.Location = new System.Drawing.Point(126, 111);
            this.day3TextBox.Name = "day3TextBox";
            this.day3TextBox.Size = new System.Drawing.Size(100, 23);
            this.day3TextBox.TabIndex = 2;
            this.day3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day3TextBox.TextChanged += new System.EventHandler(this.day3TextBox_TextChanged);
            // 
            // day4TextBox
            // 
            this.day4TextBox.Location = new System.Drawing.Point(126, 142);
            this.day4TextBox.Name = "day4TextBox";
            this.day4TextBox.Size = new System.Drawing.Size(100, 23);
            this.day4TextBox.TabIndex = 3;
            this.day4TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day4TextBox.TextChanged += new System.EventHandler(this.day4TextBox_TextChanged);
            // 
            // day5TextBox
            // 
            this.day5TextBox.Location = new System.Drawing.Point(126, 173);
            this.day5TextBox.Name = "day5TextBox";
            this.day5TextBox.Size = new System.Drawing.Size(100, 23);
            this.day5TextBox.TabIndex = 4;
            this.day5TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day5TextBox.TextChanged += new System.EventHandler(this.day5TextBox_TextChanged);
            // 
            // day6TextBox
            // 
            this.day6TextBox.Location = new System.Drawing.Point(126, 204);
            this.day6TextBox.Name = "day6TextBox";
            this.day6TextBox.Size = new System.Drawing.Size(100, 23);
            this.day6TextBox.TabIndex = 5;
            this.day6TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day6TextBox.TextChanged += new System.EventHandler(this.day6TextBox_TextChanged);
            // 
            // day7TextBox
            // 
            this.day7TextBox.Location = new System.Drawing.Point(126, 235);
            this.day7TextBox.Name = "day7TextBox";
            this.day7TextBox.Size = new System.Drawing.Size(100, 23);
            this.day7TextBox.TabIndex = 6;
            this.day7TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day7TextBox.TextChanged += new System.EventHandler(this.day7TextBox_TextChanged);
            // 
            // dif1DisplayLabel
            // 
            this.dif1DisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dif1DisplayLabel.Location = new System.Drawing.Point(232, 49);
            this.dif1DisplayLabel.Name = "dif1DisplayLabel";
            this.dif1DisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.dif1DisplayLabel.TabIndex = 14;
            this.dif1DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dif2DisplayLabel
            // 
            this.dif2DisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dif2DisplayLabel.Location = new System.Drawing.Point(232, 80);
            this.dif2DisplayLabel.Name = "dif2DisplayLabel";
            this.dif2DisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.dif2DisplayLabel.TabIndex = 15;
            this.dif2DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dif3DisplayLabel
            // 
            this.dif3DisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dif3DisplayLabel.Location = new System.Drawing.Point(232, 111);
            this.dif3DisplayLabel.Name = "dif3DisplayLabel";
            this.dif3DisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.dif3DisplayLabel.TabIndex = 16;
            this.dif3DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dif4DisplayLabel
            // 
            this.dif4DisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dif4DisplayLabel.Location = new System.Drawing.Point(232, 142);
            this.dif4DisplayLabel.Name = "dif4DisplayLabel";
            this.dif4DisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.dif4DisplayLabel.TabIndex = 17;
            this.dif4DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dif5DisplayLabel
            // 
            this.dif5DisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dif5DisplayLabel.Location = new System.Drawing.Point(232, 173);
            this.dif5DisplayLabel.Name = "dif5DisplayLabel";
            this.dif5DisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.dif5DisplayLabel.TabIndex = 18;
            this.dif5DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dif6DisplayLabel
            // 
            this.dif6DisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dif6DisplayLabel.Location = new System.Drawing.Point(232, 204);
            this.dif6DisplayLabel.Name = "dif6DisplayLabel";
            this.dif6DisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.dif6DisplayLabel.TabIndex = 19;
            this.dif6DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dif7DisplayLabel
            // 
            this.dif7DisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dif7DisplayLabel.Location = new System.Drawing.Point(232, 235);
            this.dif7DisplayLabel.Name = "dif7DisplayLabel";
            this.dif7DisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.dif7DisplayLabel.TabIndex = 20;
            this.dif7DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(60, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "Total Tips";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(194, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Average Tip";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalDisplayLabel
            // 
            this.totalDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalDisplayLabel.Location = new System.Drawing.Point(60, 289);
            this.totalDisplayLabel.Name = "totalDisplayLabel";
            this.totalDisplayLabel.Size = new System.Drawing.Size(128, 32);
            this.totalDisplayLabel.TabIndex = 23;
            this.totalDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avgDisplayLabel
            // 
            this.avgDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.avgDisplayLabel.Location = new System.Drawing.Point(194, 289);
            this.avgDisplayLabel.Name = "avgDisplayLabel";
            this.avgDisplayLabel.Size = new System.Drawing.Size(128, 32);
            this.avgDisplayLabel.TabIndex = 24;
            this.avgDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(38, 337);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(150, 34);
            this.processButton.TabIndex = 7;
            this.processButton.Text = "&Process and Calculate";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(194, 337);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 34);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.processButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(382, 409);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.avgDisplayLabel);
            this.Controls.Add(this.totalDisplayLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dif7DisplayLabel);
            this.Controls.Add(this.dif6DisplayLabel);
            this.Controls.Add(this.dif5DisplayLabel);
            this.Controls.Add(this.dif4DisplayLabel);
            this.Controls.Add(this.dif3DisplayLabel);
            this.Controls.Add(this.dif2DisplayLabel);
            this.Controls.Add(this.dif1DisplayLabel);
            this.Controls.Add(this.day7TextBox);
            this.Controls.Add(this.day6TextBox);
            this.Controls.Add(this.day5TextBox);
            this.Controls.Add(this.day4TextBox);
            this.Controls.Add(this.day3TextBox);
            this.Controls.Add(this.day2TextBox);
            this.Controls.Add(this.day1TextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIP COMPARISON CALCULATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox day1TextBox;
        private System.Windows.Forms.TextBox day2TextBox;
        private System.Windows.Forms.TextBox day3TextBox;
        private System.Windows.Forms.TextBox day4TextBox;
        private System.Windows.Forms.TextBox day5TextBox;
        private System.Windows.Forms.TextBox day6TextBox;
        private System.Windows.Forms.TextBox day7TextBox;
        private System.Windows.Forms.Label dif1DisplayLabel;
        private System.Windows.Forms.Label dif2DisplayLabel;
        private System.Windows.Forms.Label dif3DisplayLabel;
        private System.Windows.Forms.Label dif4DisplayLabel;
        private System.Windows.Forms.Label dif5DisplayLabel;
        private System.Windows.Forms.Label dif6DisplayLabel;
        private System.Windows.Forms.Label dif7DisplayLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label totalDisplayLabel;
        private System.Windows.Forms.Label avgDisplayLabel;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Button exitButton;
    }
}

