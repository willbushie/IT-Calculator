
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
            this.correctInputFormatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.possibleConversionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commonErrorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutITCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSessionFile = new System.Windows.Forms.Button();
            this.operateOnChosenFile = new System.Windows.Forms.Button();
            this.clearAllTextBoxes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // binaryArithmaticSectionLabel
            // 
            this.binaryArithmaticSectionLabel.AutoSize = true;
            this.binaryArithmaticSectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryArithmaticSectionLabel.Location = new System.Drawing.Point(317, 6);
            this.binaryArithmaticSectionLabel.Name = "binaryArithmaticSectionLabel";
            this.binaryArithmaticSectionLabel.Size = new System.Drawing.Size(118, 18);
            this.binaryArithmaticSectionLabel.TabIndex = 0;
            this.binaryArithmaticSectionLabel.Text = "Binary Arithmetic";
            // 
            // binaryArith_LeftTextBox
            // 
            this.binaryArith_LeftTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryArith_LeftTextBox.Location = new System.Drawing.Point(190, 63);
            this.binaryArith_LeftTextBox.Name = "binaryArith_LeftTextBox";
            this.binaryArith_LeftTextBox.Size = new System.Drawing.Size(100, 23);
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
            this.operationComboBox.Location = new System.Drawing.Point(327, 61);
            this.operationComboBox.Name = "operationComboBox";
            this.operationComboBox.Size = new System.Drawing.Size(103, 24);
            this.operationComboBox.TabIndex = 2;
            // 
            // binaryArithm_LeftTextBoxLabel
            // 
            this.binaryArithm_LeftTextBoxLabel.AutoSize = true;
            this.binaryArithm_LeftTextBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryArithm_LeftTextBoxLabel.Location = new System.Drawing.Point(180, 37);
            this.binaryArithm_LeftTextBoxLabel.Name = "binaryArithm_LeftTextBoxLabel";
            this.binaryArithm_LeftTextBoxLabel.Size = new System.Drawing.Size(133, 17);
            this.binaryArithm_LeftTextBoxLabel.TabIndex = 3;
            this.binaryArithm_LeftTextBoxLabel.Text = "First Binary Number";
            // 
            // operationComboBoxLabel
            // 
            this.operationComboBoxLabel.AutoSize = true;
            this.operationComboBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationComboBoxLabel.Location = new System.Drawing.Point(343, 37);
            this.operationComboBoxLabel.Name = "operationComboBoxLabel";
            this.operationComboBoxLabel.Size = new System.Drawing.Size(71, 17);
            this.operationComboBoxLabel.TabIndex = 4;
            this.operationComboBoxLabel.Text = "Operation";
            // 
            // binaryArith_RightTextBox
            // 
            this.binaryArith_RightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryArith_RightTextBox.Location = new System.Drawing.Point(461, 63);
            this.binaryArith_RightTextBox.Name = "binaryArith_RightTextBox";
            this.binaryArith_RightTextBox.Size = new System.Drawing.Size(100, 23);
            this.binaryArith_RightTextBox.TabIndex = 5;
            // 
            // binaryArithm_RightTextBoxLabel
            // 
            this.binaryArithm_RightTextBoxLabel.AutoSize = true;
            this.binaryArithm_RightTextBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryArithm_RightTextBoxLabel.Location = new System.Drawing.Point(439, 37);
            this.binaryArithm_RightTextBoxLabel.Name = "binaryArithm_RightTextBoxLabel";
            this.binaryArithm_RightTextBoxLabel.Size = new System.Drawing.Size(154, 17);
            this.binaryArithm_RightTextBoxLabel.TabIndex = 6;
            this.binaryArithm_RightTextBoxLabel.Text = "Second Binary Number";
            // 
            // conversionSectionLabel
            // 
            this.conversionSectionLabel.AutoSize = true;
            this.conversionSectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionSectionLabel.Location = new System.Drawing.Point(333, 246);
            this.conversionSectionLabel.Name = "conversionSectionLabel";
            this.conversionSectionLabel.Size = new System.Drawing.Size(92, 18);
            this.conversionSectionLabel.TabIndex = 7;
            this.conversionSectionLabel.Text = "Conversions";
            // 
            // binaryArithm_AnswerTextBox
            // 
            this.binaryArithm_AnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryArithm_AnswerTextBox.Location = new System.Drawing.Point(307, 154);
            this.binaryArithm_AnswerTextBox.Name = "binaryArithm_AnswerTextBox";
            this.binaryArithm_AnswerTextBox.Size = new System.Drawing.Size(153, 23);
            this.binaryArithm_AnswerTextBox.TabIndex = 8;
            // 
            // binaryArithm_OperationAnswerTextBoxLabel
            // 
            this.binaryArithm_OperationAnswerTextBoxLabel.AutoSize = true;
            this.binaryArithm_OperationAnswerTextBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryArithm_OperationAnswerTextBoxLabel.Location = new System.Drawing.Point(353, 134);
            this.binaryArithm_OperationAnswerTextBoxLabel.Name = "binaryArithm_OperationAnswerTextBoxLabel";
            this.binaryArithm_OperationAnswerTextBoxLabel.Size = new System.Drawing.Size(58, 17);
            this.binaryArithm_OperationAnswerTextBoxLabel.TabIndex = 9;
            this.binaryArithm_OperationAnswerTextBoxLabel.Text = "Answer:";
            // 
            // binaryArithm_ProcessOperationButton
            // 
            this.binaryArithm_ProcessOperationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryArithm_ProcessOperationButton.Location = new System.Drawing.Point(341, 97);
            this.binaryArithm_ProcessOperationButton.Name = "binaryArithm_ProcessOperationButton";
            this.binaryArithm_ProcessOperationButton.Size = new System.Drawing.Size(75, 30);
            this.binaryArithm_ProcessOperationButton.TabIndex = 10;
            this.binaryArithm_ProcessOperationButton.Text = "Equals";
            this.binaryArithm_ProcessOperationButton.UseVisualStyleBackColor = true;
            this.binaryArithm_ProcessOperationButton.Click += new System.EventHandler(this.binaryArithm_ProcessOperationButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 224);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(808, 3);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(307, 295);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 23);
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
            this.comboBox1.Location = new System.Drawing.Point(484, 293);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.AcceptsTab = true;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(278, 404);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 98);
            this.textBox2.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(341, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 16;
            this.button1.Text = "Equals";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(520, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Output Base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Answer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
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
            this.comboBox2.Location = new System.Drawing.Point(125, 293);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(159, 24);
            this.comboBox2.TabIndex = 21;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 26);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(768, 24);
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
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // userGuideToolStripMenuItem
            // 
            this.userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            this.userGuideToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.userGuideToolStripMenuItem.Text = "User Guide";
            this.userGuideToolStripMenuItem.Click += new System.EventHandler(this.userGuideToolStripMenuItem_Click);
            // 
            // correctInputFormatsToolStripMenuItem
            // 
            this.correctInputFormatsToolStripMenuItem.Name = "correctInputFormatsToolStripMenuItem";
            this.correctInputFormatsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.correctInputFormatsToolStripMenuItem.Text = "Correct Input Formats";
            this.correctInputFormatsToolStripMenuItem.Click += new System.EventHandler(this.correctInputFormatsToolStripMenuItem_Click);
            // 
            // possibleConversionsToolStripMenuItem
            // 
            this.possibleConversionsToolStripMenuItem.Name = "possibleConversionsToolStripMenuItem";
            this.possibleConversionsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.possibleConversionsToolStripMenuItem.Text = "Possible Conversions";
            this.possibleConversionsToolStripMenuItem.Click += new System.EventHandler(this.possibleConversionsToolStripMenuItem_Click);
            // 
            // commonErrorsToolStripMenuItem
            // 
            this.commonErrorsToolStripMenuItem.Name = "commonErrorsToolStripMenuItem";
            this.commonErrorsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.commonErrorsToolStripMenuItem.Text = "Common Errors";
            this.commonErrorsToolStripMenuItem.Click += new System.EventHandler(this.commonErrorsToolStripMenuItem_Click);
            // 
            // aboutITCalculatorToolStripMenuItem
            // 
            this.aboutITCalculatorToolStripMenuItem.Name = "aboutITCalculatorToolStripMenuItem";
            this.aboutITCalculatorToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.aboutITCalculatorToolStripMenuItem.Text = "About IT-Calculator";
            this.aboutITCalculatorToolStripMenuItem.Click += new System.EventHandler(this.aboutITCalculatorToolStripMenuItem_Click);
            // 
            // saveSessionFile
            // 
            this.saveSessionFile.Location = new System.Drawing.Point(693, 12);
            this.saveSessionFile.Name = "saveSessionFile";
            this.saveSessionFile.Size = new System.Drawing.Size(63, 42);
            this.saveSessionFile.TabIndex = 27;
            this.saveSessionFile.Text = "Save Session";
            this.saveSessionFile.UseVisualStyleBackColor = true;
            this.saveSessionFile.Click += new System.EventHandler(this.saveSessionFile_Click);
            // 
            // operateOnChosenFile
            // 
            this.operateOnChosenFile.Location = new System.Drawing.Point(693, 60);
            this.operateOnChosenFile.Name = "operateOnChosenFile";
            this.operateOnChosenFile.Size = new System.Drawing.Size(63, 42);
            this.operateOnChosenFile.TabIndex = 28;
            this.operateOnChosenFile.Text = "Choose File";
            this.operateOnChosenFile.UseVisualStyleBackColor = true;
            this.operateOnChosenFile.Click += new System.EventHandler(this.operateOnChosenFile_Click);
            // 
            // clearAllTextBoxes
            // 
            this.clearAllTextBoxes.Location = new System.Drawing.Point(693, 108);
            this.clearAllTextBoxes.Name = "clearAllTextBoxes";
            this.clearAllTextBoxes.Size = new System.Drawing.Size(63, 42);
            this.clearAllTextBoxes.TabIndex = 29;
            this.clearAllTextBoxes.Text = "Clear Text Boxes";
            this.clearAllTextBoxes.UseVisualStyleBackColor = true;
            this.clearAllTextBoxes.Click += new System.EventHandler(this.clearAllTextBoxes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 537);
            this.Controls.Add(this.clearAllTextBoxes);
            this.Controls.Add(this.operateOnChosenFile);
            this.Controls.Add(this.saveSessionFile);
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
        private System.Windows.Forms.ToolStripMenuItem correctInputFormatsToolStripMenuItem;
        private System.Windows.Forms.Button saveSessionFile;
        private System.Windows.Forms.Button operateOnChosenFile;
        private System.Windows.Forms.Button clearAllTextBoxes;
    }
}

