using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinSyncFusion
{
    public class MainPageModel
    {
        public Type Type { get; private set; }

        public string Title { get; private set; }

        public string Description { get; private set; }


        public MainPageModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }

        static MainPageModel()
        {
            All = new List<MainPageModel>
            {
                new MainPageModel(typeof(GettingStarted), "Getting Started", "Setup a chart")
            };
        }

        public static IList<MainPageModel> All { get; private set; }
    }
}
