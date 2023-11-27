using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers_2.Models
{
    internal class Employee
    {
        private string _name;
        private bool _isSuccessfull;
        private float _salary;

        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Trim().Length >= 3 && value.Trim().Length <= 16)
                {
                    _name = value;
                }
            } 
        }
        public bool IsSuccessfull 
        {
            get
            {
                return _isSuccessfull;
            }
            set
            {
                _isSuccessfull = value;
            }
        }
        public float Salary 
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value >= 300) 
                {
                    _salary = value;
                }
            } 
        }

        public Employee(string name,float salary,bool issusccessfull)
        {
            Name = name;
            Salary = salary;
            IsSuccessfull = issusccessfull;
        }
    }
}
