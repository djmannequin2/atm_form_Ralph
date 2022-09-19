namespace atm_form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblLoan = new System.Windows.Forms.Label();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.withdraw_butt = new System.Windows.Forms.Button();
            this.balance_butt = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.deposit_butt = new System.Windows.Forms.Button();
            this.loan_butt = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.backspace = new System.Windows.Forms.Button();
            this.period_butt = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.empty_butt1 = new System.Windows.Forms.Button();
            this.enter_butt = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.clear_butt = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.cancel_butt = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.amtOfLoan = new System.Windows.Forms.Label();
            this.amtOfLoan_txt = new System.Windows.Forms.TextBox();
            this.exit_butt = new System.Windows.Forms.Button();
            this.reset_butt = new System.Windows.Forms.Button();
            this.receipt_butt = new System.Windows.Forms.Button();
            this.loan_system_butt = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.totalPay = new System.Windows.Forms.Label();
            this.monthlyPay = new System.Windows.Forms.Label();
            this.interestRate = new System.Windows.Forms.Label();
            this.numOfYears = new System.Windows.Forms.Label();
            this.totalPay_txt = new System.Windows.Forms.TextBox();
            this.monthlyPay_txt = new System.Windows.Forms.TextBox();
            this.interestRate_txt = new System.Windows.Forms.TextBox();
            this.numOfYears_txt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 600);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblPin
            // 
            this.lblPin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPin.Font = new System.Drawing.Font("SquareFont", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPin.Location = new System.Drawing.Point(7, 99);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(180, 29);
            this.lblPin.TabIndex = 6;
            this.lblPin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeposit.Location = new System.Drawing.Point(118, 128);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(69, 21);
            this.lblDeposit.TabIndex = 5;
            this.lblDeposit.Text = "Deposit";
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoan.Location = new System.Drawing.Point(138, 36);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(47, 21);
            this.lblLoan.TabIndex = 4;
            this.lblLoan.Text = "Loan";
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWithdraw.Location = new System.Drawing.Point(2, 129);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(85, 21);
            this.lblWithdraw.TabIndex = 3;
            this.lblWithdraw.Text = "Withdraw";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBalance.Location = new System.Drawing.Point(4, 36);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(70, 21);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Balance";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.withdraw_butt);
            this.groupBox3.Controls.Add(this.balance_butt);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(2, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 183);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // withdraw_butt
            // 
            this.withdraw_butt.Font = new System.Drawing.Font("Fira Sans Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.withdraw_butt.Location = new System.Drawing.Point(0, 99);
            this.withdraw_butt.Name = "withdraw_butt";
            this.withdraw_butt.Size = new System.Drawing.Size(144, 75);
            this.withdraw_butt.TabIndex = 1;
            this.withdraw_butt.TabStop = false;
            this.withdraw_butt.Text = "=>";
            this.withdraw_butt.UseVisualStyleBackColor = true;
            this.withdraw_butt.Click += new System.EventHandler(this.withdraw_butt_Click);
            // 
            // balance_butt
            // 
            this.balance_butt.Font = new System.Drawing.Font("Fira Sans Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.balance_butt.Location = new System.Drawing.Point(0, 13);
            this.balance_butt.Name = "balance_butt";
            this.balance_butt.Size = new System.Drawing.Size(144, 75);
            this.balance_butt.TabIndex = 0;
            this.balance_butt.TabStop = false;
            this.balance_butt.Text = "=>";
            this.balance_butt.UseVisualStyleBackColor = true;
            this.balance_butt.Click += new System.EventHandler(this.balance_butt_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox4.Controls.Add(this.deposit_butt);
            this.groupBox4.Controls.Add(this.loan_butt);
            this.groupBox4.Location = new System.Drawing.Point(338, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 183);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // deposit_butt
            // 
            this.deposit_butt.Font = new System.Drawing.Font("Fira Sans Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deposit_butt.Location = new System.Drawing.Point(10, 99);
            this.deposit_butt.Name = "deposit_butt";
            this.deposit_butt.Size = new System.Drawing.Size(144, 75);
            this.deposit_butt.TabIndex = 3;
            this.deposit_butt.TabStop = false;
            this.deposit_butt.Text = "<=";
            this.deposit_butt.UseVisualStyleBackColor = true;
            this.deposit_butt.Click += new System.EventHandler(this.deposit_butt_Click);
            // 
            // loan_butt
            // 
            this.loan_butt.Font = new System.Drawing.Font("Fira Sans Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loan_butt.Location = new System.Drawing.Point(10, 13);
            this.loan_butt.Name = "loan_butt";
            this.loan_butt.Size = new System.Drawing.Size(144, 75);
            this.loan_butt.TabIndex = 2;
            this.loan_butt.TabStop = false;
            this.loan_butt.Text = "<=";
            this.loan_butt.UseVisualStyleBackColor = true;
            this.loan_butt.Click += new System.EventHandler(this.loan_butt_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.backspace);
            this.groupBox5.Controls.Add(this.period_butt);
            this.groupBox5.Controls.Add(this.zero);
            this.groupBox5.Controls.Add(this.empty_butt1);
            this.groupBox5.Controls.Add(this.enter_butt);
            this.groupBox5.Controls.Add(this.nine);
            this.groupBox5.Controls.Add(this.eight);
            this.groupBox5.Controls.Add(this.seven);
            this.groupBox5.Controls.Add(this.clear_butt);
            this.groupBox5.Controls.Add(this.six);
            this.groupBox5.Controls.Add(this.five);
            this.groupBox5.Controls.Add(this.four);
            this.groupBox5.Controls.Add(this.cancel_butt);
            this.groupBox5.Controls.Add(this.three);
            this.groupBox5.Controls.Add(this.two);
            this.groupBox5.Controls.Add(this.one);
            this.groupBox5.Location = new System.Drawing.Point(2, 201);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(507, 448);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // backspace
            // 
            this.backspace.Font = new System.Drawing.Font("Fira Sans Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backspace.Location = new System.Drawing.Point(394, 273);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(101, 65);
            this.backspace.TabIndex = 19;
            this.backspace.TabStop = false;
            this.backspace.Text = " Backspace";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // period_butt
            // 
            this.period_butt.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.period_butt.Location = new System.Drawing.Point(262, 273);
            this.period_butt.Name = "period_butt";
            this.period_butt.Size = new System.Drawing.Size(101, 65);
            this.period_butt.TabIndex = 18;
            this.period_butt.TabStop = false;
            this.period_butt.Text = " .";
            this.period_butt.UseVisualStyleBackColor = true;
            this.period_butt.Click += new System.EventHandler(this.period_butt_Click);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Fira Sans Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zero.Location = new System.Drawing.Point(133, 273);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(101, 65);
            this.zero.TabIndex = 17;
            this.zero.TabStop = false;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // empty_butt1
            // 
            this.empty_butt1.Location = new System.Drawing.Point(10, 273);
            this.empty_butt1.Name = "empty_butt1";
            this.empty_butt1.Size = new System.Drawing.Size(101, 65);
            this.empty_butt1.TabIndex = 16;
            this.empty_butt1.TabStop = false;
            this.empty_butt1.Text = " ";
            this.empty_butt1.UseVisualStyleBackColor = true;
            // 
            // enter_butt
            // 
            this.enter_butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.enter_butt.Font = new System.Drawing.Font("Fira Sans Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enter_butt.Location = new System.Drawing.Point(393, 190);
            this.enter_butt.Name = "enter_butt";
            this.enter_butt.Size = new System.Drawing.Size(101, 65);
            this.enter_butt.TabIndex = 15;
            this.enter_butt.TabStop = false;
            this.enter_butt.Text = "ENTER";
            this.enter_butt.UseVisualStyleBackColor = false;
            this.enter_butt.Click += new System.EventHandler(this.enter_butt_Click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Fira Sans Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nine.Location = new System.Drawing.Point(260, 190);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(101, 65);
            this.nine.TabIndex = 14;
            this.nine.TabStop = false;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Fira Sans Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eight.Location = new System.Drawing.Point(131, 190);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(101, 65);
            this.eight.TabIndex = 13;
            this.eight.TabStop = false;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Fira Sans Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.seven.Location = new System.Drawing.Point(8, 190);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(101, 65);
            this.seven.TabIndex = 12;
            this.seven.TabStop = false;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // clear_butt
            // 
            this.clear_butt.BackColor = System.Drawing.Color.Yellow;
            this.clear_butt.Font = new System.Drawing.Font("Fira Sans Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear_butt.Location = new System.Drawing.Point(393, 105);
            this.clear_butt.Name = "clear_butt";
            this.clear_butt.Size = new System.Drawing.Size(101, 65);
            this.clear_butt.TabIndex = 11;
            this.clear_butt.TabStop = false;
            this.clear_butt.Text = "CLEAR";
            this.clear_butt.UseVisualStyleBackColor = false;
            this.clear_butt.Click += new System.EventHandler(this.clear_butt_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Fira Sans Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.six.Location = new System.Drawing.Point(260, 105);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(101, 65);
            this.six.TabIndex = 10;
            this.six.TabStop = false;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Fira Sans Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.five.Location = new System.Drawing.Point(131, 105);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(101, 65);
            this.five.TabIndex = 9;
            this.five.TabStop = false;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Fira Sans Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.four.Location = new System.Drawing.Point(8, 105);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(101, 65);
            this.four.TabIndex = 8;
            this.four.TabStop = false;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // cancel_butt
            // 
            this.cancel_butt.BackColor = System.Drawing.Color.Red;
            this.cancel_butt.Font = new System.Drawing.Font("Fira Sans Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancel_butt.Location = new System.Drawing.Point(391, 22);
            this.cancel_butt.Name = "cancel_butt";
            this.cancel_butt.Size = new System.Drawing.Size(101, 65);
            this.cancel_butt.TabIndex = 7;
            this.cancel_butt.TabStop = false;
            this.cancel_butt.Text = "CANCEL";
            this.cancel_butt.UseVisualStyleBackColor = false;
            this.cancel_butt.Click += new System.EventHandler(this.cancel_butt_Click);
            // 
            // three
            // 
            this.three.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.three.Font = new System.Drawing.Font("Fira Sans Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.three.Location = new System.Drawing.Point(258, 22);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(101, 65);
            this.three.TabIndex = 6;
            this.three.TabStop = false;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Fira Sans Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.two.Location = new System.Drawing.Point(129, 22);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(101, 65);
            this.two.TabIndex = 5;
            this.two.TabStop = false;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Fira Sans Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.one.Location = new System.Drawing.Point(6, 22);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(101, 65);
            this.one.TabIndex = 4;
            this.one.TabStop = false;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.amtOfLoan);
            this.panel1.Controls.Add(this.amtOfLoan_txt);
            this.panel1.Controls.Add(this.exit_butt);
            this.panel1.Controls.Add(this.reset_butt);
            this.panel1.Controls.Add(this.receipt_butt);
            this.panel1.Controls.Add(this.loan_system_butt);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.totalPay);
            this.panel1.Controls.Add(this.monthlyPay);
            this.panel1.Controls.Add(this.interestRate);
            this.panel1.Controls.Add(this.numOfYears);
            this.panel1.Controls.Add(this.totalPay_txt);
            this.panel1.Controls.Add(this.monthlyPay_txt);
            this.panel1.Controls.Add(this.interestRate_txt);
            this.panel1.Controls.Add(this.numOfYears_txt);
            this.panel1.Location = new System.Drawing.Point(543, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 559);
            this.panel1.TabIndex = 2;
            // 
            // amtOfLoan
            // 
            this.amtOfLoan.AutoSize = true;
            this.amtOfLoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.amtOfLoan.Location = new System.Drawing.Point(33, 60);
            this.amtOfLoan.Name = "amtOfLoan";
            this.amtOfLoan.Size = new System.Drawing.Size(96, 15);
            this.amtOfLoan.TabIndex = 14;
            this.amtOfLoan.Text = "Amount of Loan";
            this.amtOfLoan.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // amtOfLoan_txt
            // 
            this.amtOfLoan_txt.Location = new System.Drawing.Point(157, 56);
            this.amtOfLoan_txt.Multiline = true;
            this.amtOfLoan_txt.Name = "amtOfLoan_txt";
            this.amtOfLoan_txt.Size = new System.Drawing.Size(138, 30);
            this.amtOfLoan_txt.TabIndex = 1;
            // 
            // exit_butt
            // 
            this.exit_butt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit_butt.Location = new System.Drawing.Point(572, 449);
            this.exit_butt.Name = "exit_butt";
            this.exit_butt.Size = new System.Drawing.Size(112, 61);
            this.exit_butt.TabIndex = 0;
            this.exit_butt.TabStop = false;
            this.exit_butt.Text = "Exit";
            this.exit_butt.UseVisualStyleBackColor = true;
            this.exit_butt.Click += new System.EventHandler(this.exit_butt_Click);
            // 
            // reset_butt
            // 
            this.reset_butt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reset_butt.Location = new System.Drawing.Point(366, 449);
            this.reset_butt.Name = "reset_butt";
            this.reset_butt.Size = new System.Drawing.Size(112, 61);
            this.reset_butt.TabIndex = 0;
            this.reset_butt.TabStop = false;
            this.reset_butt.Text = "Reset";
            this.reset_butt.UseVisualStyleBackColor = true;
            this.reset_butt.Click += new System.EventHandler(this.reset_butt_Click);
            // 
            // receipt_butt
            // 
            this.receipt_butt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.receipt_butt.Location = new System.Drawing.Point(183, 387);
            this.receipt_butt.Name = "receipt_butt";
            this.receipt_butt.Size = new System.Drawing.Size(112, 61);
            this.receipt_butt.TabIndex = 0;
            this.receipt_butt.TabStop = false;
            this.receipt_butt.Text = "View Receipt";
            this.receipt_butt.UseVisualStyleBackColor = true;
            this.receipt_butt.Click += new System.EventHandler(this.receipt_butt_Click);
            // 
            // loan_system_butt
            // 
            this.loan_system_butt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loan_system_butt.Location = new System.Drawing.Point(33, 387);
            this.loan_system_butt.Name = "loan_system_butt";
            this.loan_system_butt.Size = new System.Drawing.Size(112, 61);
            this.loan_system_butt.TabIndex = 0;
            this.loan_system_butt.TabStop = false;
            this.loan_system_butt.Text = "Calculate Loan";
            this.loan_system_butt.UseVisualStyleBackColor = true;
            this.loan_system_butt.Click += new System.EventHandler(this.loan_system_butt_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(317, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(426, 383);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            // 
            // totalPay
            // 
            this.totalPay.AutoSize = true;
            this.totalPay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalPay.Location = new System.Drawing.Point(33, 308);
            this.totalPay.Name = "totalPay";
            this.totalPay.Size = new System.Drawing.Size(86, 15);
            this.totalPay.TabIndex = 7;
            this.totalPay.Text = "Total Payment";
            this.totalPay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // monthlyPay
            // 
            this.monthlyPay.AutoSize = true;
            this.monthlyPay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monthlyPay.Location = new System.Drawing.Point(33, 253);
            this.monthlyPay.Name = "monthlyPay";
            this.monthlyPay.Size = new System.Drawing.Size(105, 15);
            this.monthlyPay.TabIndex = 6;
            this.monthlyPay.Text = "Monthly Payment";
            this.monthlyPay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // interestRate
            // 
            this.interestRate.AutoSize = true;
            this.interestRate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.interestRate.Location = new System.Drawing.Point(33, 191);
            this.interestRate.Name = "interestRate";
            this.interestRate.Size = new System.Drawing.Size(81, 15);
            this.interestRate.TabIndex = 5;
            this.interestRate.Text = "Interest Rate";
            this.interestRate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.interestRate.Click += new System.EventHandler(this.interestRate_Click);
            // 
            // numOfYears
            // 
            this.numOfYears.AutoSize = true;
            this.numOfYears.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numOfYears.Location = new System.Drawing.Point(33, 122);
            this.numOfYears.Name = "numOfYears";
            this.numOfYears.Size = new System.Drawing.Size(100, 15);
            this.numOfYears.TabIndex = 4;
            this.numOfYears.Text = "Number of Years";
            this.numOfYears.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalPay_txt
            // 
            this.totalPay_txt.Location = new System.Drawing.Point(157, 304);
            this.totalPay_txt.Multiline = true;
            this.totalPay_txt.Name = "totalPay_txt";
            this.totalPay_txt.Size = new System.Drawing.Size(138, 30);
            this.totalPay_txt.TabIndex = 5;
            // 
            // monthlyPay_txt
            // 
            this.monthlyPay_txt.Location = new System.Drawing.Point(157, 244);
            this.monthlyPay_txt.Multiline = true;
            this.monthlyPay_txt.Name = "monthlyPay_txt";
            this.monthlyPay_txt.Size = new System.Drawing.Size(138, 30);
            this.monthlyPay_txt.TabIndex = 4;
            // 
            // interestRate_txt
            // 
            this.interestRate_txt.Location = new System.Drawing.Point(157, 182);
            this.interestRate_txt.Multiline = true;
            this.interestRate_txt.Name = "interestRate_txt";
            this.interestRate_txt.Size = new System.Drawing.Size(138, 30);
            this.interestRate_txt.TabIndex = 3;
            // 
            // numOfYears_txt
            // 
            this.numOfYears_txt.Location = new System.Drawing.Point(157, 118);
            this.numOfYears_txt.Multiline = true;
            this.numOfYears_txt.Name = "numOfYears_txt";
            this.numOfYears_txt.Size = new System.Drawing.Size(138, 30);
            this.numOfYears_txt.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.lblPrompt);
            this.panel2.Controls.Add(this.lblPin);
            this.panel2.Controls.Add(this.lblDeposit);
            this.panel2.Controls.Add(this.lblBalance);
            this.panel2.Controls.Add(this.lblLoan);
            this.panel2.Controls.Add(this.lblWithdraw);
            this.panel2.Location = new System.Drawing.Point(152, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 183);
            this.panel2.TabIndex = 7;
            // 
            // lblPrompt
            // 
            this.lblPrompt.Font = new System.Drawing.Font("SquareFont", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrompt.Location = new System.Drawing.Point(9, 69);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(181, 30);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1336, 594);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "ATM Services";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Button withdraw_butt;
        private Button balance_butt;
        private Button deposit_butt;
        private Button loan_butt;
        private Button cancel_butt;
        private Button three;
        private Button two;
        private Button one;
        private Button backspace;
        private Button period_butt;
        private Button zero;
        private Button empty_butt1;
        private Button enter_butt;
        private Button nine;
        private Button eight;
        private Button seven;
        private Button clear_butt;
        private Button six;
        private Button five;
        private Button four;
        private Label lblPin;
        private Label lblDeposit;
        private Label lblLoan;
        private Label lblWithdraw;
        private Label lblBalance;
        private Panel panel1;
        private Label amtOfLoan;
        private TextBox amtOfLoan_txt;
        private Button exit_butt;
        private Button reset_butt;
        private Button receipt_butt;
        private Button loan_system_butt;
        private RichTextBox richTextBox1;
        private Label totalPay;
        private Label monthlyPay;
        private Label interestRate;
        private Label numOfYears;
        private TextBox totalPay_txt;
        private TextBox monthlyPay_txt;
        private TextBox interestRate_txt;
        private TextBox numOfYears_txt;
        private Panel panel2;
        private Label lblPrompt;
    }
}