using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{
    class Student
    {
        public int Stud_Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string dateOfBirth { get; set; }
        public string highSchoolGrade { get; set; }

        public Student (String fName, String lName, String doB, String hsGrade)
        {
            //this.Stud_Id = Id;
            this.firstName = fName;
            this.lastName = lName;
            this.dateOfBirth = doB;
            this.highSchoolGrade = hsGrade;
        }

    }
}
