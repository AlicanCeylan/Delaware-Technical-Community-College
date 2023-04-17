namespace MyTunesGUI
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
            this.musicListBox = new System.Windows.Forms.ListBox();
            this.displayLabel = new System.Windows.Forms.Label();
            this.exitButtom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase multiple songs by holding down the Ctrl key while making selections. Dow" +
    "nload cost is $0.99 per song.";
            // 
            // musicListBox
            // 
            this.musicListBox.FormattingEnabled = true;
            this.musicListBox.ItemHeight = 15;
            this.musicListBox.Items.AddRange(new object[] {
            "Thriller - Michael Jackson",
            "Rocket Man - Elton John",
            "Atomic Dog - George Clinton",
            "Highway to Hell - ACDC",
            "Bad Company - Bad Company",
            "Born in the USA - Bruce Springsteen",
            "God Blessed Texas - Diamond Rio",
            "Beast of Burden - Rolling Stones"});
            this.musicListBox.Location = new System.Drawing.Point(36, 111);
            this.musicListBox.Name = "musicListBox";
            this.musicListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.musicListBox.Size = new System.Drawing.Size(299, 124);
            this.musicListBox.TabIndex = 1;
            this.musicListBox.SelectedIndexChanged += new System.EventHandler(this.musicListBox_SelectedIndexChanged);
            // 
            // displayLabel
            // 
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(36, 262);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(300, 36);
            this.displayLabel.TabIndex = 2;
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButtom
            // 
            this.exitButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButtom.Location = new System.Drawing.Point(106, 318);
            this.exitButtom.Name = "exitButtom";
            this.exitButtom.Size = new System.Drawing.Size(163, 42);
            this.exitButtom.TabIndex = 3;
            this.exitButtom.Text = "&Exit Application";
            this.exitButtom.UseVisualStyleBackColor = true;
            this.exitButtom.Click += new System.EventHandler(this.exitButtom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButtom;
            this.ClientSize = new System.Drawing.Size(369, 417);
            this.ControlBox = false;
            this.Controls.Add(this.exitButtom);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.musicListBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MY TUNES DOWNLOAD APPLICATION";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox musicListBox;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Button exitButtom;
    }
}

