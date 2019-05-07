namespace WindowsFormsApplication1
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
            this.subtract = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.savedNumber = new System.Windows.Forms.TextBox();
            this.operation = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(122, 164);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(75, 23);
            this.subtract.TabIndex = 0;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(122, 135);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 1;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(122, 222);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 23);
            this.multiply.TabIndex = 2;
            this.multiply.Text = "X";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(122, 193);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 23);
            this.divide.TabIndex = 3;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(122, 251);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(75, 23);
            this.equal.TabIndex = 4;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(86, 135);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(30, 23);
            this.nine.TabIndex = 5;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(86, 164);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(30, 23);
            this.six.TabIndex = 6;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(86, 193);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(30, 23);
            this.three.TabIndex = 7;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(14, 193);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(30, 23);
            this.one.TabIndex = 10;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(14, 164);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(30, 23);
            this.four.TabIndex = 9;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(14, 135);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(30, 23);
            this.seven.TabIndex = 8;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(50, 193);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(30, 23);
            this.two.TabIndex = 13;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(50, 164);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(30, 23);
            this.five.TabIndex = 12;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(50, 135);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(30, 23);
            this.eight.TabIndex = 11;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(50, 222);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(30, 23);
            this.zero.TabIndex = 14;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(50, 37);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(146, 20);
            this.display.TabIndex = 15;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // savedNumber
            // 
            this.savedNumber.BackColor = System.Drawing.SystemColors.Control;
            this.savedNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.savedNumber.Location = new System.Drawing.Point(50, 11);
            this.savedNumber.Name = "savedNumber";
            this.savedNumber.Size = new System.Drawing.Size(124, 13);
            this.savedNumber.TabIndex = 16;
            this.savedNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // operation
            // 
            this.operation.BackColor = System.Drawing.SystemColors.Control;
            this.operation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.operation.Location = new System.Drawing.Point(170, 11);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(26, 13);
            this.operation.TabIndex = 17;
            this.operation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(86, 222);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(30, 23);
            this.clear.TabIndex = 18;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 280);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.savedNumber);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.display);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.two);
            this.Controls.Add(this.five);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.one);
            this.Controls.Add(this.four);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.three);
            this.Controls.Add(this.six);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.add);
            this.Controls.Add(this.subtract);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.TextBox display;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox savedNumber;
        private System.Windows.Forms.TextBox operation;
        private System.Windows.Forms.Button clear;
    }
}

