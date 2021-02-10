using System;

namespace Assessment_1_School_Register
{
    class Program
    {
        static int FormGroupCount = 0;


        static void Main(string[] args)
        {
            FormGroup[] FormGroups = new FormGroup[13];

        }

        static public void SchoolRegisterMenu(FormGroup formGroups)
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
                        AddFormGroup(formGroups);
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

        static public void AddFormGroup(FormGroup formGroups)
        {
            Console.WriteLine("What is the name of your form group?");
            string FormGroupName = Console.ReadLine();

            Console.WriteLine("What is the name of the teacher?");
            string FormTeacherName = Console.ReadLine();

            formGroups[FormGroupCount] = new FormGroup(FormGroupName, FormTeacherName);
        }


    }
}
