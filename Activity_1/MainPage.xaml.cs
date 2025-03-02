namespace Activity_1
{
    //By: Kim Terrence Quines | Activity 1 | IT-322
    public partial class MainPage : ContentPage
    {
        private List<DataItem> inputList = new();
        private int idCounter = 1;
        public MainPage()
        {
            InitializeComponent();
        }
        //By: Kim Terrence Quines | Activity 1 | IT-322
        private void GoToTaker(object sender, EventArgs e) //Show taker screen
        {
            TakerScreen.IsVisible = true;
            LandingSreen.IsVisible = false;
            AdminScreen.IsVisible = false;
        }
        //By: Kim Terrence Quines | Activity 1 | IT-322
        private void GoToLogin(object sender, EventArgs e) //Show login screen for admin
        {
            LoginScreen.IsVisible = true;
            LandingSreen.IsVisible = false;
            AdminScreen.IsVisible = false;
            TakerScreen.IsVisible = false;
        }
        //By: Kim Terrence Quines | Activity 1 | IT-322
        private void LoginBtnClk(object sender, EventArgs e) //Triger login button to redirect to admin screen  use "admin" as username and password
        {
            if (username.Text == "admin")
            {
                if (!string.IsNullOrWhiteSpace(password.Text))
                {
                    if (password.Text == "admin")
                    {
                        AdminScreen.IsVisible = true;
                        LoginScreen.IsVisible = false;
                    }
                    else
                    {
                        DisplayAlert("Warning", "Wrong Password", "OK");
                    }
                }
                else
                {
                    DisplayAlert("Warning", "Enter Password", "OK");
                }
            }
            else
            {
                DisplayAlert("Warning", "Username not found", "OK");
            }
        }
        //By: Kim Terrence Quines | Activity 1 | IT-322
        private void Exit(object sender, EventArgs e) //Go back to Landing Screen
        {
            LandingSreen.IsVisible = true;
            TakerScreen.IsVisible = false;
            LoginScreen.IsVisible = false;
            AdminScreen.IsVisible = false;
        }
        //By: Kim Terrence Quines | Activity 1 | IT-322
        private void Submit(object sender, EventArgs e) // Submit takers info
        {

            if (!string.IsNullOrWhiteSpace(TakerFn.Text) && SelectCollege.SelectedItem != null && SelectLevel.SelectedItem != null)
            {
                var item = new DataItem
                {
                    Id = idCounter++,
                    TakerFn = TakerFn.Text,
                    SelectCollege = SelectCollege.SelectedItem.ToString(),
                    SelectLevel = SelectLevel.SelectedItem.ToString()
                };

                inputList.Add(item);

                dataListView.ItemsSource = null;
                dataListView.ItemsSource = inputList;

                TakerFn.Text = "";
                SelectCollege.SelectedItem = null;
                SelectLevel.SelectedItem = null;

                DisplayAlert("Attention", "Form Submitted", "OK");

                LandingSreen.IsVisible = true;
                TakerScreen.IsVisible = false;
                LoginScreen.IsVisible = false;
                AdminScreen.IsVisible = false;
            }
            else
            {
                DisplayAlert("Warning", "Field Must Not Empty", "OK");
            }

        }
        //By: Kim Terrence Quines | Activity 1 | IT-322
        public class DataItem
        {
            public int Id { get; set; }
            public string TakerFn { get; set; }
            public string SelectCollege { get; set; }
            public string SelectLevel { get; set; }
        }
    }

}
//By: Kim Terrence Quines | Activity 1 | IT-322
