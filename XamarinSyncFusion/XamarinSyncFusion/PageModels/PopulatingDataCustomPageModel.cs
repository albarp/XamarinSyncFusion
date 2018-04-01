using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace XamarinSyncFusion
{
    public class PopulatingDataCustomPageModel
    {
        public ObservableCollection<MonthDemand>  Demands { get; private set; }

        public PopulatingDataCustomPageModel()
        {
            Demands = new ObservableCollection<MonthDemand>
            {
                new MonthDemand("Jan", 42, 27),
                new MonthDemand("Feb", 44, 28),
                new MonthDemand("Mar", 53, 35),
                new MonthDemand("Apr", 64, 44),
                new MonthDemand("May", 75, 54),
                new MonthDemand("Jun", 83, 63),
                new MonthDemand("Jul", 87, 68),
                new MonthDemand("Aug", 84, 66),
                new MonthDemand("Sep", 78, 59),
                new MonthDemand("Oct", 67, 48),
                new MonthDemand("Nov", 55, 38),
                new MonthDemand("Dec", 45, 29)
            };
        }
    }
}
