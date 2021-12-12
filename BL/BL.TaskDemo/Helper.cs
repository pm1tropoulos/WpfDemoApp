using DL.Customer;
using System;

namespace BL.TaskDemo
{
    public static class Helper
    {
        public static Customer FromCsv(string csvLine)
        {
            var customerByCsv = new Customer();
            string[] values = csvLine.Split(',');
            customerByCsv.ID = Convert.ToInt32(values[0]);
            customerByCsv.FirstName = Convert.ToString(values[1]);
            customerByCsv.LastName = Convert.ToString(values[2]);
            customerByCsv.email = Convert.ToString(values[3]);
            return customerByCsv;
        }
    }
}
