using System;

namespace Assessment_1_School_Register
{
    class Program
    {
        static void Main(string[] args)
        {
            FormGroup year12 = new FormGroup("12FB", "Faye Blairs");

            year12.AddStudent("Toy", "01/01/2001", "M");
            year12.AddStudent("Thoai", "01/01/2001", "M");
            year12.AddStudent("Bob", "01/01/2001", "M");

            year12.TakeAttendance(DateTime.Now);


        }
    }
}
