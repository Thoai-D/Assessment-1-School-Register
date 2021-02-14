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
        Attendance[] Attendances = new Attendance[180];
        int DaysPresent;
        int DaysLate;
        int DaysAbsent;
        int LateMinutes;

        int i = 0;


        //Constructor
        public Student(string Name, DateTime dateOfBirth, string Gender)
        {
            this.Name = Name;
            DateOfBirth = dateOfBirth;
            this.Gender = Gender;
        }

        //

        public void AddAttendance(DateTime Date, string AttendanceStatus, int MinutesLate)
        {
            Attendances[i] = new Attendance(Date, AttendanceStatus, MinutesLate);
        }




        //Accessors
        public string GetAttendanceStatus(DateTime Date)
        {
            for (int x = 0; x < Attendances.Length; x = x + 1)
            {
                if (Attendances[x].GetAttendanceStatus() != null)
                {
                    if (Date == Attendances[x].GetDate())
                    {
                        return Attendances[x].GetAttendanceStatus();
                    }
                }
                else
                {
                    return "Day Not Found";
                }
            }
            return "Day not found";
        }

        public int GetDaysPresent()
        {
            for (int x = 0; x < Attendances.Length; x++)
            {
                if (Attendances[x] == null)
                {
                    continue;
                }
                else if (Attendances[x].GetAttendanceStatus() == "P")
                {
                    DaysPresent++;
                }
            }
            return DaysPresent;
        }

        public int GetDaysLate()
        {
            for (int x = 0; x < Attendances.Length; x++)
            {
                if (Attendances[x] == null)
                {
                    continue;
                }
                else if (Attendances[x].GetAttendanceStatus() == "L")
                {
                    DaysLate++;
                }
            }
            return DaysLate;
        }


        public int GetDaysAbsent()
        {
            for (int x = 0; x < Attendances.Length; x++)
            {
                if (Attendances[x] == null)
                {
                    continue;
                }
                else if (Attendances[x].GetAttendanceStatus() == "A")
                {
                    DaysAbsent++;
                }
            }
            return DaysAbsent;
        }

        public int GetLateMinutes()
        {
            for (int x = 0; x < Attendances.Length; x++)
            {
                if (Attendances[x] == null)
                {
                    continue;
                }
                else
                {
                    LateMinutes = LateMinutes + Attendances[x].GetMinutesLate();
                }
            }
            return LateMinutes;
        }


        public string GetStudentName()
        {
            return Name;
        }


    }
}
