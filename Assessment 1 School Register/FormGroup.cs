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
                if (Students[i].CheckForExistingDate(Date) == true)
                {
                    int x = i + 1;
                    Console.WriteLine("{0,0} {1,0} {2,10} {3,2} {4,2}", x, ".", Students[i].GetStudentName(), " was: ", Students[i].GetAttendanceStatus(Date));
                }
                else
                {
                    Console.WriteLine("Date not found, enter an existing date");
                    break;
                }
            }
        }

        public void PrintFormGroupInformation()
        {
            Console.WriteLine("Year Group: " + GroupName);
            Console.WriteLine("Form Tutor: " + TeacherName);
            for(int i = 0; i < StudentCount; i++)
            {
                if(Students[i] != null)
                {
                    int x = i + 1;
                    Console.WriteLine("{0,0} {1,0} {2, 5} {3,10} {4,0} {5,8} {6,0} {7,5} {8,2} {9,5} {10,0} {11,5} {12,0} {13,5} {14,0}", x, ".", Students[i].GetStudentName(), "|| Date Of Birth:", Students[i].GetDateOfBirth(), "|| Gender:", Students[i].GetGender(), "|| Days Present:", Students[i].GetDaysPresent(), "|| Days Late:", Students[i].GetDaysLate(), "|| Days Absent:", Students[i].GetDaysAbsent(), "||Late Minutes:", Students[i].GetLateMinutes()); 
                }
            }
        }

        public int GetNumberOfStudents()
        {
            return NumberOfStudents;
        }



    }
}
