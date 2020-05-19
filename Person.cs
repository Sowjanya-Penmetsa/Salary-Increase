using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Salary_Increase
{
    class Person
    {
        public Person(string firstname, string lastname, int age,decimal salary)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.salary = salary;
        }

        private string firstname;
        private string lastname;
        private int age;
        private decimal salary;

        public string Firstname
        {
            get
            {
                return this.firstname;
            }
        }

        public string Lastname
        {
            get
            {
                return this.lastname;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
        }

        public void IncreaseSalary(decimal percentage)
        {
         if(this.age>30)
            {
                this.salary += this.salary * percentage / 100;
            }
         else
            {
                this.salary += this.salary * percentage / 200;

            }
        }

       public override string ToString()
        {
            return $"{this.firstname}  {this.lastname} receives  {this.salary} dollars";
        }
    }

}
