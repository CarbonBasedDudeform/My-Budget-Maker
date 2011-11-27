namespace MyBudget
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
            this.calander = new System.Windows.Forms.MonthCalendar();
            this.totalAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.calcedDailyAmountTxt = new System.Windows.Forms.Label();
            this.calcedWeeklyAmounTxt = new System.Windows.Forms.Label();
            this.calcedMonthlyAmountTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.totalAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // calander
            // 
            this.calander.Location = new System.Drawing.Point(13, 42);
            this.calander.Name = "calander";
            this.calander.TabIndex = 0;
            // 
            // totalAmount
            // 
            this.totalAmount.Location = new System.Drawing.Point(120, 10);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(120, 20);
            this.totalAmount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Amount:";
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(165, 216);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 3;
            this.calcBtn.Text = "Calc";
            this.calcBtn.UseVisualStyleBackColor = true;
            // 
            // calcedDailyAmountTxt
            // 
            this.calcedDailyAmountTxt.AutoSize = true;
            this.calcedDailyAmountTxt.Location = new System.Drawing.Point(205, 255);
            this.calcedDailyAmountTxt.Name = "calcedDailyAmountTxt";
            this.calcedDailyAmountTxt.Size = new System.Drawing.Size(13, 13);
            this.calcedDailyAmountTxt.TabIndex = 4;
            this.calcedDailyAmountTxt.Text = "0";
            // 
            // calcedWeeklyAmounTxt
            // 
            this.calcedWeeklyAmounTxt.AutoSize = true;
            this.calcedWeeklyAmounTxt.Location = new System.Drawing.Point(205, 279);
            this.calcedWeeklyAmounTxt.Name = "calcedWeeklyAmounTxt";
            this.calcedWeeklyAmounTxt.Size = new System.Drawing.Size(13, 13);
            this.calcedWeeklyAmounTxt.TabIndex = 5;
            this.calcedWeeklyAmounTxt.Text = "0";
            // 
            // calcedMonthlyAmountTxt
            // 
            this.calcedMonthlyAmountTxt.AutoSize = true;
            this.calcedMonthlyAmountTxt.Location = new System.Drawing.Point(205, 306);
            this.calcedMonthlyAmountTxt.Name = "calcedMonthlyAmountTxt";
            this.calcedMonthlyAmountTxt.Size = new System.Drawing.Size(13, 13);
            this.calcedMonthlyAmountTxt.TabIndex = 6;
            this.calcedMonthlyAmountTxt.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Daily Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Weekly Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Montly Amount:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 334);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calcedMonthlyAmountTxt);
            this.Controls.Add(this.calcedWeeklyAmounTxt);
            this.Controls.Add(this.calcedDailyAmountTxt);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalAmount);
            this.Controls.Add(this.calander);
            this.Name = "Form1";
            this.Text = "My Budget Maker";
            ((System.ComponentModel.ISupportInitialize)(this.totalAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calander;
        private System.Windows.Forms.NumericUpDown totalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label calcedDailyAmountTxt;
        private System.Windows.Forms.Label calcedWeeklyAmounTxt;
        private System.Windows.Forms.Label calcedMonthlyAmountTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

