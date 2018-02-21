namespace winforms_calculator
{
    partial class Kalkulator
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
            this.buttonPop = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.Calcboard = new System.Windows.Forms.GroupBox();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonNegative = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonComma = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.Label();
            this.Calcboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPop
            // 
            this.buttonPop.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonPop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonPop.Location = new System.Drawing.Point(196, 65);
            this.buttonPop.Name = "buttonPop";
            this.buttonPop.Size = new System.Drawing.Size(40, 40);
            this.buttonPop.TabIndex = 1;
            this.buttonPop.Text = "<-";
            this.buttonPop.UseVisualStyleBackColor = true;
            this.buttonPop.Click += new System.EventHandler(this.buttonPop_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonClear.Location = new System.Drawing.Point(196, 19);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(40, 40);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Calcboard
            // 
            this.Calcboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Calcboard.CausesValidation = false;
            this.Calcboard.Controls.Add(this.buttonClearAll);
            this.Calcboard.Controls.Add(this.buttonEquals);
            this.Calcboard.Controls.Add(this.buttonNegative);
            this.Calcboard.Controls.Add(this.buttonDivide);
            this.Calcboard.Controls.Add(this.buttonMultiply);
            this.Calcboard.Controls.Add(this.buttonSubtract);
            this.Calcboard.Controls.Add(this.buttonSum);
            this.Calcboard.Controls.Add(this.buttonComma);
            this.Calcboard.Controls.Add(this.buttonZero);
            this.Calcboard.Controls.Add(this.buttonThree);
            this.Calcboard.Controls.Add(this.buttonTwo);
            this.Calcboard.Controls.Add(this.buttonOne);
            this.Calcboard.Controls.Add(this.buttonSix);
            this.Calcboard.Controls.Add(this.buttonFive);
            this.Calcboard.Controls.Add(this.buttonFour);
            this.Calcboard.Controls.Add(this.buttonNine);
            this.Calcboard.Controls.Add(this.buttonEight);
            this.Calcboard.Controls.Add(this.buttonSeven);
            this.Calcboard.Controls.Add(this.buttonClear);
            this.Calcboard.Controls.Add(this.buttonPop);
            this.Calcboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calcboard.Location = new System.Drawing.Point(14, 171);
            this.Calcboard.Name = "Calcboard";
            this.Calcboard.Size = new System.Drawing.Size(294, 203);
            this.Calcboard.TabIndex = 3;
            this.Calcboard.TabStop = false;
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonClearAll.Location = new System.Drawing.Point(242, 19);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(46, 178);
            this.buttonClearAll.TabIndex = 20;
            this.buttonClearAll.Text = "CE";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEquals.Location = new System.Drawing.Point(196, 157);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(40, 40);
            this.buttonEquals.TabIndex = 19;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonNegative
            // 
            this.buttonNegative.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonNegative.Location = new System.Drawing.Point(196, 111);
            this.buttonNegative.Name = "buttonNegative";
            this.buttonNegative.Size = new System.Drawing.Size(40, 40);
            this.buttonNegative.TabIndex = 18;
            this.buttonNegative.Text = "+|-";
            this.buttonNegative.UseVisualStyleBackColor = true;
            this.buttonNegative.Click += new System.EventHandler(this.buttonNegative_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDivide.Location = new System.Drawing.Point(150, 19);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(40, 40);
            this.buttonDivide.TabIndex = 17;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonMultiply.Location = new System.Drawing.Point(150, 65);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(40, 40);
            this.buttonMultiply.TabIndex = 16;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSubtract.Location = new System.Drawing.Point(150, 111);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(40, 40);
            this.buttonSubtract.TabIndex = 15;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSum.Location = new System.Drawing.Point(150, 157);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(40, 40);
            this.buttonSum.TabIndex = 14;
            this.buttonSum.Text = "+";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // buttonComma
            // 
            this.buttonComma.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonComma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonComma.Location = new System.Drawing.Point(104, 157);
            this.buttonComma.Name = "buttonComma";
            this.buttonComma.Size = new System.Drawing.Size(40, 40);
            this.buttonComma.TabIndex = 13;
            this.buttonComma.Text = ".";
            this.buttonComma.UseVisualStyleBackColor = true;
            this.buttonComma.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonZero.Location = new System.Drawing.Point(12, 157);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(86, 40);
            this.buttonZero.TabIndex = 12;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonThree.Location = new System.Drawing.Point(104, 111);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(40, 40);
            this.buttonThree.TabIndex = 11;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = true;
            this.buttonThree.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonTwo.Location = new System.Drawing.Point(58, 111);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(40, 40);
            this.buttonTwo.TabIndex = 10;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonOne.Location = new System.Drawing.Point(12, 111);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(40, 40);
            this.buttonOne.TabIndex = 9;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSix.Location = new System.Drawing.Point(104, 65);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(40, 40);
            this.buttonSix.TabIndex = 8;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = true;
            this.buttonSix.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonFive.Location = new System.Drawing.Point(58, 65);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(40, 40);
            this.buttonFive.TabIndex = 7;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = true;
            this.buttonFive.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonFour.Location = new System.Drawing.Point(12, 65);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(40, 40);
            this.buttonFour.TabIndex = 6;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = true;
            this.buttonFour.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonNine.Location = new System.Drawing.Point(104, 19);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(40, 40);
            this.buttonNine.TabIndex = 5;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = true;
            this.buttonNine.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEight.Location = new System.Drawing.Point(58, 19);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(40, 40);
            this.buttonEight.TabIndex = 4;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = true;
            this.buttonEight.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSeven.Location = new System.Drawing.Point(12, 19);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(40, 40);
            this.buttonSeven.TabIndex = 3;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = true;
            this.buttonSeven.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCurrentOperation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCurrentOperation.Location = new System.Drawing.Point(31, 49);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 20);
            this.labelCurrentOperation.TabIndex = 4;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBoxValue.Location = new System.Drawing.Point(26, 73);
            this.textBoxValue.MaximumSize = new System.Drawing.Size(282, 51);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(282, 51);
            this.textBoxValue.TabIndex = 5;
            this.textBoxValue.Text = "0";
            this.textBoxValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBoxValue.Click += new System.EventHandler(this.textBoxValue_Click);
            // 
            // Kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 386);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.Calcboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Kalkulator";
            this.Text = "Kalkulator";
            this.Calcboard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPop;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox Calcboard;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonNegative;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonComma;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Label labelCurrentOperation;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Label textBoxValue;
    }
}

