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
    /// Interaction logic for BudgetReportPage.xaml
    /// </summary>
    public partial class BudgetReportPage : Page
    {
        //object of classes
        PopulateArrayLists populateArrayLists = new PopulateArrayLists();
        Vehicle vehicle = new Vehicle();
        VariableBinding vb = new VariableBinding();
        Rental rental = new Rental();
        HomeLoan hml = new HomeLoan();

        //Delegate
        public delegate void DelNotifyUser(double a, double b, double c);

        //List for delegate
        public List<string> DelegateList = new List<string>();


        public BudgetReportPage()
        {
            InitializeComponent();

            //Data context to get data
            this.DataContext = vb;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RichBox1.Visibility = Visibility.Visible;


            if (rental.RentalAmount == 0)
            {
                //Call methods from HomeLoan class
                vehicle.CalculateMonthly();
                hml.CalculateAvailableAmount(vb.VehicleOption, vehicle.VehicleMonthlyAmount, vb.Salary, populateArrayLists.sumArr(), vb.TaxAmount, hml.HomeLoanAmount);
                hml.BudgetReport(vb.VehicleOption, vehicle.ModelAndMake, vehicle.VehicleMonthlyAmount, vehicle.InsurancePremium, vb.Salary, vb.TaxAmount, populateArrayLists.sortArray(), hml.availAmount); // displays budget report
                hml.CalculateMonthly();

                for (int i = 0; i < hml.HomeLoanLines.Count; i++)
                {
                    //Display from HomeLoan class
                    RichBox1.AppendText(Environment.NewLine + hml.HomeLoanLines[i]);
                }

                //Call delegate method
                DelegateMethod();
            }

            else

            {
                //call methods from rental class
                vehicle.CalculateMonthly();
                rental.CalculateMonthly();
                rental.CalculateAvailableAmount(vb.VehicleOption, vehicle.VehicleMonthlyAmount, vb.Salary, populateArrayLists.sumArr(), vb.TaxAmount, rental.RentalAmount); // calculates available amount after expense deductions
                rental.BudgetReport(vb.VehicleOption, vehicle.ModelAndMake, vehicle.VehicleMonthlyAmount, vehicle.InsurancePremium, vb.Salary, vb.TaxAmount, populateArrayLists.sortArray(), rental.RentalAmount, rental.availAmount); // displays budget report
                
                for (int i = 0; i < rental.RentalLines.Count; i++)
                {
                    //Display from HomeLoan class
                    RichBox1.AppendText(Environment.NewLine + rental.RentalLines[i]);
                }
                
                //Call delegate method
                DelegateMethod();
            }
        }


        public void NotifyUser(double rentalAmount, double rentalAvailAmount, double homeLoanAvailAmount)
        {

            //The NotifyUser method notifies the user if their expenses have exceeded over 755 of their salary

            // checks if the rental amount is zero, if it is zero, then it calculates 75% of the HomeLoan available amount
            if (rentalAmount == 0)
            {
                if (homeLoanAvailAmount < (vb.Salary * 0.75))
                {
                    DelegateList.Add("Warning! Your Expenses Have Exceeded Over 75% Of Your Salary.");
                    for (int i = 0; i < DelegateList.Count; i++)
                    {
                        RichBox1.AppendText(Environment.NewLine + DelegateList[i]);
                    }
                }

                else
                {
                    DelegateList.Add("Your Expenses Have Not Exceeded Over 75% Of Your Salary.");
                    for (int i = 0; i < DelegateList.Count; i++)
                    {
                        RichBox1.AppendText(Environment.NewLine + DelegateList[i]);
                    }
                }
            }

            else

            {
                // calculates 75% of the HomeLoan available amount

                if ((rentalAvailAmount) < (vb.Salary * 0.75))
                {
                    DelegateList.Add("Warning! Your Expenses Have Exceeded Over 75% Of Your Salary.");
                    for (int i = 0; i < DelegateList.Count; i++)
                    {
                        RichBox1.AppendText(Environment.NewLine + DelegateList[i]);
                    }

                }

                else
                {
                    DelegateList.Add("Your Expenses Have Not Exceeded Over 75% Of Your Salary.");
                    for (int i = 0; i < DelegateList.Count; i++)
                    {
                        RichBox1.AppendText(Environment.NewLine + DelegateList[i]);
                    }

                }

            }
        }

        public void DelegateMethod()
        {

            // Delegate used to call the NotifyUser method

            DelNotifyUser delegateNotify = new DelNotifyUser(NotifyUser);
            delegateNotify(rental.RentalAmount, rental.availAmount, hml.availAmount);

            
        }

    }
}
