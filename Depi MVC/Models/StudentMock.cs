namespace Depi_MVC.Models
{
    public class StudentMock
    {
        List<Student> Students = new List<Student>();
        public StudentMock()
        {
            Students.Add(new Student { Id = 1, Name = "name1",Address = "Address1" , ImgPath = "1.jfif"});
            Students.Add(new Student { Id = 2, Name = "name2",Address = "Address2" , ImgPath = "2.jfif"});
            Students.Add(new Student { Id = 3, Name = "name3",Address = "Address3" , ImgPath = "3.jfif"});
        }
        public List<Student> GetStudents()
        {
            return Students;
        }
        public Student GetStudentById(int id)
        {
            return Students.FirstOrDefault(p => p.Id == id);
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

    }
}
