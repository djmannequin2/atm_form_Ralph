namespace atm_form
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBalance.Visible = false;
            lblLoan.Visible = false;
            lblDeposit.Visible = false;
            lblWithdraw.Visible = false;
            loan_butt.Enabled = false;
            deposit_butt.Enabled = false;
            withdraw_butt.Enabled = false;
            balance_butt.Enabled = false;
            loan_system_butt.Enabled = false;
            receipt_butt.Enabled = false;
            reset_butt.Enabled = false;
            amtOfLoan_txt.Enabled = false;
            numOfYears_txt.Enabled = false;
            interestRate_txt.Enabled = false;
            monthlyPay_txt.Enabled = false;
            totalPay_txt.Enabled = false;




        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1)
            {
                one.PerformClick();
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "1";
            
        }

        private void two_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "2";

        }

        private void three_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "3";

        }

        private void four_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "4";

        }

        private void five_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "5";

        }

        private void six_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "6";

        }

        private void seven_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "7";

        }

        private void eight_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "8";

        }

        private void nine_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "9";

        }

        private void zero_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "0";

        }

        private void interestRate_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "0";

        }

        private void clear_butt_Click(object sender, EventArgs e)
        {
            lblPin.Text = "";
            lblBalance.Visible = false;
            lblLoan.Visible = false;
            lblDeposit.Visible = false;
            lblWithdraw.Visible = false;
            loan_butt.Enabled = false;
            deposit_butt.Enabled = false;
            withdraw_butt.Enabled = false;
            balance_butt.Enabled = false;
            loan_system_butt.Enabled = false;
            receipt_butt.Enabled = false;
            reset_butt.Enabled = false;
            amtOfLoan_txt.Enabled = false;
            numOfYears_txt.Enabled = false;
            interestRate_txt.Enabled = false;
            monthlyPay_txt.Enabled = false;
            totalPay_txt.Enabled = false;

        }

        private void cancel_butt_Click(object sender, EventArgs e)
        {
            DialogResult iRestart;

            iRestart = MessageBox.Show("Confirm you want to cancel", "ATM System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iRestart == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        // Hide this logic
        private void loan_system_butt_Click(object sender, EventArgs e)
        {
            double interestRateVar = Convert.ToDouble(interestRate_txt.Text);
            double monthlyInterestRate = interestRateVar / 1200;
            int numberOfYears = Convert.ToInt32(numOfYears_txt.Text);
            double loanAmount = Convert.ToDouble(amtOfLoan_txt.Text);

            double monthlyPayment = loanAmount * monthlyInterestRate / (1 - 1 / Math.Pow(1 + monthlyInterestRate, numberOfYears * 12));

            string iMonthlyPayment = Convert.ToString(monthlyPayment);
            iMonthlyPayment = String.Format("{0:C}", monthlyPayment);
            monthlyPay_txt.Text = (iMonthlyPayment);

            double totalPayment = monthlyPayment * numberOfYears * 12;
            string iTotalPayment = String.Format("{0:C}", totalPayment);
            totalPay_txt.Text = (iTotalPayment);

            amtOfLoan_txt.Text = String.Format("{0:C}", loanAmount);
        }
        // End

        private void receipt_butt_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Loan Management Systems Calculator" + "\n");
            richTextBox1.AppendText("------------------------------------" + "\n");
            richTextBox1.AppendText("Enter the amount of Loan" + "\t" + amtOfLoan_txt.Text + "\n");
            richTextBox1.AppendText("Enter the number of years" + "\t" + numOfYears_txt.Text + "\n");
            richTextBox1.AppendText("Enter the interest rate" + "\t" + "\t" + interestRate_txt.Text + "\n");
            richTextBox1.AppendText("Monthly Payment" + "\t" + "\t" + monthlyPay_txt.Text + "\n");
            richTextBox1.AppendText("Total Payment" + "\t" + "\t" + "\t" + totalPay_txt.Text + "\n");
            richTextBox1.AppendText("-----------------------------------" + "\n");
            richTextBox1.AppendText("------------Thank You--------------" + "\n");
        }

        private void enter_butt_Click(object sender, EventArgs e)
        {
            // 
            // Put this part in a new class
            //

            string pin1 = string.Format(lblPin.Text);
            string pin2 = string.Format(lblPin.Text);
            string pin3 = string.Format(lblPin.Text);
            string pin4 = string.Format(lblPin.Text);
            string pin5 = string.Format(lblPin.Text);

            string name;
            double balance;

            if (pin1 == "1234")
            {
                name = "Charles";
                balance = 0.03;
                lblBalance.Visible = true;
                lblLoan.Visible = true;
                lblDeposit.Visible = true;
                lblWithdraw.Visible = true;
                loan_butt.Enabled = true;
                deposit_butt.Enabled = true;
                withdraw_butt.Enabled = true;
                balance_butt.Enabled = true;
                lblPin.Text = "";

            }

            else if (pin2 == "2345")
            {
                name = "Barbara";
                balance = 100451.03;
                lblBalance.Visible = true;
                lblLoan.Visible = true;
                lblDeposit.Visible = true;
                lblWithdraw.Visible = true;
                loan_butt.Enabled = true;
                deposit_butt.Enabled = true;
                withdraw_butt.Enabled = true;
                balance_butt.Enabled = true;
                lblPin.Text = "";


            }
            else if (pin3 == "3456")
            {
                name = "Clarence";
                balance = 17384.02;
                lblBalance.Visible = true;
                lblLoan.Visible = true;
                lblDeposit.Visible = true;
                lblWithdraw.Visible = true;
                loan_butt.Enabled = true;
                deposit_butt.Enabled = true;
                withdraw_butt.Enabled = true;
                balance_butt.Enabled = true;
                lblPin.Text = "";


            }
            else if (pin4 == "4567")
            {
                name = "Brianna";
                balance = 34.20;
                lblBalance.Visible = true;
                lblLoan.Visible = true;
                lblDeposit.Visible = true;
                lblWithdraw.Visible = true;
                loan_butt.Enabled = true;
                deposit_butt.Enabled = true;
                withdraw_butt.Enabled = true;
                balance_butt.Enabled = true;
                lblPin.Text = "";


            }
            else if (pin5 == "5678")
            {
                name = "Sam";
                balance = 1345.52;
                lblBalance.Visible = true;
                lblLoan.Visible = true;
                lblDeposit.Visible = true;
                lblWithdraw.Visible = true;
                loan_butt.Enabled = true;
                deposit_butt.Enabled = true;
                withdraw_butt.Enabled = true;
                balance_butt.Enabled = true;
                lblPin.Text = "";


            }
            else { lblPin.Text = "Entered PIN is invalid."; }
        }
            //
            // End
            //

        private void loan_butt_Click(object sender, EventArgs e)
        {
            // Create a "right side enabled" or something method
            loan_system_butt.Enabled = true;
            receipt_butt.Enabled = true;
            reset_butt.Enabled = true;
            amtOfLoan_txt.Enabled = true;
            numOfYears_txt.Enabled = true;
            interestRate_txt.Enabled = true;
            monthlyPay_txt.Enabled = true;
            totalPay_txt.Enabled = true;
        }

        private void exit_butt_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm you want to exit", "ATM System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void reset_butt_Click(object sender, EventArgs e)
        {
            amtOfLoan_txt.Clear();
            numOfYears_txt.Clear();
            interestRate_txt.Clear();
            monthlyPay_txt.Clear();
            totalPay_txt.Clear();
            richTextBox1.Clear();

        }
        private void balance_butt_Click(object sender, EventArgs e)
        {
        }

    }
}