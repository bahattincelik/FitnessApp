namespace FitnessApp
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Saved", "Your profile has been saved.", "OK");
        }
    }
}
