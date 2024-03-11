using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU_Management_App.Views;

public partial class InstructorLoginPage : ContentPage
{
    public InstructorLoginPage()
    {
        InitializeComponent();
    }
    private async void InstructLoginClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Instructor");
    }
    
    private async void ForgotInstructPassClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Instructor");
    }
}