using System;
using System.Collections.Generic;
using System.Text;

namespace CCL.Security.Identity
{
    public class Student
            : User
    {
        public Student(int userId, string name, string surname, int groupId)
            : base(userId, name, surname, groupId, nameof(Student))
        {

        }
    }
}
