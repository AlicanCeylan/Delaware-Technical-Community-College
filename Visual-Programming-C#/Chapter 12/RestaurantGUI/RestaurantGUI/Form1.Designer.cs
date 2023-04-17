namespace RestaurantGUI
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
            this.appListBox = new System.Windows.Forms.ListBox();
            this.entreeListBox = new System.Windows.Forms.ListBox();
            this.dessertListBox = new System.Windows.Forms.ListBox();
            this.displayLabel = new System.Windows.Forms.Label();
            this.viewButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(107, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose one item from each category and click the View Cost button.";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(91, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Appetizers";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(279, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Entrees";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(433, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Desserts";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // appListBox
            // 
            this.appListBox.FormattingEnabled = true;
            this.appListBox.ItemHeight = 15;
            this.appListBox.Items.AddRange(new object[] {
            "Steak Fries & Cheese",
            "Shrimp Cocktail",
            "Stuffed Mushrooms"});
            this.appListBox.Location = new System.Drawing.Point(64, 101);
            this.appListBox.Name = "appListBox";
            this.appListBox.Size = new System.Drawing.Size(119, 49);
            this.appListBox.TabIndex = 0;
            // 
            // entreeListBox
            // 
            this.entreeListBox.FormattingEnabled = true;
            this.entreeListBox.ItemHeight = 15;
            this.entreeListBox.Items.AddRange(new object[] {
            "Lasagna with Meat Sauce ",
            "Linguini with Clam Sauce",
            "Spaghetti with Marinara Sauce \t"});
            this.entreeListBox.Location = new System.Drawing.Point(203, 101);
            this.entreeListBox.Name = "entreeListBox";
            this.entreeListBox.Size = new System.Drawing.Size(184, 49);
            this.entreeListBox.TabIndex = 1;
            // 
            // dessertListBox
            // 
            this.dessertListBox.FormattingEnabled = true;
            this.dessertListBox.ItemHeight = 15;
            this.dessertListBox.Items.AddRange(new object[] {
            "Cannoli",
            "Chocolate Truffle",
            "Tira Mi Su "});
            this.dessertListBox.Location = new System.Drawing.Point(407, 101);
            this.dessertListBox.Name = "dessertListBox";
            this.dessertListBox.Size = new System.Drawing.Size(103, 49);
            this.dessertListBox.TabIndex = 2;
            // 
            // displayLabel
            // 
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(64, 177);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(446, 29);
            this.displayLabel.TabIndex = 7;
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(64, 239);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(133, 37);
            this.viewButton.TabIndex = 3;
            this.viewButton.Text = "&View Cost";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(216, 239);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(133, 37);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "&Reset Interface";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(376, 239);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(133, 37);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.viewButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(574, 302);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.dessertListBox);
            this.Controls.Add(this.entreeListBox);
            this.Controls.Add(this.appListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox appListBox;
        private System.Windows.Forms.ListBox entreeListBox;
        private System.Windows.Forms.ListBox dessertListBox;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
    }
}

