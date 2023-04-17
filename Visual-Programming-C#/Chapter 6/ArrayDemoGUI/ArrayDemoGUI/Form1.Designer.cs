namespace ArrayDemoGUI
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
            this.intTextBox = new System.Windows.Forms.TextBox();
            this.writeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.entryDisplayLabel = new System.Windows.Forms.Label();
            this.revDisplayOrder = new System.Windows.Forms.Label();
            this.sortedDisplayLabel = new System.Windows.Forms.Label();
            this.entryOrderButton = new System.Windows.Forms.Button();
            this.revButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(91, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter 10 Integer Values";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // intTextBox
            // 
            this.intTextBox.Location = new System.Drawing.Point(232, 54);
            this.intTextBox.Name = "intTextBox";
            this.intTextBox.Size = new System.Drawing.Size(96, 23);
            this.intTextBox.TabIndex = 0;
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(344, 53);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(110, 23);
            this.writeButton.TabIndex = 1;
            this.writeButton.Text = "&Write to Array";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(91, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Entry Order";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(363, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sorted Order";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(229, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Reverse Order";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // entryDisplayLabel
            // 
            this.entryDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.entryDisplayLabel.Location = new System.Drawing.Point(91, 132);
            this.entryDisplayLabel.Name = "entryDisplayLabel";
            this.entryDisplayLabel.Size = new System.Drawing.Size(91, 159);
            this.entryDisplayLabel.TabIndex = 6;
            this.entryDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // revDisplayOrder
            // 
            this.revDisplayOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.revDisplayOrder.Location = new System.Drawing.Point(227, 132);
            this.revDisplayOrder.Name = "revDisplayOrder";
            this.revDisplayOrder.Size = new System.Drawing.Size(91, 159);
            this.revDisplayOrder.TabIndex = 7;
            this.revDisplayOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sortedDisplayLabel
            // 
            this.sortedDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sortedDisplayLabel.Location = new System.Drawing.Point(363, 132);
            this.sortedDisplayLabel.Name = "sortedDisplayLabel";
            this.sortedDisplayLabel.Size = new System.Drawing.Size(91, 159);
            this.sortedDisplayLabel.TabIndex = 8;
            this.sortedDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // entryOrderButton
            // 
            this.entryOrderButton.Location = new System.Drawing.Point(90, 309);
            this.entryOrderButton.Name = "entryOrderButton";
            this.entryOrderButton.Size = new System.Drawing.Size(91, 46);
            this.entryOrderButton.TabIndex = 2;
            this.entryOrderButton.Text = "View &Entry Order";
            this.entryOrderButton.UseVisualStyleBackColor = true;
            this.entryOrderButton.Click += new System.EventHandler(this.entryOrderButton_Click);
            // 
            // revButton
            // 
            this.revButton.Location = new System.Drawing.Point(227, 309);
            this.revButton.Name = "revButton";
            this.revButton.Size = new System.Drawing.Size(91, 46);
            this.revButton.TabIndex = 3;
            this.revButton.Text = "View &Reverse Order";
            this.revButton.UseVisualStyleBackColor = true;
            this.revButton.Click += new System.EventHandler(this.revButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(356, 309);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(89, 46);
            this.sortButton.TabIndex = 4;
            this.sortButton.Text = "View &Sorted Order";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(180, 385);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(172, 45);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.writeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(527, 496);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.revButton);
            this.Controls.Add(this.entryOrderButton);
            this.Controls.Add(this.sortedDisplayLabel);
            this.Controls.Add(this.revDisplayOrder);
            this.Controls.Add(this.entryDisplayLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.intTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARRAY ORDER / SEARCH APPLICATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox intTextBox;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label entryDisplayLabel;
        private System.Windows.Forms.Label revDisplayOrder;
        private System.Windows.Forms.Label sortedDisplayLabel;
        private System.Windows.Forms.Button entryOrderButton;
        private System.Windows.Forms.Button revButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button exitButton;
    }
}

