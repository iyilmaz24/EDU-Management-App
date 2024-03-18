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
}