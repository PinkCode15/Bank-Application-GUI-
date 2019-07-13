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
    
    public partial class Form3 : Form
    {
        int click;
        BankAccount theAccount;
        public Form RefToForm1
        {
            get;
            set;
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.RefToForm1.Show();
            Close();
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            this.RefToForm1.Close();
            Close();
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            click = 1;
            acct2Lbl.Visible = true;
            acct2txtBox.Visible = true;
            amounttxtBox.Visible = true;
            amountLbl.Visible = true;
            balLbl.Visible = false;
            depnameLbl.Text = "Name";
            depnameLbl.Visible = true;
            depnamextxBox.Visible = true;
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            click = 2;
            acct2Lbl.Visible = false;
            acct2txtBox.Visible = false;
            balLbl.Visible = false;
            depnameLbl.Text = "Pin";
            depnameLbl.Visible = true;
            depnamextxBox.Visible = true;
            amounttxtBox.Visible = true;
            amountLbl.Visible = true;
        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            click = 3;
            acct2Lbl.Visible = true;
            acct2txtBox.Visible = true;
            balLbl.Visible = false;
            depnameLbl.Text = "Pin";
            depnameLbl.Visible = true;
            depnamextxBox.Visible = true;
            amounttxtBox.Visible = true;
            amountLbl.Visible = true;

        }

        private void balanceBtn_Click(object sender, EventArgs e)
        {
            click = 4;
            acct2Lbl.Visible = false;
            acct2txtBox.Visible = false;
            balLbl.Visible = false;
            amountLbl.Visible = false;
            amounttxtBox.Visible = false;
            depnameLbl.Text = "Pin";
            depnameLbl.Visible = true;
            depnamextxBox.Visible = true;
            
            
        }
        private void okBtn_Click(object sender, EventArgs e)
        {
            
            switch (click)
            {
                case 0:
                    break;
                case 1:
                    BankAccount.Deposit(acctnotxtBox.Text, depnamextxBox.Text, Convert.ToDouble(amounttxtBox.Text));
                    withdrawBtn.Enabled = false;
                    transferBtn.Enabled = false;
                    balanceBtn.Enabled = false;
                    break;
                case 2:
                    theAccount.Withdraw(depnamextxBox.Text, Convert.ToDouble(amounttxtBox.Text));
                    depositBtn.Enabled = false;
                    transferBtn.Enabled = false;
                    balanceBtn.Enabled = false;
                    break;
                case 3:
                    theAccount.Transfer(depnamextxBox.Text,acct2txtBox.Text,Convert.ToDouble(amounttxtBox.Text));
                    depositBtn.Enabled = false;
                    withdrawBtn.Enabled = false;
                    balanceBtn.Enabled = false;
                    break;
                case 4:
                    var x = theAccount.GetBalance(depnamextxBox.Text);
                    withdrawBtn.Enabled = false;
                    depositBtn.Enabled = false;
                    transferBtn.Enabled = false;
                    if(!(x == -1))
                    {
                        depnameLbl.Visible = false;
                        depnamextxBox.Visible = false;
                        balLbl.Visible = true;
                        balLbl.Text = "Account name:" + BankAccount.GetAccountName(acctnotxtBox.Text) + "\nAccount number: " + acctnotxtBox.Text + "\nAccount balance: " + theAccount.GetBalance(depnamextxBox.Text)  + "\n";
                    }
                    break;

            }
            okBtn.Enabled = false;
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            theAccount = BankAccount.FindAccount(acctnotxtBox.Text);
            if ((theAccount == null))
            {
                MessageBox.Show("\nAccount doesn't exist!\n");
            }
            else
            {
                depositBtn.Visible = true;
                withdrawBtn.Visible = true;
                transferBtn.Visible = true;
                balanceBtn.Visible = true;
                welcomeLbl.Visible = true;
                okBtn.Visible = true;
                doneBtn.Visible = true;
                enterBtn.Visible = false;
                welcomeLbl.Text = "Welcome " + BankAccount.GetAccountName(acctnotxtBox.Text);
                acctnotxtBox.Enabled = false;
            }


        }
    }
}
