using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EDU_Management_App.ViewModels;

using EDU_App_Library.Services;
using EDU_App_Library.Models;
public class InstructorViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public Student? SelectedPerson { get; set; }
    private Student? student = new Student(" ", " ");
    public Student? Student => student;
    public string Name
    {
        get { return student?.Name ?? string.Empty; }
        set { if (student != null) { student.Name = value; }
        }
    }
    public string Class
    {
        get { return student?.Class ?? string.Empty; }
        set { if (student != null) { student.Class = value; }
        }
    }
    public ObservableCollection<Student> StudentsList
    {
        get => new ObservableCollection<Student>(StudentService.Current.students);
    }
    
    public InstructorViewModel()
    {
        ;
    }

    // adds new student to general roster of students
    public void AddStudent()
    {
        if (student?.Name == null || student.Name == " " || student.Name == "")
        { return; };
        if (student?.Class == null || student.Class == " " || student.Name == "")
        { return; };
        
        StudentService.Current.AddStudent(new Student(student.Name, student.Class));
        NotifyPropertyChanged(nameof(StudentsList));
    }
    
    public void DeleteStudent()
    {
        if (SelectedPerson is null) return;
        
        StudentService.Current.DeleteStudent(SelectedPerson);
        NotifyPropertyChanged(nameof(StudentsList));
    }
    
    public void UpdateStudent()
    {
        if (SelectedPerson is null) return;
        if (student?.Name == null) return;
        if (student?.Class == null) return;
        
        StudentService.Current.UpdateStudent(SelectedPerson, student.Name, student.Class);
        NotifyPropertyChanged(nameof(StudentsList));
    }

    // // enrolls existing student to a specific course
    // public void EnrollStudent(Student student, Course course)
    // {
    //     CourseService.Current.AddStudent(student, course);
    // }
    //
    // // return the entire general roster of students
    // public ObservableCollection<Student> GetAllStudents()
    // {
    //     return new ObservableCollection<Student>(StudentService.Current.students);
    // }


    public void Refresh()
    {
        NotifyPropertyChanged(nameof(StudentsList));
    }

}

