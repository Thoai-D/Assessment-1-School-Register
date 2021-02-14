using System;

namespace Assessment_1_School_Register
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WindowHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth;
            Console.WindowLeft = 0;
            Console.WindowTop = 0;
            FormGroup year12 = new FormGroup("12FB", "Faye Blairs");
            year12.AddStudent("Thoai", new DateTime(2004, 3, 12), "M");
            year12.AddStudent("Prem", new DateTime(2003, 12, 20), "M");
            year12.AddStudent("Ankit", new DateTime(2004, 3, 12), "M");
            year12.AddStudent("Inn", new DateTime(2004, 3, 12), "M");
            SchoolRegisterMenu(year12);
        }

        static public void SchoolRegisterMenu(FormGroup year12)
        {
            string UserInput;
            int OptionNumber;
            bool valid = false;

            while (valid == false)
            {
                Console.WriteLine("Press 1 to add new student, press 2 to take attendance, press 3 to print out registars, press 4 to view form group information, press 5 to exit");
                UserInput = Console.ReadLine();

                if (int.TryParse(UserInput, out OptionNumber))
                {
                    if (OptionNumber == 1)
                    {
                        AddStudent(year12);
                        Console.WriteLine("");
                    }
                    else if (OptionNumber == 2)
                    {
                        TakeAttendance(year12);
                        Console.WriteLine("");
                    }
                    else if (OptionNumber == 3)
                    {
                        PrintRegistar(year12);
                        Console.WriteLine("");
                    }
                    else if(OptionNumber == 4)
                    {
                        GetFormGroupInformation(year12);
                        Console.WriteLine("");
                    }
                    else if(OptionNumber == 5)
                    {
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid response");
                        Console.WriteLine("");
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid response");
                    Console.WriteLine("");
                }
            }





        }


        static public void AddStudent(FormGroup year12)
        {
            DateTime StudentDOB;
            string StudentGender;

            Console.WriteLine("What is the name of your student?");
            string StudentName = Console.ReadLine();

            Console.WriteLine("What is their gender?");
            StudentGender = Console.ReadLine();

            bool valid = false;
            while (valid == false)
            {
                Console.WriteLine("What is their date of birth?");
                string UserResponse = Console.ReadLine();

                if (DateTime.TryParse(UserResponse, out StudentDOB))
                {
                    valid = true;
                    year12.AddStudent(StudentName, StudentDOB, StudentGender);
                }
            }
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

        static public void GetFormGroupInformation(FormGroup year12)
        {
            year12.PrintFormGroupInformation();
        }
    }
}


