namespace DiscountGUI
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
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.priceDisplayLabel = new System.Windows.Forms.Label();
            this.savingsDisplayLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(177, 49);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 23);
            this.priceTextBox.TabIndex = 0;
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // discountTextBox
            // 
            this.discountTextBox.Location = new System.Drawing.Point(177, 87);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(100, 23);
            this.discountTextBox.TabIndex = 1;
            this.discountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.discountTextBox.TextChanged += new System.EventHandler(this.discountTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(39, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Price";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(39, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Discount Rate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(39, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Discounted Price";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(39, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Savings Amount";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priceDisplayLabel
            // 
            this.priceDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.priceDisplayLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceDisplayLabel.Location = new System.Drawing.Point(177, 126);
            this.priceDisplayLabel.Name = "priceDisplayLabel";
            this.priceDisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.priceDisplayLabel.TabIndex = 6;
            this.priceDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // savingsDisplayLabel
            // 
            this.savingsDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.savingsDisplayLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingsDisplayLabel.Location = new System.Drawing.Point(177, 171);
            this.savingsDisplayLabel.Name = "savingsDisplayLabel";
            this.savingsDisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.savingsDisplayLabel.TabIndex = 7;
            this.savingsDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(42, 219);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(114, 43);
            this.calcButton.TabIndex = 8;
            this.calcButton.Text = "&Calculate Discount";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(177, 219);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(110, 43);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(327, 349);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.savingsDisplayLabel);
            this.Controls.Add(this.priceDisplayLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DISCOUNT / SAVINGS CALCULATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label priceDisplayLabel;
        private System.Windows.Forms.Label savingsDisplayLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button exitButton;
    }
}

