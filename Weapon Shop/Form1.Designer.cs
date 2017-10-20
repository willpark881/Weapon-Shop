namespace Weapon_Shop
{
    partial class form1
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
            this.checkOut = new System.Windows.Forms.Button();
            this.clayInput = new System.Windows.Forms.TextBox();
            this.gladInput = new System.Windows.Forms.TextBox();
            this.khoInput = new System.Windows.Forms.TextBox();
            this.katanInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.printR = new System.Windows.Forms.Button();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkOut
            // 
            this.checkOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.checkOut.Location = new System.Drawing.Point(158, 274);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(164, 42);
            this.checkOut.TabIndex = 0;
            this.checkOut.Text = "Go to Checkout";
            this.checkOut.UseVisualStyleBackColor = true;
            this.checkOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // clayInput
            // 
            this.clayInput.Location = new System.Drawing.Point(191, 55);
            this.clayInput.Name = "clayInput";
            this.clayInput.Size = new System.Drawing.Size(100, 20);
            this.clayInput.TabIndex = 1;
            // 
            // gladInput
            // 
            this.gladInput.Location = new System.Drawing.Point(191, 101);
            this.gladInput.Name = "gladInput";
            this.gladInput.Size = new System.Drawing.Size(100, 20);
            this.gladInput.TabIndex = 2;
            // 
            // khoInput
            // 
            this.khoInput.Location = new System.Drawing.Point(191, 158);
            this.khoInput.Name = "khoInput";
            this.khoInput.Size = new System.Drawing.Size(100, 20);
            this.khoInput.TabIndex = 3;
            // 
            // katanInput
            // 
            this.katanInput.Location = new System.Drawing.Point(191, 211);
            this.katanInput.Name = "katanInput";
            this.katanInput.Size = new System.Drawing.Size(100, 20);
            this.katanInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(61, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Claymore";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(70, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gladius";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(64, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Khopesh";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(73, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Katana";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(105, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Price:";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(232, 365);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(10, 13);
            this.outputLabel.TabIndex = 10;
            this.outputLabel.Text = ".";
            // 
            // printR
            // 
            this.printR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.printR.Location = new System.Drawing.Point(428, 27);
            this.printR.Name = "printR";
            this.printR.Size = new System.Drawing.Size(134, 35);
            this.printR.TabIndex = 11;
            this.printR.Text = "Print Receipt";
            this.printR.UseVisualStyleBackColor = true;
            this.printR.Click += new System.EventHandler(this.printR_Click);
            // 
            // receiptLabel
            // 
            this.receiptLabel.Location = new System.Drawing.Point(398, 90);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(191, 288);
            this.receiptLabel.TabIndex = 12;
            this.receiptLabel.Text = " . ";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 415);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.printR);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.katanInput);
            this.Controls.Add(this.khoInput);
            this.Controls.Add(this.gladInput);
            this.Controls.Add(this.clayInput);
            this.Controls.Add(this.checkOut);
            this.Name = "form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkOut;
        private System.Windows.Forms.TextBox clayInput;
        private System.Windows.Forms.TextBox gladInput;
        private System.Windows.Forms.TextBox khoInput;
        private System.Windows.Forms.TextBox katanInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button printR;
        private System.Windows.Forms.Label receiptLabel;
    }
}

