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
    /// Interaction logic for ExpensePage.xaml
    /// </summary>
    public partial class ExpensePage : Page
    {
        //Object of classes
        VariableBinding vb = new VariableBinding();
        PopulateArrayLists populateArrayLists = new PopulateArrayLists(); // Object of the PopulateArrays class
        
        public ExpensePage()
        {
            InitializeComponent();
            
            //create a data context --> source of data to get info
            this.DataContext = vb; 
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Validate user's input for the groceries amount
            double Groceries = 0;
            if (!double.TryParse(vb.groceriesSTR, out Groceries))  // checks if the amount is null 
                                                                   // or if it a double data type
            {
               // Notify user if they have not entered a value, or if they have entered the incorrect data type
                Error3.Visibility = Visibility.Visible;   
                Error3.Foreground = Brushes.Red;
                Error3.Text = "Error. Please Enter A Valid Amount For The Groceries."; 
            }

            else
            {
                //Notify user that the groceries amount has been saved
                Error3.Visibility = Visibility.Visible;
                Error3.Foreground = Brushes.Green;
                Error3.Text = "Saved Successfully!"; 
            }

            //Validate user's input for the water and lights
            double WaterAndLights = 0;
            if (!double.TryParse(vb.waterAndLightsSTR, out WaterAndLights)) // checks if the amount is null 
                                                                            // or if it a double data type
            {
                // Notify user if they have not entered a value, or if they have entered the incorrect data type
                Error4.Visibility = Visibility.Visible;
                Error4.Foreground = Brushes.Red;
                Error4.Text = "Error. Please Enter A Valid Amount For The Water And Lights.";
            }

            else
            {
                //Notify user that the water and lights amount has been saved
                Error4.Visibility = Visibility.Visible;
                Error4.Foreground = Brushes.Green;
                Error4.Text = "Saved Successfully!";
            }

            //Validate user's input for the travel costs
            double TravelCosts = 0;
            if (!double.TryParse(vb.travelCostsSTR, out TravelCosts)) // checks if the amount is null 
                                                                      // or if it a double data type
            {
                // Notify user if they have not entered a value, or if they have entered the incorrect data type
                Error5.Visibility = Visibility.Visible;
                Error5.Foreground = Brushes.Red;
                Error5.Text = "Error. Please Enter A Valid Amount For The Travel Costs.";
            }
            else
            {
                //Notify user that the travel cost amount has been saved
                Error5.Visibility = Visibility.Visible;
                Error5.Foreground = Brushes.Green;
                Error5.Text = "Saved Successfully!";
            }

            //Validate user's input for the telephone costs
            double Telephone = 0;
            if (!double.TryParse(vb.telephoneSTR, out Telephone)) // checks if the amount is null 
                                                                  // or if it a double data type
            {
                // Notify user if they have not entered a value, or if they have entered the incorrect data type
                Error6.Visibility = Visibility.Visible;
                Error6.Foreground = Brushes.Red;
                Error6.Text = "Error. Please Enter A Valid Amount For The Telephone Costs.";
            }
            else
            {
                //Notify user that the telephone cost amount has been saved
                Error6.Visibility = Visibility.Visible;
                Error6.Foreground = Brushes.Green;
                Error6.Text = "Saved Successfully!";
            }


            // if all the basic expenses fields have been saved successfully,
            //the program will then saves these expenses to the arraylist
            // and then make the fields for additional expenses visible
            if (Error3.Text == "Saved Successfully!"
             && Error4.Text == "Saved Successfully!"
             && Error5.Text == "Saved Successfully!"
             && Error6.Text == "Saved Successfully!")

            {
                //save values to arraylist
                populateArrayLists.populateValues("Groceries", Groceries);
                populateArrayLists.populateValues("Water And Lights", WaterAndLights);
                populateArrayLists.populateValues("Travel Costs", TravelCosts);
                populateArrayLists.populateValues("Telephone", Telephone);
                MessageBox.Show("Basic Expenses Have Been Saved Successfully!");

                // make additional expense fields visible once the user has successfully entered values 
                // for the basic expenses

                st_additional.Visibility = Visibility.Visible;
                YesCB.Visibility = Visibility.Visible;
                NoCB.Visibility = Visibility.Visible;
                
            }

            else 
            {
                //Display message to user to warn that the fields have not been saved
                MessageBox.Show("Error.\nPlease Ensure That All Fields Have Been Filled Correctly."); 
            }


        }

        private void YesCB_Checked(object sender, RoutedEventArgs e)
        {

            // if the checks the 'yes' checkbox under the additional expenses section
            // the additional expense fields will become visible
            if (YesCB.IsChecked == true)
            {
                //make fields visible
                NoCB.IsChecked = false;
                ExpenseNameTBlock.Visibility = Visibility.Visible;
                ExpenseTBox.Visibility = Visibility.Visible;
                ExpenseCostTBlock.Visibility = Visibility.Visible;
                ExpenseCostTBox.Visibility = Visibility.Visible;
                Button2.Visibility = Visibility.Visible;
            }
        }

        private void YesCB_UnChecked(object sender, RoutedEventArgs e)
        {
            // if the user unchecked the 'yes' checkbox under the additional expenses section
            // the additional expense fields will become hidden

            if (YesCB.IsChecked == false)
            {
                //hide fields
                NoCB.IsChecked = false;
                ExpenseNameTBlock.Visibility = Visibility.Hidden;
                ExpenseTBox.Visibility = Visibility.Hidden;
                ExpenseCostTBlock.Visibility = Visibility.Hidden;
                ExpenseCostTBox.Visibility = Visibility.Hidden;
                Button2.Visibility = Visibility.Hidden;
                Error7.Visibility = Visibility.Hidden;
                Error8.Visibility = Visibility.Hidden;
            }
        }


        private void NoCB_Checked(object sender, RoutedEventArgs e)
        {
            //acknowledges that the user has not decided to add an additional expense
            YesCB.IsChecked = false;
            MessageBox.Show("Selection Saved!");

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            //validate additional expense name
            if (string.IsNullOrEmpty(vb.additionalExpenseNameSTR)) // checks if the user has entered an additional expense name
            {
                // Notify user if they have not entered a value
                Error7.Visibility = Visibility.Visible;
                Error7.Foreground = Brushes.Red;
                Error7.Text = "Error. Please Enter A Valid Name For The Additional Expense.";  
            }
            else 
            {
                //Notify user that the additional expense name has been saved
                Error7.Visibility = Visibility.Visible;
                Error7.Foreground = Brushes.Green;
                Error7.Text = "Saved Successfully!";

            }

            //validate additional expense cost
            double AdditionalExpenseCost = 0;
            if (!double.TryParse(vb.additionalExpenseCostSTR, out AdditionalExpenseCost)) // checks if the amount is null 
                                                                                          // or if it a double data type
            {
                // Notify user if they have not entered a value, or if they have entered the incorrect data type
                Error8.Visibility = Visibility.Visible;
                Error8.Foreground = Brushes.Red;
                Error8.Text = "Error. Please Enter A Valid Amount For The Additional Expense's Cost.";
            }

            else
            {
                //Notify user that the additional expense cost has been saved
                Error8.Visibility = Visibility.Visible;
                Error8.Foreground = Brushes.Green;
                Error8.Text = "Saved Successfully!";
            }

            // if both the additional expense name and additional expense cost were saved successfully
            // the program will save the values and then clear the fields so that the user can add another
            // additional expense
            if (Error7.Text == "Saved Successfully!"
            && Error8.Text == "Saved Successfully!")

            {
                // adds the additional expense name and cost to the arraylist
                populateArrayLists.populateValues(vb.additionalExpenseNameSTR, AdditionalExpenseCost);
                // clear fields so user can input another additional expense
                vb.additionalExpenseNameSTR = "";
                vb.additionalExpenseCostSTR = "";
                ExpenseCostTBox.Clear();
                ExpenseTBox.Clear();
                Error7.Visibility= Visibility.Hidden;
                Error8.Visibility = Visibility.Hidden;

                

                // notify user that fields for the additional expenses have been saved
                MessageBox.Show("Additional Expenses Have Been Saved Successfully!");
            }

            else 
            { 
                // notifies user that they have not entered the details for the additional expense correctly
                MessageBox.Show("Error.\nPlease Ensure That All Fields Have Been Filled Correctly."); 
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Validate user's input for the salary 
            double Salary = 0;
            if (!double.TryParse(vb.salarySTR, out Salary))  // checks if the amount is null 
                                                             // or if it a double data type
            {
                // Notify user if they have not entered a value, or if they have entered the incorrect data type
                Error1.Visibility = Visibility.Visible;
                Error1.Foreground = Brushes.Red;
                Error1.Text = "Error. Please Enter A Valid Amount For The Salary.";
            }
            else
            {
                //Notify user that the salary amount has been saved
                Error1.Visibility = Visibility.Visible;
                Error1.Foreground = Brushes.Green;
                Error1.Text = "Saved Successfully!";
            }

            //Validate user's input for the tax amount 
            double TaxAmount = 0;
            if (!double.TryParse(vb.taxAmountSTR, out TaxAmount)) // checks if the amount is null 
                                                                  // or if it a double data type
            {
                // Notify user if they have not entered a value, or if they have entered the incorrect data type
                Error2.Visibility = Visibility.Visible;
                Error2.Foreground = Brushes.Red;
                Error2.Text = "Error. Please Enter A Valid Amount For The Tax Amount.";
            }
            else
            {
                //Notify user that the tax amount has been saved
                Error2.Visibility = Visibility.Visible;
                Error2.Foreground = Brushes.Green;
                Error2.Text = "Saved Successfully!";
            }

            // if the salary and tax amount have been saved successfully, the program
            // will then make basic expenses fields visible
            if (Error1.Text == "Saved Successfully!"
             && Error2.Text == "Saved Successfully!")
            {
                //save salary and tax amount
                vb.Salary = Salary;
                vb.TaxAmount = TaxAmount;
                MessageBox.Show("Salary And Tax Amount Have Been Saved Successfully!"); 

                //make expense fields visible once the user has successfully entered a salary and tax amount
                st_basic.Visibility = Visibility.Visible;
                GroceriesTextBlock.Visibility = Visibility.Visible;
                GroceriesTextBox.Visibility = Visibility.Visible;
                WLTextBlock.Visibility = Visibility.Visible;
                WLTextBox.Visibility = Visibility.Visible;
                TCTextBlock.Visibility = Visibility.Visible;
                TCTextBox.Visibility = Visibility.Visible;
                PBTextBlock.Visibility = Visibility.Visible;
                PBTextBox.Visibility = Visibility.Visible;
                BasicButton.Visibility = Visibility.Visible;


            }
        }

        
    }
}
