using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnortalDotNetTrainingBatch3.ConsoleApp
{
    // public / private / internal / protected
    internal class Student : Father
    {
        public Student()
        {
            StudentName = "--Test--";
        }

        public Student(int studentNo, string studentName, DateTime dateOfBirth)
        {
            StudentName = "--Test--";
        }

        // Properties
        public int StudentNo { get; set; }
        public string StudentName { get; set; } 
        public DateTime DateOfBirth { get; set; }
    }

    public class Father
    {
        protected string ProName { get; set; }

        protected void Test()
        {

        }
    }

    public class Employee
    {
        public string Name;
        public int EmployeeNo { get; set; }
        public string EmployeeName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

    public class Wallet
    {
        public decimal amount; // fields
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public decimal Balance { get; private set; } // properties
        public decimal ShowBalance()
        {
            return Balance;
        }
        public void SetBalance(decimal amount)
        {
            if (amount < 0)
            {
                throw new Exception("Amount must be greater than 0");
            }
            Balance = amount;
        }
    }
}
