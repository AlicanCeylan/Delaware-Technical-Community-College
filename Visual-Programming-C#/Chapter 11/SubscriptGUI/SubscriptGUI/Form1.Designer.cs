namespace SubscriptGUI
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
            this.subTextBox = new System.Windows.Forms.TextBox();
            this.displayLabel = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(56, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Array Subscript to Find Its Value (Valid Subscripts 0 to 9)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subTextBox
            // 
            this.subTextBox.Location = new System.Drawing.Point(59, 93);
            this.subTextBox.Name = "subTextBox";
            this.subTextBox.Size = new System.Drawing.Size(84, 23);
            this.subTextBox.TabIndex = 0;
            this.subTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.subTextBox.TextChanged += new System.EventHandler(this.subTextBox_TextChanged);
            // 
            // displayLabel
            // 
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(191, 93);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(84, 23);
            this.displayLabel.TabIndex = 2;
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // findButton
            // 
            this.findButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.findButton.Location = new System.Drawing.Point(59, 140);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(84, 40);
            this.findButton.TabIndex = 1;
            this.findButton.Text = "&Find Value";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(191, 140);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(84, 40);
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
            this.ClientSize = new System.Drawing.Size(331, 216);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.subTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARRAY SUBSCRIPT VALIDATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subTextBox;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button exitButton;
    }
}

