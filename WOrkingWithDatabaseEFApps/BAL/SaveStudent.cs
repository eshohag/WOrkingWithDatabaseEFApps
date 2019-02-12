using System;
using WOrkingWithDatabaseEFApps.DAL;
using WOrkingWithDatabaseEFApps.DAL.Model;

namespace WOrkingWithDatabaseEFApps.BAL
{
    class SaveStudent
    {
        public string Save(Student aStudent)
        {
            StudentManager aStudentManager = new StudentManager();
            if (String.IsNullOrEmpty(aStudent.Name) || String.IsNullOrEmpty(aStudent.ContactNo))
            {
                return "Input was not correct value or Blank field";
            }

            if (aStudentManager.Save(aStudent) > 0)
            {
                return "Successfully Saved";
            }

            return "Faild to save";
        }
    }
}
