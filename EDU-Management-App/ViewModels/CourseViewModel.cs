using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EDU_Management_App.ViewModels;

using EDU_App_Library.Services;
using EDU_App_Library.Models;

public class CourseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public Course? SelectedCourse { get; set; }
    private Course? course = new Course();
    public Course? Course => course;
    public string Name
    {
        get { return course?.Name ?? string.Empty; }
        set { if (course != null) { course.Name = value; }
        }
    }
    public string Code
    {
        get { return course?.Code ?? string.Empty; }
        set { if (course != null) { course.Code = value; }
        }
    }
    public string Description
    {
        get { return course?.Description ?? string.Empty; }
        set { if (course != null) { course.Description = value; }
        }
    }
    public ObservableCollection<Course> CoursesList
    {
        get => new ObservableCollection<Course>(CourseService.Current.courses);
    }
    
    public CourseViewModel()
    {
        ;
    }

    // adds new course to general roster of students, description is optional
    public void AddCourse()
    {
        if (Course?.Name == null || Course.Name == " " || Course.Name.Length == 0)
        { return; };
        if (Course?.Code == null || Course.Code == " " || Course.Code.Length == 0)
        { return; };
        
        CourseService.Current.AddCourse(new Course(Course.Name, Course.Code, Course?.Description ?? string.Empty));
        NotifyPropertyChanged(nameof(CoursesList));
    }
    
    public void DeleteCourse()
    {
        if (SelectedCourse is null) return;
        
        CourseService.Current.DeleteCourse(SelectedCourse);
        NotifyPropertyChanged(nameof(CoursesList));
    }
    
    public void UpdateCourse()
    {
        if (SelectedCourse is null) return;
        if (Course?.Name is null) return;
        if (Course?.Code is null) return;
        if (Course?.Description is null) return; 
        
        CourseService.Current.UpdateCourse(SelectedCourse, Course.Name, Course.Code, Course.Description);
        NotifyPropertyChanged(nameof(CoursesList));
    }

    public void Refresh()
    {
        NotifyPropertyChanged(nameof(CoursesList));
    }

}

