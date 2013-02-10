namespace BirdCountForm
{
    partial class birdCountForm
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
            this.regionComboBox = new System.Windows.Forms.ComboBox();
            this.regionLabel = new System.Windows.Forms.Label();
            this.birdCountDatePicker = new System.Windows.Forms.DateTimePicker();
            this.birdCountDatePickerLabel = new System.Windows.Forms.Label();
            this.birderComboBox = new System.Windows.Forms.ComboBox();
            this.birderLabel = new System.Windows.Forms.Label();
            this.birdTypeComboBox = new System.Windows.Forms.ComboBox();
            this.birdTypeLabel = new System.Windows.Forms.Label();
            this.numOfBirdsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numOfBirdsLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.queryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numOfBirdsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // regionComboBox
            // 
            this.regionComboBox.FormattingEnabled = true;
            this.regionComboBox.Location = new System.Drawing.Point(50, 40);
            this.regionComboBox.Name = "regionComboBox";
            this.regionComboBox.Size = new System.Drawing.Size(121, 24);
            this.regionComboBox.TabIndex = 0;
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Location = new System.Drawing.Point(50, 13);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(57, 17);
            this.regionLabel.TabIndex = 1;
            this.regionLabel.Text = "Region:";
            // 
            // birdCountDatePicker
            // 
            this.birdCountDatePicker.Location = new System.Drawing.Point(50, 101);
            this.birdCountDatePicker.Name = "birdCountDatePicker";
            this.birdCountDatePicker.Size = new System.Drawing.Size(240, 22);
            this.birdCountDatePicker.TabIndex = 2;
            // 
            // birdCountDatePickerLabel
            // 
            this.birdCountDatePickerLabel.AutoSize = true;
            this.birdCountDatePickerLabel.Location = new System.Drawing.Point(50, 74);
            this.birdCountDatePickerLabel.Name = "birdCountDatePickerLabel";
            this.birdCountDatePickerLabel.Size = new System.Drawing.Size(99, 17);
            this.birdCountDatePickerLabel.TabIndex = 3;
            this.birdCountDatePickerLabel.Text = "Date of Count:";
            // 
            // birderComboBox
            // 
            this.birderComboBox.FormattingEnabled = true;
            this.birderComboBox.Location = new System.Drawing.Point(50, 160);
            this.birderComboBox.Name = "birderComboBox";
            this.birderComboBox.Size = new System.Drawing.Size(121, 24);
            this.birderComboBox.TabIndex = 4;
            // 
            // birderLabel
            // 
            this.birderLabel.AutoSize = true;
            this.birderLabel.Location = new System.Drawing.Point(50, 133);
            this.birderLabel.Name = "birderLabel";
            this.birderLabel.Size = new System.Drawing.Size(91, 17);
            this.birderLabel.TabIndex = 5;
            this.birderLabel.Text = "Birder Name:";
            // 
            // birdTypeComboBox
            // 
            this.birdTypeComboBox.FormattingEnabled = true;
            this.birdTypeComboBox.Location = new System.Drawing.Point(50, 221);
            this.birdTypeComboBox.Name = "birdTypeComboBox";
            this.birdTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.birdTypeComboBox.TabIndex = 6;
            // 
            // birdTypeLabel
            // 
            this.birdTypeLabel.AutoSize = true;
            this.birdTypeLabel.Location = new System.Drawing.Point(50, 194);
            this.birdTypeLabel.Name = "birdTypeLabel";
            this.birdTypeLabel.Size = new System.Drawing.Size(73, 17);
            this.birdTypeLabel.TabIndex = 7;
            this.birdTypeLabel.Text = "Bird Type:";
            // 
            // numOfBirdsNumericUpDown
            // 
            this.numOfBirdsNumericUpDown.Location = new System.Drawing.Point(50, 284);
            this.numOfBirdsNumericUpDown.Name = "numOfBirdsNumericUpDown";
            this.numOfBirdsNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.numOfBirdsNumericUpDown.TabIndex = 8;
            // 
            // numOfBirdsLabel
            // 
            this.numOfBirdsLabel.AutoSize = true;
            this.numOfBirdsLabel.Location = new System.Drawing.Point(50, 257);
            this.numOfBirdsLabel.Name = "numOfBirdsLabel";
            this.numOfBirdsLabel.Size = new System.Drawing.Size(114, 17);
            this.numOfBirdsLabel.TabIndex = 9;
            this.numOfBirdsLabel.Text = "Number of Birds:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(215, 270);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 36);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(317, 270);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(75, 36);
            this.queryButton.TabIndex = 11;
            this.queryButton.Text = "Query";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // birdCountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 336);
            this.Controls.Add(this.queryButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.numOfBirdsLabel);
            this.Controls.Add(this.numOfBirdsNumericUpDown);
            this.Controls.Add(this.birdTypeLabel);
            this.Controls.Add(this.birdTypeComboBox);
            this.Controls.Add(this.birderLabel);
            this.Controls.Add(this.birderComboBox);
            this.Controls.Add(this.birdCountDatePickerLabel);
            this.Controls.Add(this.birdCountDatePicker);
            this.Controls.Add(this.regionLabel);
            this.Controls.Add(this.regionComboBox);
            this.Name = "birdCountForm";
            this.Text = "Bird Count";
            this.Load += new System.EventHandler(this.birdCountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numOfBirdsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox regionComboBox;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.DateTimePicker birdCountDatePicker;
        private System.Windows.Forms.Label birdCountDatePickerLabel;
        private System.Windows.Forms.ComboBox birderComboBox;
        private System.Windows.Forms.Label birderLabel;
        private System.Windows.Forms.ComboBox birdTypeComboBox;
        private System.Windows.Forms.Label birdTypeLabel;
        private System.Windows.Forms.NumericUpDown numOfBirdsNumericUpDown;
        private System.Windows.Forms.Label numOfBirdsLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button queryButton;
    }
}

