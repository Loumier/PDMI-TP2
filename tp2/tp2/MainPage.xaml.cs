using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace tp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void goToStandardStyle(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StandardStyle());
        }

        private async void goToDynamicStyle(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DynamicStyle());
        }

        private async void goToEventTriggers(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EventTriggers());
        }
        
        private async void goToSimpleListView(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SimpleListView());
        }

        private async void goToHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }
    }
}
