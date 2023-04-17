namespace ConfirmFlightGUI
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
            this.airlineTextBox = new System.Windows.Forms.TextBox();
            this.flightTextBox = new System.Windows.Forms.TextBox();
            this.rowTexBox = new System.Windows.Forms.TextBox();
            this.seatTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // airlineTextBox
            // 
            this.airlineTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.airlineTextBox.Location = new System.Drawing.Point(182, 41);
            this.airlineTextBox.Name = "airlineTextBox";
            this.airlineTextBox.Size = new System.Drawing.Size(100, 23);
            this.airlineTextBox.TabIndex = 0;
            this.airlineTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.airlineTextBox.TextChanged += new System.EventHandler(this.airlineTextBox_TextChanged);
            // 
            // flightTextBox
            // 
            this.flightTextBox.Location = new System.Drawing.Point(182, 70);
            this.flightTextBox.Name = "flightTextBox";
            this.flightTextBox.Size = new System.Drawing.Size(100, 23);
            this.flightTextBox.TabIndex = 1;
            this.flightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.flightTextBox.TextChanged += new System.EventHandler(this.flightTextBox_TextChanged);
            // 
            // rowTexBox
            // 
            this.rowTexBox.Location = new System.Drawing.Point(182, 99);
            this.rowTexBox.Name = "rowTexBox";
            this.rowTexBox.Size = new System.Drawing.Size(100, 23);
            this.rowTexBox.TabIndex = 2;
            this.rowTexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rowTexBox.TextChanged += new System.EventHandler(this.rowTexBox_TextChanged);
            // 
            // seatTextBox
            // 
            this.seatTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.seatTextBox.Location = new System.Drawing.Point(182, 128);
            this.seatTextBox.Name = "seatTextBox";
            this.seatTextBox.Size = new System.Drawing.Size(100, 23);
            this.seatTextBox.TabIndex = 3;
            this.seatTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.seatTextBox.TextChanged += new System.EventHandler(this.seatTextBox_TextChanged);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(48, 350);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(100, 38);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "&Confirm Flight";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(182, 350);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 38);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Airline Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(38, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Flight Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(38, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter Row Number";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(38, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter Seat Letter";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // displayLabel
            // 
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(48, 179);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(241, 138);
            this.displayLabel.TabIndex = 10;
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(331, 426);
            this.ControlBox = false;
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.seatTextBox);
            this.Controls.Add(this.rowTexBox);
            this.Controls.Add(this.flightTextBox);
            this.Controls.Add(this.airlineTextBox);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLIGHT CONFIRMATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox airlineTextBox;
        private System.Windows.Forms.TextBox flightTextBox;
        private System.Windows.Forms.TextBox rowTexBox;
        private System.Windows.Forms.TextBox seatTextBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label displayLabel;
    }
}

