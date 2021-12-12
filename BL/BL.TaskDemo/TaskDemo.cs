using DL.Customer;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BL.TaskDemo
{
    public static class TaskDemo
    {

        public static Task<List<Customer>> DoSearch()
        {
            var loadLinesTask = Task.Run(() =>
            {
                var lines = File.ReadAllLines($"C:\\Users\\PANAGIOTIS\\source\\repos\\WPF_Demo_App\\BL\\BL.TaskDemo\\myFile0.csv");
                return lines;
            });

            var finalTask = loadLinesTask.ContinueWith((completedTask) =>
            {
                var lines = completedTask.Result;
                var data = new List<Customer>();
                foreach (var line in lines.Skip(1))
                {
                    var customer = Helper.FromCsv(line);
                    data.Add(customer);
                }
                return data;
            });

            var final = finalTask.ContinueWith((completedTask) =>
            {
                return completedTask.Result;
            });
            return final;
        }
    }
}
