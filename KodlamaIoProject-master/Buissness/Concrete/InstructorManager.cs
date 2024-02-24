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
    public class InstructorManager : IInstructorService
    {
        private readonly ILogger _logger;
        public InstructorManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add(Instructor instructor)
        {
            Console.WriteLine("Egitmen eklendi : "+instructor.FirstName+" "+instructor.LastName);
            _logger.Log(instructor.FirstName+ " : "+instructor.LastName);
        }

        public void Delete(Instructor instructor)
        {
            Console.WriteLine("Egitmen silindi : " + instructor.FirstName + " " + instructor.LastName);
        }

        public void Get(Instructor instructor)
        {
            Console.WriteLine("Egitmen getirildi : " + instructor.FirstName + " " + instructor.LastName);
        }

        public void Update(Instructor instructor)
        {
            Console.WriteLine("Egitmen guncellendi : " + instructor.FirstName + " " + instructor.LastName);
        }
    }
}
