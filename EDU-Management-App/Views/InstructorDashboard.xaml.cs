using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU_Management_App.Views;

public partial class InstructorDashboard : ContentPage
{
    public InstructorDashboard()
    {
        InitializeComponent();
    }
    private async void SignOutClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
    
}