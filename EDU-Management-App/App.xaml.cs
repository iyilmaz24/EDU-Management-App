﻿using EDU_Management_App.Views;

namespace EDU_Management_App;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
        
        Routing.RegisterRoute("Home", typeof(MainPage));
        Routing.RegisterRoute("Student", typeof(StudentDashboard));
        Routing.RegisterRoute("Instructor", typeof(InstructorDashboard));
        
        Routing.RegisterRoute("StudentLogin", typeof(StudentLoginPage));
        Routing.RegisterRoute("InstructorLogin", typeof(InstructorLoginPage));

        Routing.RegisterRoute("ListViewInstructorStudent", typeof(ListViewInstructorStudent));
        Routing.RegisterRoute("ListViewInstructorCourse", typeof(ListViewInstructorCourse));
        Routing.RegisterRoute("InstructorEditCourse", typeof(InstructorEditCourse));
        Routing.RegisterRoute("InstructorUpdateStudent", typeof(InstructorUpdateStudent));
    }
}