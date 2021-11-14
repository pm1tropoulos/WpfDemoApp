using DL.Customer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BL.TaskDemo
{
    public static class TaskDemo
    {

        public static List<Customer> DoSearch()
        {
            var loadLinesTask = Task.Run(() =>
            {
                var lines = File.ReadAllLines($"C:\\Users\\PANAGIOTIS\\source\\repos\\WPF_Demo_App\\BL\\BL.TaskDemo\\myFile0.csv");
                return lines;
            });

            var finalTask = loadLinesTask.ContinueWith((completedTask) => {
                var lines = completedTask.Result;
                var data = new List<Customer>();
                foreach (var line in lines.Skip(1))
                {
                    var customer = Helper.FromCsv(line);
                    data.Add(customer);
                }
                return data;
            });

            var final = finalTask.ContinueWith((completed)=> 
            {
                return completed.Result;
            });

            return final.Result;
        }   
    }

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
