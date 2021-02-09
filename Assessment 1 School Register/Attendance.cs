using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_1_School_Register
{
    class Attendance
    {
        private DateTime Date;
        private string DayOfTheWeek;
        private string AttendanceStatus; //P for Present, L for Late, A for Absent
        private int MinutesLate;

        //Constructors
        public Attendance(DateTime Date, string AttendanceStatus)
        {
            this.Date = Date;
            this.DayOfTheWeek = Date.ToString("dddd");
            this.AttendanceStatus = AttendanceStatus;
            MinutesLate = 0;
        }
        public Attendance(DateTime Date, string AttendanceStatus, int MinutesLate)
        {
            this.Date = Date;
            this.DayOfTheWeek = Date.ToString("dddd");
            this.AttendanceStatus = AttendanceStatus;
            this.MinutesLate = MinutesLate;
        }


        public int GetMinutesLate()
        {
            return MinutesLate;
        }

        public string GetAttendanceStatus()
        {
            return AttendanceStatus;
        }

        public DateTime GetDate()
        {
            return Date;
        }
    }
}
