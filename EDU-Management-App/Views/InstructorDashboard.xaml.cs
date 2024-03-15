using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDU_Management_App.ViewModels;

namespace EDU_Management_App.Views;


public partial class InstructorDashboard : ContentPage
{
    public InstructorDashboard()
    {
        InitializeComponent();
        BindingContext = new InstructorViewModel();
    }
    private async void SignOutClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
    
}