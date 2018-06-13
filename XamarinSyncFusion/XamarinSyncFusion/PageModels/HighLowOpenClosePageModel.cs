using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace XamarinSyncFusion
{
    public class HighLowOpenClosePageModel
    {
        public ObservableCollection<ChartDataPoint> Data { get; private set; }

        public HighLowOpenClosePageModel()
        {
            Data = new ObservableCollection<ChartDataPoint>
            {
                new ChartDataPoint("2010", 873.8, 878.85, 855.5, 860.5),
                new ChartDataPoint("2011", 861, 868.4, 835.2, 843.45)
            };
        }
    }
}
