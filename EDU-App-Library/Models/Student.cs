namespace EDU_App_Library.Models {
    
    public class Student {
        public Student(string name, string classI) {
            Name = name;
            Class = classI;
            courses = new List<Course>();
        }
        IList<Course> courses;
        private string? _class;
        public string Class {
            get { return _class ?? ""; }
            set { _class = value?.ToUpper(); }
        }

        private string? _name;
        public string Name {
            get { return _name ?? ""; }
            set { _name = value; }
        }

        public void AddCourse(Course course) {
            courses.Add(course);
        }

        public void RemoveCourse(Course course) {
            courses.Remove(course);
        }

        public override string ToString()
        {
            return $"{Name} - {Class}";
        }

        public void PrintStudentDetails() {
            Console.WriteLine(ToString());
            Console.WriteLine($"{Name}'s Courses:");
            foreach(var c in courses) {
                Console.WriteLine(c.ToString());
            }
        }
    }
}