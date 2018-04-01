using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinSyncFusion
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

        private async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // Clears the SelectedItem, this will trigger a 2nd .ItemSelected event which is caught on line below
            (sender as ListView).SelectedItem = null;

            if(e.SelectedItem == null)
            {
                return;
            }
            else
            {
                var selectedpageModel = (MainPageModel)e.SelectedItem;

                Page nextPage = (Page)Activator.CreateInstance(selectedpageModel.Type);

                await Navigation.PushAsync(nextPage);
            }
        }

    }
}