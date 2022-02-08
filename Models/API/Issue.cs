﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDashboard.Models
{
    public class Issues
    {
        public string TitleIssue { get; set; }
        public int NumberIssue { get; set; }
        public string ExplicationIssue { get; set; }
        public string StateIssue { get; set; }
        public string DateOfResolutionIssue { get; set; }
        public Issues()
        {
        }
    }
}