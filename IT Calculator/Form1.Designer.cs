﻿
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
            this.components = new System.ComponentModel.Container();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.possibleConversionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commonErrorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutITCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileWriteTestButton = new System.Windows.Forms.Button();
            this.correctInputFormatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // binaryArithmaticSectionLabel
            // 
            this.binaryArithmaticSectionLabel.AutoSize = true;
            this.binaryArithmaticSectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryArithmaticSectionLabel.Location = new System.Drawing.Point(476, 9);
            this.binaryArithmaticSectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.binaryArithmaticSectionLabel.Name = "binaryArithmaticSectionLabel";
            this.binaryArithmaticSectionLabel.Size = new System.Drawing.Size(178, 26);
            this.binaryArithmaticSectionLabel.TabIndex = 0;
            this.binaryArithmaticSectionLabel.Text = "Binary Arithmetic";
            // 
            // binaryArith_LeftTextBox
            // 
            this.binaryArith_LeftTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryArith_LeftTextBox.Location = new System.Drawing.Point(285, 97);
            this.binaryArith_LeftTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.binaryArith_LeftTextBox.Name = "binaryArith_LeftTextBox";
            this.binaryArith_LeftTextBox.Size = new System.Drawing.Size(148, 30);
            this.binaryArith_LeftTextBox.TabIndex = 1;
            // 
            // operationComboBox
            // 
            this.operationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationComboBox.FormattingEnabled = true;
            this.operationComboBox.Items.AddRange(new object[] {
            "Addition",
            "Subtraction",
            "Multiplication"});
            this.operationComboBox.Location = new System.Drawing.Point(490, 94);
            this.operationComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.operationComboBox.Name = "operationComboBox";
            this.operationComboBox.Size = new System.Drawing.Size(152, 33);
            this.operationComboBox.TabIndex = 2;
            // 
            // binaryArithm_LeftTextBoxLabel
            // 
            this.binaryArithm_LeftTextBoxLabel.AutoSize = true;
            this.binaryArithm_LeftTextBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryArithm_LeftTextBoxLabel.Location = new System.Drawing.Point(270, 57);
            this.binaryArithm_LeftTextBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.binaryArithm_LeftTextBoxLabel.Name = "binaryArithm_LeftTextBoxLabel";
            this.binaryArithm_LeftTextBoxLabel.Size = new System.Drawing.Size(183, 25);
            this.binaryArithm_LeftTextBoxLabel.TabIndex = 3;
            this.binaryArithm_LeftTextBoxLabel.Text = "First Binary Number";
            // 
            // operationComboBoxLabel
            // 
            this.operationComboBoxLabel.AutoSize = true;
            this.operationComboBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationComboBoxLabel.Location = new System.Drawing.Point(514, 57);
            this.operationComboBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.operationComboBoxLabel.Name = "operationComboBoxLabel";
            this.operationComboBoxLabel.Size = new System.Drawing.Size(98, 25);
            this.operationComboBoxLabel.TabIndex = 4;
            this.operationComboBoxLabel.Text = "Operation";
            // 
            // binaryArith_RightTextBox
            // 
            this.binaryArith_RightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryArith_RightTextBox.Location = new System.Drawing.Point(692, 97);
            this.binaryArith_RightTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.binaryArith_RightTextBox.Name = "binaryArith_RightTextBox";
            this.binaryArith_RightTextBox.Size = new System.Drawing.Size(148, 30);
            this.binaryArith_RightTextBox.TabIndex = 5;
            // 
            // binaryArithm_RightTextBoxLabel
            // 
            this.binaryArithm_RightTextBoxLabel.AutoSize = true;
            this.binaryArithm_RightTextBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryArithm_RightTextBoxLabel.Location = new System.Drawing.Point(658, 57);
            this.binaryArithm_RightTextBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.binaryArithm_RightTextBoxLabel.Name = "binaryArithm_RightTextBoxLabel";
            this.binaryArithm_RightTextBoxLabel.Size = new System.Drawing.Size(214, 25);
            this.binaryArithm_RightTextBoxLabel.TabIndex = 6;
            this.binaryArithm_RightTextBoxLabel.Text = "Second Binary Number";
            // 
            // conversionSectionLabel
            // 
            this.conversionSectionLabel.AutoSize = true;
            this.conversionSectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionSectionLabel.Location = new System.Drawing.Point(500, 378);
            this.conversionSectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conversionSectionLabel.Name = "conversionSectionLabel";
            this.conversionSectionLabel.Size = new System.Drawing.Size(133, 26);
            this.conversionSectionLabel.TabIndex = 7;
            this.conversionSectionLabel.Text = "Conversions";
            // 
            // binaryArithm_AnswerTextBox
            // 
            this.binaryArithm_AnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryArithm_AnswerTextBox.Location = new System.Drawing.Point(460, 237);
            this.binaryArithm_AnswerTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.binaryArithm_AnswerTextBox.Name = "binaryArithm_AnswerTextBox";
            this.binaryArithm_AnswerTextBox.Size = new System.Drawing.Size(228, 30);
            this.binaryArithm_AnswerTextBox.TabIndex = 8;
            // 
            // binaryArithm_OperationAnswerTextBoxLabel
            // 
            this.binaryArithm_OperationAnswerTextBoxLabel.AutoSize = true;
            this.binaryArithm_OperationAnswerTextBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryArithm_OperationAnswerTextBoxLabel.Location = new System.Drawing.Point(530, 206);
            this.binaryArithm_OperationAnswerTextBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.binaryArithm_OperationAnswerTextBoxLabel.Name = "binaryArithm_OperationAnswerTextBoxLabel";
            this.binaryArithm_OperationAnswerTextBoxLabel.Size = new System.Drawing.Size(84, 25);
            this.binaryArithm_OperationAnswerTextBoxLabel.TabIndex = 9;
            this.binaryArithm_OperationAnswerTextBoxLabel.Text = "Answer:";
            // 
            // binaryArithm_ProcessOperationButton
            // 
            this.binaryArithm_ProcessOperationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryArithm_ProcessOperationButton.Location = new System.Drawing.Point(512, 149);
            this.binaryArithm_ProcessOperationButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.binaryArithm_ProcessOperationButton.Name = "binaryArithm_ProcessOperationButton";
            this.binaryArithm_ProcessOperationButton.Size = new System.Drawing.Size(112, 46);
            this.binaryArithm_ProcessOperationButton.TabIndex = 10;
            this.binaryArithm_ProcessOperationButton.Text = "Equals";
            this.binaryArithm_ProcessOperationButton.UseVisualStyleBackColor = true;
            this.binaryArithm_ProcessOperationButton.Click += new System.EventHandler(this.binaryArithm_ProcessOperationButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 345);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1212, 5);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(460, 454);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 30);
            this.textBox1.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Binary",
            "Decimal",
            "Hexadecimal",
            "IP Address",
            "Mac Address"});
            this.comboBox1.Location = new System.Drawing.Point(726, 451);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 33);
            this.comboBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.AcceptsTab = true;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(417, 622);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(316, 149);
            this.textBox2.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(512, 518);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 42);
            this.button1.TabIndex = 16;
            this.button1.Text = "Equals";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 414);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(780, 414);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Output Base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(530, 591);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Answer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Input Base";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Binary",
            "Decimal",
            "Hexadecimal",
            "IP Address",
            "Mac Address"});
            this.comboBox2.Location = new System.Drawing.Point(188, 451);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(236, 33);
            this.comboBox2.TabIndex = 21;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 36);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(121, 32);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1152, 33);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGuideToolStripMenuItem,
            this.correctInputFormatsToolStripMenuItem,
            this.possibleConversionsToolStripMenuItem,
            this.commonErrorsToolStripMenuItem,
            this.aboutITCalculatorToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // userGuideToolStripMenuItem
            // 
            this.userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            this.userGuideToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.userGuideToolStripMenuItem.Text = "User Guide";
            this.userGuideToolStripMenuItem.Click += new System.EventHandler(this.userGuideToolStripMenuItem_Click);
            // 
            // possibleConversionsToolStripMenuItem
            // 
            this.possibleConversionsToolStripMenuItem.Name = "possibleConversionsToolStripMenuItem";
            this.possibleConversionsToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.possibleConversionsToolStripMenuItem.Text = "Possible Conversions";
            this.possibleConversionsToolStripMenuItem.Click += new System.EventHandler(this.possibleConversionsToolStripMenuItem_Click);
            // 
            // commonErrorsToolStripMenuItem
            // 
            this.commonErrorsToolStripMenuItem.Name = "commonErrorsToolStripMenuItem";
            this.commonErrorsToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.commonErrorsToolStripMenuItem.Text = "Common Errors";
            this.commonErrorsToolStripMenuItem.Click += new System.EventHandler(this.commonErrorsToolStripMenuItem_Click);
            // 
            // aboutITCalculatorToolStripMenuItem
            // 
            this.aboutITCalculatorToolStripMenuItem.Name = "aboutITCalculatorToolStripMenuItem";
            this.aboutITCalculatorToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.aboutITCalculatorToolStripMenuItem.Text = "About IT-Calculator";
            this.aboutITCalculatorToolStripMenuItem.Click += new System.EventHandler(this.aboutITCalculatorToolStripMenuItem_Click);
            // 
            // fileWriteTestButton
            // 
            this.fileWriteTestButton.Location = new System.Drawing.Point(32, 160);
            this.fileWriteTestButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fileWriteTestButton.Name = "fileWriteTestButton";
            this.fileWriteTestButton.Size = new System.Drawing.Size(170, 35);
            this.fileWriteTestButton.TabIndex = 26;
            this.fileWriteTestButton.Text = "file write test button";
            this.fileWriteTestButton.UseVisualStyleBackColor = true;
            this.fileWriteTestButton.Click += new System.EventHandler(this.fileWriteTestButton_Click);
            // 
            // correctInputFormatsToolStripMenuItem
            // 
            this.correctInputFormatsToolStripMenuItem.Name = "correctInputFormatsToolStripMenuItem";
            this.correctInputFormatsToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.correctInputFormatsToolStripMenuItem.Text = "Correct Input Formats";
            this.correctInputFormatsToolStripMenuItem.Click += new System.EventHandler(this.correctInputFormatsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 826);
            this.Controls.Add(this.fileWriteTestButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
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
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "IT Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem possibleConversionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commonErrorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutITCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
        private System.Windows.Forms.Button fileWriteTestButton;
        private System.Windows.Forms.ToolStripMenuItem correctInputFormatsToolStripMenuItem;
    }
}

