namespace Interest_Compounder
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.monthlySavings = new System.Windows.Forms.Label();
            this.annualInterest = new System.Windows.Forms.Label();
            this.numberOfMonths = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.nextMonth = new System.Windows.Forms.Button();
            this.monthlySavingsValue = new System.Windows.Forms.TextBox();
            this.annualInterestValue = new System.Windows.Forms.TextBox();
            this.balanceValue = new System.Windows.Forms.Label();
            this.monthsValue = new System.Windows.Forms.Label();
            this.invalidInput = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invalidInput)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.monthlySavings, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.annualInterest, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.numberOfMonths, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.balance, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Exit, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.nextMonth, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.monthlySavingsValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.annualInterestValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.balanceValue, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.monthsValue, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(644, 554);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // monthlySavings
            // 
            this.monthlySavings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthlySavings.AutoSize = true;
            this.monthlySavings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlySavings.Location = new System.Drawing.Point(93, 104);
            this.monthlySavings.Name = "monthlySavings";
            this.monthlySavings.Size = new System.Drawing.Size(136, 18);
            this.monthlySavings.TabIndex = 0;
            this.monthlySavings.Text = "Monthly Savings:";
            this.monthlySavings.Click += new System.EventHandler(this.monthlySavings_Click);
            // 
            // annualInterest
            // 
            this.annualInterest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.annualInterest.AutoSize = true;
            this.annualInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annualInterest.Location = new System.Drawing.Point(83, 140);
            this.annualInterest.Name = "annualInterest";
            this.annualInterest.Size = new System.Drawing.Size(155, 18);
            this.annualInterest.TabIndex = 1;
            this.annualInterest.Text = "Annual Interest (%):";
            this.annualInterest.Click += new System.EventHandler(this.annualInterest_Click);
            // 
            // numberOfMonths
            // 
            this.numberOfMonths.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numberOfMonths.AutoSize = true;
            this.numberOfMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfMonths.Location = new System.Drawing.Point(84, 291);
            this.numberOfMonths.Name = "numberOfMonths";
            this.numberOfMonths.Size = new System.Drawing.Size(153, 18);
            this.numberOfMonths.TabIndex = 2;
            this.numberOfMonths.Text = "Number of Months:";
            this.numberOfMonths.Click += new System.EventHandler(this.numberOfMonths_Click);
            // 
            // balance
            // 
            this.balance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.balance.AutoSize = true;
            this.balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Location = new System.Drawing.Point(124, 330);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(73, 18);
            this.balance.TabIndex = 3;
            this.balance.Text = "Balance:";
            this.balance.Click += new System.EventHandler(this.balance_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(123, 495);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // nextMonth
            // 
            this.nextMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nextMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextMonth.Location = new System.Drawing.Point(426, 494);
            this.nextMonth.Name = "nextMonth";
            this.nextMonth.Size = new System.Drawing.Size(113, 24);
            this.nextMonth.TabIndex = 5;
            this.nextMonth.Text = "Next Month";
            this.nextMonth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nextMonth.UseVisualStyleBackColor = true;
            this.nextMonth.Click += new System.EventHandler(this.nextMonth_Click);
            // 
            // monthlySavingsValue
            // 
            this.monthlySavingsValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthlySavingsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlySavingsValue.Location = new System.Drawing.Point(433, 102);
            this.monthlySavingsValue.Name = "monthlySavingsValue";
            this.monthlySavingsValue.Size = new System.Drawing.Size(100, 22);
            this.monthlySavingsValue.TabIndex = 6;
            this.monthlySavingsValue.TextChanged += new System.EventHandler(this.monthlySavingsValue_TextChanged);
            // 
            // annualInterestValue
            // 
            this.annualInterestValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.annualInterestValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annualInterestValue.Location = new System.Drawing.Point(433, 138);
            this.annualInterestValue.Name = "annualInterestValue";
            this.annualInterestValue.Size = new System.Drawing.Size(100, 22);
            this.annualInterestValue.TabIndex = 7;
            this.annualInterestValue.TextChanged += new System.EventHandler(this.annualInterestValue_TextChanged);
            // 
            // balanceValue
            // 
            this.balanceValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.balanceValue.AutoSize = true;
            this.balanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceValue.Location = new System.Drawing.Point(461, 330);
            this.balanceValue.Name = "balanceValue";
            this.balanceValue.Size = new System.Drawing.Size(44, 18);
            this.balanceValue.TabIndex = 9;
            this.balanceValue.Text = "$0.00";
            this.balanceValue.Click += new System.EventHandler(this.balanceValue_Click);
            // 
            // monthsValue
            // 
            this.monthsValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthsValue.AutoSize = true;
            this.monthsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthsValue.Location = new System.Drawing.Point(475, 291);
            this.monthsValue.Name = "monthsValue";
            this.monthsValue.Size = new System.Drawing.Size(16, 18);
            this.monthsValue.TabIndex = 10;
            this.monthsValue.Text = "0";
            // 
            // invalidInput
            // 
            this.invalidInput.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Savings Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invalidInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label monthlySavings;
        private System.Windows.Forms.Label annualInterest;
        private System.Windows.Forms.Label numberOfMonths;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button nextMonth;
        private System.Windows.Forms.TextBox monthlySavingsValue;
        private System.Windows.Forms.TextBox annualInterestValue;
        private System.Windows.Forms.Label balanceValue;
        private System.Windows.Forms.Label monthsValue;
        private System.Windows.Forms.ErrorProvider invalidInput;
    }
}

