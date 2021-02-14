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

        public void AddStudent(string StudentName, DateTime DateOfBirth, string Gender)
        {
            if (StudentCount < NumberOfStudents)
            {
                Students[StudentCount] = new Student(StudentName, DateOfBirth, Gender);
                StudentCount++;
            }
            else
            {
                Console.WriteLine("You cannot add anymore students");
            }
        }

        public void TakeAttendance(DateTime AttendanceDate)

        {
            for (int i = 0; i < NumberOfStudents; i++)
            {
                bool valid = false;
                while (valid == false)

                {
                    if (Students[i] != null && i != NumberOfStudents)
                    {
                        Console.WriteLine("Is " + Students[i].GetStudentName() + " Present(p), Late(l), or Absent(a)?");
                        string UserResponse = Console.ReadLine();
                        string LateMinutesResponse;
                        int LateMinutes = 0;


                        if (UserResponse == "l")
                        {
                            UserResponse = "Absent";
                            bool validanswer = false;
                            while (validanswer == false)
                            {
                                Console.WriteLine("How late were they(in minutes)?");
                                LateMinutesResponse = Console.ReadLine();

                                if (int.TryParse(LateMinutesResponse, out LateMinutes))
                                {
                                    validanswer = true;
                                    valid = true;
                                }
                            }
                        }
                        else if (UserResponse == "p")
                        {
                            UserResponse = "Present";
                            valid = true;
                        }
                        else if (UserResponse == "a")
                        {
                            UserResponse = "Absent";
                            valid = true;
                        }
                        else
                        {
                            Console.WriteLine("Write p for present, a for absent, and l for late");
                        }

                        Students[i].AddAttendance(AttendanceDate, UserResponse, LateMinutes);
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("Attendance Successfully Taken");
        }

        public void PrintRegistar(DateTime Date)
        {
            for (int i = 0; i < StudentCount; i++)
            {
                Console.WriteLine("{0,10} {1,2} {2,2}", Students[i].GetStudentName(), " was: ", Students[i].GetAttendanceStatus(Date));
            }
        }
    }
}
