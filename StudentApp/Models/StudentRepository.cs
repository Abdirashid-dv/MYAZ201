namespace StudentApp.Models
{
    public class StudentRepository
    {
        public List<Student> StudentList { get; set; }

        public StudentRepository()
        {
            StudentList = new List<Student>();
            StudentList.Add(new Student() { Number = 10, FirstName = "Ahmet", LastName = "Güneş" });
            StudentList.Add(new Student() { Number = 20, FirstName = "Hafza", LastName = "Yildiz" });
            StudentList.Add(new Student() { Number = 30, FirstName = "Nuri", LastName = "Irmak" });
        }

        public Student GetOneStudent(int id)
        {
            /** foreach (var std in StudentList)
            {
                if (std.Number.Equals(id))
                {
                    return std;
                }
            }
            throw new Exception("Not Found");
            **/
            var result = StudentList
            .Where(std => std.Number.Equals(id))
            .Single();

            return result;
        }

        public List<Student> GetAllStudents()
        {
            return StudentList;
        }

        public int DeleteOneStudent(int id)
        {
            var std = GetOneStudent(id); // Student : null
            if (std is not null)
            {
                StudentList.Remove(std);
                return 1;
            }
            return 0;

        }

        public Student? CreateOneStudent(Student student)
        {
            var result = StudentList.Where(std => std.Number.Equals(student.Number))
            .SingleOrDefault();
            if (result is not null)
                return null;

            StudentList.Add(student);
            return student;
        }

        public int UpdateOneStudent(int id, Student student)
        {
            foreach (var item in StudentList)
            {
                if (item.Number == id)
                {
                    item.FirstName = student.FirstName;
                    item.LastName = student.LastName;
                    item.Number = student.Number;
                    return 1;
                }
            }
            return 0;

        }

    }
}
