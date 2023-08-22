using System;
using System.Collections;
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
    /// Interaction logic for VehiclePage.xaml
    /// </summary>
    public partial class VehiclePage : Page
    {
        //Objects of classes
        PopulateArrayLists populateArrayLists = new PopulateArrayLists();
        Vehicle vehicle = new Vehicle();
        VariableBinding vb = new VariableBinding();
        
        public VehiclePage()
        {
            InitializeComponent();
           
            //Data context for accessing information
            this.DataContext = vb;
        }

        private void CB_No_Checked(object sender, RoutedEventArgs e)
        {
            //If the 'No' checkbox is selected, some fields will be made visible
            // other fields will continue to be hidden
            
            CB_Yes.IsChecked = false;
            

            NoButton.Visibility = Visibility.Visible;
            st_panel.Visibility = Visibility.Hidden;
            
            ModelTextBlock.Visibility = Visibility.Hidden;
            PriceTextBlock.Visibility = Visibility.Hidden;
            DepositTextBlock.Visibility = Visibility.Hidden;
            InterestTextBlock.Visibility = Visibility.Hidden;
            InsuranceTextBlock.Visibility = Visibility.Hidden;
            VehicleButton.Visibility = Visibility.Hidden;
            
            Notify1.Visibility = Visibility.Hidden;
            Notify2.Visibility = Visibility.Hidden;
            Notify3.Visibility = Visibility.Hidden;
            Notify4.Visibility = Visibility.Hidden;
            Notify5.Visibility = Visibility.Hidden;
            
            ModelTextBox.Visibility = Visibility.Hidden;
            PriceTextBox.Visibility = Visibility.Hidden;
            DepositTextBox.Visibility = Visibility.Hidden;
            InterestTextBox.Visibility = Visibility.Hidden;
            InsuranceTextBox.Visibility = Visibility.Hidden;

        }

        private void CB_Yes_Checked(object sender, RoutedEventArgs e)
        {
            // If the 'Yes' checkbox is selected, some fields will be made visible
            // other fields will continue to be hidden

            CB_No.IsChecked = false;
            NoButton.Visibility = Visibility.Hidden;
            st_panel.Visibility = Visibility.Visible;
            
            ModelTextBlock.Visibility = Visibility.Visible;
            PriceTextBlock.Visibility = Visibility.Visible;
            DepositTextBlock.Visibility = Visibility.Visible;
            InterestTextBlock.Visibility = Visibility.Visible;
            InsuranceTextBlock.Visibility = Visibility.Visible;
            VehicleButton.Visibility= Visibility.Visible;

            Notify1.Visibility = Visibility.Hidden;
            Notify2.Visibility = Visibility.Hidden;
            Notify3.Visibility = Visibility.Hidden;
            Notify4.Visibility = Visibility.Hidden;
            Notify5.Visibility = Visibility.Hidden;

            ModelTextBox.Visibility = Visibility.Visible;
            PriceTextBox.Visibility = Visibility.Visible;
            DepositTextBox.Visibility = Visibility.Visible;
            InterestTextBox.Visibility = Visibility.Visible;
            InsuranceTextBox.Visibility =Visibility.Visible;
        }

        private void CB_Yes_UnChecked(object sender, RoutedEventArgs e)
        {
            // If the 'Yes' checkbox is unchecked, all fields are hidden
           
            NoButton.Visibility = Visibility.Hidden;
            st_panel.Visibility = Visibility.Hidden;
            
            ModelTextBlock.Visibility = Visibility.Hidden;
            PriceTextBlock.Visibility = Visibility.Hidden;
            DepositTextBlock.Visibility = Visibility.Hidden;
            InterestTextBlock.Visibility = Visibility.Hidden;
            InsuranceTextBlock.Visibility= Visibility.Hidden;
            VehicleButton.Visibility = Visibility.Hidden;

            Notify1.Visibility = Visibility.Hidden;
            Notify2.Visibility = Visibility.Hidden;
            Notify3.Visibility = Visibility.Hidden;
            Notify4.Visibility = Visibility.Hidden;
            Notify5.Visibility = Visibility.Hidden;

            ModelTextBox.Visibility = Visibility.Hidden;
            PriceTextBox.Visibility = Visibility.Hidden;
            DepositTextBox.Visibility = Visibility.Hidden;
            InterestTextBox.Visibility = Visibility.Hidden;
            InsuranceTextBox.Visibility= Visibility.Hidden;
        }

        private void CB_No_UnChecked(object sender, RoutedEventArgs e)
        {
            // If the 'No' checkbox is unchecked, all fields are hidden
            
            CB_Yes.IsChecked = false;
            NoButton.Visibility = Visibility.Hidden;
        }

        private void VehicleButton_Click(object sender, RoutedEventArgs e)
        {
            //get vehicle details and then validate details

            vb.VehicleOption = 1; //sets vehicle option to 1 since the user wants to purchase a vehicle

            //Validate vehicle model number and make
            if (string.IsNullOrEmpty(vb.ModelMakeSTR)) // checks if the user has not entered a value 
            {
                // Notifies user to enter a model number and make
                Notify1.Visibility = Visibility.Visible;
                Notify1.Foreground = Brushes.Red;
                Notify1.Text = "Error. Please Enter A Valid Model Number And Make.";
            }
            else 
            {
                // Notifies user that model number and make have been saved
                Notify1.Visibility = Visibility.Visible;
                Notify1.Foreground = Brushes.Green;
                Notify1.Text = "Saved Successfully!";
            }

            //Validate vehicle purchase price
            double vehiclePrice = 0;
            if (!double.TryParse(vb.PriceSTR, out vehiclePrice)) // checks if the user has not entered a value for the vehicle purchase price
                                                                // or if they have entered an invalid data type 
            {
                // Notifies user they have not entered a valid purchase price for the vehicle
                Notify2.Visibility = Visibility.Visible;
                Notify2.Foreground = Brushes.Red;
                Notify2.Text = "Error. Please Enter A Valid Amount For The Vehicle Purchase Price.";

            }
            else
            {
                // Notifies user that vehicle purchase price has been saved
                Notify2.Visibility = Visibility.Visible;
                Notify2.Foreground = Brushes.Green;
                Notify2.Text = "Saved Successfully!";
            }

            // validate total deposit paid for vehicle
            double vehicleDeposit = 0;
            if (!double.TryParse(vb.DepositSTR, out vehicleDeposit)) // checks if the user has not entered a value for the vehicle deposit
                                                                     // or if they have entered an invalid data type 
            {
                // Notifies user they have not entered a valid value for the vehicle deposit
                Notify3.Visibility = Visibility.Visible;
                Notify3.Foreground = Brushes.Red;
                Notify3.Text = "Error. Please Enter A Valid Amount For The Total Deposit Paid.";
            }
            else
            {
                // Notifies user that vehicle deposit has been saved
                Notify3.Visibility = Visibility.Visible;
                Notify3.Foreground = Brushes.Green;
                Notify3.Text = "Saved Successfully!";
            }


            // validate interest rate for vehicle
            double vehicleInterest = 0;
            if (!double.TryParse(vb.VehicleInterestSTR, out vehicleInterest)) // checks if the user has not entered a value for the vehicle interest rate
                                                                              // or if they have entered an invalid data type
            {
                // Notifies user that they have not entered a valid value for the vehicle interest rate
                Notify4.Visibility = Visibility.Visible;
                Notify4.Foreground = Brushes.Red;
                Notify4.Text = "Error. Please Enter A Valid Amount For The Interest Rate(%).";

            }
            else
            {
                // Notifies user that vehicle interest rate has been saved
                Notify4.Visibility = Visibility.Visible;
                Notify4.Foreground = Brushes.Green;
                Notify4.Text = "Saved Successfully!";
            }

            
            // validate insurance premium for vehicle
            double vehicleInsurance = 0;
            if (!double.TryParse(vb.InsuranceSTR, out vehicleInsurance)) // checks if the user has not entered a value for the vehicle insurance premium
                                                                         // or if they have entered an invalid data type
            {
                // Notifies user that they have not entered a valid value for the vehicle insurance premium
                Notify5.Visibility = Visibility.Visible;
                Notify5.Foreground = Brushes.Red;
                Notify5.Text = "Error. Please Enter A Valid Amount For The Vehicle Insurance Premium.";

            }
            else
            {
                // Notifies user that vehicle insurance premium has been saved
                Notify5.Visibility = Visibility.Visible;
                Notify5.Foreground = Brushes.Green;
                Notify5.Text = "Saved Successfully!";
            }


            // if all fields have been saved successfully, the program will store the values in the vehicle class
            // it will also store the insurance premium as an expense in the arraylist
            if (Notify1.Text == "Saved Successfully!"
             && Notify2.Text == "Saved Successfully!"
             && Notify3.Text == "Saved Successfully!"
             && Notify4.Text == "Saved Successfully!"
             && Notify5.Text == "Saved Successfully!")

            {
                //store values to vehicle class and arraylists
                vehicle.ModelAndMake = vb.ModelMakeSTR;
                vehicle.PurchasePrice = vehiclePrice;
                vehicle.TotalDeposit = vehicleDeposit;
                vehicle.InterestRate = vehicleInterest;
                vehicle.InsurancePremium = vehicleInsurance;
                populateArrayLists.populateValues("Vehicle Insurance Premium", vehicle.InsurancePremium);
                MessageBox.Show("Vehicle Details Have Been Saved Successfully!");
            }

            else

            {
                // notifies user that not all fields have been saved successfully
                MessageBox.Show("Error!\nPlease Ensure That All Fields Have Been Filled In Correctly.");

            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            


        }

        

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            vb.VehicleOption = 0; // sets vehicle option to zero since the user has decided to not purchase a vehicle
            MessageBox.Show("Selection Saved!");
        }

        private void ModelTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //clears textboxes and unchecks checkboxes
            ModelTextBox.Clear();
            PriceTextBox.Clear();
            DepositTextBox.Clear();
            InterestTextBox.Clear();
            InsuranceTextBox.Clear();
            CB_Yes.IsChecked = false;
            CB_No.IsChecked = false;
        }
    }
}
