using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinSyncFusion
{
    public class MonthDemand
    {
        public string Demand { get; private set; }

        public double Year2010 { get; private set; }

        public double Year2011 { get; private set; }

        public MonthDemand(string demand, double year2010, double year2011)
        {
            Demand = demand;
            Year2010 = year2010;
            Year2011 = year2011;
        }
    }
}
