
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tasks
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TasksListPage : ContentPage
    {
        public TasksListPage()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}