using System;

namespace Assessment_1_School_Register
{
    class Program
    {

        static void Main(string[] args)
        {
            FormGroup year12 = new FormGroup("12FB", "Faye Blairs");
            year12.AddStudent("Thoai", "01/01/2001", "M");
            year12.AddStudent("Prem", "01/01/2001", "M");
            year12.AddStudent("Ankit", "01/01/2001", "M");
            year12.AddStudent("Inn", "01/01/2001", "M");
            SchoolRegisterMenu(year12);
        }

        static public void SchoolRegisterMenu(FormGroup year12)
        {
            string UserInput;
            int OptionNumber;
            bool valid = false;

            while (valid == false)
            {
                Console.WriteLine("Press 1 to add new student, press 2 to take attendance, press 3 to print out registars");
                UserInput = Console.ReadLine();

                if (int.TryParse(UserInput, out OptionNumber))
                {
                    if (OptionNumber == 1)
                    {
                        AddStudent(year12);
                    }
                    else if (OptionNumber == 2)
                    {
                        TakeAttendance(year12);
                    }
                    else if (OptionNumber == 3)
                    {
                        PrintRegistar(year12);
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid response");
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid response");
                }
            }


        }


        static public void AddStudent(FormGroup year12)
        {
            Console.WriteLine("What is the name of your student?");
            string StudentName = Console.ReadLine();

            Console.WriteLine("What is their date of birth?");
            string StudentDOB = Console.ReadLine();

            Console.WriteLine("What is their gender?");
            string StudentGender = Console.ReadLine();

            year12.AddStudent(StudentName, StudentDOB, StudentGender);
        }


        static public void TakeAttendance(FormGroup year12)
        {
            bool valid = false;
            DateTime Date;

            while (valid == false)
            {
                Console.WriteLine("Which date do you want to take the attendance with?");
                string UserResponse = Console.ReadLine();

                if (DateTime.TryParse(UserResponse, out Date))
                {
                    year12.TakeAttendance(Date);
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Enter it in the format DD/MM/YYYY");
                }
            }
        }

        static public void PrintRegistar(FormGroup year12)
        {
            bool valid = false;
            DateTime Date;
            while (valid == false)
            {
                Console.WriteLine("What date do you want to print out the registar for?");
                string UserResponse = Console.ReadLine();

                if (DateTime.TryParse(UserResponse, out Date))
                {
                    year12.PrintRegistar(Date);
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Write it as DD/MM/YYYY");
                }

            }

        }
    }
}
