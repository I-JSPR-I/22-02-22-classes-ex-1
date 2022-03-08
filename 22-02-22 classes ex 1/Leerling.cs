using System;
using System.Collections.Generic;
using System.Text;

namespace _22_02_22_classes_ex_1
{
    class Student
    {
        public string FirstNameStudent;
        public string LastNameStudent;
        public string ClassStudent;

        public Student(){
            FirstNameStudent = "Voornaam";
            LastNameStudent = "Achternaam";
            ClassStudent = "IB";
        }
        public Student(string FirstName, string LastName, string Class)
        {

            FirstNameStudent = FirstName;
            LastNameStudent = LastName;
            ClassStudent = Class;

        }
    }
}

