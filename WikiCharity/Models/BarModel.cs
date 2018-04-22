﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WikiCharity.Models
{
    public class BarModel
    {
        public string year { get; set; }
        public double TotalGrossIncome { get; set; } = 0;

        public double Expense { get; set; } = 0;
    }
}