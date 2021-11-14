using DL.Customer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BL.TaskDemo
{
    public static class TaskDemo
    {
        public static List<Customer> DoSearch()
        {
            var lines = File.ReadAllLines($"C:\\Users\\PANAGIOTIS\\source\\repos\\WPF_Demo_App\\BL\\BL.TaskDemo\\TaskDemo.csv");
            var data = new List<Customer>();
            foreach (var line in lines.Skip(1))
            {
                var customer = Helper.FromCsv(line);
                data.Add(customer);
            }
            return data;
        }
    }

    public class Helper
    {
        public static Customer FromCsv(string csvLine)
        {
            var customerByCsv = new Customer();
            string[] values = csvLine.Split(',');
            Customer.ID = Convert.ToInt32(values[0]);
            Customer.FirstName = Convert.ToString(values[1]);
            Customer.LastName = Convert.ToString(values[2]);
            Customer.email = Convert.ToString(values[3]);
            return customerByCsv;
        }
    }
}
