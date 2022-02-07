using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Employee
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }

        public Employee(string fullName, string position, string email, string phoneNumber, decimal salary, int age)
        {
            FullName = fullName;
            Position = position;
            Email = email;
            PhoneNumber = phoneNumber;
            Salary = salary;
            Age = age;
        }

        public void PrintInfo() 
        {
            Console.WriteLine($"***\nFullName: {FullName},\nPosition:{Position},\nE-mail: {Email},\nPhone Number:{PhoneNumber},\nSalary: {Salary},\nAge:{Age}");
        }

        
    }
}
