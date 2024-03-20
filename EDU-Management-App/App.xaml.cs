using EDU_Management_App.Views;

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
        
        Routing.RegisterRoute("ListViewI", typeof(ListViewInstructor));
        Routing.RegisterRoute("InstructorEditCourse", typeof(InstructorEditCourse));
    }
}