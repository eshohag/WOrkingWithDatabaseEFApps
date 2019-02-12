using System.Collections.Generic;
using WOrkingWithDatabaseEFApps.DAL;
using WOrkingWithDatabaseEFApps.DAL.Model;

namespace WOrkingWithDatabaseEFApps.BAL
{
    class StudentBAL
    {
        public List<Student> GetMoreThenOneStudent()
        {
            StudentManager aStudentManager = new StudentManager();
            if (aStudentManager.GetAllStudents().Count > 1)
            {
                return aStudentManager.GetAllStudents();
            }

            return null;
        }

        public List<StudentClass> GetStudentClass()
        {
            StudentManager aStudentManager = new StudentManager();
            if (aStudentManager.GetAllStudentClass().Count > 0)
            {
                return aStudentManager.GetAllStudentClass();
            }

            return null;
        }
    }
}
