using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.RefToForm1 = this;
            frm2.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.RefToForm1 = this;
            frm3.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    /// <summary>
    /// The <c>BankAccount</c> class.
    /// This contains methods to get account number, find account,deposit, withdraw, transfer, 
    /// get balance and interest rate
    /// </summary>
    public class BankAccount
    {
        protected string acctName;
        protected string acctPin;
        protected readonly string acctNo;
        protected double acctBalance;
        protected static int count = 0;
        protected static Dictionary<string, BankAccount> userAccounts = new Dictionary<string, BankAccount>();


        protected BankAccount()
        {
            acctNo = GetAcctNo();
        }

        /// <summary>
        /// The <c>GetAcctNo</c> method.
        /// This generates the account number for each new account created.
        /// </summary>
        /// <returns>The Account Number</returns>
        private string GetAcctNo()
        {
            string No;
            string infix = "2323";
            string postfix = "51";
            int length = count.ToString().Length;
            if (length == 1)
            {
                No = infix + "00" + count + postfix;
            }
            else if (length == 2)
            {
                No = infix + "0" + count + postfix;
            }
            else
            {
                No = infix + count + postfix;
            }
            return No;
        }

 

        /// <summary>
        /// The <c>FindAccount</c> method.
        /// This finds the account given the account number.
        /// </summary>
        /// <param name="acctNo">An account number</param>
        /// <returns>The Account </returns>
        public static BankAccount FindAccount(string acctNo)
        {
            foreach (string x in userAccounts.Keys)
            {
                if (x == acctNo)
                {
                    return userAccounts[x];
                }

            }
            return null;
        }

        /// <summary>
        /// The <c>Deposit</c> method.
        /// This makes a deposit of the specified amount into the specified account.
        /// </summary>
        /// <param name="acctNo">An account number</param>
        /// <param name="depositor">Name of depositor</param>
        /// <param name="amount">Amount to be deposited</param>
        /// <returns>A double value
        /// <list type="bullet">
        /// <item>If the account does not exist --> returns -2 </item>
        /// <item>If deposit is successful --> returns account balance</item>
        ///  </returns>
        public static double Deposit(string acctNo, string depositor, double amount)
        {

            var x = FindAccount(acctNo);
            if (x == null)
            {
                MessageBox.Show("Deposit Failed!\nAccount number: " + acctNo + "\nAccount doesn't exist!\n");
                return -2;
            }
            else
            {
                x.acctBalance += amount;
                if (x.acctName.ToLower() == depositor.ToLower())
                {
                    MessageBox.Show("Deposit Successful!\nAccount name:" + x.acctName +
                    "\nAccount number: " + x.acctNo + "\nDepositor: " + depositor + "\nAmount deposited: " + amount +
                    "\nAccount balance: " + x.acctBalance + "\n");
                }
                else
                {
                    MessageBox.Show("Deposit Successful!\nAccount name:" + x.acctName +
                    "\nAccount number: " + x.acctNo + "\nDepositor: " + depositor + "\nAmount deposited: " + amount + "\n");
                }
                return x.acctBalance;
            }
        }

        /// <summary>
        /// The <c>Withdraw</c> method.
        /// This makes a withdraw of the specified amount.
        /// </summary>
        /// <param name="pin">The pin for the account</param>
        /// <param name="amount">Amount to be withdrawn</param>
        /// <returns>A double value
        /// <list type="bullet">
        /// <item>If the pin is incorrect --> returns -1 </item>
        /// <item>If there is insufficient funds in the account --> 0</item>
        /// <item>If withdraw is successful --> returns account balance</item>
        ///  </returns>
        public double Withdraw(string pin, double amount)
        {
            var x = this;
            if (x.acctPin != pin)
            {
                MessageBox.Show("Withdraw Failed!\nAccount number: " + acctNo + "\nIncorrect Pin\n");
                return -1;
            }
            else
            {
                if (x.acctBalance < amount + 1000)
                {
                    MessageBox.Show("Withdraw Failed!\nAccount name:" + x.acctName + "\nAccount number: " + x.acctNo + "\nInsufficient funds\n");
                    return 0;
                }
                else if (amount >= 150000)
                {
                    double newAmount = InterestRate(amount);
                    x.acctBalance -= newAmount;
                    MessageBox.Show("Withdraw Successful!\nAccount name:" + x.acctName + "\nAccount number: " + x.acctNo +
                        "\nAmount withdrawn: " + amount + "\nAccount balance: " + x.acctBalance + "\n");
                    return x.acctBalance;
                }

                else
                {
                    x.acctBalance -= amount;
                    MessageBox.Show("Withdraw Successful!\nAccount name:" + x.acctName + "\nAccount number: " + x.acctNo +
                        "\nAmount withdrawn: " + amount + "\nAccount balance: " + x.acctBalance + "\n");
                    return x.acctBalance;
                }

            }


        }

        /// <summary>
        /// The <c>Transfer</c> method.
        /// This makes a transfer of the specified amount to the specified account.
        /// </summary>
        /// <param name="pin">The pin for the account</param>
        /// <param name="transferAcctNo">The account number that the specified ammount is to be transferred to</param>
        /// <param name="amount">Amount to be transferred</param>
        /// <returns>A tuple of type double
        /// <list type="bullet">
        /// <item>If the account does not exist --> returns (-2, -2) </item>
        /// <item>If the type of the accounts do not match --> returns (-3, -3) </item>
        /// <item>If the pin is incorrect --> returns (-1, -1) </item>
        /// <item>If there is insufficient funds in the account --> returns (-0, -0)</item>
        /// <item>If transfer is successful --> returns (account balance for account transferred from, 
        /// account balance for account transferred to)</item>
        ///  </returns>
        public Tuple<double, double> Transfer(string pin, string transferAcctNo, double amount)
        {
            var x = this;
            var y = FindAccount(transferAcctNo);
            if (y == null)
            {
                MessageBox.Show("Transfer Failed!\nAccount doesn't exist!\n");
                var result = Tuple.Create(-2.0, -2.0);
                return result;
            }
            //else if (x.GetType() != y.GetType())
            //{
            //    MessageBox.Show("Transfer Failed!\nAccount Type Mismatch!\n");
             //   var result = Tuple.Create(-3.0, -3.0);
             //   return result;
            //}
            else if (x.acctPin != pin)
            {
                MessageBox.Show("Transfer Failed!\nIncorrect Pin\n");
                var result = Tuple.Create(-1.0, -1.0);
                return result;
            }
            else
            {
                if (x.acctBalance < amount + 1000)
                {
                    MessageBox.Show("Transfer Failed!\nInsufficient funds\n");
                    var result = Tuple.Create(0.0, 0.0);
                    return result;
                }
                else if (amount >= 150000)
                {
                    double newAmount = InterestRate(amount);
                    x.acctBalance -= newAmount;
                    y.acctBalance += newAmount;
                    MessageBox.Show("Transfer Successful!\nTransfer from =>\nAccount name:" + x.acctName + "\nAccount number: " + x.acctNo +
                        "\nTransfer to =>\nAccount name:" + y.acctName + "\nAccount number: " + y.acctNo + "\nAmount transferred: " + amount + "\n");
                    var result = Tuple.Create(x.acctBalance, y.acctBalance);
                    return result;
                }
                else
                {
                    x.acctBalance -= amount;
                    y.acctBalance += amount;
                    MessageBox.Show("Transfer Successful!\nTransfer from =>\nAccount name:" + x.acctName + "\nAccount number: " + x.acctNo +
                        "\nTransfer to =>\nAccount name:" + y.acctName + "\nAccount number: " + y.acctNo + "\nAmount transferred: " + amount + "\n");
                    var result = Tuple.Create(x.acctBalance, y.acctBalance);
                    return result;
                }

            }


        }

        /// <summary>
        /// The <c>GetBalance</c> method.
        /// This gets the account balance.
        /// </summary>
        /// <param name="pin">The pin for the account</param>
        /// <returns>A double value
        /// <list type="bullet">
        /// <item>If the pin is incorrect --> returns -1</item>
        /// <item>If balance check is successful --> returns account balance</item>
        ///  </returns>
        public double GetBalance(string pin)
        {
            var x = this;

            if (x.acctPin != pin)
            {
                MessageBox.Show("Balance check Failed!\nAccount number: " + acctNo + "\nIncorrect Pin\n");
                return -1;
            }
            else
            {
                //MessageBox.Show("Account name:" + x.acctName + "\nAccount number: " + x.acctNo + "\nAccount balance: " + x.acctBalance + "\n");
                return x.acctBalance;
            }


        }

        public static string GetAccountNumber(BankAccount acct)
        {
            return acct.acctNo;
        }

        public static string GetAccountName(String acctNo)
        {
            foreach (string x in userAccounts.Keys)
            {
                if (x == acctNo)
                {
                    return userAccounts[x].acctName;
                }

            }
            return null;
        }


        /// <summary>
        /// The <c>InterestRate</c> method.
        /// </summary>
        /// <param name="amount">The amount taken from the account</param>
        /// <returns>A double value of 0 </returns>
        protected virtual double InterestRate(double amount)
        {
            return 0;
        }
    }

    /// <summary>
    /// The <c>SavingsAccount</c> class.
    /// This class is a derived class of the <c>BankAccount</c> class.
    /// This contains method to create account and get interest rate
    /// </summary>
    public class SavingsAccount : BankAccount
    {
        /// <summary>
        /// The <c>CreateAccount</c> method.
        /// This finds the account given the account number.
        /// </summary>
        /// <param name="acctName">The account name</param>
        /// <param name="acctPin">The account pin</param>
        /// <param name="acctBalance">Optional starting balance</param>
        /// <returns>A Savings Account</returns>
        public static SavingsAccount CreateAccount(string acctName, string acctPin, double acctBalance = 0)
        {
            var userAccount = new SavingsAccount();
            userAccount.acctName = acctName;
            userAccount.acctPin = acctPin;
            userAccount.acctBalance = acctBalance;
            userAccounts.Add(userAccount.acctNo,userAccount);
            count += 1;
            MessageBox.Show("Thanks for opening a Savings account at Dolphin Bank\nAccount name: " + userAccount.acctName +
                "\nAccount number: " + userAccount.acctNo + "\nAccount balance: " + userAccount.acctBalance + "\n");
            return userAccount;
        }

        /// <summary>
        /// The <c>InterestRate</c> method.
        /// This calculates the amount to be deducted from the account balance when more than 
        /// 150,000 is to be taken from the account
        /// </summary>
        /// <param name="amount">Amount to be taken from account</param>
        /// <returns>A double value of new amount to be deducted</returns>
        protected override double InterestRate(double amount)
        {
            double rate = 0.001;
            double ans = amount + (rate * amount);
            return ans;
        }
    }

    /// <summary>
    /// The <c>CurrentAccount</c> class.
    /// This class is a derived class of the <c>BankAccount</c> class.
    /// This contains method to create account and get interest rate
    /// </summary>
    public class CurrentAccount : BankAccount
    {
        /// <summary>
        /// The <c>CreateAccount</c> method.
        /// This finds the account given the account number.
        /// </summary>
        /// <param name="acctName">The account name</param>
        /// <param name="acctPin">The account pin</param>
        /// <param name="acctBalance">Optional starting balance</param>
        /// <returns>A Current Account</returns>
        public static CurrentAccount CreateAccount(string acctName, string acctPin, double acctBalance = 0)
        {
            var userAccount = new CurrentAccount();
            userAccount.acctName = acctName;
            userAccount.acctPin = acctPin;
            userAccount.acctBalance = acctBalance;
            userAccounts.Add(userAccount.acctNo, userAccount);
            count += 1;
            MessageBox.Show("Thanks for opening a Current account at Dolphin Bank\nAccount name: " + userAccount.acctName +
                "\nAccount number: " + userAccount.acctNo + "\nAccount balance: " + userAccount.acctBalance + "\n");
            return userAccount;
        }

        /// <summary>
        /// The <c>InterestRate</c> method.
        /// This calculates the amount to be deducted from the account balance when more than 
        /// 150,000 is to be taken from the account
        /// </summary>
        /// <param name="amount">Amount to be taken from account</param>
        /// <returns>A double value of new amount to be deducted</returns>
        protected override double InterestRate(double amount)
        {
            double rate = 0.002;
            double ans = amount + (rate * amount);
            return ans;
        }
    }
}
