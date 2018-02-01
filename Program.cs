using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_297_Program1

{
    class taxForms
    {
        static int _userIncome;
        static int _grossIncome;
        static int _adjustedGrossIncome;
        static int _itemizedDeduction;
        static double totalTax;
        static double taxAtBracket;
        static double grossIncomePercentage;
        static double adjustedIncomePercentage;
        static int standardDeduction = 6350;
        public static string deductionStatus;
        
        static void Main(string[] arg)
        {
            Console.WriteLine("**Enter your earnings. Enter '0' to signify end of earnings**");
            do
            {
                string line = Console.ReadLine();
                _userIncome = int.Parse(line);
                _grossIncome += _userIncome;
            } while (_userIncome != 0);
            Console.Write("Gross Income: ");
            Console.WriteLine(_grossIncome);
            _adjustedGrossIncome = _grossIncome;
            Console.WriteLine("If you had any itemized deductions enter a 'I'. If not, enter a 'S'.");
            deductionStatus = Console.ReadLine();
            if (deductionStatus == "I")
            {
                Console.WriteLine("Enter the amounts of the itemized deductions. Enter 0 once finished.");
                do
                {
                    string line2 = Console.ReadLine();
                    _itemizedDeduction = int.Parse(line2);
                    _adjustedGrossIncome -= _itemizedDeduction;
                 } while (_itemizedDeduction != 0);
            }
            else if (deductionStatus == "S")
            {
                _adjustedGrossIncome -= standardDeduction;
            }
            if (_adjustedGrossIncome < 0)
            {
                Console.WriteLine("Total taxes owed: $0");
            }
            else if(_adjustedGrossIncome > 0 && _adjustedGrossIncome < 9325) //10% tax bracket
            {
                totalTax = _adjustedGrossIncome * .1;
                grossIncomePercentage = (totalTax / _grossIncome) * 100;
                grossIncomePercentage = Math.Round((double)grossIncomePercentage, 2);
                adjustedIncomePercentage = (totalTax / _adjustedGrossIncome) * 100;
                adjustedIncomePercentage = Math.Round((double)adjustedIncomePercentage, 2);
                Console.WriteLine($"Taxes owed at 10%: ${totalTax}");
                Console.WriteLine($"Total taxes owed: ${totalTax}");
                Console.WriteLine($"Taxes as a percentage of Gross Income: {grossIncomePercentage}%");
                Console.WriteLine($"Taxes as a percentage of Adjusted Gross Income: {adjustedIncomePercentage}%");
            }
            else if (_adjustedGrossIncome > 9325 && _adjustedGrossIncome < 37950) //15% tax bracket
            {
                taxAtBracket = ((_adjustedGrossIncome - 9325)* .15);
                totalTax = 932.5 + taxAtBracket;
                grossIncomePercentage = (totalTax / _grossIncome) * 100;
                adjustedIncomePercentage = (totalTax / _adjustedGrossIncome) * 100;
                adjustedIncomePercentage = Math.Round((double)adjustedIncomePercentage, 2);
                Console.WriteLine($"Taxes owed at 10%: $932.50");
                Console.WriteLine($"Taxes owed at 15%: ${taxAtBracket}");
                Console.WriteLine($"Total taxes owed: ${totalTax}");
                Console.WriteLine($"Taxes as a percentage of Gross Income: {grossIncomePercentage}%");
                Console.WriteLine($"Taxes as a percentage of Adjusted Gross Income: {adjustedIncomePercentage}%");
            }
            else if (_adjustedGrossIncome > 37950 && _adjustedGrossIncome < 91900) //25% tax bracket
            {
                taxAtBracket = ((_adjustedGrossIncome - 37950) * .25);
                totalTax = 932.5  + 4293.75 + taxAtBracket;
                grossIncomePercentage = (totalTax / _grossIncome) * 100;
                grossIncomePercentage = Math.Round((double)grossIncomePercentage, 2);
                adjustedIncomePercentage = (totalTax / _adjustedGrossIncome) * 100;
                adjustedIncomePercentage = Math.Round((double)adjustedIncomePercentage, 2);
                Console.WriteLine($"Taxes owed at 10%: $932.50");
                Console.WriteLine($"Taxes owed at 15%: $4293.75");
                Console.WriteLine($"Taxes owed at 25%: ${taxAtBracket}");
                Console.WriteLine($"Total taxes owed: ${totalTax}");
                Console.WriteLine($"Taxes as a percentage of Gross Income: {grossIncomePercentage}%");
                Console.WriteLine($"Taxes as a percentage of Adjusted Gross Income: {adjustedIncomePercentage}%");
            }
            else if (_adjustedGrossIncome > 91900 && _adjustedGrossIncome < 191650) //28% tax bracket
            {
                taxAtBracket = ((_adjustedGrossIncome - 91900) * .28);
                totalTax = 932.5 + 4293.75 + 13487.5 + taxAtBracket;
                grossIncomePercentage = (totalTax / _grossIncome) * 100;
                grossIncomePercentage = Math.Round((double)grossIncomePercentage, 2);
                adjustedIncomePercentage = (totalTax / _adjustedGrossIncome) * 100;
                adjustedIncomePercentage = Math.Round((double)adjustedIncomePercentage, 2);
                Console.WriteLine($"Taxes owed at 10%: $932.50");
                Console.WriteLine($"Taxes owed at 15%: $4293.75");
                Console.WriteLine($"Taxes owed at 25%: $13487.50");
                Console.WriteLine($"Taxes owed at 28%: ${taxAtBracket}");
                Console.WriteLine($"Total taxes owed: ${totalTax}");
                Console.WriteLine($"Taxes as a percentage of Gross Income: {grossIncomePercentage}%");
                Console.WriteLine($"Taxes as a percentage of Adjusted Gross Income: {adjustedIncomePercentage}%");
            }
            else if (_adjustedGrossIncome > 191650 && _adjustedGrossIncome < 416700) //33% tax bracket
            {
                taxAtBracket = ((_adjustedGrossIncome - 191650) * .33);
                totalTax = 932.5 + 4293.75 + 13487.5 + 27930 + taxAtBracket;
                grossIncomePercentage = (totalTax / _grossIncome) * 100;
                grossIncomePercentage = Math.Round((double)grossIncomePercentage, 2);
                adjustedIncomePercentage = (totalTax / _adjustedGrossIncome) * 100;
                adjustedIncomePercentage = Math.Round((double)adjustedIncomePercentage, 2);
                Console.WriteLine($"Taxes owed at 10%: $932.50");
                Console.WriteLine($"Taxes owed at 15%: $4293.75");
                Console.WriteLine($"Taxes owed at 25%: $13487.50");
                Console.WriteLine($"Taxes owed at 28%: $27930");
                Console.WriteLine($"Taxes owed at 33%: ${taxAtBracket}");
                Console.WriteLine($"Total taxes owed: ${totalTax}");
                Console.WriteLine($"Taxes as a percentage of Gross Income: {grossIncomePercentage}%");
                Console.WriteLine($"Taxes as a percentage of Adjusted Gross Income: {adjustedIncomePercentage}%");
            }
            else if (_adjustedGrossIncome > 416700 && _adjustedGrossIncome < 418400) //35% tax bracket
            {
                taxAtBracket = ((_adjustedGrossIncome - 416700) * .35);
                totalTax = 932.5 + 4293.75 + 13487.5 + 27930 + 74266.5 + taxAtBracket;
                grossIncomePercentage = (totalTax / _grossIncome) * 100;
                grossIncomePercentage = Math.Round((double)grossIncomePercentage, 2);
                adjustedIncomePercentage = (totalTax / _adjustedGrossIncome) * 100;
                adjustedIncomePercentage = Math.Round((double)adjustedIncomePercentage, 2);
                Console.WriteLine($"Taxes owed at 10%: $932.50");
                Console.WriteLine($"Taxes owed at 15%: $4293.75");
                Console.WriteLine($"Taxes owed at 25%: $13487.50");
                Console.WriteLine($"Taxes owed at 28%: $27930");
                Console.WriteLine($"Taxes owed at 33%: $74266.50");
                Console.WriteLine($"Taxes owed at 35%: ${taxAtBracket}");
                Console.WriteLine($"Total taxes owed: ${totalTax}");
                Console.WriteLine($"Taxes as a percentage of Gross Income: {grossIncomePercentage}%");
                Console.WriteLine($"Taxes as a percentage of Adjusted Gross Income: {adjustedIncomePercentage}%");
            }
            else if (_adjustedGrossIncome > 418400) //39.6% tax bracket
            {
                taxAtBracket = ((_adjustedGrossIncome - 418400) * .396);
                totalTax = 932.5 + 4293.75 + 13487.5 + 27930 + 74266.5 + 595 + taxAtBracket;
                grossIncomePercentage = (totalTax / _grossIncome) * 100;
                grossIncomePercentage = Math.Round((double)grossIncomePercentage, 2);
                adjustedIncomePercentage = (totalTax / _adjustedGrossIncome) * 100;
                adjustedIncomePercentage = Math.Round((double)adjustedIncomePercentage, 2);
                Console.WriteLine($"Taxes owed at 10%: $932.50");
                Console.WriteLine($"Taxes owed at 15%: $4293.75");
                Console.WriteLine($"Taxes owed at 25%: $13487.50");
                Console.WriteLine($"Taxes owed at 28%: $27930");
                Console.WriteLine($"Taxes owed at 33%: $74266.50");
                Console.WriteLine($"Taxes owed at 35%: $595");
                Console.WriteLine($"Taxes owed at 39.6%: ${taxAtBracket}");
                Console.WriteLine($"Total taxes owed: ${totalTax}");
                Console.WriteLine($"Taxes as a percentage of Gross Income: {grossIncomePercentage}%");
                Console.WriteLine($"Taxes as a percentage of Adjusted Gross Income: {adjustedIncomePercentage}%");
            }
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }

}
