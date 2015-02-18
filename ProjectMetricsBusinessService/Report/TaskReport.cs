﻿using Cognizant.Tools.ProjectMetrics.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.BusinessService
{
    public class TaskReport : Report
    {
        public List<TaskDetail> TaskDetails { get; private set; }
    }
}