namespace BinaryToDecimal
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
            this.convertButton = new System.Windows.Forms.Button();
            this.binaryText = new System.Windows.Forms.TextBox();
            this.decimalText = new System.Windows.Forms.TextBox();
            this.signedCheck = new System.Windows.Forms.CheckBox();
            this.binaryLabel = new System.Windows.Forms.Label();
            this.decimalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(79, 81);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // binaryText
            // 
            this.binaryText.Location = new System.Drawing.Point(54, 6);
            this.binaryText.MaxLength = 32;
            this.binaryText.Name = "binaryText";
            this.binaryText.Size = new System.Drawing.Size(189, 20);
            this.binaryText.TabIndex = 1;
            // 
            // decimalText
            // 
            this.decimalText.Location = new System.Drawing.Point(54, 55);
            this.decimalText.Name = "decimalText";
            this.decimalText.ReadOnly = true;
            this.decimalText.Size = new System.Drawing.Size(189, 20);
            this.decimalText.TabIndex = 2;
            // 
            // signedCheck
            // 
            this.signedCheck.AutoSize = true;
            this.signedCheck.Location = new System.Drawing.Point(54, 32);
            this.signedCheck.Name = "signedCheck";
            this.signedCheck.Size = new System.Drawing.Size(65, 17);
            this.signedCheck.TabIndex = 3;
            this.signedCheck.Text = "Signed?";
            this.signedCheck.UseVisualStyleBackColor = true;
            // 
            // binaryLabel
            // 
            this.binaryLabel.AutoSize = true;
            this.binaryLabel.Location = new System.Drawing.Point(12, 9);
            this.binaryLabel.Name = "binaryLabel";
            this.binaryLabel.Size = new System.Drawing.Size(36, 13);
            this.binaryLabel.TabIndex = 4;
            this.binaryLabel.Text = "Binary";
            // 
            // decimalLabel
            // 
            this.decimalLabel.AutoSize = true;
            this.decimalLabel.Location = new System.Drawing.Point(3, 58);
            this.decimalLabel.Name = "decimalLabel";
            this.decimalLabel.Size = new System.Drawing.Size(45, 13);
            this.decimalLabel.TabIndex = 5;
            this.decimalLabel.Text = "Decimal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 113);
            this.Controls.Add(this.decimalLabel);
            this.Controls.Add(this.binaryLabel);
            this.Controls.Add(this.signedCheck);
            this.Controls.Add(this.decimalText);
            this.Controls.Add(this.binaryText);
            this.Controls.Add(this.convertButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Binary Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox binaryText;
        private System.Windows.Forms.TextBox decimalText;
        private System.Windows.Forms.CheckBox signedCheck;
        private System.Windows.Forms.Label binaryLabel;
        private System.Windows.Forms.Label decimalLabel;
    }
}

