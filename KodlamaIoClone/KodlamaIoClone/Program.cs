using KodlamaIoClone.Business;
using KodlamaIoClone.Entities;





CoursesManager coursesManager = new CoursesManager();
List<Courses> courses = coursesManager.GetAll();

for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine("Course Name : " + courses[i].courseName + " / Eğitmen : " + courses[i].instructorName);
}

Console.ReadLine();