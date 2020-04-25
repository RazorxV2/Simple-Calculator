namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.resultBox = new System.Windows.Forms.TextBox();
            this.modulo = new System.Windows.Forms.Button();
            this.clearEntry = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.plusMinus = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.decimalPoint = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(12, 12);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(346, 80);
            this.resultBox.TabIndex = 0;
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // modulo
            // 
            this.modulo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.modulo.Location = new System.Drawing.Point(12, 113);
            this.modulo.Name = "modulo";
            this.modulo.Size = new System.Drawing.Size(82, 73);
            this.modulo.TabIndex = 1;
            this.modulo.Text = "%";
            this.modulo.UseVisualStyleBackColor = false;
            this.modulo.Click += new System.EventHandler(this.Modulo_Click);
            // 
            // clearEntry
            // 
            this.clearEntry.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clearEntry.Location = new System.Drawing.Point(100, 113);
            this.clearEntry.Name = "clearEntry";
            this.clearEntry.Size = new System.Drawing.Size(82, 73);
            this.clearEntry.TabIndex = 2;
            this.clearEntry.Text = "CE";
            this.clearEntry.UseVisualStyleBackColor = false;
            this.clearEntry.Click += new System.EventHandler(this.ClearEntry_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clear.Location = new System.Drawing.Point(188, 113);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(82, 73);
            this.clear.TabIndex = 3;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.equals.Location = new System.Drawing.Point(276, 429);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(82, 73);
            this.equals.TabIndex = 4;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(12, 192);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(82, 73);
            this.seven.TabIndex = 5;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(100, 192);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(82, 73);
            this.eight.TabIndex = 6;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(188, 192);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(82, 73);
            this.nine.TabIndex = 7;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.divide.Location = new System.Drawing.Point(276, 113);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(82, 73);
            this.divide.TabIndex = 8;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(12, 271);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(82, 73);
            this.four.TabIndex = 9;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.Four_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(100, 271);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(82, 73);
            this.five.TabIndex = 10;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.Five_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(188, 271);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(82, 73);
            this.six.TabIndex = 11;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.Six_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.multiply.Location = new System.Drawing.Point(276, 192);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(82, 73);
            this.multiply.TabIndex = 12;
            this.multiply.Text = "X";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(12, 350);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(82, 73);
            this.one.TabIndex = 13;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.One_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(100, 350);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(82, 73);
            this.two.TabIndex = 14;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.Two_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(188, 350);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(82, 73);
            this.three.TabIndex = 15;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.Three_Click);
            // 
            // subtraction
            // 
            this.subtraction.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.subtraction.Location = new System.Drawing.Point(276, 271);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(82, 73);
            this.subtraction.TabIndex = 16;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = false;
            this.subtraction.Click += new System.EventHandler(this.Subtraction_Click);
            // 
            // plusMinus
            // 
            this.plusMinus.Location = new System.Drawing.Point(12, 429);
            this.plusMinus.Name = "plusMinus";
            this.plusMinus.Size = new System.Drawing.Size(82, 73);
            this.plusMinus.TabIndex = 17;
            this.plusMinus.Text = "+/-";
            this.plusMinus.UseVisualStyleBackColor = true;
            this.plusMinus.Click += new System.EventHandler(this.PlusMinus_Click);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(100, 429);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(82, 73);
            this.zero.TabIndex = 18;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // decimalPoint
            // 
            this.decimalPoint.Location = new System.Drawing.Point(188, 429);
            this.decimalPoint.Name = "decimalPoint";
            this.decimalPoint.Size = new System.Drawing.Size(82, 73);
            this.decimalPoint.TabIndex = 19;
            this.decimalPoint.Text = ".";
            this.decimalPoint.UseVisualStyleBackColor = true;
            this.decimalPoint.Click += new System.EventHandler(this.DecimalPoint_Click);
            // 
            // addition
            // 
            this.addition.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addition.Location = new System.Drawing.Point(276, 350);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(82, 73);
            this.addition.TabIndex = 20;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = false;
            this.addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 529);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.decimalPoint);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.plusMinus);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.clearEntry);
            this.Controls.Add(this.modulo);
            this.Controls.Add(this.resultBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button modulo;
        private System.Windows.Forms.Button clearEntry;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button plusMinus;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button decimalPoint;
        private System.Windows.Forms.Button addition;
    }
}

