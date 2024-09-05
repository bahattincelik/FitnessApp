namespace FitnessApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnProfileClicked(object sender, EventArgs e)
        {
            // Profile sayfasına git
            await Shell.Current.GoToAsync("//Profile");
        }
    }
}
