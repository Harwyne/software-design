namespace lab2
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
            lblResult = new Label();
            txtInput = new TextBox();
            btnCalculateFactorial = new Button();
            txtArrayInput = new TextBox();
            btnCalculateSum = new Button();
            lblSumResult = new Label();
            lblFibonacciResult = new Label();
            btnCalculateFibonacci = new Button();
            txtInpArray = new TextBox();
            lblPowerResult = new Label();
            btnCalculatePower = new Button();
            txtBaseInput = new TextBox();
            txtExponentInput = new TextBox();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(415, 72);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(49, 20);
            lblResult.TabIndex = 0;
            lblResult.Text = "Result";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(273, 69);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(125, 27);
            txtInput.TabIndex = 1;
            // 
            // btnCalculateFactorial
            // 
            btnCalculateFactorial.Location = new Point(78, 68);
            btnCalculateFactorial.Name = "btnCalculateFactorial";
            btnCalculateFactorial.Size = new Size(189, 29);
            btnCalculateFactorial.TabIndex = 2;
            btnCalculateFactorial.Text = "Calculate Factorial";
            btnCalculateFactorial.UseVisualStyleBackColor = true;
            btnCalculateFactorial.Click += btnCalculateFactorial_Click;
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(271, 136);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(125, 27);
            txtArrayInput.TabIndex = 3;
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(78, 136);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(187, 29);
            btnCalculateSum.TabIndex = 4;
            btnCalculateSum.Text = "Calculate Sum";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Location = new Point(415, 145);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(49, 20);
            lblSumResult.TabIndex = 5;
            lblSumResult.Text = "Result";
            // 
            // lblFibonacciResult
            // 
            lblFibonacciResult.AutoSize = true;
            lblFibonacciResult.Location = new Point(417, 202);
            lblFibonacciResult.Name = "lblFibonacciResult";
            lblFibonacciResult.Size = new Size(49, 20);
            lblFibonacciResult.TabIndex = 8;
            lblFibonacciResult.Text = "Result";
            // 
            // btnCalculateFibonacci
            // 
            btnCalculateFibonacci.Location = new Point(80, 193);
            btnCalculateFibonacci.Name = "btnCalculateFibonacci";
            btnCalculateFibonacci.Size = new Size(187, 29);
            btnCalculateFibonacci.TabIndex = 7;
            btnCalculateFibonacci.Text = "Calculate Fibonacci";
            btnCalculateFibonacci.UseVisualStyleBackColor = true;
            btnCalculateFibonacci.Click += btnCalculateFibonacci_Click;
            // 
            // txtInpArray
            // 
            txtInpArray.Location = new Point(273, 193);
            txtInpArray.Name = "txtInpArray";
            txtInpArray.Size = new Size(125, 27);
            txtInpArray.TabIndex = 6;
            // 
            // lblPowerResult
            // 
            lblPowerResult.AutoSize = true;
            lblPowerResult.Location = new Point(415, 256);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(49, 20);
            lblPowerResult.TabIndex = 11;
            lblPowerResult.Text = "Result";
            // 
            // btnCalculatePower
            // 
            btnCalculatePower.Location = new Point(78, 247);
            btnCalculatePower.Name = "btnCalculatePower";
            btnCalculatePower.Size = new Size(187, 29);
            btnCalculatePower.TabIndex = 10;
            btnCalculatePower.Text = "Calculate Power";
            btnCalculatePower.UseVisualStyleBackColor = true;
            btnCalculatePower.Click += btnCalculatePower_Click;
            // 
            // txtBaseInput
            // 
            txtBaseInput.Location = new Point(271, 247);
            txtBaseInput.Name = "txtBaseInput";
            txtBaseInput.Size = new Size(125, 27);
            txtBaseInput.TabIndex = 9;
            // 
            // txtExponentInput
            // 
            txtExponentInput.Location = new Point(271, 282);
            txtExponentInput.Name = "txtExponentInput";
            txtExponentInput.Size = new Size(125, 27);
            txtExponentInput.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtExponentInput);
            Controls.Add(lblPowerResult);
            Controls.Add(btnCalculatePower);
            Controls.Add(txtBaseInput);
            Controls.Add(lblFibonacciResult);
            Controls.Add(btnCalculateFibonacci);
            Controls.Add(txtInpArray);
            Controls.Add(lblSumResult);
            Controls.Add(btnCalculateSum);
            Controls.Add(txtArrayInput);
            Controls.Add(btnCalculateFactorial);
            Controls.Add(txtInput);
            Controls.Add(lblResult);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private TextBox txtInput;
        private Button btnCalculateFactorial;
        private TextBox txtArrayInput;
        private Button btnCalculateSum;
        private Label lblSumResult;
        private Label lblFibonacciResult;
        private Button btnCalculateFibonacci;
        private TextBox txtInpArray;
        private Label lblPowerResult;
        private Button btnCalculatePower;
        private TextBox txtBaseInput;
        private TextBox txtExponentInput;
    }
}
