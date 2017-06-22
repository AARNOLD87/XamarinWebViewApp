namespace XamarinWebViewApp.Views
{
    using Xamarin.Forms;

    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.Windows)
            {
                Master.Icon = "StoreLogo.png";
                MasterBehavior = MasterBehavior.Popover; // Added this line of code
            }

            if (Device.RuntimePlatform == Device.iOS)
                IsGestureEnabled = false;
        }
    }
}
