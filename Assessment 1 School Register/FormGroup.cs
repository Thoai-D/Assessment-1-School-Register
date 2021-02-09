using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_1_School_Register
{
    class FormGroup
    {
        string GroupName;
        string TeacherName;
        Student[] Students = new Student[25];
        int NumberOfStudents = 25;
        int StudentCount;

        //Constructors
        public FormGroup(string GroupName, string TeacherName)
        {
            this.GroupName = GroupName;
            this.TeacherName = TeacherName;
        }

        public void AddStudent(string StudentName, string DateOfBirth, string Gender)
        {
            if(StudentCount < NumberOfStudents)
            {
                Students[StudentCount] = new Student(StudentName, DateOfBirth, Gender);
                StudentCount++;
            }
        }

        public void TakeAttendance(DateTime AttendanceDate)

        {
            for(int i = 0; i < NumberOfStudents; i++)
            {
                if(Students[i] != null)
                {
                    Console.WriteLine("Is " + Students[i].GetStudentName() + " Present(p), Late(l), or Absent(a)?");
                    string UserResponse = Console.ReadLine();
                    string LateMinutesResponse;
                    int LateMinutes = 0;
                    bool valid = true;


                    if(UserResponse == "l")
                    {
                        valid = false;
                        while (valid == false)
                        {
                            Console.WriteLine("How late were they(in minutes)?");
                            LateMinutesResponse = Console.ReadLine();

                            if(int.TryParse(LateMinutesResponse, out LateMinutes))
                            {
                                valid = true;
                            }
                        }

                    }
                    Students[i].AddAttendance(AttendanceDate, UserResponse, LateMinutes);
                }
            }
        }


    }
}
