using System;

namespace Assessment_1_School_Register
{
    class Program
    {
        static int FormGroupCount = 0;


        static void Main(string[] args)
        {
            FormGroup[] FormGroups = new FormGroup[13];
            SchoolRegisterMenu(FormGroups[0]);

        }

        static public void SchoolRegisterMenu(FormGroup FormGroups)
        {
            string UserInput;
            int OptionNumber;
            bool valid = false;

            while (valid == false)
            {
                Console.WriteLine("Press 1 to add new form group, press 2 to select a form group");
                UserInput = Console.ReadLine();

                if(int.TryParse(UserInput, out OptionNumber))
                {
                    if(OptionNumber == 1)
                    {
                        AddFormGroup(FormGroups);
                    }
                    else if(OptionNumber == 2)
                    {

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


        static public void AddFormGroup(FormGroup FormGroups)
        {
            Console.WriteLine("What is the name of your form group?");
            string FormGroupName = Console.ReadLine();

            Console.WriteLine("What is the name of the teacher?");
            string FormTeacherName = Console.ReadLine();

            FormGroups[FormGroupCount] = new FormGroup(FormGroupName, FormTeacherName);
        }


    }
}
