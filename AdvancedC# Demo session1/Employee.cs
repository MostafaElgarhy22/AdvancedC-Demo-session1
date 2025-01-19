using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC__Demo_session1
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is Employee employee)
            {
                return this.Id == employee.Id &&
                       this.Name == employee.Name &&
                       this.Salary == employee.Salary;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Id, this.Name, this.Salary);
        }


    }
}
