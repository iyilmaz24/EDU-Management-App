

namespace EDU_Management_App.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private async void StudentLoginClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("StudentLogin");
    }
    
    private async void InstructorLoginClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("InstructorLogin");
    }
}