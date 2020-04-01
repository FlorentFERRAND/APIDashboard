﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDashboard.Models
{
    public class PieChart
    {
        public string TitlePieChart { get; set; }
        public string StatusByMethodPieChart { get; set; }
        public int NumberMethodsByStatus { get; set; }
        public PieChart()
        {
        }
    }
}