namespace HurricaneGUI
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
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(133, 46);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(116, 23);
            this.speedTextBox.TabIndex = 0;
            this.speedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.speedTextBox.TextChanged += new System.EventHandler(this.speedTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(47, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wind Speed";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // displayLabel
            // 
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(50, 100);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(199, 28);
            this.displayLabel.TabIndex = 2;
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(50, 151);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(199, 40);
            this.findButton.TabIndex = 1;
            this.findButton.Text = "&Find Classification";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(50, 197);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(199, 40);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.findButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(296, 287);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speedTextBox);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HURRICANE CATEGORIES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button exitButton;
    }
}

