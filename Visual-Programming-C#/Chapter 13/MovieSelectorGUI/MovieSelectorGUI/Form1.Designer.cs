namespace MovieSelectorGUI
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
            this.movieListBox = new System.Windows.Forms.ListBox();
            this.timesDisplayLabel = new System.Windows.Forms.Label();
            this.movieLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // movieListBox
            // 
            this.movieListBox.FormattingEnabled = true;
            this.movieListBox.ItemHeight = 15;
            this.movieListBox.Items.AddRange(new object[] {
            "The Amazing Spider-Man",
            "The Other Woman",
            "Brick Mansions",
            "Heaven Is for Real",
            "Rio 2"});
            this.movieListBox.Location = new System.Drawing.Point(56, 45);
            this.movieListBox.Name = "movieListBox";
            this.movieListBox.Size = new System.Drawing.Size(156, 94);
            this.movieListBox.TabIndex = 0;
            this.movieListBox.SelectedIndexChanged += new System.EventHandler(this.movieListBox_SelectedIndexChanged);
            this.movieListBox.MouseLeave += new System.EventHandler(this.movieListBox_MouseLeave);
            this.movieListBox.MouseHover += new System.EventHandler(this.movieListBox_MouseHover);
            // 
            // timesDisplayLabel
            // 
            this.timesDisplayLabel.Enabled = false;
            this.timesDisplayLabel.Location = new System.Drawing.Point(246, 42);
            this.timesDisplayLabel.Name = "timesDisplayLabel";
            this.timesDisplayLabel.Size = new System.Drawing.Size(141, 94);
            this.timesDisplayLabel.TabIndex = 1;
            this.timesDisplayLabel.Text = "7:00 p.m. and 9:30 p.m.\r\n7:05 p.m. and 9:20 p.m.\r\n7:15 p.m. and 9:00 p.m.\r\n7:10 p" +
    ".m. and 9:05 p.m.\r\n7:00 p.m. and 9:30 p.m.\r\n";
            this.timesDisplayLabel.Visible = false;
            // 
            // movieLabel
            // 
            this.movieLabel.Location = new System.Drawing.Point(56, 22);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(156, 20);
            this.movieLabel.TabIndex = 2;
            this.movieLabel.Text = "Movies";
            this.movieLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // instructionLabel
            // 
            this.instructionLabel.Enabled = false;
            this.instructionLabel.ForeColor = System.Drawing.Color.Red;
            this.instructionLabel.Location = new System.Drawing.Point(59, 184);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(318, 20);
            this.instructionLabel.TabIndex = 4;
            this.instructionLabel.Text = "Select a movie by click on it.";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.instructionLabel.Visible = false;
            // 
            // displayLabel
            // 
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.displayLabel.Location = new System.Drawing.Point(59, 214);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(318, 32);
            this.displayLabel.TabIndex = 5;
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(159, 277);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(124, 32);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.Enabled = false;
            this.timeLabel.Location = new System.Drawing.Point(246, 22);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(131, 20);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Starting Times";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.timeLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(443, 389);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.movieLabel);
            this.Controls.Add(this.timesDisplayLabel);
            this.Controls.Add(this.movieListBox);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MOVIE SELECTOR";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox movieListBox;
        private System.Windows.Forms.Label timesDisplayLabel;
        private System.Windows.Forms.Label movieLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label timeLabel;
    }
}

