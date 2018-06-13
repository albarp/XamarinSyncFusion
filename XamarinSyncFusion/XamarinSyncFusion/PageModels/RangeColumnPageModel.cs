using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinSyncFusion.Models;

namespace XamarinSyncFusion
{
    public class RangeColumnPageModel
    {
        public ObservableCollection<Pressure> Data { get; private set; }

        public RangeColumnPageModel()
        {
            Data = new ObservableCollection<Pressure>
            {
                new Pressure
                {
                    Year = "2017",
                    Min = 60,
                    Max = 90
                },
                new Pressure
                {
                    Year = "2018",
                    Min = 70,
                    Max = 120
                }
            };
        }
    }
}
