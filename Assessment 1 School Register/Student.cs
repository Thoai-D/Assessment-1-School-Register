using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_1_School_Register
{
    class Student
    {
        string Name;
        DateTime DateOfBirth;
        string Gender; //M, F
        Attendance[] Attendances = new  Attendance[180];
        int i = 0;


        //Constructor
        public Student(string Name, string dateOfBirth, string Gender)
        {
            this.Name = Name;
            DateOfBirth = DateTime.Now;
            DateTime.TryParse(dateOfBirth, out DateOfBirth);
            this.Gender = Gender;
        }

        //

        public void AddAttendance(DateTime Date, string AttendanceStatus)
        {

        }
    }
}
