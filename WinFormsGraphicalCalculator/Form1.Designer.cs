namespace WinFormsGraphicalCalculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.txtfirstNumber = new System.Windows.Forms.TextBox();
            this.txtsecondNumber = new System.Windows.Forms.TextBox();
            this.outputTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label_FirstNumber
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter first number:";
            // 
            // Label_SecondNumber
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter second number:";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.ForestGreen;
            this.btn1.Location = new System.Drawing.Point(330, 60);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(39, 39);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.GetUserButtonValue);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.ForestGreen;
            this.btn9.Location = new System.Drawing.Point(447, 149);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(39, 37);
            this.btn9.TabIndex = 4;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.GetUserButtonValue);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.ForestGreen;
            this.btn8.Location = new System.Drawing.Point(389, 149);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(39, 37);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.GetUserButtonValue);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.ForestGreen;
            this.btn7.Location = new System.Drawing.Point(330, 149);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(39, 37);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.GetUserButtonValue);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.ForestGreen;
            this.btn6.Location = new System.Drawing.Point(447, 105);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(39, 38);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.GetUserButtonValue);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.ForestGreen;
            this.btn5.Location = new System.Drawing.Point(389, 105);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(39, 38);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.GetUserButtonValue);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.ForestGreen;
            this.btn4.Location = new System.Drawing.Point(330, 105);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(39, 38);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.GetUserButtonValue);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.ForestGreen;
            this.btn3.Location = new System.Drawing.Point(447, 60);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(39, 39);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.GetUserButtonValue);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.ForestGreen;
            this.btn2.Location = new System.Drawing.Point(389, 60);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(39, 39);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.GetUserButtonValue);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.ForestGreen;
            this.btn0.Location = new System.Drawing.Point(389, 192);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(39, 34);
            this.btn0.TabIndex = 12;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.GetUserButtonValue);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCalculate.Location = new System.Drawing.Point(58, 182);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 33);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "=";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClear.Location = new System.Drawing.Point(167, 182);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 33);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.clearBtnClick);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDivide.Location = new System.Drawing.Point(527, 192);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 15;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.CalculateOperationButton);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMultiply.Location = new System.Drawing.Point(527, 149);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 23);
            this.btnMultiply.TabIndex = 16;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.CalculateOperationButton);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.Location = new System.Drawing.Point(527, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.CalculateOperationButton);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSubtract.Location = new System.Drawing.Point(527, 60);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(75, 23);
            this.btnSubtract.TabIndex = 18;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.CalculateOperationButton);
            // 
            // txtfirstNumber
            // 
            this.txtfirstNumber.Location = new System.Drawing.Point(142, 60);
            this.txtfirstNumber.Name = "txtfirstNumber";
            this.txtfirstNumber.Size = new System.Drawing.Size(100, 22);
            this.txtfirstNumber.TabIndex = 19;
            // 
            // txtsecondNumber
            // 
            this.txtsecondNumber.Location = new System.Drawing.Point(142, 105);
            this.txtsecondNumber.Name = "txtsecondNumber";
            this.txtsecondNumber.Size = new System.Drawing.Size(100, 22);
            this.txtsecondNumber.TabIndex = 20;
            // 
            // outputTxtBox
            // 
            this.outputTxtBox.Location = new System.Drawing.Point(58, 231);
            this.outputTxtBox.Name = "outputTxtBox";
            this.outputTxtBox.Size = new System.Drawing.Size(184, 22);
            this.outputTxtBox.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputTxtBox);
            this.Controls.Add(this.txtsecondNumber);
            this.Controls.Add(this.txtfirstNumber);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.TextBox txtfirstNumber;
        private System.Windows.Forms.TextBox txtsecondNumber;
        private System.Windows.Forms.TextBox outputTxtBox;
    }
}

