using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDU_Management_App.ViewModels;

namespace EDU_Management_App.Views;


public partial class InstructorEditCourse : ContentPage
{
    public InstructorEditCourse()
    {
        InitializeComponent();
        BindingContext = new InstructorViewModel();
    }
    private async void AddStudentClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("ListViewI");
    }

    private async void PreviousPageClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Instructor");
    }
    
}