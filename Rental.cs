using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10084788_PROG6221_POE_PART_3
{
    class Rental : Expense
    {
        // Rental class extends Expense class

        private static double rentalAmount;
        private static string rentalAmountSTR;

        public double RentalAmount { get { return rentalAmount; } set { rentalAmount = value; } }
        public string RentalAmountSTR { get { return rentalAmountSTR; } set { rentalAmountSTR = value; } }

        private static List<string> rentalLines = new List<string>();

        public List<string> RentalLines { get { return rentalLines; } set { rentalLines = value; } }
        public override void CalculateMonthly()
        {
            RentalAmount = Math.Round(RentalAmount);

        }

        public double CalculateAvailableAmount(int carOption, double carAmount, double salary, double expenses, double taxAmount, double accommodation)
        {   // calculates available amount after expense deductions

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


        public void BudgetReport(int carOption, string CarName, double carAmount, double insurance, double salary, double taxAmount, string sort, double accommodation, double availAmount)
        {
            PopulateArrayLists parr = new PopulateArrayLists();
            // displays a summary of the the user's expenses, salary, tax amount, rental amount

           
          
           
            if (carOption == 1)
            {
                RentalLines.Add("Salary: R" + salary);
                RentalLines.Add("Tax Amount: R" + taxAmount);
                RentalLines.Add("Salary After Tax Deductions: R" + (salary - taxAmount));
               
                RentalLines.Add("Your Monthly Expenses Are As Follows In Descending Order: ");
                RentalLines.Add(sort);
               
                RentalLines.Add("Your Monthly Vehicle Repayment on " + CarName + " is: R" + carAmount);
                RentalLines.Add("Your Monthly Vehicle Repayment With Insurance Premium: R" + (carAmount + insurance));
                RentalLines.Add("Your Monthly Rental Amount: R" + accommodation);
                RentalLines.Add("Your Monthly Available Amount After All Expense Deductions: R" + availAmount);
            }

            else
            {
                RentalLines.Add("Salary: R" + salary);
                RentalLines.Add("Tax Amount: R" + taxAmount);
                RentalLines.Add("Salary After Tax Deductions: R" + (salary - taxAmount));
               
                RentalLines.Add("Your Monthly Expenses Are As Follows In Descending Order: ");
                RentalLines.Add(sort);
               
                RentalLines.Add("Your Monthly Rental Amount: R" + accommodation);
                RentalLines.Add("Your Monthly Available Amount After All Expense Deductions: R" + availAmount);
            }
        }

        public void ClearList()
        {
            rentalLines.Clear();

        }
    }
}
