using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{

    class Grades
    {
        public string className { get; set; }
        public string grade { get; set; }
        public int index { get; set; }


        public Grades(String classN, String grade1, int indexNum)
        {
            this.className = classN;
            this.grade = grade1;
            this.index = indexNum;
        }


    }
}
