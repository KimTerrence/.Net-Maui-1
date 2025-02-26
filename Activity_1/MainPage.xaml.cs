namespace Activity_1
{
    public partial class MainPage : ContentPage
    {
        private List<DataItem> inputList = new();
        private int idCounter = 1;
        public MainPage()
        {
            InitializeComponent();
        }
        private void LoginClk(object sender, EventArgs e)
        {
            if(username.Text == "admin")
            {
              if(password.Text == "admin")
                {
                    AdminScreen.IsVisible = true;
                    LoginScreen.IsVisible = false;
                }
            }
            else
            {
                DisplayAlert("Warning", "Username not found", "OK");
            }
        }
        private void GoTaker(object sender, EventArgs e)
        {
            TakerScreen.IsVisible = true;
            WelcomeSreen.IsVisible = false;
            AdminScreen.IsVisible = false;
        }
        private void GoLogin(object sender, EventArgs e)    
        {
            LoginScreen.IsVisible = true;
            WelcomeSreen.IsVisible = false;
            AdminScreen.IsVisible = false;
            TakerScreen.IsVisible = false;
        }
        private void Exit(object sender, EventArgs e)
        {
            WelcomeSreen.IsVisible = true;
            TakerScreen.IsVisible = false;
            LoginScreen.IsVisible = false;
            AdminScreen.IsVisible = false;
        }
        private void Submit(object sender, EventArgs e)
        {
            //  String college = picker1.SelectedItem.ToString();
            // DisplayAlert("Note", college, "KOi");

            if (!string.IsNullOrWhiteSpace(TakerName.Text))
            {
                var item = new DataItem
                {
                    Id = idCounter++,
                    Taker = TakerName.Text,
                    CollegePick = CollegePick.SelectedItem.ToString(),
                    LevelPick = LevePick.SelectedItem.ToString()
                };

                inputList.Add(item);

                dataListView.ItemsSource = null;
                dataListView.ItemsSource = inputList;

                TakerName.Text = "";
                CollegePick.SelectedItem = null;
                LevePick.SelectedItem = null;
            }
            else
            {
                DisplayAlert("Note", "Empty", "KOi");
            }

        }
        public class DataItem
        {
            public int Id { get; set; }
            public string Taker { get; set; }
            public string CollegePick { get; set; }
            public string LevelPick { get; set; }
        }
    }

}
