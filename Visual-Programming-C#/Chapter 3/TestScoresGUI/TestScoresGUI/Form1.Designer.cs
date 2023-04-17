namespace TestScoresGUI
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
            this.findButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.avgDisplayLabel = new System.Windows.Forms.Label();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.test4TextBox = new System.Windows.Forms.TextBox();
            this.test5TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(48, 246);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(104, 35);
            this.findButton.TabIndex = 5;
            this.findButton.Text = "&Find Average";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(190, 246);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(104, 35);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Test Score 1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(45, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Test Score 2";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(45, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Test Score 3";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(45, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter Test Score 4";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(45, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Enter Test Score 5";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(45, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Average Test Score";
            // 
            // avgDisplayLabel
            // 
            this.avgDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.avgDisplayLabel.Location = new System.Drawing.Point(190, 197);
            this.avgDisplayLabel.Name = "avgDisplayLabel";
            this.avgDisplayLabel.Size = new System.Drawing.Size(104, 19);
            this.avgDisplayLabel.TabIndex = 8;
            this.avgDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // test1TextBox
            // 
            this.test1TextBox.Location = new System.Drawing.Point(190, 34);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(100, 23);
            this.test1TextBox.TabIndex = 0;
            this.test1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.test1TextBox.TextChanged += new System.EventHandler(this.test1TextBox_TextChanged);
            // 
            // test2TextBox
            // 
            this.test2TextBox.Location = new System.Drawing.Point(190, 65);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(100, 23);
            this.test2TextBox.TabIndex = 1;
            this.test2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.test2TextBox.TextChanged += new System.EventHandler(this.test2TextBox_TextChanged);
            // 
            // test3TextBox
            // 
            this.test3TextBox.Location = new System.Drawing.Point(190, 95);
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(100, 23);
            this.test3TextBox.TabIndex = 2;
            this.test3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.test3TextBox.TextChanged += new System.EventHandler(this.test3TextBox_TextChanged);
            // 
            // test4TextBox
            // 
            this.test4TextBox.Location = new System.Drawing.Point(190, 127);
            this.test4TextBox.Name = "test4TextBox";
            this.test4TextBox.Size = new System.Drawing.Size(100, 23);
            this.test4TextBox.TabIndex = 3;
            this.test4TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.test4TextBox.TextChanged += new System.EventHandler(this.test4TextBox_TextChanged);
            // 
            // test5TextBox
            // 
            this.test5TextBox.Location = new System.Drawing.Point(190, 164);
            this.test5TextBox.Name = "test5TextBox";
            this.test5TextBox.Size = new System.Drawing.Size(100, 23);
            this.test5TextBox.TabIndex = 4;
            this.test5TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.test5TextBox.TextChanged += new System.EventHandler(this.test5TextBox_TextChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.findButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(339, 366);
            this.ControlBox = false;
            this.Controls.Add(this.test5TextBox);
            this.Controls.Add(this.test4TextBox);
            this.Controls.Add(this.test3TextBox);
            this.Controls.Add(this.test2TextBox);
            this.Controls.Add(this.test1TextBox);
            this.Controls.Add(this.avgDisplayLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.findButton);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVERAGE TEST SCORE CALCULATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label avgDisplayLabel;
        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.TextBox test3TextBox;
        private System.Windows.Forms.TextBox test4TextBox;
        private System.Windows.Forms.TextBox test5TextBox;
    }
}

