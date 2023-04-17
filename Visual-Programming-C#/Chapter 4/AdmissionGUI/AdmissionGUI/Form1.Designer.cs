namespace AdmissionGUI
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
            this.gpaTextBox = new System.Windows.Forms.TextBox();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.applicationDisplayLabel = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gpaTextBox
            // 
            this.gpaTextBox.Location = new System.Drawing.Point(167, 46);
            this.gpaTextBox.Name = "gpaTextBox";
            this.gpaTextBox.Size = new System.Drawing.Size(68, 23);
            this.gpaTextBox.TabIndex = 0;
            this.gpaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gpaTextBox.TextChanged += new System.EventHandler(this.gpaTextBox_TextChanged);
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Location = new System.Drawing.Point(167, 94);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(68, 23);
            this.scoreTextBox.TabIndex = 1;
            this.scoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.scoreTextBox.TextChanged += new System.EventHandler(this.scoreTextBox_TextChanged);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(61, 46);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(68, 23);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "G P A";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(58, 94);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(71, 23);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Test Score";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // applicationDisplayLabel
            // 
            this.applicationDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.applicationDisplayLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationDisplayLabel.Location = new System.Drawing.Point(61, 138);
            this.applicationDisplayLabel.Name = "applicationDisplayLabel";
            this.applicationDisplayLabel.Size = new System.Drawing.Size(174, 48);
            this.applicationDisplayLabel.TabIndex = 4;
            this.applicationDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(61, 207);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(174, 37);
            this.checkButton.TabIndex = 5;
            this.checkButton.Text = "&Check for Acceptance";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(61, 250);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(174, 37);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.checkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(293, 333);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.applicationDisplayLabel);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.gpaTextBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMISSION VERIFICATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gpaTextBox;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label applicationDisplayLabel;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button exitButton;
    }
}

