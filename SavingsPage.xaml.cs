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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ST10084788_PROG6221_POE_PART_3
{
    /// <summary>
    /// Interaction logic for SavingsPage.xaml
    /// </summary>
    public partial class SavingsPage : Page
    {
        //Object of the VariableBinding class
        VariableBinding vb = new VariableBinding(); 
        
        public SavingsPage()
        {
            InitializeComponent();

            //set DataContext
            this.DataContext = vb;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Declare variables that are used to calculate the monthly savings amount
            double total;
            double interest;
            double totalAmount;

            //Validate user's input for the savings amount 
            double SavingsAmount = 0;
            if (!double.TryParse(vb.SavingsAmountSTR, out SavingsAmount)) // checks if the amount is null 
                                                                          // or if it a double data type
            {
                // Notify user if they have not entered a value, or if they have entered the incorrect data type
                Notify1.Visibility = Visibility.Visible;
                Notify1.Foreground = Brushes.Red;
                Notify1.Text = "Error. Please Enter A Valid Amount For The Savings Amount.";
            }
            else
            {
                //Notify user that the savings amount has been saved
                Notify1.Visibility = Visibility.Visible;
                Notify1.Foreground = Brushes.Green;
                Notify1.Text = "Saved Successfully!";
            }

            //Validate user's input for the number of years
            int years = 0;
            if (!int.TryParse(vb.YearSTR, out years)) // checks if the amount is null 
                                                      // or if it a double data type
             {
                // Notify user if they have not entered a value, or if they have entered the incorrect data type
                Notify2.Visibility = Visibility.Visible;
                Notify2.Foreground = Brushes.Red;
                Notify2.Text = "Error. Please Enter A Valid Amount For The Number Of Years.";
            }
            else
            {
               //Notify user that the number of years have been saved
                Notify2.Visibility = Visibility.Visible;
                Notify2.Foreground = Brushes.Green;
                Notify2.Text = "Saved Successfully!";
            }

            //Validate user's input for the savings interest rate
            double SavingsInterest = 0;
            if (!double.TryParse(vb.SavingInterestSTR, out SavingsInterest)) // checks if the amount is null 
                                                                             // or if it a double data type 
            {
                // Notify user if they have not entered a value, or if they have entered the incorrect data type
                Notify3.Visibility = Visibility.Visible;
                Notify3.Foreground = Brushes.Red;
                Notify3.Text = "Error. Please Enter A Valid Amount For The Interest(%).";
            }
            else
            {
                //Notify user that the interest rate has been saved
                Notify3.Visibility = Visibility.Visible;
                Notify3.Foreground = Brushes.Green;
                Notify3.Text = "Saved Successfully!";
            }

            if (Notify1.Text == "Saved Successfully!"
             && Notify2.Text == "Saved Successfully!"
             && Notify3.Text == "Saved Successfully!")
            
            {
                ClearButton.Visibility = Visibility.Visible;
                // If all fields have been saved successfully, then the program will calculate and display
                // the monthly savings amount
                MessageBox.Show("Information Has Been Saved Successfully!");

                //Textblock for display monthly savings amount is set to visible
                Savings.Visibility = Visibility.Visible;

                //Calculate monthly savings amount 
                // Formula used --> A = P (1 * (in))
                interest = SavingsInterest / 100;
                total = SavingsAmount * (1 + (interest * (years/12)));
                totalAmount = Math.Round( total / (years * 12), 2);
                
                //Display monthly savings amount in textblock
                Savings.Text = "Amount To Save: R" + SavingsAmount.ToString() + "\n" +
                               "Years To Save: " + years.ToString() + "\n" +
                               "Interest Rate: " + SavingsInterest.ToString() + "% \n" +
                               "You Will Therefore Need To Save R" + totalAmount.ToString() + " Monthly.";
            }

            else
            {
                //Display error message if they have not entered valid inputs
                MessageBox.Show("Error.\nPlease Ensure That All Fields Have Been Filled In Correctly.");
            }




        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {

            //Clear and hide fields
            TextBox1.Clear();
            TextBox2.Clear();
            TextBox3.Clear();

            Savings.Text = String.Empty;
            Savings.Visibility= Visibility.Hidden;

            Notify1.Visibility = Visibility.Hidden;
            Notify2.Visibility = Visibility.Hidden;
            Notify3.Visibility = Visibility.Hidden;
            ClearButton.Visibility = Visibility.Hidden; 

        }
    }
}
