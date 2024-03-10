using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU_Management_App.Views;

public partial class StudentLoginPage : ContentPage
{
    public StudentLoginPage()
    {
        InitializeComponent();
    }
    private async void StudLoginClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Student");
    }
    
    private async void ForgotStudPassClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Student");
    }
}