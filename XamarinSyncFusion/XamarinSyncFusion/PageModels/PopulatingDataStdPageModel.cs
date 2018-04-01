using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace XamarinSyncFusion
{
    public class PopulatingDataStdPageModel
    {
        public ObservableCollection<ChartDataPoint> HighTemperature { get; set; }

        public PopulatingDataStdPageModel()
        {
            HighTemperature = new ObservableCollection<ChartDataPoint>
            {
                new ChartDataPoint("Jan", 42),
                new ChartDataPoint("Feb", 44),
                new ChartDataPoint("Mar", 53),
                new ChartDataPoint("Apr", 64),
                new ChartDataPoint("May", 75),
                new ChartDataPoint("Jun", 83),
                new ChartDataPoint("Jul", 87),
                new ChartDataPoint("Aug", 84),
                new ChartDataPoint("Sep", 78),
                new ChartDataPoint("Oct", 67),
                new ChartDataPoint("Nov", 55),
                new ChartDataPoint("Dec", 45)
            };

        }
    }
}
