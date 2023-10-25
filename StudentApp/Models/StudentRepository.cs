namespace StudentApp.Models
{
    public class StudentRepository
    {
        public List<Student> StudentList { get; set; }

        public StudentRepository()
        {
            StudentList = new List<Student>();
            StudentList.Add(new Student(){Number = 10, FirstName= "Ahmet", LastName = "Güneş" });
            StudentList.Add(new Student() { Number = 20, FirstName = "Hafza", LastName = "Yildiz"});
            StudentList.Add(new Student() { Number = 30, FirstName = "Nuri", LastName = "Irmak" });
        }

        public Student GetOne(int id)
        {
            foreach (var std in StudentList)
            {
                if (std.Number.Equals(id))
                {
                    return std;
                }
            }
            throw new Exception("Not Found");
        }

        public List<Student> GetAll()
        {
            return StudentList;
        }

        public void DeleteOne(int id)
        {
            var std = GetOne(id);
            StudentList.Remove(std);
        }

        public Student CreateOne(Student student)
        {
            StudentList.Add(student);
            return student;
        }

        public void UpdateOne(int id, Student student)
        {
            foreach(var item in StudentList)
            {
                if (item.Number == id)
                {
                    item.FirstName = student.FirstName;
                    item.LastName = student.LastName;
                    item.Number = student.Number;
                    return;
                }
            }
            throw new Exception("Not Found");
        }

    }
}
