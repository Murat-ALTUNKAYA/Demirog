using KodlamaIoClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoClone.Business;

public class CoursesManager
{
    List<Courses> courses = new List<Courses>();
    public CoursesManager()  //bu class newlendiğinde çalışır.
    {
        
        
        Courses courses1 = new Courses();
        courses1.courseId = 1;
        courses1.courseCategory = "C#";
        courses1.courseName = "Yazılım Geliştirici Yetiştirme Kampı (c# + Angular)";
        courses1.instructorName = "Engin Demiroğ";
        courses.Add(courses1);

        Courses courses2 = new Courses();
        courses2.courseId = 2;
        courses2.courseCategory = "Java";
        courses2.courseName = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)";
        courses2.instructorName = "Engin Demiroğ";
        courses.Add(courses2);

        Courses courses3 = new Courses();
        courses3.courseId = 3;
        courses3.courseCategory = "JavaScript";
        courses3.courseName = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)";
        courses3.instructorName = "Engin Demiroğ";
        courses.Add(courses3);

        Courses courses4 = new Courses();
        courses4.courseId = 4;
        courses4.courseCategory = ".net";
        courses4.courseName = "Senior Yazılım Geliştirici Yetiştirme Kampı (.net)";
        courses4.instructorName = "Engin Demiroğ";
        courses.Add(courses4);

        Courses courses5 = new Courses();
        courses5.courseId = 5;
        courses5.courseCategory = "C#";
        courses5.courseName = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)";
        courses5.instructorName = "Engin Demiroğ";
        courses.Add(courses5);

        Courses courses6 = new Courses();
        courses6.courseId = 6;
        courses6.courseCategory = "C#";
        courses6.courseName = "Programlamaya Giriş için Temel Kurs";
        courses6.instructorName = "Engin Demiroğ";
        courses.Add(courses6);

        Courses courses7 = new Courses();
        courses7.courseId = 7;
        courses7.courseCategory = "Python";
        courses7.courseName = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium";
        courses7.instructorName = "Halit Enes Kalaycı";
        courses.Add(courses7);
    }
    public List<Courses> GetAll()
    {
        return courses;
    }
}
