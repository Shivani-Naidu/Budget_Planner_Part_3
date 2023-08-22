using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10084788_PROG6221_POE_PART_3
{
    class HomeLoan : Expense
    {
        // declaration of variables needed in the HomeLoan class
        private static double purchasePrice; // purchase price of property
        private static double totalDeposit; // total deposit user has paid
        private static double interestRate; // interest rate of monthly home loan repayment (percentage)
        private static int repayMonths; // number of months to repay home loan
        private static double salaryAmount; // stores user's salary

        



        // get and sets for private variables decalred in HomeLoan class
        public double PurchasePrice { get { return purchasePrice; } set {purchasePrice = value; } }
        public double TotalDeposit { get { return totalDeposit; } set {totalDeposit = value; } }
        public double InterestRate { get { return interestRate; } set { interestRate = value; } }
        public int RepayMonths { get { return repayMonths; } set { repayMonths = value; } }
        public double SalaryAmount { get { return salaryAmount; } set { salaryAmount = value; } }
        
        public double HomeLoanAmount; 

        private static List<string> homeLoanLines = new List<string>();

        public List<string> HomeLoanLines { get { return homeLoanLines; } set { homeLoanLines = value; } }

        public override void CalculateMonthly()
        {
            //Formula to calculate monthly home loan repayment amount --> A = P (1 * (in))

            //variables used to in formula
            double principleAmount;
            double total;
            double years;
            double interest;

            principleAmount = PurchasePrice - TotalDeposit; // calculates purchase price after deposit
            years = RepayMonths / 12; // calculates months
            interest = InterestRate / 100; // sorts out interest rate

            total = principleAmount * (1 + (interest * years)); // the total amount that the user needs to pay
            HomeLoanAmount = Math.Round((total / repayMonths), 2); // calculates monthly home loan repayment
            HomeLoanLines.Add("Your Monthly Home Loan Repayment Is: R" + HomeLoanAmount); // displays amount to user
            if (HomeLoanAmount > (SalaryAmount / 3))
            {
                // displays warning if the monthly home loan repayment amount if greater than a third of the user's salary
               
                HomeLoanLines.Add("Approval Of The Home Loan Is Unlikely. \n" +
                                  "The Monthly Home Loan Repayment Is More Than A Third Of Your Monthly Salary.");
               
            }

            else
            {
                // also notifies user if their home is likely to be approved

                HomeLoanLines.Add("Your Home Loan Is Likely To Be Approved. ");
                

            }
        }

        public double CalculateAvailableAmount(int carOption, double carAmount, double salary, double expenses, double taxAmount, double accommodation)
        {
            if (carOption == 1)
            {
                availAmount = Math.Round((salary - (taxAmount + expenses + accommodation + carAmount)), 2);
            }
            else
            {
                availAmount = Math.Round((salary - (taxAmount + expenses + accommodation)), 2);
            }

            return availAmount;
        }

        public void BudgetReport(int carOption, string CarName, double carAmount, double insurance, double salary, double taxAmount, string output, double availAmount)
        {
            // displays a summary of the the user's expenses, salary, tax amount, rental amount

           
            if (carOption == 1)
            {
                HomeLoanLines.Add("Salary: R" + salary);
                HomeLoanLines.Add("Tax Amount: R" + taxAmount);
                HomeLoanLines.Add("Salary After Tax Deductions: R" + (salary - taxAmount));
               
                HomeLoanLines.Add("Your Monthly Expenses Are As Follows In Descending Order: ");
                HomeLoanLines.Add(output);
                
                HomeLoanLines.Add("Your Monthly Vehicle Repayment on " + CarName + " is: R" + carAmount);
                HomeLoanLines.Add("Your Monthly Vehicle Repayment With Insurance Premium: R" + (carAmount + insurance));

                HomeLoanLines.Add("Your Monthly Available Amount After All Expense Deductions: R" + availAmount);
            }

            else
            {
                HomeLoanLines.Add("Salary: R" + salary);
                HomeLoanLines.Add("Tax Amount: R" + taxAmount);
                HomeLoanLines.Add("Salary After Tax Deductions: R" + (salary - taxAmount));
               
                HomeLoanLines.Add("Your Monthly Expenses Are As Follows In Descending Order: ");
                HomeLoanLines.Add(output);
                

                HomeLoanLines.Add("Your Monthly Available Amount After All Expense Deductions: R" + availAmount);
            }
        }

        public void ClearList()
        { 
        homeLoanLines.Clear();
        
        }
    }
}
