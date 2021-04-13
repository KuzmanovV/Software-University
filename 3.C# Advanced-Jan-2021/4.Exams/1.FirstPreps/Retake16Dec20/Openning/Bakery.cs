using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        List<Employee> data;
        public Bakery(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Employee>();
        }
        public int Count => data.Count();
        public string Name { get; set; }
        public int Capacity { get; set; }
        public void Add(Employee employee)
        {
            if (data.Count < Capacity)
            {
                data.Add(employee);
            }
        }
        public bool Remove(string name)
        {
            Employee employee = data.FirstOrDefault(e => e.Name == name);

            if (employee == null)
            {
                return false;
            }

            data.Remove(employee);
            return true;
        }
        public Employee GetTheOldestEmployee()
        {
            return data.OrderByDescending(e => e.Age).FirstOrDefault();
        }
        public Employee GetEmployee(string name)
        {
            return data.FirstOrDefault(e => e.Name == name);
        }
        public string Report()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Employees working at Bakery {Name}:");

            foreach (Employee item in data)
            {
                result.AppendLine(item.ToString());
            }

            return result.ToString();
        }
    }
}
