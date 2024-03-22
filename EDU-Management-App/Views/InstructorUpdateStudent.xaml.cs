using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDU_Management_App.ViewModels;

namespace EDU_Management_App.Views;

public partial class InstructorUpdateStudent : ContentPage
{
    public InstructorUpdateStudent()
    {
        InitializeComponent();
        BindingContext = new InstructorViewModel();
    }
    
    public async void UpdateClicked(object sender, EventArgs e)
    {
        (BindingContext as InstructorViewModel)?.UpdateStudent();
    }
    
    public async void CancelClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("ListViewI");
    }
}