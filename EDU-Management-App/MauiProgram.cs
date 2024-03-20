using EDU_Management_App.Views;
using Microsoft.Extensions.Logging;

namespace EDU_Management_App;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<StudentDashboard>();
        builder.Services.AddTransient<InstructorDashboard>();
        builder.Services.AddTransient<ListViewInstructor>();
        builder.Services.AddTransient<InstructorEditCourse>();
            
#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}