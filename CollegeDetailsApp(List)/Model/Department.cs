﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeDetailsApp_List_.Model
{
    internal class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public Department(int deptId, string deptName)
        {
            DeptId = deptId;
            DeptName = deptName;
        }

    }
}
