using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDU_Management_App.ViewModels;

namespace EDU_Management_App.Views;

public partial class ListViewInstructor : ContentPage
{
    public ListViewInstructor()
    {
        InitializeComponent();
        BindingContext = new InstructorViewModel();
    }

    public void AddClicked(object sender, EventArgs e)
    {
        (BindingContext as InstructorViewModel)?.AddStudent();
    }
    
    public async void CancelClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Instructor");
    }
}