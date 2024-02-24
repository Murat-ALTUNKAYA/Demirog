using Buissness.Abstract;
using Buissness.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartAProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.CourseName = "Spring";
            course1.Author = "Engin Demirog";
            course1.Description = "Spring-boot Spring Security ehate edir!";

            Category category1 = new Category();
            category1.Id = 2;
            category1.CategoryName = "Programming";

            Instructor instructor1 = new Instructor();
            instructor1.Id = 3;
            instructor1.FirstName = "Engin";
            instructor1.LastName = "Demirog";
            instructor1.courses = new[]{ course1 };

            ICrudService<Category> crudService1 = new CategoryManager(new FileLogger());
            crudService1.Add(category1);

            ICrudService<Instructor> crudService2 = new InstructorManager(new DataBaseLogger());  
            crudService2.Add(instructor1);

            ICrudService<Course> crudService3= new CourseManager(new SmsLogger());
            crudService3.Add(course1);

            Console.ReadLine();
        }
    }
}
