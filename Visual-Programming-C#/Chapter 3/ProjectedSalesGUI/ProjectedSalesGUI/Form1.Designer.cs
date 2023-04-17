namespace ProjectedSalesGUI
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
            this.projectSalesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.northTextBox = new System.Windows.Forms.TextBox();
            this.southTextBox = new System.Windows.Forms.TextBox();
            this.northDisplayLabel = new System.Windows.Forms.Label();
            this.southDisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(46, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Current North Division Sales";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(46, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Current South Division Sales";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(46, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Projected North Division Sales";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(46, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Projected South Division Sales";
            // 
            // projectSalesButton
            // 
            this.projectSalesButton.Location = new System.Drawing.Point(49, 221);
            this.projectSalesButton.Name = "projectSalesButton";
            this.projectSalesButton.Size = new System.Drawing.Size(143, 39);
            this.projectSalesButton.TabIndex = 2;
            this.projectSalesButton.Text = "&Find Projected Sales";
            this.projectSalesButton.UseVisualStyleBackColor = true;
            this.projectSalesButton.Click += new System.EventHandler(this.projectSalesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(241, 221);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(143, 39);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // northTextBox
            // 
            this.northTextBox.Location = new System.Drawing.Point(283, 41);
            this.northTextBox.Name = "northTextBox";
            this.northTextBox.Size = new System.Drawing.Size(93, 23);
            this.northTextBox.TabIndex = 0;
            this.northTextBox.TextChanged += new System.EventHandler(this.northTextBox_TextChanged);
            // 
            // southTextBox
            // 
            this.southTextBox.Location = new System.Drawing.Point(283, 80);
            this.southTextBox.Name = "southTextBox";
            this.southTextBox.Size = new System.Drawing.Size(93, 23);
            this.southTextBox.TabIndex = 1;
            this.southTextBox.TextChanged += new System.EventHandler(this.southTextBox_TextChanged);
            // 
            // northDisplayLabel
            // 
            this.northDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.northDisplayLabel.Location = new System.Drawing.Point(283, 124);
            this.northDisplayLabel.Name = "northDisplayLabel";
            this.northDisplayLabel.Size = new System.Drawing.Size(93, 23);
            this.northDisplayLabel.TabIndex = 8;
            // 
            // southDisplayLabel
            // 
            this.southDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.southDisplayLabel.Location = new System.Drawing.Point(283, 161);
            this.southDisplayLabel.Name = "southDisplayLabel";
            this.southDisplayLabel.Size = new System.Drawing.Size(93, 23);
            this.southDisplayLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AcceptButton = this.projectSalesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(430, 321);
            this.ControlBox = false;
            this.Controls.Add(this.southDisplayLabel);
            this.Controls.Add(this.northDisplayLabel);
            this.Controls.Add(this.southTextBox);
            this.Controls.Add(this.northTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.projectSalesButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CURRENT AND PROJECTED SALES CALCULATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button projectSalesButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox northTextBox;
        private System.Windows.Forms.TextBox southTextBox;
        private System.Windows.Forms.Label northDisplayLabel;
        private System.Windows.Forms.Label southDisplayLabel;
    }
}

