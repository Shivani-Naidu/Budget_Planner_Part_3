using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10084788_PROG6221_POE_PART_3
{
    public class VariableBinding
    {

        // variables needed for ExpensePage binding

        public string groceriesSTR { get; set; }
        public string waterAndLightsSTR { get; set; }
        public string travelCostsSTR { get; set; }
        public string telephoneSTR { get; set; }
        public string additionalExpenseNameSTR { get; set; }
        public string additionalExpenseCostSTR { get; set; }
        public string salarySTR { get; set; }
        public string taxAmountSTR { get; set; }

        public int VehicleOptionSTR { get; set; }


        // variables needed for VehiclePage

        public string ModelMakeSTR { get; set; }
        public string PriceSTR { get; set; }

        public string DepositSTR { get; set; }

        public string VehicleInterestSTR { get; set; }

        public string InsuranceSTR { get; set; }

        



        // variables needed for accommodation page

        public string PurchasePriceSTR { get; set; }
        public string TotalDepositSTR { get; set; }
        public string InterestRateSTR { get; set; }
        public string RepayMonthsSTR { get; set; }

        public string RentalAmountSTR { get; set; }




        private static double salary;
        public  double Salary
        { 
        get { return salary; }
            set { salary = value; }
        }
        
        
        private static double taxAmount;
        public double TaxAmount
        {
            get { return taxAmount; }
            set { taxAmount = value; }
        }

        

        private static int vehicleOption;
        public int VehicleOption
        {
            get { return vehicleOption; }
            set { vehicleOption = value; }
        }


        // Variables for saving page


        public string SavingsAmountSTR { get; set; }
        public string YearSTR { get; set; }

        public string SavingInterestSTR { get; set; }

        











    }
}
