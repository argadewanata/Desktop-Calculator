namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTotal = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button0 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonClear = new Button();
            buttonEqual = new Button();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonMultiply = new Button();
            buttonDivision = new Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.Location = new Point(12, 12);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(245, 57);
            txtTotal.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(13, 199);
            button1.Name = "button1";
            button1.Size = new Size(52, 48);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(71, 199);
            button2.Name = "button2";
            button2.Size = new Size(52, 48);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(129, 199);
            button3.Name = "button3";
            button3.Size = new Size(52, 48);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button0
            // 
            button0.Location = new Point(71, 253);
            button0.Name = "button0";
            button0.Size = new Size(52, 48);
            button0.TabIndex = 4;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // button4
            // 
            button4.Location = new Point(13, 145);
            button4.Name = "button4";
            button4.Size = new Size(52, 48);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(71, 145);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(52, 48);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(129, 145);
            button6.Name = "button6";
            button6.RightToLeft = RightToLeft.No;
            button6.Size = new Size(52, 48);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(13, 91);
            button7.Name = "button7";
            button7.RightToLeft = RightToLeft.No;
            button7.Size = new Size(52, 48);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(71, 91);
            button8.Name = "button8";
            button8.RightToLeft = RightToLeft.No;
            button8.Size = new Size(52, 48);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(129, 91);
            button9.Name = "button9";
            button9.RightToLeft = RightToLeft.No;
            button9.Size = new Size(52, 48);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(13, 253);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(52, 48);
            buttonClear.TabIndex = 11;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.Location = new Point(129, 253);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.RightToLeft = RightToLeft.No;
            buttonEqual.Size = new Size(52, 48);
            buttonEqual.TabIndex = 12;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(187, 91);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.RightToLeft = RightToLeft.No;
            buttonPlus.Size = new Size(71, 48);
            buttonPlus.TabIndex = 13;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(187, 145);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.RightToLeft = RightToLeft.No;
            buttonMinus.Size = new Size(71, 48);
            buttonMinus.TabIndex = 14;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(187, 199);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.RightToLeft = RightToLeft.No;
            buttonMultiply.Size = new Size(71, 48);
            buttonMultiply.TabIndex = 15;
            buttonMultiply.Text = "X";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonDivision
            // 
            buttonDivision.Location = new Point(187, 253);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.RightToLeft = RightToLeft.No;
            buttonDivision.Size = new Size(71, 48);
            buttonDivision.TabIndex = 16;
            buttonDivision.Text = "/";
            buttonDivision.UseVisualStyleBackColor = true;
            buttonDivision.Click += buttonDivision_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 311);
            Controls.Add(buttonDivision);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
            Controls.Add(buttonEqual);
            Controls.Add(buttonClear);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button0);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTotal);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button0;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonClear;
        private Button buttonEqual;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonMultiply;
        private Button buttonDivision;
    }
}