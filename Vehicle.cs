using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10084788_PROG6221_POE_PART_3
{
    class Vehicle : Expense
    {
        //variables needed to calculate the vehicle monthly repayment amount
        private static string modelAndMake;
        private static double purchasePrice;
        private static double totalDeposit;
        private static double interestRate;
        private static double insurancePremium;
        
        public string ModelAndMake { get { return modelAndMake; } set { modelAndMake = value; } }
        public double PurchasePrice { get { return purchasePrice; } set {purchasePrice = value; } }
        public double TotalDeposit { get { return totalDeposit; } set { totalDeposit = value; } }
        public double InterestRate { get { return interestRate; } set { interestRate = value; } }
        public double InsurancePremium { get { return insurancePremium; } set { insurancePremium = value; } }
        
        public double VehicleMonthlyAmount;



        public override void CalculateMonthly()
        {
            double principleAmount;
            double total;
            double years;
            double interest;
            double totalCost;

            // calculate monthly car amount 
            principleAmount = PurchasePrice - TotalDeposit; // calculates purchase price after deposit
            years = 5; // calculates months
            interest = InterestRate / 100; // sorts out interest rate

            total = principleAmount * (1 + (interest * years)); // the total amount that the user needs to pay
            totalCost = total / 60;
            VehicleMonthlyAmount = Math.Round((totalCost), 2); // calculates monthly home loan repayment


        }
    }
}
