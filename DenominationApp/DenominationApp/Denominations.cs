using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DenominationApp
{

    public class Denominations
    {
        private enum denominations
        {
            Rs1000 = 1000,
            Rs500 = 500,
            Rs200 = 200,
            Rs50 = 50,
            Rs20 = 20,
            Rs10 = 10,
            Rs5 = 5,
            Rs2 = 2,
            Rs1 = 1,
        }
        public StringBuilder CalculateDenominations(int amount, string pricevalue)
        {
            try
            {
                StringBuilder result = new StringBuilder();
                if (amount < Convert.ToDouble(pricevalue))
                {
                    result.Append("The amount is less than price of product\nPlease provide amount more than price of product");
                }
                else if (amount == Convert.ToDouble(pricevalue))
                {
                    result.Append("Your Change is 0");
                }
                else
                {
                    int temp = 0;
                    int i = 0;
                    double returnAmount = amount - Convert.ToDouble(pricevalue);
                    string[] differencevalues = returnAmount.ToString().Split('.');
                    int difference = Convert.ToInt32(differencevalues[0]);
                    int[] values = (int[])Enum.GetValues(typeof(denominations));
                    var sortedNumbers = values.OrderByDescending(x => x).ToArray();
                    result.Append("Your Change is");
                    result.Append("\n");
                    foreach (int item in sortedNumbers)
                    {
                        temp = (int)difference / item;
                        difference = difference % item;
                        if (temp >= 1)
                        {
                            result.Append(temp + "*" + Enum.GetName(typeof(denominations), item));
                            result.Append("\n");
                        }
                        if (difference == 0)
                        {
                            break;
                        }

                    }
                    if (differencevalues.Length > 1)
                        result.Append(1 + "*" + "50p");
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Exception Occured");
            }
        }

    }
}
