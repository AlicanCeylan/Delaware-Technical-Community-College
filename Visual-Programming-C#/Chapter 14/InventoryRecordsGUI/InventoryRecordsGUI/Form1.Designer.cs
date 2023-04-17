namespace InventoryRecordsGUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.allButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.itemDscTextBox = new System.Windows.Forms.TextBox();
            this.itemNumTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(32, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Item Price";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Item Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Item Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(343, 203);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 27);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // allButton
            // 
            this.allButton.Location = new System.Drawing.Point(186, 203);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(112, 27);
            this.allButton.TabIndex = 15;
            this.allButton.Text = "&View All Items";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(36, 203);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(112, 27);
            this.selectButton.TabIndex = 14;
            this.selectButton.Text = "Select an &Item";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(318, 147);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(137, 27);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "&Save to File";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Location = new System.Drawing.Point(168, 147);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.Size = new System.Drawing.Size(116, 23);
            this.itemPriceTextBox.TabIndex = 12;
            // 
            // itemDscTextBox
            // 
            this.itemDscTextBox.Location = new System.Drawing.Point(168, 93);
            this.itemDscTextBox.Name = "itemDscTextBox";
            this.itemDscTextBox.Size = new System.Drawing.Size(287, 23);
            this.itemDscTextBox.TabIndex = 11;
            // 
            // itemNumTextBox
            // 
            this.itemNumTextBox.Location = new System.Drawing.Point(168, 37);
            this.itemNumTextBox.Name = "itemNumTextBox";
            this.itemNumTextBox.Size = new System.Drawing.Size(116, 23);
            this.itemNumTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(497, 287);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.allButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.itemPriceTextBox);
            this.Controls.Add(this.itemDscTextBox);
            this.Controls.Add(this.itemNumTextBox);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button allButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.TextBox itemDscTextBox;
        private System.Windows.Forms.TextBox itemNumTextBox;
    }
}

