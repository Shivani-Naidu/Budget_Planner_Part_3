using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;

namespace ST10084788_PROG6221_POE_PART_3
{
    /// <summary>
    /// Interaction logic for Accommodation.xaml
    /// </summary>
    public partial class Accommodation : Page
    {
        //Objects of classes
        Rental rental = new Rental();
        HomeLoan hml = new HomeLoan();
        VariableBinding vb = new VariableBinding();
        
        public Accommodation()
        {
            InitializeComponent();

            // Data context to access user's input
            this.DataContext = vb;
        }

        private void RentCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            // if the rent checkbox is checked, rent fields will be made visible
            // property fields will remain hidden
            PropertyCheckBox.IsChecked = false; 

            Notify1.Visibility = Visibility.Hidden;
            RentTextBlock.Visibility = Visibility.Visible;
            RentTextBox.Visibility = Visibility.Visible;
            RentButton.Visibility = Visibility.Visible;
            st_rental.Visibility = Visibility.Visible;

           
            st_property.Visibility = Visibility.Hidden;
            PurchasePriceTextBlock.Visibility = Visibility.Hidden;
            PurchasePriceTextBox.Visibility = Visibility.Hidden;
            DepositTextBlock.Visibility = Visibility.Hidden;
            DepositTextBox.Visibility = Visibility.Hidden;
            InterestTextBlock.Visibility = Visibility.Hidden;
            InterestTextBox.Visibility = Visibility.Hidden;
            IntMonthsTextBlock.Visibility = Visibility.Hidden;
            CB_240.Visibility = Visibility.Hidden;
            CB_360.Visibility = Visibility.Hidden;
            PropertyButton.Visibility = Visibility.Hidden;
            Notify2.Visibility = Visibility.Hidden;
            Notify3.Visibility = Visibility.Hidden;
            Notify4.Visibility = Visibility.Hidden;

        }

        private void PropertyCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            // if the property checkbox is checked, the proeprty fields will be made visible
            // the rent fields will remain hidden
            RentCheckBox.IsChecked = false;

            RentTextBlock.Visibility = Visibility.Hidden;
            RentTextBox.Visibility = Visibility.Hidden;
            RentButton.Visibility = Visibility.Hidden;
            Notify1.Visibility = Visibility.Hidden;
            
            st_rental.Visibility= Visibility.Hidden;

           
            st_property.Visibility = Visibility.Visible;
            PurchasePriceTextBlock.Visibility = Visibility.Visible;
            PurchasePriceTextBox.Visibility = Visibility.Visible;
            DepositTextBlock.Visibility = Visibility.Visible;
            DepositTextBox.Visibility = Visibility.Visible;
            InterestTextBlock.Visibility = Visibility.Visible;
            InterestTextBox.Visibility = Visibility.Visible;
            IntMonthsTextBlock.Visibility = Visibility.Visible;
            CB_240.Visibility = Visibility.Visible;
            CB_360.Visibility = Visibility.Visible;
            PropertyButton.Visibility = Visibility.Visible;
            Notify2.Visibility = Visibility.Hidden;
            Notify3.Visibility = Visibility.Hidden;
            Notify4.Visibility = Visibility.Hidden;
        }

        private void RentCheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            // if the rent checkbox is unchecked, the rent fields will be hidden
            RentCheckBox.IsChecked = false;

            RentTextBlock.Visibility = Visibility.Hidden;
            RentTextBox.Visibility = Visibility.Hidden;
            RentButton.Visibility = Visibility.Hidden;
            Notify2.Visibility = Visibility.Hidden;
            Notify3.Visibility = Visibility.Hidden;
            Notify4.Visibility = Visibility.Hidden;
            rental.RentalAmount = 0;
            Notify1.Visibility = Visibility.Hidden;
           

            st_property.Visibility = Visibility.Hidden;
        }

        private void PropertyCheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            //if the property checkbox is unchecked, the property fields will be made hidden
            PropertyCheckBox.IsChecked = false;

            st_property.Visibility= Visibility.Hidden;
            
            PurchasePriceTextBlock.Visibility = Visibility.Hidden;
            PurchasePriceTextBox.Visibility = Visibility.Hidden;
            DepositTextBlock.Visibility = Visibility.Hidden;
            DepositTextBox.Visibility = Visibility.Hidden;
            InterestTextBlock.Visibility = Visibility.Hidden;
            InterestTextBox.Visibility = Visibility.Hidden;
            IntMonthsTextBlock.Visibility = Visibility.Hidden;
            CB_240.Visibility = Visibility.Hidden;
            CB_360.Visibility = Visibility.Hidden;
            PropertyButton.Visibility = Visibility.Hidden;
            Notify2.Visibility = Visibility.Hidden;
            Notify3.Visibility = Visibility.Hidden;
            Notify4.Visibility = Visibility.Hidden;
            Notify1.Visibility= Visibility.Hidden;
        }

        private void RentButton_Click(object sender, RoutedEventArgs e)
        {
            // validate rental amount from user
            double rentalAmount = 0;
            if (!double.TryParse(vb.RentalAmountSTR, out rentalAmount)) // checks if the user has not entered a value for the rental amount
                                                                        // or if they have entered an invalid data type
            {
                // Notifies user that they have not entered a valid value for the rental amount
                Notify1.Visibility = Visibility.Visible;
                Notify1.Foreground = Brushes.Red;
                Notify1.Text = "Error. Please Enter A Valid Amount For The Rental Amount.";
            }
            else
            {
                // Notifies user that the rental amount has been saved
                Notify1.Visibility = Visibility.Visible;
                Notify1.Foreground = Brushes.Green;
                rental.RentalAmount= rentalAmount;
                Notify1.Text = "Saved Successfully!";
                MessageBox.Show("Rental Amount Has Been Saved Successfully!");
            }
        }

        private void PropertyButton_Click(object sender, RoutedEventArgs e)
        {
            rental.RentalAmount = 0; // sets rental amount to zero since the user has decided to not rent an accommodation


            // validate property purchase price
            double purchasePrice = 0;
            if (!double.TryParse(vb.PurchasePriceSTR, out purchasePrice))  // checks if the user has not entered a value for the purchase price
                                                                           // or if they have entered an invalid data type

            {
                // Notifies user that they have not entered a valid value for the purchase price
                Notify2.Visibility = Visibility.Visible;
                Notify2.Foreground = Brushes.Red;
                Notify2.Text = "Error. Please Enter A Valid Amount For The Purchase Price.";
            }

            else
            {
                // Notifies user that the purchase price has been saved
                Notify2.Visibility = Visibility.Visible;
                Notify2.Foreground = Brushes.Green;
                Notify2.Text = "Saved Successfully!";
            }


            // validate the total deposit paid
            double totalDeposit = 0;
            if (!double.TryParse(vb.TotalDepositSTR, out totalDeposit))  // checks if the user has not entered a value for the total deposit
                                                                         // or if they have entered an invalid data type
            {
                // Notifies user that they have not entered a valid value for the deposit
                Notify3.Visibility = Visibility.Visible;
                Notify3.Foreground = Brushes.Red;
                Notify3.Text = "Error. Please Enter A Valid Amount For The Total Deposit Paid.";
            }

            else
            {
                // Notifies user that the deposit has been saved
                Notify3.Visibility = Visibility.Visible;
                Notify3.Foreground = Brushes.Green;
                Notify3.Text = "Saved Successfully!";
            }


            // validate the interest rate
            double interestRate = 0;
            if (!double.TryParse(vb.InterestRateSTR, out interestRate)) // checks if the user has not entered a value for the interest rate
                                                                        // or if they have entered an invalid data type
            {
                // Notifies user that they have not entered a valid value for the interest rate
                Notify4.Visibility = Visibility.Visible;
                Notify4.Foreground = Brushes.Red;
                Notify4.Text = "Error. Please Enter A Valid Amount For The Interest Rate.";
            }

            else
            {
                // Notifies user that the interest rate has been saved
                Notify4.Visibility = Visibility.Visible;
                Notify4.Foreground = Brushes.Green;
                Notify4.Text = "Saved Successfully!";
            }

            //if the all the input for the property fields have been successfully,
            // the program will store the values to the HomeLoan class
            if (Notify2.Text == "Saved Successfully!"
             && Notify3.Text == "Saved Successfully!"
             && Notify4.Text == "Saved Successfully!"
             && (CB_240.IsChecked == true || CB_360.IsChecked == true))

            {
                //based on which checkbox the user has checked, the RepayMonths value will differ
                if (CB_240.IsChecked == true)
                {
                    hml.RepayMonths = 240;
                
                }


                if (CB_360.IsChecked == true)
                {
                    hml.RepayMonths = 360;
                
                }

                //save values to HomeLoan class
                hml.PurchasePrice = purchasePrice;
                hml.TotalDeposit = totalDeposit;
                hml.InterestRate = interestRate;
                hml.SalaryAmount = vb.Salary;
                MessageBox.Show("Home Loan Details Have Been Saved Successfully!");
            }

            else

            { 
                //Notify user that not all fields have been filled in
                MessageBox.Show("Error.\nPlease Ensure That All Fields Have Been Filled In Correctly."); 
            }

        }

        private void CB_240_Checked(object sender, RoutedEventArgs e)
        {
            CB_360.IsChecked = false;
          
        }

        private void CB_360_Checked(object sender, RoutedEventArgs e)
        {
            CB_240.IsChecked = false;
            
        }

        private void CB_240_UnChecked(object sender, RoutedEventArgs e)
        {
            hml.RepayMonths = 0;
        }

        private void CB_360_UnChecked(object sender, RoutedEventArgs e)
        {
            hml.RepayMonths = 0;
        }





    }
}
