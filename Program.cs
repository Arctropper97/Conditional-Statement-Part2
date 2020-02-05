using System;

namespace Conditional_Statement_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentGradeInput = "";
            int result;

            Console.WriteLine("Plase enter in the total score out of 100 you believe you are going to get in ISM 4300");
            //We are setting the users input equal to the studentgrade variable.
            studentGradeInput = Console.ReadLine();
            //We are now converting this into a int from a string variable. 
            result = int.Parse(studentGradeInput);

            //Here we are creating a conditonal loop statement to deterime what the users grade will be.
            //If they enter in certin number between 0-100 they will get a corosponding letter grade.
            if(result <= 100 && result >= 98 )
            {
                Console.WriteLine("You have recived an A+ for this course.");
            }
            else if(result <= 97 && result >= 92)
            {
                Console.WriteLine("You have recived an A for this course");
            }
            else if(result <= 91 && result >= 90)
            {
                Console.WriteLine("You have recevied an A- for this course");
            }
            else if(result <= 89 && result >= 88)
            {
                Console.WriteLine("You have recevied an B+ for this course");
            }
            else if(result <= 87 && result >= 82)
            {
                Console.WriteLine("You have recevied an B for this course");
            }
            else if(result <= 81 && result >= 80)
            {
                Console.WriteLine("You have recevied an B- for this course");
            }
            else if(result <= 79 && result >= 78)
            {
                Console.WriteLine("You have recevied an C+ for this course");
            }
            else if(result <= 77 && result >= 72)
            {
                Console.WriteLine("You have recevied an C for this course");
            }
            else if(result <= 71 && result >= 70)
            {
                Console.WriteLine("You have received an C- for this course");
            }
            else if(result <= 69 && result >= 68)
            {
                Console.WriteLine("You have received an D+ for this course");
            }
            else if(result <= 67 && result >= 62)
            {
                Console.WriteLine("You have received an D for this course");
            }
            else if(result <= 61 && result >= 60)
            {
                Console.WriteLine("You have received an D- for this course");
            }
            else if(result < 60)
            {
                Console.WriteLine("You have received an F for this course, which means you failed!");
            }

        }
    }
}
//telephoneCharges = decimal.Parse(telephoneChargesTextBox.Text);