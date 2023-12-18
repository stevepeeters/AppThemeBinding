namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRequestLightTheme(object sender, EventArgs e)
        {
            Application.Current.UserAppTheme = AppTheme.Light;
        }

        private void OnRequestDarkTheme(object sender, EventArgs e)
        {
            Application.Current.UserAppTheme = AppTheme.Dark;
        }
    }
}
