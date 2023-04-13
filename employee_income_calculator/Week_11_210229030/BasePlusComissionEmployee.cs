﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_11_210229030
{
    public class BasePlusComissionEmployee : ComissionEmployee
    {
        private decimal baseSalary; // base salary per week

        // six-parameter constructor
        public BasePlusComissionEmployee(string firstName, string lastName,
        string socialSecurityNumber, decimal grossSales,
        decimal commissionRate, decimal baseSalary)
            : base(firstName, lastName, socialSecurityNumber,
 grossSales, commissionRate)

        {
            BaseSalary = baseSalary; // validates base salary
        }

        // property that gets and sets 
        // BasePlusCommissionEmployee's base salary
        public decimal BaseSalary
        {
            get
            {
                return baseSalary;
            }
            set
            {
                if (value < 0) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(BaseSalary)} must be >= 0");
                }

                baseSalary = value;
            }
        }
        // calculate earnings
        public override decimal Earnings() => BaseSalary + base.Earnings();

        // return string representation of BasePlusCommissionEmployee
        public override string ToString() =>
        $"base-salaried {base.ToString()}\nbase salary: {BaseSalary:C}";

    }
}
