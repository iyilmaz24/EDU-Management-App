using EDU_App_Library.Models;

namespace EDU_App_Library.Services {
    public class CourseService {
        private static object threadLock = new();
        private static CourseService? instance;
        public IList<Course> courses;
        public static CourseService Current {
            get {
                lock(threadLock) {               
                    if(instance == null) {
                        instance = new CourseService();
                    }
                }
                return instance;
            }
        }
        private CourseService() {
            courses = new List<Course>();
        }

        public List<Course> Search(string? query) { 
                return courses.Where(
                c => 
                    c.Name.ToUpper().Contains(query?.ToUpper() ?? string.Empty)
                    || c.Code.ToUpper().Contains(query?.ToUpper() ?? string.Empty)).ToList();
        }
        public void SearchBackend(string? query) {
            List<Course> searchResults = Search(query??"0");
            Console.WriteLine("===== Search Results ======");
                if(searchResults.Count() == 0){
                    Console.WriteLine("Returned 0 Total Results.");
                }
                else {
                    foreach(var c in searchResults){
                        c.PrintCourseDetails();
                    }
                }
            Console.WriteLine("=====//============//======");
        }
        public void AddCourse(Course newCourse) {
            courses.Add(newCourse);
        }
        public void DeleteCourse(Course oldCourse) {
            courses.Remove(oldCourse);
        }

        public void UpdateCourse(Course oldCourse, String name, String code, String description)
        {
            List<Course> searchResults = Search(oldCourse.Code);
            if(searchResults.Count() != 0)
            {
                if (name != " " && name != "")
                {
                    searchResults[0].Name = name;
                }
                if (code != " " && code != "")
                {
                    searchResults[0].Code = code;
                }
                if (description != " " && description != "")
                {
                    searchResults[0].Description = description;
                }
            }
        }
        
        public Course SelectCourse() {

            int count = 0;
            Console.WriteLine("Select a Course: ");
            foreach(Course c in courses)
            {
                Console.WriteLine(++count + ". " + c);
            }
            Console.WriteLine("Type Selection: ");

            int intTemp = Convert.ToInt32(Console.ReadLine());
            if(intTemp != 0){
                Console.WriteLine("Selected: " + courses[intTemp-1]);
            }
            else {
                Console.WriteLine("Typed Selection is Invalid!");
            }

            return courses[intTemp-1];
        }

        public void AddStudent(Student student, Course course) {
            course.Enroll(student);
        }
        public void RemoveStudent(int index, Course course) {
            course.Unenroll(index);
        }

        public Assignment CreateAssignment(string name, string description, double points, string dueDate) {
            Assignment newAssignment = new Assignment{Name = name, Description = description, TotalAvailablePoints = points, DueDate = dueDate};
            return newAssignment;
        }

        public void AddAssignment(Assignment assignment, Course course) {
            course.AddAssignment(assignment);
        }
        public void Print() {
            foreach(Course course in courses){
                Console.WriteLine(course.ToString());
            }
        }
    }
}