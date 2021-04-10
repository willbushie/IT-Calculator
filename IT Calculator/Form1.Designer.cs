
namespace IT_Calculator
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
            this.binaryArithmaticSectionLabel = new System.Windows.Forms.Label();
            this.binaryArith_LeftTextBox = new System.Windows.Forms.TextBox();
            this.operationComboBox = new System.Windows.Forms.ComboBox();
            this.binaryArithm_LeftTextBoxLabel = new System.Windows.Forms.Label();
            this.operationComboBoxLabel = new System.Windows.Forms.Label();
            this.binaryArith_RightTextBox = new System.Windows.Forms.TextBox();
            this.binaryArithm_RightTextBoxLabel = new System.Windows.Forms.Label();
            this.conversionSectionLabel = new System.Windows.Forms.Label();
            this.binaryArithm_AnswerTextBox = new System.Windows.Forms.TextBox();
            this.binaryArithm_OperationAnswerTextBoxLabel = new System.Windows.Forms.Label();
            this.binaryArithm_ProcessOperationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // binaryArithmaticSectionLabel
            // 
            this.binaryArithmaticSectionLabel.AutoSize = true;
            this.binaryArithmaticSectionLabel.Location = new System.Drawing.Point(14, 9);
            this.binaryArithmaticSectionLabel.Name = "binaryArithmaticSectionLabel";
            this.binaryArithmaticSectionLabel.Size = new System.Drawing.Size(85, 13);
            this.binaryArithmaticSectionLabel.TabIndex = 0;
            this.binaryArithmaticSectionLabel.Text = "Binary Arithmetic";
            // 
            // binaryArith_LeftTextBox
            // 
            this.binaryArith_LeftTextBox.Location = new System.Drawing.Point(17, 63);
            this.binaryArith_LeftTextBox.Name = "binaryArith_LeftTextBox";
            this.binaryArith_LeftTextBox.Size = new System.Drawing.Size(100, 20);
            this.binaryArith_LeftTextBox.TabIndex = 1;
            // 
            // operationComboBox
            // 
            this.operationComboBox.FormattingEnabled = true;
            this.operationComboBox.Items.AddRange(new object[] {
            "Addition",
            "Subtraction",
            "Multiplication",
            "Division"});
            this.operationComboBox.Location = new System.Drawing.Point(133, 63);
            this.operationComboBox.Name = "operationComboBox";
            this.operationComboBox.Size = new System.Drawing.Size(76, 21);
            this.operationComboBox.TabIndex = 2;
            // 
            // binaryArithm_LeftTextBoxLabel
            // 
            this.binaryArithm_LeftTextBoxLabel.AutoSize = true;
            this.binaryArithm_LeftTextBoxLabel.Location = new System.Drawing.Point(18, 47);
            this.binaryArithm_LeftTextBoxLabel.Name = "binaryArithm_LeftTextBoxLabel";
            this.binaryArithm_LeftTextBoxLabel.Size = new System.Drawing.Size(98, 13);
            this.binaryArithm_LeftTextBoxLabel.TabIndex = 3;
            this.binaryArithm_LeftTextBoxLabel.Text = "First Binary Number";
            // 
            // operationComboBoxLabel
            // 
            this.operationComboBoxLabel.AutoSize = true;
            this.operationComboBoxLabel.Location = new System.Drawing.Point(145, 47);
            this.operationComboBoxLabel.Name = "operationComboBoxLabel";
            this.operationComboBoxLabel.Size = new System.Drawing.Size(53, 13);
            this.operationComboBoxLabel.TabIndex = 4;
            this.operationComboBoxLabel.Text = "Operation";
            // 
            // binaryArith_RightTextBox
            // 
            this.binaryArith_RightTextBox.Location = new System.Drawing.Point(228, 63);
            this.binaryArith_RightTextBox.Name = "binaryArith_RightTextBox";
            this.binaryArith_RightTextBox.Size = new System.Drawing.Size(100, 20);
            this.binaryArith_RightTextBox.TabIndex = 5;
            // 
            // binaryArithm_RightTextBoxLabel
            // 
            this.binaryArithm_RightTextBoxLabel.AutoSize = true;
            this.binaryArithm_RightTextBoxLabel.Location = new System.Drawing.Point(220, 47);
            this.binaryArithm_RightTextBoxLabel.Name = "binaryArithm_RightTextBoxLabel";
            this.binaryArithm_RightTextBoxLabel.Size = new System.Drawing.Size(116, 13);
            this.binaryArithm_RightTextBoxLabel.TabIndex = 6;
            this.binaryArithm_RightTextBoxLabel.Text = "Second Binary Number";
            // 
            // conversionSectionLabel
            // 
            this.conversionSectionLabel.AutoSize = true;
            this.conversionSectionLabel.Location = new System.Drawing.Point(17, 150);
            this.conversionSectionLabel.Name = "conversionSectionLabel";
            this.conversionSectionLabel.Size = new System.Drawing.Size(65, 13);
            this.conversionSectionLabel.TabIndex = 7;
            this.conversionSectionLabel.Text = "Conversions";
            // 
            // binaryArithm_AnswerTextBox
            // 
            this.binaryArithm_AnswerTextBox.Location = new System.Drawing.Point(228, 109);
            this.binaryArithm_AnswerTextBox.Name = "binaryArithm_AnswerTextBox";
            this.binaryArithm_AnswerTextBox.Size = new System.Drawing.Size(100, 20);
            this.binaryArithm_AnswerTextBox.TabIndex = 8;
            // 
            // binaryArithm_OperationAnswerTextBoxLabel
            // 
            this.binaryArithm_OperationAnswerTextBoxLabel.AutoSize = true;
            this.binaryArithm_OperationAnswerTextBoxLabel.Location = new System.Drawing.Point(256, 93);
            this.binaryArithm_OperationAnswerTextBoxLabel.Name = "binaryArithm_OperationAnswerTextBoxLabel";
            this.binaryArithm_OperationAnswerTextBoxLabel.Size = new System.Drawing.Size(45, 13);
            this.binaryArithm_OperationAnswerTextBoxLabel.TabIndex = 9;
            this.binaryArithm_OperationAnswerTextBoxLabel.Text = "Answer:";
            // 
            // binaryArithm_ProcessOperationButton
            // 
            this.binaryArithm_ProcessOperationButton.Location = new System.Drawing.Point(133, 107);
            this.binaryArithm_ProcessOperationButton.Name = "binaryArithm_ProcessOperationButton";
            this.binaryArithm_ProcessOperationButton.Size = new System.Drawing.Size(75, 23);
            this.binaryArithm_ProcessOperationButton.TabIndex = 10;
            this.binaryArithm_ProcessOperationButton.Text = "Equals";
            this.binaryArithm_ProcessOperationButton.UseVisualStyleBackColor = true;
            this.binaryArithm_ProcessOperationButton.Click += new System.EventHandler(this.binaryArithm_ProcessOperationButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.binaryArithm_ProcessOperationButton);
            this.Controls.Add(this.binaryArithm_OperationAnswerTextBoxLabel);
            this.Controls.Add(this.binaryArithm_AnswerTextBox);
            this.Controls.Add(this.conversionSectionLabel);
            this.Controls.Add(this.binaryArithm_RightTextBoxLabel);
            this.Controls.Add(this.binaryArith_RightTextBox);
            this.Controls.Add(this.operationComboBoxLabel);
            this.Controls.Add(this.binaryArithm_LeftTextBoxLabel);
            this.Controls.Add(this.operationComboBox);
            this.Controls.Add(this.binaryArith_LeftTextBox);
            this.Controls.Add(this.binaryArithmaticSectionLabel);
            this.Name = "Form1";
            this.Text = "IT Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label binaryArithmaticSectionLabel;
        private System.Windows.Forms.TextBox binaryArith_LeftTextBox;
        private System.Windows.Forms.ComboBox operationComboBox;
        private System.Windows.Forms.Label binaryArithm_LeftTextBoxLabel;
        private System.Windows.Forms.Label operationComboBoxLabel;
        private System.Windows.Forms.TextBox binaryArith_RightTextBox;
        private System.Windows.Forms.Label binaryArithm_RightTextBoxLabel;
        private System.Windows.Forms.Label conversionSectionLabel;
        private System.Windows.Forms.TextBox binaryArithm_AnswerTextBox;
        private System.Windows.Forms.Label binaryArithm_OperationAnswerTextBoxLabel;
        private System.Windows.Forms.Button binaryArithm_ProcessOperationButton;
    }
}

