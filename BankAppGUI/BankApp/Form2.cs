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
    public partial class Form2 : Form
    {
        public Form RefToForm1
        {
            get;
            set;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.RefToForm1.Show();
            Close();
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            amtLbl.Visible = true;
            amttxtBox.Visible = true;
            depositBtn.Visible = false;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            BankAccount x;
            if (accttypeBox.SelectedIndex == 0)
            {
                x = CurrentAccount.CreateAccount(nametxtBox.Text, pintxtBox.Text, Convert.ToDouble(amttxtBox.Text));
            }
            else
            {
                x = SavingsAccount.CreateAccount(nametxtBox.Text, pintxtBox.Text, Convert.ToDouble(amttxtBox.Text));
            }
            depositBtn.Visible = false;
            acctnotxtBox.Text = BankAccount.GetAccountNumber(x);
            acctnoLbl.Visible = true;
            acctnotxtBox.Visible = true;
            createBtn.Enabled = false;

        }

      
        private void doneBtn_Click(object sender, EventArgs e)
        {
            this.RefToForm1.Close();
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void accttypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
