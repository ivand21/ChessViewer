using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChessViewer
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNewGameButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GamePage(), true);
        }

        private void OnLoadGameButtonClicked(object sender, EventArgs e)
        {
            //await 
        }

        private async void OnSettingsButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsPage(), true);
        }

        private async void OnCreditsButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreditsPage(), true);
        }

    }
}
