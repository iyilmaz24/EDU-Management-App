using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDU_Management_App.ViewModels;

namespace EDU_Management_App.Views;

public partial class ListViewInstructorCourse : ContentPage
{
    public ListViewInstructorCourse()
    {
        InitializeComponent();
        BindingContext = new CourseViewModel();
    }
    public void AddClicked(object sender, EventArgs e)
    {
        (BindingContext as CourseViewModel)?.AddCourse();
    }
    public void DeleteClicked(object sender, EventArgs e)
    {
        (BindingContext as CourseViewModel)?.DeleteCourse();
    }
    public async void UpdateClicked(object sender, EventArgs e)
    {
        (BindingContext as CourseViewModel)?.UpdateCourse();
    }
    public async void CancelClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Instructor");
    }
}