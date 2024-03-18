using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EDU_Management_App.ViewModels;

using EDU_App_Library.Services;
using EDU_App_Library.Models;
public class InstructorViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    
    public Student SelectedPerson { get; set; }
    public ObservableCollection<Student> StudentsList
    {
        get => new ObservableCollection<Student>(StudentService.Current.students); 
    }
    
    public InstructorViewModel()
    {
        AddStudent("John Smith", "2nd Year");
        // AddStudent("Ana Jones", "4th Year");
        // AddStudent("Michael Yellow", "3rd Year");
    }

    // adds new student to general roster of students
    public void AddStudent(string name, string classI) {
        Student newStu = new Student(name, classI);
        StudentService.Current.AddStudent(newStu);
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

}

