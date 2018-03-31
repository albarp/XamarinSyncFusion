using System.Collections.Generic;

namespace XamarinSyncFusion
{
    public class ViewModel
    {
        public List<Person> Data { get; set; }

        public ViewModel()
        {
            Data = new List<Person>
            {
                new Person{Name = "Alberto", Height=170 },
                new Person{Name="Pippo", Height=190 },
                new Person{Name="Minnie", Height=160 },
                new Person{Name="Pluto", Height=180 }
            };

        }
    }
}
