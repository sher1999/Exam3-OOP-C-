using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public class Employee
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private int _salary;
        public Employee(int id, string firstName, string lastName, int salary)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _salary = salary;
        }
        public int GetId()
        {
            return _id;
        }
        public string GetFirsName()
        {
            return _firstName;
        }
        public string GetLastName()
        {
            return _lastName;
        }
        public string GetName()
        {
            return $"{_firstName} {_lastName}";
        }
        public int GetSalary()
        {
            return _salary;
        }
        public void SetSalary(int salary)
        {
            _salary = salary;
        }
        public int GetAnnualSalary()
        {
            return _salary * 12;
        }
        public int RaiseSalary(int percent)
        {
            return ((_salary * percent) / 100) + _salary;
        }

        public override string ToString()
        {
            return $"Employee[id={_id},name={_firstName} {_lastName},salary={_salary}";
        }




    }
}
