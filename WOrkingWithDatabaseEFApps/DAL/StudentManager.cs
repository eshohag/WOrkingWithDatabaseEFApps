using System.Collections.Generic;
using System.Linq;
using WOrkingWithDatabaseEFApps.DAL.Model;

namespace WOrkingWithDatabaseEFApps.DAL
{
    class StudentManager
    {
        public List<Student> GetAllStudents()
        {
            using (var db = new ApplicationDbContext())
            {
                return db.Students.ToList();
            }
        }


        public List<StudentClass> GetAllStudentClass()
        {
            using (var db = new ApplicationDbContext())
            {
                return db.StudentClasses.ToList();
            }
        }

        public int Save(Student aStudent)
        {
            using (var db = new ApplicationDbContext())
            {
                db.Students.Add(aStudent);

                int result = db.SaveChanges();

                return result;
            }

        }
    }
}
