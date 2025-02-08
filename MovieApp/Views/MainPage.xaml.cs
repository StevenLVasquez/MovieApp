using Microsoft.Maui.ApplicationModel;
using MovieApp.ViewModels;
using MovieApp;

namespace MovieApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        private void OnExitClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // URL de la página de registro de Netflix
            var netflixSignupUrl = "https://www.netflix.com/signup";

            // Abre la URL en el navegador
            await Launcher.OpenAsync(netflixSignupUrl);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var trending1 = "https://www.netflix.com/tudum/top10/es";
            await Launcher.OpenAsync(trending1);
        }

        public async void OnImageTapped(object sender, EventArgs e)
        {
            var url = "https://www.youtube.com/watch?v=OgU_UDYd9lY";
            await Launcher.OpenAsync(new Uri(url));
        }
    }
}
