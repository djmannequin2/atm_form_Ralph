using Newtonsoft.Json;
using System.Net.Http;

namespace atm_form
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        static HttpClient client = new HttpClient() { BaseAddress = new Uri("https://localhost:7280/People/") };
        int pin;
        decimal balance;
        bool withdrawAccess = false;
        bool depositAccess = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetButtons();
            lblPrompt.Text = "Please enter your PIN.";
        }

        #region KeyDownEvents
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1)
            {
                one.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad2)
            {
                two.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad3)
            {
                three.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad4)
            {
                four.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad5)
            {
                five.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad6)
            {
                six.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad7)
            {
                seven.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad8)
            {
                eight.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad9)
            {
                nine.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad0)
            {
                zero.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                clear_butt.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                enter_butt.PerformClick();
            }
            else if (e.KeyCode == Keys.Back)
            {
                lblPin.Text = "";
            }
            else if (e.KeyCode == Keys.Decimal)
            {
                period_butt.PerformClick();
            }
        }
        #endregion

        #region NumberClickEvents
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
        private void period_butt_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + ".";
        }
        private void backspace_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text.Remove(lblPin.Text.Length - 1, 1);
        }
        #endregion


        private void clear_butt_Click(object sender, EventArgs e) => ResetButtons();

        private void cancel_butt_Click(object sender, EventArgs e)
        {
            DialogResult iRestart;

            iRestart = MessageBox.Show("Confirm you want to cancel", "ATM System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iRestart == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void loan_system_butt_Click(object sender, EventArgs e)
        {
            monthlyPay_txt.Enabled = true;
            totalPay_txt.Enabled = true;

            //convert typed to double and store it in variable
            double interestRateVar = Convert.ToDouble(interestRate_txt.Text);

            //define monthly rate
            double monthlyInterestRate = interestRateVar / 1200;

            //convert typed to int
            int numberOfYears = Convert.ToInt32(numOfYears_txt.Text);

            //convert typed to double
            double loanAmount = Convert.ToDouble(amtOfLoan_txt.Text);

            //calculate monthly rate based on previous definitions/conversions
            double monthlyPayment = loanAmount * monthlyInterestRate / (1 - 1 / Math.Pow(1 + monthlyInterestRate, numberOfYears * 12));

            //use monthly payment calcuation to define imonthly payment and send it to the text box
            string iMonthlyPayment = Convert.ToString(monthlyPayment);
            iMonthlyPayment = String.Format("{0:C}", monthlyPayment);
            monthlyPay_txt.Text = (iMonthlyPayment);

            //use previously defined variables to define total payment and itotalpayment and send to the text box
            double totalPayment = monthlyPayment * numberOfYears * 12;
            string iTotalPayment = String.Format("{0:C}", totalPayment);
            totalPay_txt.Text = (iTotalPayment);

            //print the amount of the loan
            amtOfLoan_txt.Text = String.Format("{0:C}", loanAmount);
        }

        private void receipt_butt_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Loan Management Systems Calculator" + "\n" +
                                    "------------------------------------" + "\n" +
                                    "Enter the amount of Loan" + "\t" + amtOfLoan_txt.Text + "\n" +
                                    "Enter the number of years" + "\t" + numOfYears_txt.Text + "\n" +
                                    "Enter the interest rate" + "\t" + "\t" + interestRate_txt.Text + "\n" +
                                    "Monthly Payment" + "\t" + "\t" + monthlyPay_txt.Text + "\n" +
                                    "Total Payment" + "\t" + "\t" + "\t" + totalPay_txt.Text + "\n" +
                                    "-----------------------------------" + "\n" +
                                    "------------Thank You--------------" + "\n");
        }

        private async void enter_butt_Click(object sender, EventArgs e)
        {
            if (withdrawAccess == false && depositAccess == false)
            {
                try
                {
                    await PinCheck();
                }
                catch
                {
                    lblPin.Text = "Invalid PIN.";
                }
            }
            else if (withdrawAccess == true && depositAccess == false)
            {
                decimal withdraw = Convert.ToDecimal(lblPin.Text);
                balance = balance - withdraw;
                await SetBalance(Convert.ToString(pin), Convert.ToString(balance));
            }
            else if (withdrawAccess == false && depositAccess == true)
            {
                decimal deposit = Convert.ToDecimal(lblPin.Text);
                balance = balance + deposit;
                await SetBalance(Convert.ToString(pin), Convert.ToString(balance));
            }

        }
        private void loan_butt_Click(object sender, EventArgs e)
        {
            loan_system_butt.Enabled = true;
            receipt_butt.Enabled = true;
            reset_butt.Enabled = true;
            amtOfLoan_txt.Enabled = true;
            numOfYears_txt.Enabled = true;
            interestRate_txt.Enabled = true;
            KeyPreview = false;
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
        private void balance_butt_Click(object sender, EventArgs e) => ShowBalance();
        
        private void withdraw_butt_Click(object sender, EventArgs e)
        {
            withdrawAccess = true;
            lblPin.Text = "";
            lblPrompt.Text = "How much would you like to withdraw?";
        }

        private void deposit_butt_Click(object sender, EventArgs e)
        {
            depositAccess = true;
            lblPin.Text = "";
            lblPrompt.Text = "How much would you like to deposit?";
        }
        

        public void AccessButtons()
        {
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

        #region ResetButtons
        public void ResetButtons()
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
            KeyPreview = true;
        }
        #endregion

        private async Task<decimal> GetBalance()
        {
            string result = await client.GetStringAsync($"{pin}");

            int pFrom = result.IndexOf("\"balance\":") + "\"balance\":".Length;
            int pTo = result.LastIndexOf("}");

            balance = Convert.ToDecimal(result.Substring(pFrom, pTo - pFrom));
            return balance;
        }

        private void ShowBalance()
        {
            lblPrompt.Text = "Available balance: ";
            lblPin.Text = $"{balance:C2}";
        }

        private async Task SetBalance(string pin, string balance)
        {
            Person atm_user = new Person { Id = Convert.ToInt32(pin), Balance = Convert.ToDecimal(balance) };
            var request = new HttpRequestMessage(HttpMethod.Get, $"{pin}");

            var response = await client.SendAsync(request);
            string apiResponse = await response.Content.ReadAsStringAsync();

            atm_user = JsonConvert.DeserializeObject<Person>(apiResponse);

            if (response.IsSuccessStatusCode)
            {
                lblPrompt.Text = "Neat";
            }
            else
                lblPrompt.Text = "No. Bad.";
        }

        private async Task PinCheck()
        {
            pin = Convert.ToInt32(lblPin.Text);
            string result = await client.GetStringAsync($"{pin}");
            await GetBalance();
            AccessButtons();
            lblPrompt.Text = "What would you like to do?";
        }

    }

}