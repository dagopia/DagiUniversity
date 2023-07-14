using DagiUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DagiUniversity.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstMidName="Dagem",LastName="Teshome",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Bereket",LastName="Zergaw",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Samrawit",LastName="Debaso",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Selamawit",LastName="Fikadu",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Ahati",LastName="Tekilay",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Fiyameta",LastName="Gilay",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="Obsinet",LastName="Teshome",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Hana",LastName="Nigusse",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Fandamental Acting",Credits=3,},
            new Course{CourseID=4022,Title="Professional editing ",Credits=3,},
            new Course{CourseID=4041,Title="Acting for Stage",Credits=3,},
            new Course{CourseID=1045,Title="Theatr Concepts",Credits=4,},
            new Course{CourseID=3141,Title="Histroy of World Acting",Credits=4,},
            new Course{CourseID=2021,Title="Acting for Screen",Credits=3,},
            new Course{CourseID=2042,Title="Directing",Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050,},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}