using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
//using System.Windows.Controls;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ExpensePage expensePage = new ExpensePage();
        Accommodation accommodation = new Accommodation();
        VehiclePage vehicle = new VehiclePage();
        BudgetReportPage budgetReportPage = new BudgetReportPage();
        DisplayIcon displayIcon = new DisplayIcon();
        SavingsPage savingsPage = new SavingsPage();
        HomePage homePage = new HomePage();
        PopulateArrayLists populateArrayLists = new PopulateArrayLists();
        Rental rental = new Rental();
        HomeLoan hml = new HomeLoan();

        public MainWindow()
        {
            InitializeComponent();
           
            

        }


        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            // Tooltip visibility is disabled when the panel is hidden

            if (Tg_Btn.IsChecked == true)
            {
                tt_Home.Visibility = Visibility.Collapsed;
                tt_Expense.Visibility = Visibility.Collapsed;
                tt_Housing.Visibility = Visibility.Collapsed;
                tt_Vehicle.Visibility = Visibility.Collapsed;
                tt_BudgetRep.Visibility = Visibility.Collapsed;
                tt_Reset.Visibility = Visibility.Collapsed;
                tt_Savings.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_Home.Visibility = Visibility.Visible;
                tt_Expense.Visibility = Visibility.Visible;
                tt_Housing.Visibility = Visibility.Visible;
                tt_Vehicle.Visibility = Visibility.Visible;
                tt_BudgetRep.Visibility = Visibility.Visible;
                tt_Reset.Visibility = Visibility.Visible;
                tt_Savings.Visibility= Visibility.Visible;

            }
        }
        
        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            Tg_Btn.IsChecked = false;
            nav_panel.Width = 80;
            FrameMain.Content = homePage;


            
        }

        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            Tg_Btn.IsChecked = false;
            nav_panel.Width = 80;
            FrameMain.Content =  expensePage;
            


        }

        private void ListViewItem_Selected_2(object sender, RoutedEventArgs e)
        {
            Tg_Btn.IsChecked = false;
            nav_panel.Width = 80;
            FrameMain.Content = accommodation;
           
        }

        private void ListViewItem_Selected_3(object sender, RoutedEventArgs e)
        {
            Tg_Btn.IsChecked = false;
            nav_panel.Width = 80;
            FrameMain.Content = vehicle;
           
        }

        private void LV5_Selected(object sender, RoutedEventArgs e)
        {
            Tg_Btn.IsChecked = false;
            nav_panel.Width = 80;
            FrameMain.Content = budgetReportPage;



        }

        private void Window_Activated(object sender, EventArgs e)
        {
            

        }

        private void LV6_Selected(object sender, RoutedEventArgs e)
        {
            Tg_Btn.IsChecked = false;
            nav_panel.Width = 80;
            FrameMain.Content = savingsPage;

        }

        private void FrameMain_Loaded(object sender, RoutedEventArgs e)
        {
            FrameMain.Content = displayIcon;
        }

        private void LV7_Selected(object sender, RoutedEventArgs e)
        {
            //Reset fields for ExpensePage
            expensePage.SalaryTextBox.Clear();
            expensePage.TaxTextBox.Clear();
            expensePage.GroceriesTextBlock.Visibility = Visibility.Hidden;
            expensePage.WLTextBlock.Visibility = Visibility.Hidden;
            expensePage.TCTextBlock.Visibility = Visibility.Hidden;
            expensePage.PBTextBlock.Visibility = Visibility.Hidden;
            expensePage.GroceriesTextBox.Clear();
            expensePage.WLTextBox.Clear();
            expensePage.TCTextBox.Clear();
            expensePage.PBTextBox.Clear();
            expensePage.ExpenseTBox.Clear();
            expensePage.GroceriesTextBox.Visibility = Visibility.Hidden;
            expensePage.WLTextBox.Visibility = Visibility.Hidden;
            expensePage.TCTextBox.Visibility = Visibility.Hidden;
            expensePage.PBTextBox.Visibility = Visibility.Hidden;
            

            expensePage.ExpenseCostTBox.Clear();
            expensePage.YesCB.IsChecked = false;
            expensePage.NoCB.IsChecked = false;
            expensePage.YesCB.Visibility = Visibility.Hidden;
            expensePage.NoCB.Visibility = Visibility.Hidden;
            expensePage.BasicButton.Visibility = Visibility.Hidden;
            expensePage.Error1.Visibility = Visibility.Hidden;
            expensePage.Error2.Visibility = Visibility.Hidden;
            expensePage.Error3.Visibility = Visibility.Hidden;
            expensePage.Error4.Visibility = Visibility.Hidden;
            expensePage.Error5.Visibility = Visibility.Hidden;
            expensePage.Error6.Visibility = Visibility.Hidden;
            expensePage.Error7.Visibility = Visibility.Hidden;
            expensePage.Error8.Visibility = Visibility.Hidden;
            expensePage.st_basic.Visibility = Visibility.Hidden;
            expensePage.st_additional.Visibility = Visibility.Hidden;

            //Reset fields for Accommodation page

            accommodation.PropertyCheckBox.IsChecked= false;
            accommodation.RentCheckBox.IsChecked= false;
            accommodation.RentTextBox.Clear();
            accommodation.PurchasePriceTextBox.Clear();
            accommodation.DepositTextBox.Clear();
            accommodation.InterestTextBox.Clear();
            accommodation.CB_240.IsChecked= false;
            accommodation.CB_360.IsChecked = false;
            accommodation.st_property.Visibility= Visibility.Hidden;
            accommodation.st_rental.Visibility= Visibility.Hidden;

            //Reset fields for Vehicle page

            vehicle.CB_Yes.IsChecked= false;
            vehicle.CB_No.IsChecked = false;
            vehicle.PriceTextBox.Clear();
            vehicle.DepositTextBox.Clear();
            vehicle.ModelTextBox.Clear();
            vehicle.InterestTextBox.Clear();
            vehicle.InsuranceTextBox.Clear();
            vehicle.st_panel.Visibility= Visibility.Hidden;

            //reset fields for budget report page
            budgetReportPage.RichBox1.Document.Blocks.Clear();
            budgetReportPage.RichBox1.Visibility= Visibility.Hidden;

            // clear array lists and list
            populateArrayLists.clearArrayList();

            // clear fields in savings page
            savingsPage.TextBox1.Clear();
            savingsPage.TextBox2.Clear();
            savingsPage.TextBox3.Clear();

            savingsPage.Savings.Text = String.Empty;
            savingsPage.Savings.Visibility = Visibility.Hidden;

            savingsPage.Notify1.Visibility = Visibility.Hidden;
            savingsPage.Notify2.Visibility = Visibility.Hidden;
            savingsPage.Notify3.Visibility = Visibility.Hidden;
            savingsPage.ClearButton.Visibility= Visibility.Hidden;

            // clear lists
            hml.ClearList();
            rental.ClearList();

            MessageBox.Show("Application Has Been Reset.");
            Tg_Btn.IsChecked = false;
            nav_panel.Width = 80;
            FrameMain.Content = displayIcon;


           

        }
    }
}


