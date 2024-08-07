using Depi_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Depi_MVC.Controllers
{
    public class StudentController : Controller
    {
        // /Student/GetAllStudents
       
        public IActionResult GetAllStudents()
        {
            StudentMock studentMock = new StudentMock();
            var Students = studentMock.GetStudents();
            return View("StudentList",Students);
        }
        public IActionResult GetStudentById(int id)
        {
            StudentMock studentMock = new StudentMock();
            var student = studentMock.GetStudentById(id);
            return View("Student", student);
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student model)
        {
            StudentMock studentMock = new StudentMock();
            studentMock.AddStudent(model);
            return View("StudentList",studentMock.GetStudents());
        }
    }
}
