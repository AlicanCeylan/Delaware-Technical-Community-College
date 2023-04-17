namespace DateGUI
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
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.todayDisplayLabel = new System.Windows.Forms.Label();
            this.tmrDisplayLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(49, 62);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(64, 23);
            this.monthTextBox.TabIndex = 0;
            this.monthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.monthTextBox.TextChanged += new System.EventHandler(this.monthTextBox_TextChanged);
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(142, 62);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(64, 23);
            this.dayTextBox.TabIndex = 1;
            this.dayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dayTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(235, 62);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(64, 23);
            this.yearTextBox.TabIndex = 2;
            this.yearTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yearTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(49, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Month";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(142, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Day";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(235, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // todayDisplayLabel
            // 
            this.todayDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.todayDisplayLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayDisplayLabel.Location = new System.Drawing.Point(49, 105);
            this.todayDisplayLabel.Name = "todayDisplayLabel";
            this.todayDisplayLabel.Size = new System.Drawing.Size(250, 29);
            this.todayDisplayLabel.TabIndex = 6;
            this.todayDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrDisplayLabel
            // 
            this.tmrDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tmrDisplayLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmrDisplayLabel.Location = new System.Drawing.Point(49, 161);
            this.tmrDisplayLabel.Name = "tmrDisplayLabel";
            this.tmrDisplayLabel.Size = new System.Drawing.Size(250, 29);
            this.tmrDisplayLabel.TabIndex = 7;
            this.tmrDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(186, 218);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(113, 38);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.displayButton.Location = new System.Drawing.Point(49, 218);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(113, 38);
            this.displayButton.TabIndex = 10;
            this.displayButton.Text = "&Display Dates";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.displayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(352, 302);
            this.ControlBox = false;
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tmrDisplayLabel);
            this.Controls.Add(this.todayDisplayLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label todayDisplayLabel;
        private System.Windows.Forms.Label tmrDisplayLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button displayButton;
    }
}

