namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNum1 = new System.Windows.Forms.Button();
            this.buttonNum2 = new System.Windows.Forms.Button();
            this.buttonNum3 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonNum6 = new System.Windows.Forms.Button();
            this.buttonNum5 = new System.Windows.Forms.Button();
            this.buttonNum4 = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonNum9 = new System.Windows.Forms.Button();
            this.buttonNum8 = new System.Windows.Forms.Button();
            this.buttonNum7 = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonRequestResult = new System.Windows.Forms.Button();
            this.buttonNumComma = new System.Windows.Forms.Button();
            this.buttonNum0 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currentEditingNumber = new System.Windows.Forms.Label();
            this.calculationInfo = new System.Windows.Forms.Label();
            this.signButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNum1
            // 
            this.buttonNum1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNum1.Location = new System.Drawing.Point(17, 219);
            this.buttonNum1.Name = "buttonNum1";
            this.buttonNum1.Size = new System.Drawing.Size(86, 71);
            this.buttonNum1.TabIndex = 1;
            this.buttonNum1.Text = "1";
            this.buttonNum1.UseVisualStyleBackColor = true;
            this.buttonNum1.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // buttonNum2
            // 
            this.buttonNum2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNum2.Location = new System.Drawing.Point(109, 219);
            this.buttonNum2.Name = "buttonNum2";
            this.buttonNum2.Size = new System.Drawing.Size(86, 71);
            this.buttonNum2.TabIndex = 2;
            this.buttonNum2.Text = "2";
            this.buttonNum2.UseVisualStyleBackColor = true;
            this.buttonNum2.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // buttonNum3
            // 
            this.buttonNum3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNum3.Location = new System.Drawing.Point(201, 219);
            this.buttonNum3.Name = "buttonNum3";
            this.buttonNum3.Size = new System.Drawing.Size(86, 71);
            this.buttonNum3.TabIndex = 3;
            this.buttonNum3.Text = "3";
            this.buttonNum3.UseVisualStyleBackColor = true;
            this.buttonNum3.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.Location = new System.Drawing.Point(293, 219);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(77, 71);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSubtract.Location = new System.Drawing.Point(293, 296);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(77, 71);
            this.buttonSubtract.TabIndex = 8;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // buttonNum6
            // 
            this.buttonNum6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNum6.Location = new System.Drawing.Point(201, 296);
            this.buttonNum6.Name = "buttonNum6";
            this.buttonNum6.Size = new System.Drawing.Size(86, 71);
            this.buttonNum6.TabIndex = 7;
            this.buttonNum6.Text = "6";
            this.buttonNum6.UseVisualStyleBackColor = true;
            this.buttonNum6.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // buttonNum5
            // 
            this.buttonNum5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNum5.Location = new System.Drawing.Point(109, 296);
            this.buttonNum5.Name = "buttonNum5";
            this.buttonNum5.Size = new System.Drawing.Size(86, 71);
            this.buttonNum5.TabIndex = 6;
            this.buttonNum5.Text = "5";
            this.buttonNum5.UseVisualStyleBackColor = true;
            this.buttonNum5.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // buttonNum4
            // 
            this.buttonNum4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNum4.Location = new System.Drawing.Point(17, 296);
            this.buttonNum4.Name = "buttonNum4";
            this.buttonNum4.Size = new System.Drawing.Size(86, 71);
            this.buttonNum4.TabIndex = 5;
            this.buttonNum4.Text = "4";
            this.buttonNum4.UseVisualStyleBackColor = true;
            this.buttonNum4.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDivide.Location = new System.Drawing.Point(293, 373);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(77, 71);
            this.buttonDivide.TabIndex = 12;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // buttonNum9
            // 
            this.buttonNum9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNum9.Location = new System.Drawing.Point(201, 373);
            this.buttonNum9.Name = "buttonNum9";
            this.buttonNum9.Size = new System.Drawing.Size(86, 71);
            this.buttonNum9.TabIndex = 11;
            this.buttonNum9.Text = "9";
            this.buttonNum9.UseVisualStyleBackColor = true;
            this.buttonNum9.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // buttonNum8
            // 
            this.buttonNum8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNum8.Location = new System.Drawing.Point(109, 373);
            this.buttonNum8.Name = "buttonNum8";
            this.buttonNum8.Size = new System.Drawing.Size(86, 71);
            this.buttonNum8.TabIndex = 10;
            this.buttonNum8.Text = "8";
            this.buttonNum8.UseVisualStyleBackColor = true;
            this.buttonNum8.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // buttonNum7
            // 
            this.buttonNum7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNum7.Location = new System.Drawing.Point(17, 373);
            this.buttonNum7.Name = "buttonNum7";
            this.buttonNum7.Size = new System.Drawing.Size(86, 71);
            this.buttonNum7.TabIndex = 9;
            this.buttonNum7.Text = "7";
            this.buttonNum7.UseVisualStyleBackColor = true;
            this.buttonNum7.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMultiply.Location = new System.Drawing.Point(293, 450);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(77, 71);
            this.buttonMultiply.TabIndex = 16;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // buttonRequestResult
            // 
            this.buttonRequestResult.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRequestResult.Location = new System.Drawing.Point(201, 450);
            this.buttonRequestResult.Name = "buttonRequestResult";
            this.buttonRequestResult.Size = new System.Drawing.Size(86, 71);
            this.buttonRequestResult.TabIndex = 15;
            this.buttonRequestResult.Text = "=";
            this.buttonRequestResult.UseVisualStyleBackColor = true;
            this.buttonRequestResult.Click += new System.EventHandler(this.ResultButtonButton_Click);
            // 
            // buttonNumComma
            // 
            this.buttonNumComma.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNumComma.Location = new System.Drawing.Point(17, 450);
            this.buttonNumComma.Name = "buttonNumComma";
            this.buttonNumComma.Size = new System.Drawing.Size(86, 71);
            this.buttonNumComma.TabIndex = 14;
            this.buttonNumComma.Text = ",";
            this.buttonNumComma.UseVisualStyleBackColor = true;
            this.buttonNumComma.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // buttonNum0
            // 
            this.buttonNum0.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNum0.Location = new System.Drawing.Point(109, 450);
            this.buttonNum0.Name = "buttonNum0";
            this.buttonNum0.Size = new System.Drawing.Size(86, 71);
            this.buttonNum0.TabIndex = 17;
            this.buttonNum0.Text = "0";
            this.buttonNum0.UseVisualStyleBackColor = true;
            this.buttonNum0.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClear.Location = new System.Drawing.Point(17, 171);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(270, 42);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.currentEditingNumber);
            this.groupBox1.Controls.Add(this.calculationInfo);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 152);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculations";
            // 
            // currentEditingNumber
            // 
            this.currentEditingNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentEditingNumber.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentEditingNumber.Location = new System.Drawing.Point(10, 45);
            this.currentEditingNumber.Name = "currentEditingNumber";
            this.currentEditingNumber.Size = new System.Drawing.Size(341, 104);
            this.currentEditingNumber.TabIndex = 1;
            this.currentEditingNumber.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // calculationInfo
            // 
            this.calculationInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calculationInfo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calculationInfo.Location = new System.Drawing.Point(7, 22);
            this.calculationInfo.Name = "calculationInfo";
            this.calculationInfo.Size = new System.Drawing.Size(344, 23);
            this.calculationInfo.TabIndex = 0;
            this.calculationInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // signButton
            // 
            this.signButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signButton.Location = new System.Drawing.Point(293, 171);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(77, 42);
            this.signButton.TabIndex = 20;
            this.signButton.Text = "±";
            this.signButton.UseVisualStyleBackColor = true;
            this.signButton.Click += new System.EventHandler(this.SignButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(382, 531);
            this.Controls.Add(this.signButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonNum0);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonRequestResult);
            this.Controls.Add(this.buttonNumComma);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonNum9);
            this.Controls.Add(this.buttonNum8);
            this.Controls.Add(this.buttonNum7);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonNum6);
            this.Controls.Add(this.buttonNum5);
            this.Controls.Add(this.buttonNum4);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonNum3);
            this.Controls.Add(this.buttonNum2);
            this.Controls.Add(this.buttonNum1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonNum1;
        private System.Windows.Forms.Button buttonNum2;
        private System.Windows.Forms.Button buttonNum3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonNum6;
        private System.Windows.Forms.Button buttonNum5;
        private System.Windows.Forms.Button buttonNum4;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonNum9;
        private System.Windows.Forms.Button buttonNum8;
        private System.Windows.Forms.Button buttonNum7;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonRequestResult;
        private System.Windows.Forms.Button buttonNumComma;
        private System.Windows.Forms.Button buttonNum0;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label currentEditingNumber;
        private System.Windows.Forms.Label calculationInfo;
        private System.Windows.Forms.Button signButton;
    }
}

