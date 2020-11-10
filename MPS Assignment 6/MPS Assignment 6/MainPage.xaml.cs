using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Banking;

namespace MPS_Assignment_6
{
    public partial class MainPage : ContentPage
    {
        Bank fnb;
        Customer myNewCustomer;
        BankAccount account;

        public MainPage()
        {
            InitializeComponent();
            fnb = new Bank("First National Bank", 4324, "Kenilworth");
            myNewCustomer = new Customer("7766445424", "10 me at home", "Bob", "The Builder");
            fnb.AddCustomer(myNewCustomer);
            account = myNewCustomer.ApplyForBankAccount();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            decimal amount = Decimal.Parse(amountDeposit.Text.ToString());
            string reason = reasonDeposit.Text.ToString();
            account.DepositMoney(amount, DateTime.Now, reason);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            decimal amount = Decimal.Parse(amountWithdraw.Text.ToString());
            string reason = reasonWithdraw.Text.ToString();
            
            account.WithdrawMoney(amount, DateTime.Now, reason);
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            string history = account.GetTransactionHistory();
            TransactionHistory.Text = history;
            DisplayAlert("Transaction History", history, "OK");
        }

        
    }
}
