namespace Activity_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void LoginClk(object sender, EventArgs e)
        {
            DisplayAlert("Warning", "Username not found", "OK");
        }
        private void GoTaker(object sender, EventArgs e)
        {
            TakerScreen.IsVisible = true;
            WelcomeSreen.IsVisible = false;
        }
        private void GoLogin(object sender, EventArgs e)
        {
            LoginScreen.IsVisible = true;
            WelcomeSreen.IsVisible = false;
        }
        private void Exit(object sender, EventArgs e)
        {
            WelcomeSreen.IsVisible = true;
            TakerScreen.IsVisible = false;
            LoginScreen.IsVisible = false;
        }
    }

}
