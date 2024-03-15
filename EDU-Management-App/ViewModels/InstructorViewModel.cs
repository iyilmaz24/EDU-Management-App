namespace EDU_Management_App.ViewModels;

using EDU_App_Library.Services;
using EDU_App_Library.Models;
public class InstructorViewModel
{
    private CourseService courseService;
    private StudentService studentService;
    public InstructorViewModel(string UserId)
    {
        courseService = CourseService.Current;
        studentService = StudentService.Current;
    }

    // adds new student to general roster of students
    public void AddStudent(string name, string classI) {
        Student newStu = new Student(name, classI);
        studentService.AddStudent(newStu);
    }

    // enrolls existing student to a specific course
    public void EnrollStudent(Student student, Course course)
    {
        courseService.AddStudent(student, course);
    }
    
    // return the entire general roster of students
    public IList<Student> GetAllStudents()
    {
        return studentService.students;
    }
    
}

