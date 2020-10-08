using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VenmoApp
{
	public partial class VenmoForm : Form
	{

      VenmoUser[] users = new VenmoUser[6];

		public VenmoForm()
		{
			InitializeComponent();
		}

		private void VenmoApp_Load(object sender, EventArgs e)
		{


         VenmoUser junior = new VenmoUser("Junior", "DoSantos", "Junior@gmail.com");
         junior.AddPaymentMethod(new SavingsAccount());
         junior.AddPaymentMethod(new CheckingAccount());
         users[0] = junior;

         VenmoUser pain = new VenmoUser("Pain", "DeVito", "Pain@gmail.com"); 
         pain.AddPaymentMethod(new SavingsAccount());
         pain.AddPaymentMethod(new CheckingAccount());
         users[1] = pain;

         VenmoUser crusher = new VenmoUser("Crusher", "McPawnface", "Crush@gmail.com");
         crusher.AddPaymentMethod(new SavingsAccount());
         crusher.AddPaymentMethod(new CheckingAccount());
         users[2] = crusher;

         VenmoUser rusty = new VenmoUser("Rusty", "Barnes", "Rusty@gmail.com");
         rusty.AddPaymentMethod(new SavingsAccount());
         rusty.AddPaymentMethod(new CheckingAccount());
         users[3] = rusty;

         VenmoUser adam = new VenmoUser("Adam", "Palehorse", "Adam@gmail.com");
         adam.AddPaymentMethod(new SavingsAccount());
         adam.AddPaymentMethod(new CheckingAccount());
         users[4] = adam;

         VenmoUser seggsy = new VenmoUser("Seggsy", "Davis", "Seggsy@gmail.com");
         seggsy.AddPaymentMethod(new SavingsAccount());
         seggsy.AddPaymentMethod(new CheckingAccount());
         users[5] = seggsy;

         updateLabel();
      }

      private void updateLabel()
      {
         labelVenmoUsers.Text = "";
         foreach (VenmoUser venmo in users)
         {
            labelVenmoUsers.Text += venmo.ToString();
         }
      }

      private void payButton_Click(object sender, EventArgs e)
      {
         int payer = payerComboBox.SelectedIndex;
         int payee = payeeComboBox.SelectedIndex;

         if (payFromAccountListBox.SelectedItem is "Checking Account")
         {
            if (users[payer].payWithChecking(users[payer],users[payee], paymentAmountUpDown.Value))
            {
               users[payee].acceptPayment(users[payee], paymentAmountUpDown.Value, payToAccountListBox.SelectedItem);
            }
            else
            {
               users[payee].acceptPayment(users[payee], 0, payToAccountListBox.SelectedItem);
            }
            
         }
         if (payFromAccountListBox.SelectedItem is "Savings Account")
         {
            if (users[payer].payWithSavings(users[payer], users[payee], paymentAmountUpDown.Value))
            {
               users[payee].acceptPayment(users[payee], paymentAmountUpDown.Value, payToAccountListBox.SelectedItem);
            }
            else
            {
               users[payee].acceptPayment(users[payee], 0, payToAccountListBox.SelectedItem);
            }
         }

         updateLabel();
      }
   }
}
