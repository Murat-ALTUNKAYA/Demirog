using Buissness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buissness.Concrete
{
    public class CourseManager : ICourseService
    {
        private readonly ILogger _logger;
        public CourseManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add(Course course)
        {
            Console.WriteLine("Kurs elave olundu: "+course.CourseName);
            _logger.Log(course.CourseName);
        }

        public void Delete(Course course)
        {
            Console.WriteLine("Kurs silindi: " + course.CourseName);
        }

        public void Get(Course course)
        {
            Console.WriteLine("Kurs getirildi: " + course.CourseName);
        }

        public void Update(Course course)
        {
            Console.WriteLine("Kurs guncellendi: " + course.CourseName);
        }
    }
}
