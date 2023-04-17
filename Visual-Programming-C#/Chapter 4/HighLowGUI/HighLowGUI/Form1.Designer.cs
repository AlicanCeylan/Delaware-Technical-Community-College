namespace HighLowGUI
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
            this.int1TextBox = new System.Windows.Forms.TextBox();
            this.int2TextBox = new System.Windows.Forms.TextBox();
            this.int3TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.highDisplayLabel = new System.Windows.Forms.Label();
            this.lowDisplayLabel = new System.Windows.Forms.Label();
            this.determineButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // int1TextBox
            // 
            this.int1TextBox.Location = new System.Drawing.Point(177, 61);
            this.int1TextBox.Name = "int1TextBox";
            this.int1TextBox.Size = new System.Drawing.Size(100, 23);
            this.int1TextBox.TabIndex = 0;
            this.int1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.int1TextBox.TextChanged += new System.EventHandler(this.int1TextBox_TextChanged);
            // 
            // int2TextBox
            // 
            this.int2TextBox.Location = new System.Drawing.Point(177, 99);
            this.int2TextBox.Name = "int2TextBox";
            this.int2TextBox.Size = new System.Drawing.Size(100, 23);
            this.int2TextBox.TabIndex = 1;
            this.int2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.int2TextBox.TextChanged += new System.EventHandler(this.int2TextBox_TextChanged);
            // 
            // int3TextBox
            // 
            this.int3TextBox.Location = new System.Drawing.Point(177, 137);
            this.int3TextBox.Name = "int3TextBox";
            this.int3TextBox.Size = new System.Drawing.Size(100, 23);
            this.int3TextBox.TabIndex = 2;
            this.int3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.int3TextBox.TextChanged += new System.EventHandler(this.int3TextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Integer One";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(22, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Integer Two";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Integer Three";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "High Number";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Low Number";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // highDisplayLabel
            // 
            this.highDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.highDisplayLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highDisplayLabel.Location = new System.Drawing.Point(177, 172);
            this.highDisplayLabel.Name = "highDisplayLabel";
            this.highDisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.highDisplayLabel.TabIndex = 8;
            this.highDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lowDisplayLabel
            // 
            this.lowDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lowDisplayLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowDisplayLabel.Location = new System.Drawing.Point(177, 211);
            this.lowDisplayLabel.Name = "lowDisplayLabel";
            this.lowDisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.lowDisplayLabel.TabIndex = 9;
            this.lowDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // determineButton
            // 
            this.determineButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.determineButton.Location = new System.Drawing.Point(42, 266);
            this.determineButton.Name = "determineButton";
            this.determineButton.Size = new System.Drawing.Size(97, 49);
            this.determineButton.TabIndex = 3;
            this.determineButton.Text = "&Determine High / Low";
            this.determineButton.UseVisualStyleBackColor = true;
            this.determineButton.Click += new System.EventHandler(this.determineButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(177, 266);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(97, 49);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.determineButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(343, 408);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.determineButton);
            this.Controls.Add(this.lowDisplayLabel);
            this.Controls.Add(this.highDisplayLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.int3TextBox);
            this.Controls.Add(this.int2TextBox);
            this.Controls.Add(this.int1TextBox);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HIGH AND LOW NUMBER FINDER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox int1TextBox;
        private System.Windows.Forms.TextBox int2TextBox;
        private System.Windows.Forms.TextBox int3TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label highDisplayLabel;
        private System.Windows.Forms.Label lowDisplayLabel;
        private System.Windows.Forms.Button determineButton;
        private System.Windows.Forms.Button exitButton;
    }
}

